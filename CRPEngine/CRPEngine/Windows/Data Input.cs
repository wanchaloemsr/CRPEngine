using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPEngine.Windows
{
    public partial class Data_Input : Form
    {
        CR_Prediction_Module main;
        
        public Data_Input()
        {
            InitializeComponent();
        }
        public Data_Input(CR_Prediction_Module main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Data_Input_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (GDP1.Text != null && GDP2.Text != null && Inflation1.Text != null && Inflation2.Text != null && Inflation3.Text != null && AUD1.Text != null && AUD2.Text != null && AUD3.Text != null && CR1.Text != null && CR2.Text != null && CR3.Text != null &&
                GDP1.Text != "" && GDP2.Text != "" && Inflation1.Text != "" && Inflation2.Text != "" && Inflation3.Text != "" && AUD1.Text != "" && AUD2.Text != "" && AUD3.Text != "" && CR1.Text != "" && CR2.Text != "" && CR3.Text != "")
            {
                main.data[0, 0] = double.Parse(GDP1.Text);
                main.data[0, 1] = double.Parse(GDP2.Text);

                main.data[1, 0] = double.Parse(Inflation1.Text);
                main.data[1, 1] = double.Parse(Inflation2.Text);
                main.data[1, 2] = double.Parse(Inflation3.Text);

                main.data[2, 0] = double.Parse(AUD1.Text);
                main.data[2, 1] = double.Parse(AUD2.Text);
                main.data[2, 2] = double.Parse(AUD3.Text);

                main.data[3, 0] = double.Parse(CR1.Text);
                main.data[3, 1] = double.Parse(CR2.Text);
                main.data[3, 2] = double.Parse(CR3.Text);

                main.RefreshInputList();
                main.inputRun = 1;

                this.Close();
            }
            else
            {
                errorLabel.Text = "Please enter a value in all fields";
                errorLabel.Refresh();
            }
        }
    }
}
