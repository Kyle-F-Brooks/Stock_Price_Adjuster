using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Price_Adjuster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oldStockQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar =='.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void oldStockValTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar =='.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void newStockQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void newStockValTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buildText_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/Kyle-F-Brooks");

        private void button1_Click(object sender, EventArgs e)
        {
            int oldQuantity = int.Parse(oldStockQtyTextBox.Text);
            int newQuantity = int.Parse(newStockQtyTextBox.Text);
            double oldPurchaseVal = double.Parse(oldStockValTextBox.Text);
            double newPurchaseVal = double.Parse(newStockValTextBox.Text);
            double oldPurchaseTotal = oldQuantity * oldPurchaseVal;
            double newPurchaseTotal = newQuantity * newPurchaseVal;
            double averagePurchase = (oldPurchaseTotal + newPurchaseTotal)/(oldQuantity+newQuantity);
            double markup = 2.4 * averagePurchase;

            avgTextBox.Text = averagePurchase.ToString();
            markupTextBox.Text = markup.ToString();

        }
    }
}
