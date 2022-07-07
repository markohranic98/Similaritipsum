using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Similaritipsum.Services;

namespace Similaritipsum
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Determines length of lipsum paragraphs
        /// </summary>
        private string ipsumLengthDefault = "short";
        /// <summary>
        /// determines the number of paragraphs fetched
        /// </summary>
        private string ipsumNoParagraphsDefault = "1";
        /// <summary>
        /// stores generated lipsum sstream in an array
        /// </summary>
        private List<string> lipsumStreamArray = new List<string>();
        /// <summary>
        /// Stores number of stream counts chosen in combobox
        /// </summary>
        private int lipsumStreamCount = 0;

        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            streamNumberCbox.SelectedIndex = 0;
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lipsumStreamArray.Clear();
            lipsumStreamCount =streamNumberCbox.SelectedIndex+1;
            for (int i = 0; i < lipsumStreamCount; i++)
            {
                lipsumStreamArray.Add(WebAPIServices.GetLoremIpsum(ipsumNoParagraphsDefault, ipsumNoParagraphsDefault));
            }
        }

        private void showPirateReferencesBtn_Click(object sender, EventArgs e)
        {
            PirateReferencesForm form = new PirateReferencesForm(lipsumStreamArray);
            form.ShowDialog();
        }

        private void levensteinButton_Click(object sender, EventArgs e)
        {
            if (lipsumStreamCount > 2)
            {
                LevensteinReportForm form = new LevensteinReportForm(lipsumStreamArray);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Need at least two streams to compare");
            }
            
        }
    }
}
