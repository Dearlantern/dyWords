using System;
using System.Windows.Forms;
using ProceeditDictionary.requests;

namespace ProceeditDictionary.screens.Search
{
    public partial class SearchForm : Form
    {
        object[] requestValues = new object[3];
        object[] searchValues = new object[1];

        public SearchForm()
        {
            InitializeComponent();
        }

        private void getSearchBtn_Click(object sender, EventArgs e)
        {


            if (srcSearchLangComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(null, "Please select the source language.", "Required!");
            }
            else
            {
                searchValues[0] = srcSearchLangComboBox.SelectedText;
                sendEntriesResquest(searchValues);
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
