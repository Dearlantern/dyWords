using System;
using System.Windows.Forms;
using ProceeditDictionary.requests;

namespace ProceeditDictionary.screens.Entries
{
    public partial class EntriesForm : Form
    {
        object[] requestValues = new object[3];
        object[] entriesValues = new object[1];

        public EntriesForm()
        {
            InitializeComponent();
        }

        private void getEntriesBtn_Click(object sender, EventArgs e)
        {
            if (srcEntriesLangComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(null, "Please select the source language.", "Required!");
            }
            else
            {
                entriesValues[0] = srcEntriesLangComboBox.SelectedText;
                sendEntriesResquest(entriesValues);
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
