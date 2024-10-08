namespace GRIPSJiraDocumentationGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            generate = new Button();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            tokenTextBox = new TextBox();
            tokenLabel = new Label();
            browseButton = new Button();
            browseTextBox = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            issueNoLabel = new Label();
            issueNoTextBox = new TextBox();
            filePathLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // generate
            // 
            generate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            generate.Location = new Point(103, 261);
            generate.Name = "generate";
            generate.Size = new Size(248, 44);
            generate.TabIndex = 0;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += Generate_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNameTextBox.Location = new Point(80, 3);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(347, 23);
            userNameTextBox.TabIndex = 4;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(3, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(71, 56);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "User  Name:";
            // 
            // tokenTextBox
            // 
            tokenTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tokenTextBox.Location = new Point(80, 59);
            tokenTextBox.Name = "tokenTextBox";
            tokenTextBox.Size = new Size(347, 23);
            tokenTextBox.TabIndex = 6;
            // 
            // tokenLabel
            // 
            tokenLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tokenLabel.AutoSize = true;
            tokenLabel.Location = new Point(3, 56);
            tokenLabel.Name = "tokenLabel";
            tokenLabel.Size = new Size(71, 53);
            tokenLabel.TabIndex = 5;
            tokenLabel.Text = "API Token:";
            // 
            // browseButton
            // 
            browseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            browseButton.Location = new Point(368, 232);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(71, 24);
            browseButton.TabIndex = 7;
            browseButton.Text = "Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // browseTextBox
            // 
            browseTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseTextBox.Location = new Point(103, 232);
            browseTextBox.Name = "browseTextBox";
            browseTextBox.Size = new Size(248, 23);
            browseTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tokenLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(issueNoLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(tokenTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(userNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(userNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(issueNoTextBox, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9433975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0566025F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Size = new Size(430, 183);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // issueNoLabel
            // 
            issueNoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            issueNoLabel.AutoSize = true;
            issueNoLabel.Location = new Point(3, 109);
            issueNoLabel.Name = "issueNoLabel";
            issueNoLabel.Size = new Size(71, 15);
            issueNoLabel.TabIndex = 1;
            issueNoLabel.Text = "Issue No.";
            // 
            // issueNoTextBox
            // 
            issueNoTextBox.Location = new Point(80, 112);
            issueNoTextBox.Name = "issueNoTextBox";
            issueNoTextBox.Size = new Size(139, 23);
            issueNoTextBox.TabIndex = 2;
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Location = new Point(103, 214);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(52, 15);
            filePathLabel.TabIndex = 10;
            filePathLabel.Text = "File Path";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 317);
            Controls.Add(filePathLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(generate);
            Controls.Add(browseTextBox);
            Controls.Add(browseButton);
            Name = "MainForm";
            Text = "GRIPS Jira Documentation Generator";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generate;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private TextBox tokenTextBox;
        private Label tokenLabel;
        private Button browseButton;
        private TextBox browseTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label issueNoLabel;
        private TextBox issueNoTextBox;
        private Label filePathLabel;
    }
}
