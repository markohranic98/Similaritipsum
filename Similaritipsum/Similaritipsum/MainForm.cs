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

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = WebAPIServices.GetLoremIpsum(ipsumNoParagraphsDefault,ipsumNoParagraphsDefault);
        }
    }
}
