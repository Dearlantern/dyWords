using System;
using System.Windows.Forms;
using ProceeditDictionary.requests;

namespace ProceeditDictionary.screens.Translation
{
    public partial class TranslationForm : Form
    {
        object[] requestValues = new object[3];
        object[] translationValues = new object[1];

        public TranslationForm()
        {
            InitializeComponent();
        }

        private void getTranslationBtn_Click(object sender, EventArgs e)
        {
            if (tgtTranslationLangComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(null, "Please select the source and target languages.", "Required!");
            }
            else
            {
                translationValues[0] = srcTranslationLangComboBox.SelectedText;
                translationValues[1] = tgtTranslationLangComboBox.SelectedText;
                sendTranslationResquest(translationValues);
            }
        }

        private void sendTranslationResquest(object[] serviceValues)
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

        private void srcTranslationLangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tgtTranslationLangComboBox.SelectedIndex = -1;
            tgtTranslationLangComboBox.Items.Clear();

            switch (srcTranslationLangComboBox.SelectedItem)
            {
                case "en/English":
                    tgtTranslationLangComboBox.Items.Insert(0, "es/Spanish");
                    tgtTranslationLangComboBox.Items.Insert(1, "nso/Northern Sotho");
                    tgtTranslationLangComboBox.Items.Insert(2, "ro/Romanian");
                    tgtTranslationLangComboBox.Items.Insert(3, "ms/Malay");
                    tgtTranslationLangComboBox.Items.Insert(4, "zu/isiZulu");
                    tgtTranslationLangComboBox.Items.Insert(5, "id/Indonesian");
                    tgtTranslationLangComboBox.Items.Insert(6, "tn/Setswana");
                    tgtTranslationLangComboBox.Items.Insert(7, "de/German");
                    tgtTranslationLangComboBox.Items.Insert(8, "pt/Portuguese");
                    tgtTranslationLangComboBox.Items.Insert(9, "el/Greek");
                    tgtTranslationLangComboBox.Items.Insert(10, "xh/isiXhosa");
                    tgtTranslationLangComboBox.Items.Insert(11, "tg/Tajik");
                    tgtTranslationLangComboBox.Items.Insert(12, "tt/Tatar");
                    tgtTranslationLangComboBox.Items.Insert(13, "tpi/Tok Pisin");
                    tgtTranslationLangComboBox.Items.Insert(14, "tk/Turkmen");
                    tgtTranslationLangComboBox.Items.Insert(15, "zh/Chinese");
                    break;
                case "es/Spanish":
                    tgtTranslationLangComboBox.Items.Insert(0, "en/English");
                    tgtTranslationLangComboBox.Items.Insert(1, "qu/Quechua");
                    break;
                default:
                    break;
            }
        }
    }
}

