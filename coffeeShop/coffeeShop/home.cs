using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeShop
{

    public partial class home : Form
    {


        public home()
        {
            InitializeComponent();
        }

        private void ConfirmButtonByCustomer_Click(object sender, EventArgs e)
        {
            int quantity, result;
            quantity = int.Parse(orderQuantityTextBox.Text);

            if (orderItemComboBox.Text == "Black-120")
            {
                result = quantity * 120;
                customerOrderInvoiceRichTextBox.Text = " Name: " + customerNameTextBox.Text + "\n" +
                    " Contact: " + customerContactTextBox.Text + "\n" + "" +
                    " Address: " + customerAddressTxtBox.Text + "\n" + " " +
                    " Order Item: " + orderItemComboBox.Text + "  ," + orderQuantityTextBox.Text + " Cup\n" +
                    " Total ammount: " + result.ToString() + " tk";

            }
            else if (orderItemComboBox.Text == "Cold-100")
            {
                result = quantity * 100;
                customerOrderInvoiceRichTextBox.Text = " Name: " + customerNameTextBox.Text + "\n" +
                    " Contact: " + customerContactTextBox.Text + "\n" + "" +
                    " Address: " + customerAddressTxtBox.Text + "\n" + " " +
                    " Order Item: " + orderItemComboBox.Text + "  ," + orderQuantityTextBox.Text + " Cup\n" +
                    " Total ammount: " + result.ToString() + " tk";

            }
            else if (orderItemComboBox.Text == "Hot-90")
            {
                result = quantity * 90;
                customerOrderInvoiceRichTextBox.Text = " Name: " + customerNameTextBox.Text + "\n" +
                    " Contact: " + customerContactTextBox.Text + "\n" + "" +
                    " Address: " + customerAddressTxtBox.Text + "\n" + " " +
                    " Order Item: " + orderItemComboBox.Text + "  ," + orderQuantityTextBox.Text + " Cup\n" +
                    " Total ammount: " + result.ToString() + " tk";

            }
            else if (orderItemComboBox.Text == "Regular-80")

            {
                result = quantity * 80;
                customerOrderInvoiceRichTextBox.Text = " Name: " + customerNameTextBox.Text + "\n" +
                   " Contact: " + customerContactTextBox.Text + "\n" + "" +
                   " Address: " + customerAddressTxtBox.Text + "\n" + " " +
                   " Order Item: " + orderItemComboBox.Text + "  ," + orderQuantityTextBox.Text + " Cup\n" +
                   " Total ammount: " + result.ToString() + " tk";
            }


        }

    }
}
