namespace ProceeditDictionary.screens.Search
{
    partial class SearchForm
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
            this.settingsTranslationGroupBox = new System.Windows.Forms.GroupBox();
            this.getSearchBtn = new System.Windows.Forms.Button();
            this.srcSearchLangComboBox = new System.Windows.Forms.ComboBox();
            this.srcLangSearchLabel = new System.Windows.Forms.Label();
            this.settingsTranslationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTranslationGroupBox
            // 
            this.settingsTranslationGroupBox.Controls.Add(this.getSearchBtn);
            this.settingsTranslationGroupBox.Controls.Add(this.srcSearchLangComboBox);
            this.settingsTranslationGroupBox.Controls.Add(this.srcLangSearchLabel);
            this.settingsTranslationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsTranslationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsTranslationGroupBox.Name = "settingsTranslationGroupBox";
            this.settingsTranslationGroupBox.Size = new System.Drawing.Size(303, 132);
            this.settingsTranslationGroupBox.TabIndex = 2;
            this.settingsTranslationGroupBox.TabStop = false;
            this.settingsTranslationGroupBox.Text = "Settings";
            // 
            // getSearchBtn
            // 
            this.getSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSearchBtn.Location = new System.Drawing.Point(46, 80);
            this.getSearchBtn.Name = "getSearchBtn";
            this.getSearchBtn.Size = new System.Drawing.Size(203, 23);
            this.getSearchBtn.TabIndex = 4;
            this.getSearchBtn.Text = "Get Search";
            this.getSearchBtn.UseVisualStyleBackColor = true;
            this.getSearchBtn.Click += new System.EventHandler(this.getSearchBtn_Click);
            // 
            // srcSearchLangComboBox
            // 
            this.srcSearchLangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcSearchLangComboBox.FormattingEnabled = true;
            this.srcSearchLangComboBox.Items.AddRange(new object[] {
            "en-gb/English",
            "en-us/English",
            "es/Spanish",
            "lv/Latvian",
            "hi/Hindi",
            "sw/Swahili",
            "ta/Tamil",
            "gu/Gujarati",
            "ro/Romanian"});
            this.srcSearchLangComboBox.Location = new System.Drawing.Point(152, 28);
            this.srcSearchLangComboBox.Name = "srcSearchLangComboBox";
            this.srcSearchLangComboBox.Size = new System.Drawing.Size(121, 24);
            this.srcSearchLangComboBox.TabIndex = 2;
            // 
            // srcLangSearchLabel
            // 
            this.srcLangSearchLabel.AutoSize = true;
            this.srcLangSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcLangSearchLabel.Location = new System.Drawing.Point(16, 31);
            this.srcLangSearchLabel.Name = "srcLangSearchLabel";
            this.srcLangSearchLabel.Size = new System.Drawing.Size(130, 17);
            this.srcLangSearchLabel.TabIndex = 0;
            this.srcLangSearchLabel.Text = "* Source Language";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 156);
            this.Controls.Add(this.settingsTranslationGroupBox);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.settingsTranslationGroupBox.ResumeLayout(false);
            this.settingsTranslationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsTranslationGroupBox;
        private System.Windows.Forms.Button getSearchBtn;
        private System.Windows.Forms.ComboBox srcSearchLangComboBox;
        private System.Windows.Forms.Label srcLangSearchLabel;
    }
}