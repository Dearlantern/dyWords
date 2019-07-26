using System;
using System.Windows.Forms;
using ProceeditDictionary.requests;

namespace ProceeditDictionary.screens.Thesaurus
{
    public partial class ThesaurusForm : Form
    {
        object[] requestValues = new object[3];
        object[] thesaurusValues = new object[1];

        public ThesaurusForm()
        {
            InitializeComponent();
        }

        private void getThesaurusBtn_Click(object sender, EventArgs e)
        {
            if (srcThesaurusLangComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(null, "Please select the source language.", "Required!");
            }
            else
            {
                thesaurusValues[0] = srcThesaurusLangComboBox.SelectedText;
                sendEntriesResquest(thesaurusValues);
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
