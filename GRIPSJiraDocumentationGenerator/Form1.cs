using Newtonsoft.Json.Linq;
using RestSharp;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace GRIPSJiraDocumentationGenerator
{
    public partial class MainForm : Form
    {
        JiraClient jiraClient;
        private ErrorProvider errorProvider;

        public MainForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = Properties.Settings.Default.savedUserName;
            tokenTextBox.Text = Properties.Settings.Default.savedToken;
        }

        private async void Generate_Click(object sender, EventArgs e)
        {

            if (!ValidateFields())
            {
                MessageBox.Show("Please fill the required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            jiraClient = new JiraClient
            {
                UserName = userNameTextBox.Text,
                UserToken = tokenTextBox.Text,
                IssueNumber = issueNoTextBox.Text,
                FilePath = browseTextBox.Text
            };

            Properties.Settings.Default.savedUserName = userNameTextBox.Text;
            Properties.Settings.Default.savedToken = tokenTextBox.Text;
            Properties.Settings.Default.savedPath = browseTextBox.Text;
            Properties.Settings.Default.Save();

            string resultMesage = await jiraClient.GetAndSaveIssueDataAsync();
            MessageBox.Show(resultMesage);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    browseTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(userNameTextBox, "Username cannot be empty.");
            }
            else
            {
                errorProvider.SetError(userNameTextBox, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tokenTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(tokenTextBox, "Token cannot be empty.");
            }
            else
            {
                errorProvider.SetError(tokenTextBox, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(issueNoTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(issueNoTextBox, "Issue number cannot be empty.");
            }
            else
            {
                errorProvider.SetError(issueNoTextBox, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(browseTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(browseTextBox, "Please select a file path.");
            }
            else
            {
                errorProvider.SetError(browseTextBox, string.Empty);
            }

            return isValid;
        }
    }
}
