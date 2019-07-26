namespace ProceeditDictionary.screens.Sentences
{
    partial class SentencesForm
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
            this.getSentencesBtn = new System.Windows.Forms.Button();
            this.srcSentencesLangComboBox = new System.Windows.Forms.ComboBox();
            this.srcLangSentencesLabel = new System.Windows.Forms.Label();
            this.settingsTranslationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTranslationGroupBox
            // 
            this.settingsTranslationGroupBox.Controls.Add(this.getSentencesBtn);
            this.settingsTranslationGroupBox.Controls.Add(this.srcSentencesLangComboBox);
            this.settingsTranslationGroupBox.Controls.Add(this.srcLangSentencesLabel);
            this.settingsTranslationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsTranslationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsTranslationGroupBox.Name = "settingsTranslationGroupBox";
            this.settingsTranslationGroupBox.Size = new System.Drawing.Size(304, 132);
            this.settingsTranslationGroupBox.TabIndex = 2;
            this.settingsTranslationGroupBox.TabStop = false;
            this.settingsTranslationGroupBox.Text = "Settings";
            // 
            // getSentencesBtn
            // 
            this.getSentencesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSentencesBtn.Location = new System.Drawing.Point(46, 80);
            this.getSentencesBtn.Name = "getSentencesBtn";
            this.getSentencesBtn.Size = new System.Drawing.Size(203, 23);
            this.getSentencesBtn.TabIndex = 4;
            this.getSentencesBtn.Text = "Get Sentences";
            this.getSentencesBtn.UseVisualStyleBackColor = true;
            this.getSentencesBtn.Click += new System.EventHandler(this.getSentencesBtn_Click);
            // 
            // srcSentencesLangComboBox
            // 
            this.srcSentencesLangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcSentencesLangComboBox.FormattingEnabled = true;
            this.srcSentencesLangComboBox.Items.AddRange(new object[] {
            "en-gb/English",
            "en-us/English",
            "es/Spanish",
            "lv/Latvian",
            "hi/Hindi",
            "sw/Swahili",
            "ta/Tamil",
            "gu/Gujarati",
            "ro/Romanian"});
            this.srcSentencesLangComboBox.Location = new System.Drawing.Point(152, 28);
            this.srcSentencesLangComboBox.Name = "srcSentencesLangComboBox";
            this.srcSentencesLangComboBox.Size = new System.Drawing.Size(121, 24);
            this.srcSentencesLangComboBox.TabIndex = 2;
            // 
            // srcLangSentencesLabel
            // 
            this.srcLangSentencesLabel.AutoSize = true;
            this.srcLangSentencesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcLangSentencesLabel.Location = new System.Drawing.Point(16, 31);
            this.srcLangSentencesLabel.Name = "srcLangSentencesLabel";
            this.srcLangSentencesLabel.Size = new System.Drawing.Size(130, 17);
            this.srcLangSentencesLabel.TabIndex = 0;
            this.srcLangSentencesLabel.Text = "* Source Language";
            // 
            // SentencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 156);
            this.Controls.Add(this.settingsTranslationGroupBox);
            this.Name = "SentencesForm";
            this.Text = "SentencesForm";
            this.settingsTranslationGroupBox.ResumeLayout(false);
            this.settingsTranslationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsTranslationGroupBox;
        private System.Windows.Forms.Button getSentencesBtn;
        private System.Windows.Forms.ComboBox srcSentencesLangComboBox;
        private System.Windows.Forms.Label srcLangSentencesLabel;
    }
}