namespace ProceeditDictionary.screens.Thesaurus
{
    partial class ThesaurusForm
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
            this.getThesaurusBtn = new System.Windows.Forms.Button();
            this.srcThesaurusLangComboBox = new System.Windows.Forms.ComboBox();
            this.srcLangThesaurusLabel = new System.Windows.Forms.Label();
            this.settingsTranslationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTranslationGroupBox
            // 
            this.settingsTranslationGroupBox.Controls.Add(this.getThesaurusBtn);
            this.settingsTranslationGroupBox.Controls.Add(this.srcThesaurusLangComboBox);
            this.settingsTranslationGroupBox.Controls.Add(this.srcLangThesaurusLabel);
            this.settingsTranslationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsTranslationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsTranslationGroupBox.Name = "settingsTranslationGroupBox";
            this.settingsTranslationGroupBox.Size = new System.Drawing.Size(302, 134);
            this.settingsTranslationGroupBox.TabIndex = 2;
            this.settingsTranslationGroupBox.TabStop = false;
            this.settingsTranslationGroupBox.Text = "Settings";
            // 
            // getThesaurusBtn
            // 
            this.getThesaurusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getThesaurusBtn.Location = new System.Drawing.Point(46, 80);
            this.getThesaurusBtn.Name = "getThesaurusBtn";
            this.getThesaurusBtn.Size = new System.Drawing.Size(203, 23);
            this.getThesaurusBtn.TabIndex = 4;
            this.getThesaurusBtn.Text = "Get Thesaurus";
            this.getThesaurusBtn.UseVisualStyleBackColor = true;
            this.getThesaurusBtn.Click += new System.EventHandler(this.getThesaurusBtn_Click);
            // 
            // srcThesaurusLangComboBox
            // 
            this.srcThesaurusLangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcThesaurusLangComboBox.FormattingEnabled = true;
            this.srcThesaurusLangComboBox.Items.AddRange(new object[] {
            "en-gb/English",
            "en-us/English",
            "es/Spanish",
            "lv/Latvian",
            "hi/Hindi",
            "sw/Swahili",
            "ta/Tamil",
            "gu/Gujarati",
            "ro/Romanian"});
            this.srcThesaurusLangComboBox.Location = new System.Drawing.Point(152, 28);
            this.srcThesaurusLangComboBox.Name = "srcThesaurusLangComboBox";
            this.srcThesaurusLangComboBox.Size = new System.Drawing.Size(121, 24);
            this.srcThesaurusLangComboBox.TabIndex = 2;
            // 
            // srcLangThesaurusLabel
            // 
            this.srcLangThesaurusLabel.AutoSize = true;
            this.srcLangThesaurusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcLangThesaurusLabel.Location = new System.Drawing.Point(16, 31);
            this.srcLangThesaurusLabel.Name = "srcLangThesaurusLabel";
            this.srcLangThesaurusLabel.Size = new System.Drawing.Size(130, 17);
            this.srcLangThesaurusLabel.TabIndex = 0;
            this.srcLangThesaurusLabel.Text = "* Source Language";
            // 
            // ThesaurusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 158);
            this.Controls.Add(this.settingsTranslationGroupBox);
            this.Name = "ThesaurusForm";
            this.Text = "ThesaurusForm";
            this.settingsTranslationGroupBox.ResumeLayout(false);
            this.settingsTranslationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsTranslationGroupBox;
        private System.Windows.Forms.Button getThesaurusBtn;
        private System.Windows.Forms.ComboBox srcThesaurusLangComboBox;
        private System.Windows.Forms.Label srcLangThesaurusLabel;
    }
}