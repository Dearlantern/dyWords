namespace ProceeditDictionary.screens.Main
{
    partial class dyWords
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
            this.goBtn = new System.Windows.Forms.Button();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.strictMatchCheckBox = new System.Windows.Forms.CheckBox();
            this.serviceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // goBtn
            // 
            this.goBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.Location = new System.Drawing.Point(24, 123);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(239, 26);
            this.goBtn.TabIndex = 0;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Items.AddRange(new object[] {
            "Wordlist",
            "Entries",
            "Translation",
            "Thesaurus",
            "Sentences",
            "LexiStats",
            "Utility",
            "Search",
            "Lemmatron"});
            this.serviceComboBox.Location = new System.Drawing.Point(96, 82);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(157, 24);
            this.serviceComboBox.TabIndex = 1;
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wordTextBox.Location = new System.Drawing.Point(96, 33);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(157, 23);
            this.wordTextBox.TabIndex = 2;
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wordLabel.Location = new System.Drawing.Point(35, 36);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(55, 17);
            this.wordLabel.TabIndex = 4;
            this.wordLabel.Text = "* Word:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serviceLabel.Location = new System.Drawing.Point(22, 85);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(68, 17);
            this.serviceLabel.TabIndex = 5;
            this.serviceLabel.Text = "* Service:";
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Controls.Add(this.strictMatchCheckBox);
            this.serviceGroupBox.Controls.Add(this.goBtn);
            this.serviceGroupBox.Controls.Add(this.serviceLabel);
            this.serviceGroupBox.Controls.Add(this.wordLabel);
            this.serviceGroupBox.Controls.Add(this.serviceComboBox);
            this.serviceGroupBox.Controls.Add(this.wordTextBox);
            this.serviceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Size = new System.Drawing.Size(291, 169);
            this.serviceGroupBox.TabIndex = 6;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Select a service";
            // 
            // strictMatchCheckBox
            // 
            this.strictMatchCheckBox.AutoSize = true;
            this.strictMatchCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.strictMatchCheckBox.Location = new System.Drawing.Point(96, 59);
            this.strictMatchCheckBox.Name = "strictMatchCheckBox";
            this.strictMatchCheckBox.Size = new System.Drawing.Size(81, 17);
            this.strictMatchCheckBox.TabIndex = 8;
            this.strictMatchCheckBox.Text = "Strict Match";
            this.strictMatchCheckBox.UseVisualStyleBackColor = true;
            // 
            // dyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 200);
            this.Controls.Add(this.serviceGroupBox);
            this.Name = "dyWords";
            this.Text = "dyWORDS";
            this.serviceGroupBox.ResumeLayout(false);
            this.serviceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.CheckBox strictMatchCheckBox;
    }
}

