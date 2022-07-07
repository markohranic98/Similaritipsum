using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Similaritipsum.Models;
using Similaritipsum.Services;

namespace Similaritipsum
{
    public partial class PirateReferencesForm : Form
    {
        private List<PirateResultFormOutputModel> outputModel = new List<PirateResultFormOutputModel>();
        private List<string> inputList = new List<string>();
        public PirateReferencesForm(List<string> _input)
        {
            InitializeComponent();
            inputList= _input;
        }

        private void PirateReferencesForm_Load(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (var item in inputList)
            {
                
                PirateResultFormOutputModel model = new PirateResultFormOutputModel
                {
                    StringValue = item,
                    StringName = "Stream "+counter,
                    PirateReferences = TextServices.PirateReferenceCalculator(item)
                        
                };
                counter++;
                outputModel.Add(model);
            }

            pirateDataGridView.DataSource = outputModel;
            //hide value of string since its too long
            //pirateDataGridView.Columns[1].Visible = false;
        }
    }
}
