using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Similaritipsum.Models;
using Similaritipsum.Services;

namespace Similaritipsum
{
    public partial class LevensteinReportForm : Form
    {
        private List<LevensteinOutputModel> levensteinOutputModel = new List<LevensteinOutputModel>();
        public LevensteinReportForm(List<string> lipsumStreamArray)
        {
            InitializeComponent();
            for (int i = 0; i < lipsumStreamArray.Count()-1; i++)
            {
                for (int j = i + 1; j < lipsumStreamArray.Count(); j++)
                {
                    LevensteinOutputModel model = new LevensteinOutputModel
                    {
                        FirstStringName = $"String {i + 1}",
                        SecondStringName = $"String {j + 1}",
                        LevensteinValue = TextServices.LevensteinDistance(lipsumStreamArray[i], lipsumStreamArray[j])
                    };
                    levensteinOutputModel.Add(model);
                }
            }
            dataGridView1.DataSource = levensteinOutputModel;
        }
    }
}
