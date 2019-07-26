using System;
using System.Windows.Forms;

namespace ProceeditDictionary.screens.Main
{
    public partial class dyWords : Form
    {
        object[] preliminaryValues = new object[3];

        public dyWords()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(wordTextBox.Text) || serviceComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(null, "Please fill the corresponding fields.", "Required!");
            }
            else
            {
                preliminaryValues[0] = wordTextBox.Text;
                preliminaryValues[1] = strictMatchCheckBox.Checked;
                preliminaryValues[2] = serviceComboBox.Text;

                switch (serviceComboBox.SelectedIndex)
                {
                    case 0://Wordlist
                        MessageBox.Show("Wordlist endpoint has been removed and replaced by Oxford English Wordlist product.");
                        break;
                    case 1://Entries
                        Entries.EntriesForm EntriesForm = new Entries.EntriesForm();
                        EntriesForm.setValues(preliminaryValues);
                        EntriesForm.ShowDialog();
                        break;
                    case 2://Translation
                        Translation.TranslationForm TranslationForm = new Translation.TranslationForm();
                        TranslationForm.setValues(preliminaryValues);
                        TranslationForm.ShowDialog();
                        break;
                    case 3://Thesaurus
                        Thesaurus.ThesaurusForm ThesaurusForm = new Thesaurus.ThesaurusForm();
                        ThesaurusForm.setValues(preliminaryValues);
                        ThesaurusForm.ShowDialog();
                        break;
                    case 4://Sentences
                        Sentences.SentencesForm SentencesForm = new Sentences.SentencesForm();
                        SentencesForm.setValues(preliminaryValues);
                        SentencesForm.ShowDialog();
                        break;
                    case 5://LexiStats
                        /* UNDER CONSTRUCTION */ 
                        break;
                    case 6://Utility
                        /* UNDER CONSTRUCTION */
                        break;
                    case 7://Search
                        Search.SearchForm SearchForm = new Search.SearchForm();
                        SearchForm.setValues(preliminaryValues);
                        SearchForm.ShowDialog();
                        break;
                    case 8://Lemmatron
                        Lemmatron.LemmatronForm LemmatronForm = new Lemmatron.LemmatronForm();
                        LemmatronForm.setValues(preliminaryValues);
                        LemmatronForm.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
