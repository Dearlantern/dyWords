using System;
using System.Windows.Forms;
using ProceeditDictionary.requests;

namespace ProceeditDictionary.screens.Lemmatron
{
    public partial class LemmatronForm : Form
    {
        object[] requestValues = new object[3];
        object[] lemmasValues = new object[1];

        public LemmatronForm()
        {
            InitializeComponent();
        }

        private void getLemmasBtn_Click(object sender, EventArgs e)
        {

            if (srcLemmasLangComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(null, "Please select the source language.", "Required!");
            }
            else
            {
                lemmasValues[0] = srcLemmasLangComboBox.SelectedText;
                sendEntriesResquest(lemmasValues);
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
