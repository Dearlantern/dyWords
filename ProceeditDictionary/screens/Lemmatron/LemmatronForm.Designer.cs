namespace ProceeditDictionary.screens.Lemmatron
{
    partial class LemmatronForm
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
            this.getLemmasBtn = new System.Windows.Forms.Button();
            this.srcLemmasLangComboBox = new System.Windows.Forms.ComboBox();
            this.srcLangLemmasLabel = new System.Windows.Forms.Label();
            this.settingsTranslationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTranslationGroupBox
            // 
            this.settingsTranslationGroupBox.Controls.Add(this.getLemmasBtn);
            this.settingsTranslationGroupBox.Controls.Add(this.srcLemmasLangComboBox);
            this.settingsTranslationGroupBox.Controls.Add(this.srcLangLemmasLabel);
            this.settingsTranslationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsTranslationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsTranslationGroupBox.Name = "settingsTranslationGroupBox";
            this.settingsTranslationGroupBox.Size = new System.Drawing.Size(299, 129);
            this.settingsTranslationGroupBox.TabIndex = 2;
            this.settingsTranslationGroupBox.TabStop = false;
            this.settingsTranslationGroupBox.Text = "Settings";
            // 
            // getLemmasBtn
            // 
            this.getLemmasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getLemmasBtn.Location = new System.Drawing.Point(46, 80);
            this.getLemmasBtn.Name = "getLemmasBtn";
            this.getLemmasBtn.Size = new System.Drawing.Size(203, 23);
            this.getLemmasBtn.TabIndex = 4;
            this.getLemmasBtn.Text = "Get Lemmas";
            this.getLemmasBtn.UseVisualStyleBackColor = true;
            this.getLemmasBtn.Click += new System.EventHandler(this.getLemmasBtn_Click);
            // 
            // srcLemmasLangComboBox
            // 
            this.srcLemmasLangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcLemmasLangComboBox.FormattingEnabled = true;
            this.srcLemmasLangComboBox.Items.AddRange(new object[] {
            "en-gb/English",
            "en-us/English",
            "es/Spanish",
            "lv/Latvian",
            "hi/Hindi",
            "sw/Swahili",
            "ta/Tamil",
            "gu/Gujarati",
            "ro/Romanian"});
            this.srcLemmasLangComboBox.Location = new System.Drawing.Point(152, 28);
            this.srcLemmasLangComboBox.Name = "srcLemmasLangComboBox";
            this.srcLemmasLangComboBox.Size = new System.Drawing.Size(121, 24);
            this.srcLemmasLangComboBox.TabIndex = 2;
            // 
            // srcLangLemmasLabel
            // 
            this.srcLangLemmasLabel.AutoSize = true;
            this.srcLangLemmasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcLangLemmasLabel.Location = new System.Drawing.Point(16, 31);
            this.srcLangLemmasLabel.Name = "srcLangLemmasLabel";
            this.srcLangLemmasLabel.Size = new System.Drawing.Size(130, 17);
            this.srcLangLemmasLabel.TabIndex = 0;
            this.srcLangLemmasLabel.Text = "* Source Language";
            // 
            // LemmatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 153);
            this.Controls.Add(this.settingsTranslationGroupBox);
            this.Name = "LemmatronForm";
            this.Text = "LemmatronForm";
            this.settingsTranslationGroupBox.ResumeLayout(false);
            this.settingsTranslationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsTranslationGroupBox;
        private System.Windows.Forms.Button getLemmasBtn;
        private System.Windows.Forms.ComboBox srcLemmasLangComboBox;
        private System.Windows.Forms.Label srcLangLemmasLabel;
    }
}