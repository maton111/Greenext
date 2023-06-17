using SALES.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALES
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        SalesViewModel _salesViewModel = new SalesViewModel();


        private async void submit_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = await _salesViewModel.GetOutput(input.Text);
            }
            catch (Exception ex)
            {
                output.Text = ex.ToString();
            }
        }
    }
}
