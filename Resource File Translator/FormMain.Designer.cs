namespace Resource_File_Translator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTextTranslator = new System.Windows.Forms.TabPage();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.textBoxTranslatedText = new System.Windows.Forms.TextBox();
            this.labelTranslationResult = new System.Windows.Forms.Label();
            this.textBoxSourceText = new System.Windows.Forms.TextBox();
            this.comboBoxTargetLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxSourceLanguage = new System.Windows.Forms.ComboBox();
            this.labelTargetLanguage = new System.Windows.Forms.Label();
            this.labelSourceLanguage = new System.Windows.Forms.Label();
            this.tabPageRESXTranslator = new System.Windows.Forms.TabPage();
            this.progressBarRESXTranslation = new System.Windows.Forms.ProgressBar();
            this.buttonTraslateResourceFile = new System.Windows.Forms.Button();
            this.checkedListBoxLanguages = new System.Windows.Forms.CheckedListBox();
            this.buttonBrowseOutputFile = new System.Windows.Forms.Button();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.buttonBrowserSourceFile = new System.Windows.Forms.Button();
            this.textBoxSoureFile = new System.Windows.Forms.TextBox();
            this.labelSourceResourceFile = new System.Windows.Forms.Label();
            this.openFileDialogSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageTextTranslator.SuspendLayout();
            this.tabPageRESXTranslator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageTextTranslator);
            this.tabControlMain.Controls.Add(this.tabPageRESXTranslator);
            this.tabControlMain.Location = new System.Drawing.Point(13, 13);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(606, 361);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTextTranslator
            // 
            this.tabPageTextTranslator.Controls.Add(this.buttonTranslate);
            this.tabPageTextTranslator.Controls.Add(this.textBoxTranslatedText);
            this.tabPageTextTranslator.Controls.Add(this.labelTranslationResult);
            this.tabPageTextTranslator.Controls.Add(this.textBoxSourceText);
            this.tabPageTextTranslator.Controls.Add(this.comboBoxTargetLanguage);
            this.tabPageTextTranslator.Controls.Add(this.comboBoxSourceLanguage);
            this.tabPageTextTranslator.Controls.Add(this.labelTargetLanguage);
            this.tabPageTextTranslator.Controls.Add(this.labelSourceLanguage);
            this.tabPageTextTranslator.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextTranslator.Name = "tabPageTextTranslator";
            this.tabPageTextTranslator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextTranslator.Size = new System.Drawing.Size(598, 335);
            this.tabPageTextTranslator.TabIndex = 0;
            this.tabPageTextTranslator.Text = "Text Translator";
            this.tabPageTextTranslator.UseVisualStyleBackColor = true;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(460, 4);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslate.TabIndex = 7;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // textBoxTranslatedText
            // 
            this.textBoxTranslatedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTranslatedText.Location = new System.Drawing.Point(6, 195);
            this.textBoxTranslatedText.Multiline = true;
            this.textBoxTranslatedText.Name = "textBoxTranslatedText";
            this.textBoxTranslatedText.Size = new System.Drawing.Size(586, 132);
            this.textBoxTranslatedText.TabIndex = 6;
            // 
            // labelTranslationResult
            // 
            this.labelTranslationResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTranslationResult.AutoSize = true;
            this.labelTranslationResult.Location = new System.Drawing.Point(7, 179);
            this.labelTranslationResult.Name = "labelTranslationResult";
            this.labelTranslationResult.Size = new System.Drawing.Size(84, 13);
            this.labelTranslationResult.TabIndex = 5;
            this.labelTranslationResult.Text = "Translated Text:";
            // 
            // textBoxSourceText
            // 
            this.textBoxSourceText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceText.Location = new System.Drawing.Point(6, 33);
            this.textBoxSourceText.Multiline = true;
            this.textBoxSourceText.Name = "textBoxSourceText";
            this.textBoxSourceText.Size = new System.Drawing.Size(586, 139);
            this.textBoxSourceText.TabIndex = 4;
            // 
            // comboBoxTargetLanguage
            // 
            this.comboBoxTargetLanguage.FormattingEnabled = true;
            this.comboBoxTargetLanguage.Location = new System.Drawing.Point(333, 6);
            this.comboBoxTargetLanguage.Name = "comboBoxTargetLanguage";
            this.comboBoxTargetLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTargetLanguage.TabIndex = 3;
            // 
            // comboBoxSourceLanguage
            // 
            this.comboBoxSourceLanguage.FormattingEnabled = true;
            this.comboBoxSourceLanguage.Location = new System.Drawing.Point(108, 6);
            this.comboBoxSourceLanguage.Name = "comboBoxSourceLanguage";
            this.comboBoxSourceLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSourceLanguage.TabIndex = 2;
            // 
            // labelTargetLanguage
            // 
            this.labelTargetLanguage.AutoSize = true;
            this.labelTargetLanguage.Location = new System.Drawing.Point(235, 9);
            this.labelTargetLanguage.Name = "labelTargetLanguage";
            this.labelTargetLanguage.Size = new System.Drawing.Size(92, 13);
            this.labelTargetLanguage.TabIndex = 1;
            this.labelTargetLanguage.Text = "Target Language:";
            // 
            // labelSourceLanguage
            // 
            this.labelSourceLanguage.AutoSize = true;
            this.labelSourceLanguage.Location = new System.Drawing.Point(7, 9);
            this.labelSourceLanguage.Name = "labelSourceLanguage";
            this.labelSourceLanguage.Size = new System.Drawing.Size(95, 13);
            this.labelSourceLanguage.TabIndex = 0;
            this.labelSourceLanguage.Text = "Source Language:";
            // 
            // tabPageRESXTranslator
            // 
            this.tabPageRESXTranslator.Controls.Add(this.progressBarRESXTranslation);
            this.tabPageRESXTranslator.Controls.Add(this.buttonTraslateResourceFile);
            this.tabPageRESXTranslator.Controls.Add(this.checkedListBoxLanguages);
            this.tabPageRESXTranslator.Controls.Add(this.buttonBrowseOutputFile);
            this.tabPageRESXTranslator.Controls.Add(this.textBoxOutputFile);
            this.tabPageRESXTranslator.Controls.Add(this.labelOutputFile);
            this.tabPageRESXTranslator.Controls.Add(this.buttonBrowserSourceFile);
            this.tabPageRESXTranslator.Controls.Add(this.textBoxSoureFile);
            this.tabPageRESXTranslator.Controls.Add(this.labelSourceResourceFile);
            this.tabPageRESXTranslator.Location = new System.Drawing.Point(4, 22);
            this.tabPageRESXTranslator.Name = "tabPageRESXTranslator";
            this.tabPageRESXTranslator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRESXTranslator.Size = new System.Drawing.Size(598, 335);
            this.tabPageRESXTranslator.TabIndex = 1;
            this.tabPageRESXTranslator.Text = "RESX Translator";
            this.tabPageRESXTranslator.UseVisualStyleBackColor = true;
            // 
            // progressBarRESXTranslation
            // 
            this.progressBarRESXTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarRESXTranslation.Location = new System.Drawing.Point(9, 304);
            this.progressBarRESXTranslation.Name = "progressBarRESXTranslation";
            this.progressBarRESXTranslation.Size = new System.Drawing.Size(502, 23);
            this.progressBarRESXTranslation.TabIndex = 8;
            // 
            // buttonTraslateResourceFile
            // 
            this.buttonTraslateResourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTraslateResourceFile.Location = new System.Drawing.Point(517, 304);
            this.buttonTraslateResourceFile.Name = "buttonTraslateResourceFile";
            this.buttonTraslateResourceFile.Size = new System.Drawing.Size(75, 23);
            this.buttonTraslateResourceFile.TabIndex = 7;
            this.buttonTraslateResourceFile.Text = "Translate";
            this.buttonTraslateResourceFile.UseVisualStyleBackColor = true;
            this.buttonTraslateResourceFile.Click += new System.EventHandler(this.buttonTraslateResourceFile_Click);
            // 
            // checkedListBoxLanguages
            // 
            this.checkedListBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxLanguages.Location = new System.Drawing.Point(9, 58);
            this.checkedListBoxLanguages.MultiColumn = true;
            this.checkedListBoxLanguages.Name = "checkedListBoxLanguages";
            this.checkedListBoxLanguages.Size = new System.Drawing.Size(583, 229);
            this.checkedListBoxLanguages.TabIndex = 6;
            // 
            // buttonBrowseOutputFile
            // 
            this.buttonBrowseOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseOutputFile.Location = new System.Drawing.Point(517, 30);
            this.buttonBrowseOutputFile.Name = "buttonBrowseOutputFile";
            this.buttonBrowseOutputFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseOutputFile.TabIndex = 5;
            this.buttonBrowseOutputFile.Text = "Browse";
            this.buttonBrowseOutputFile.UseVisualStyleBackColor = true;
            this.buttonBrowseOutputFile.Click += new System.EventHandler(this.buttonBrowseOutputFile_Click);
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFile.Location = new System.Drawing.Point(124, 32);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.ReadOnly = true;
            this.textBoxOutputFile.Size = new System.Drawing.Size(387, 20);
            this.textBoxOutputFile.TabIndex = 4;
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(6, 35);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(61, 13);
            this.labelOutputFile.TabIndex = 3;
            this.labelOutputFile.Text = "Output File:";
            // 
            // buttonBrowserSourceFile
            // 
            this.buttonBrowserSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowserSourceFile.Location = new System.Drawing.Point(517, 4);
            this.buttonBrowserSourceFile.Name = "buttonBrowserSourceFile";
            this.buttonBrowserSourceFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowserSourceFile.TabIndex = 2;
            this.buttonBrowserSourceFile.Text = "Browse";
            this.buttonBrowserSourceFile.UseVisualStyleBackColor = true;
            this.buttonBrowserSourceFile.Click += new System.EventHandler(this.buttonBrowserSourceFile_Click);
            // 
            // textBoxSoureFile
            // 
            this.textBoxSoureFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSoureFile.Location = new System.Drawing.Point(124, 6);
            this.textBoxSoureFile.Name = "textBoxSoureFile";
            this.textBoxSoureFile.ReadOnly = true;
            this.textBoxSoureFile.Size = new System.Drawing.Size(387, 20);
            this.textBoxSoureFile.TabIndex = 1;
            // 
            // labelSourceResourceFile
            // 
            this.labelSourceResourceFile.AutoSize = true;
            this.labelSourceResourceFile.Location = new System.Drawing.Point(6, 9);
            this.labelSourceResourceFile.Name = "labelSourceResourceFile";
            this.labelSourceResourceFile.Size = new System.Drawing.Size(112, 13);
            this.labelSourceResourceFile.TabIndex = 0;
            this.labelSourceResourceFile.Text = "Source Resource File:";
            // 
            // openFileDialogSourceFile
            // 
            this.openFileDialogSourceFile.Filter = "Resources File(*.resx)|*resx|Language file(*.lang)|*.lang";
            // 
            // saveFileDialogOutputFile
            // 
            this.saveFileDialogOutputFile.DefaultExt = "resx";
            this.saveFileDialogOutputFile.Filter = "Resources File(*.resx)|*resx|Language file(*.lang)|*.lang";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 386);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Resource File Translator";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTextTranslator.ResumeLayout(false);
            this.tabPageTextTranslator.PerformLayout();
            this.tabPageRESXTranslator.ResumeLayout(false);
            this.tabPageRESXTranslator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTextTranslator;
        private System.Windows.Forms.TabPage tabPageRESXTranslator;
        private System.Windows.Forms.ComboBox comboBoxTargetLanguage;
        private System.Windows.Forms.ComboBox comboBoxSourceLanguage;
        private System.Windows.Forms.Label labelTargetLanguage;
        private System.Windows.Forms.Label labelSourceLanguage;
        private System.Windows.Forms.TextBox textBoxTranslatedText;
        private System.Windows.Forms.Label labelTranslationResult;
        private System.Windows.Forms.TextBox textBoxSourceText;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Label labelSourceResourceFile;
        private System.Windows.Forms.Button buttonBrowseOutputFile;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.Button buttonBrowserSourceFile;
        private System.Windows.Forms.TextBox textBoxSoureFile;
        private System.Windows.Forms.Button buttonTraslateResourceFile;
        private System.Windows.Forms.CheckedListBox checkedListBoxLanguages;
        private System.Windows.Forms.OpenFileDialog openFileDialogSourceFile;
        private System.Windows.Forms.ProgressBar progressBarRESXTranslation;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputFile;
    }
}

