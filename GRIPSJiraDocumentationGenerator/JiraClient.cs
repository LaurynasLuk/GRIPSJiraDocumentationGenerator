using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static System.Windows.Forms.LinkLabel;

namespace GRIPSJiraDocumentationGenerator
{
    public class JiraClient
    {
        private string _userName = string.Empty;
        private string _userToken = string.Empty;
        private string _issueNumber = string.Empty;
        private string _filePath = string.Empty;
        private static string _baseUrl = "https://jira.goodyear.eu/rest/api/2/issue/DEV-";

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }

        public string UserToken
        {
            get => _userToken;
            set => _userToken = value;
        }

        public string IssueNumber
        {
            get => _issueNumber;
            set => _issueNumber = value;
        }

        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        public async Task<string> GetAndSaveIssueDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_userName}:{_userToken}"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                var url = $"{_baseUrl}{_issueNumber}";

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string issueData = await response.Content.ReadAsStringAsync();
                        JObject issueJson = JObject.Parse(issueData);


                        string issueKey = issueJson["key"].ToString();
                        issueKey = issueKey.Replace("DEV-", "");

                        string summary = issueJson["fields"]["summary"].ToString();

                        string description = issueJson["fields"]["description"]?.ToString() ?? "No description";
                        description = RemoveImagesFromText(description);

                        string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "documentation-template.docx");
                        string newFileName = $"TCD {issueKey} {summary}.docx";
                        string newFilePath = Path.Combine(_filePath, newFileName);
                        var document = DocX.Load(templatePath);
                        var replacements = new Dictionary<string, string>
                        {
                            { "{IssueKey}", issueKey },
                            { "{Summary}", summary },
                            { "{Description}", description },
                        };

                        foreach (var replacement in replacements)
                        {

                            var replaceTextOptions = new StringReplaceTextOptions
                            {
                                SearchValue = replacement.Key,
                                NewValue = replacement.Value,               
                            };

                            document.ReplaceText(replaceTextOptions);
                        }

                        document.SaveAs(newFilePath);

                        return $"Document saved to {newFilePath}";
                    }
                    else
                    {
                        return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Exception: {ex.Message}";
                }
            }
        }

        private string RemoveImagesFromText(string input)
        {
            string result = Regex.Replace(input, @"!\w+\-\d{4}\-\d{2}\-\d{2}\-\d{2}\-\d{2}\-\d{2}\-\d{3}\.png\|width=\d+\,height=\d+!", string.Empty);

            result = Regex.Replace(result, @"\s+", " ").Trim();

            return result;
        }

    }



}
