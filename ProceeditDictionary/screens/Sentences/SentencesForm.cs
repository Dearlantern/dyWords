using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProceeditDictionary.requests;

namespace ProceeditDictionary.screens.Sentences
{
    public partial class SentencesForm : Form
    {
        object[] requestValues = new object[3];
        object[] sentencesValues = new object[1];

        public SentencesForm()
        {
            InitializeComponent();
        }

        private void getSentencesBtn_Click(object sender, EventArgs e)
        {
            if (srcSentencesLangComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(null, "Please select the source language.", "Required!");
            }
            else
            {
                sentencesValues[0] = srcSentencesLangComboBox.SelectedText;
                sendEntriesResquest(sentencesValues);
            }
        }

        private void sendEntriesResquest(object[] serviceValues)
        {
            RequestAPI.GetJson(requestValues, serviceValues);
        }

        public void setValues(object[] preliminaryValues)
        {
            int i = 0;
            foreach (var item in preliminaryValues)
            {
                requestValues[i] = item;
                i++;
            }
        }
    }
}
