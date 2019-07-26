namespace ProceeditDictionary.screens.Entries
{
    partial class EntriesForm
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
            this.getEntriesBtn = new System.Windows.Forms.Button();
            this.srcEntriesLangComboBox = new System.Windows.Forms.ComboBox();
            this.srcLangEntriesLabel = new System.Windows.Forms.Label();
            this.settingsTranslationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTranslationGroupBox
            // 
            this.settingsTranslationGroupBox.Controls.Add(this.getEntriesBtn);
            this.settingsTranslationGroupBox.Controls.Add(this.srcEntriesLangComboBox);
            this.settingsTranslationGroupBox.Controls.Add(this.srcLangEntriesLabel);
            this.settingsTranslationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsTranslationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsTranslationGroupBox.Name = "settingsTranslationGroupBox";
            this.settingsTranslationGroupBox.Size = new System.Drawing.Size(298, 128);
            this.settingsTranslationGroupBox.TabIndex = 1;
            this.settingsTranslationGroupBox.TabStop = false;
            this.settingsTranslationGroupBox.Text = "Settings";
            // 
            // getEntriesBtn
            // 
            this.getEntriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getEntriesBtn.Location = new System.Drawing.Point(46, 80);
            this.getEntriesBtn.Name = "getEntriesBtn";
            this.getEntriesBtn.Size = new System.Drawing.Size(203, 23);
            this.getEntriesBtn.TabIndex = 4;
            this.getEntriesBtn.Text = "Get Entries";
            this.getEntriesBtn.UseVisualStyleBackColor = true;
            this.getEntriesBtn.Click += new System.EventHandler(this.getEntriesBtn_Click);
            // 
            // srcEntriesLangComboBox
            // 
            this.srcEntriesLangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcEntriesLangComboBox.FormattingEnabled = true;
            this.srcEntriesLangComboBox.Items.AddRange(new object[] {
            "en-gb/English",
            "en-us/English",
            "es/Spanish",
            "lv/Latvian",
            "hi/Hindi",
            "sw/Swahili",
            "ta/Tamil",
            "gu/Gujarati",
            "ro/Romanian"});
            this.srcEntriesLangComboBox.Location = new System.Drawing.Point(152, 28);
            this.srcEntriesLangComboBox.Name = "srcEntriesLangComboBox";
            this.srcEntriesLangComboBox.Size = new System.Drawing.Size(121, 24);
            this.srcEntriesLangComboBox.TabIndex = 2;
            // 
            // srcLangEntriesLabel
            // 
            this.srcLangEntriesLabel.AutoSize = true;
            this.srcLangEntriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcLangEntriesLabel.Location = new System.Drawing.Point(16, 31);
            this.srcLangEntriesLabel.Name = "srcLangEntriesLabel";
            this.srcLangEntriesLabel.Size = new System.Drawing.Size(130, 17);
            this.srcLangEntriesLabel.TabIndex = 0;
            this.srcLangEntriesLabel.Text = "* Source Language";
            // 
            // EntriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 152);
            this.Controls.Add(this.settingsTranslationGroupBox);
            this.Name = "EntriesForm";
            this.Text = "EntriesForm";
            this.settingsTranslationGroupBox.ResumeLayout(false);
            this.settingsTranslationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsTranslationGroupBox;
        private System.Windows.Forms.Button getEntriesBtn;
        private System.Windows.Forms.ComboBox srcEntriesLangComboBox;
        private System.Windows.Forms.Label srcLangEntriesLabel;
    }
}