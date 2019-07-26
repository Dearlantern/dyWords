namespace ProceeditDictionary.screens.Translation
{
    partial class TranslationForm
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
            this.getTranslationBtn = new System.Windows.Forms.Button();
            this.tgtTranslationLangComboBox = new System.Windows.Forms.ComboBox();
            this.srcTranslationLangComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsTranslationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTranslationGroupBox
            // 
            this.settingsTranslationGroupBox.Controls.Add(this.getTranslationBtn);
            this.settingsTranslationGroupBox.Controls.Add(this.tgtTranslationLangComboBox);
            this.settingsTranslationGroupBox.Controls.Add(this.srcTranslationLangComboBox);
            this.settingsTranslationGroupBox.Controls.Add(this.label2);
            this.settingsTranslationGroupBox.Controls.Add(this.label1);
            this.settingsTranslationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsTranslationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsTranslationGroupBox.Name = "settingsTranslationGroupBox";
            this.settingsTranslationGroupBox.Size = new System.Drawing.Size(306, 163);
            this.settingsTranslationGroupBox.TabIndex = 0;
            this.settingsTranslationGroupBox.TabStop = false;
            this.settingsTranslationGroupBox.Text = "Settings";
            // 
            // getTranslationBtn
            // 
            this.getTranslationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getTranslationBtn.Location = new System.Drawing.Point(56, 120);
            this.getTranslationBtn.Name = "getTranslationBtn";
            this.getTranslationBtn.Size = new System.Drawing.Size(203, 23);
            this.getTranslationBtn.TabIndex = 4;
            this.getTranslationBtn.Text = "Get Translation";
            this.getTranslationBtn.UseVisualStyleBackColor = true;
            this.getTranslationBtn.Click += new System.EventHandler(this.getTranslationBtn_Click);
            // 
            // tgtTranslationLangComboBox
            // 
            this.tgtTranslationLangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tgtTranslationLangComboBox.FormattingEnabled = true;
            this.tgtTranslationLangComboBox.Location = new System.Drawing.Point(152, 75);
            this.tgtTranslationLangComboBox.Name = "tgtTranslationLangComboBox";
            this.tgtTranslationLangComboBox.Size = new System.Drawing.Size(121, 24);
            this.tgtTranslationLangComboBox.TabIndex = 3;
            // 
            // srcTranslationLangComboBox
            // 
            this.srcTranslationLangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcTranslationLangComboBox.FormattingEnabled = true;
            this.srcTranslationLangComboBox.Items.AddRange(new object[] {
            "en/English",
            "es/Spanish"});
            this.srcTranslationLangComboBox.Location = new System.Drawing.Point(152, 28);
            this.srcTranslationLangComboBox.Name = "srcTranslationLangComboBox";
            this.srcTranslationLangComboBox.Size = new System.Drawing.Size(121, 24);
            this.srcTranslationLangComboBox.TabIndex = 2;
            this.srcTranslationLangComboBox.SelectedIndexChanged += new System.EventHandler(this.srcTranslationLangComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Target Language:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Source Language";
            // 
            // TranslationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 187);
            this.Controls.Add(this.settingsTranslationGroupBox);
            this.Name = "TranslationForm";
            this.Text = "Translation";
            this.settingsTranslationGroupBox.ResumeLayout(false);
            this.settingsTranslationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsTranslationGroupBox;
        private System.Windows.Forms.ComboBox tgtTranslationLangComboBox;
        private System.Windows.Forms.ComboBox srcTranslationLangComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getTranslationBtn;
    }
}