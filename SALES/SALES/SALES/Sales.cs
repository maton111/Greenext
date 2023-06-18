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

        private void inputInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please insert in the input textbox below your list of items.\nYou should insert the quantity, if they are imported, the name of the item, and the price, in this order as demonstrated by the following format:\n[quantity] [imported?] [object] [price]", 
                            "Input Info", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void outputInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the textbox below you will find the total price you will pay, considering both the regular tax and the import duty, respectively calculated as the 10% and the 5% of the items price, also considering the exemptions.\nThe list will look like a receipt with the total price of the items after the tax, the total amount of the tax, and the total price to be paid.",
                            "Output Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
