using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

namespace myWindowsFormProject
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
        private float GetSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }

            if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

            return 0;
        }
        private float GetCrustPrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            if (rbThickCrust.Checked)
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }

            return 0;

        }
        private float GetToppingsPrice()
        {
            float toppingsPrice = 0;

            if (chkCheese.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkCheese.Tag);
            }
            if (chkOnions.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkOnions.Tag);
            }
            if (chkMushrooms.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkTomatoes.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkPeppers.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkPeppers.Tag);
            }

            return toppingsPrice;

        }
        private float GetTotalPrice()
        {
            return GetSizePrice() + GetCrustPrice() + GetToppingsPrice();
        }
        private void UpdatePrice()
        {
            lblTotalPrice.Text = GetTotalPrice().ToString() + " €";
        }


        private void UpdateSize()
        {
            UpdatePrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }
        private void UpdateCrust()
        {
            UpdatePrice();

            if (rbThinCrust.Checked)
            {
                lblCrust.Text = "Thin";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lblCrust.Text = "Thick";
                return;
            }
        }
        private void UpdateEatPlace()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Dine In";
                return;
            }
            if (rbEatOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
                return;
            }
        }
        private void UpdateToppings()
        {
            UpdatePrice();

            string toppingsString = "";

            if (chkCheese.Checked) { toppingsString = "Extra Cheese"; }
            if (chkOnions.Checked) { toppingsString += ", Onions"; }
            if (chkMushrooms.Checked) { toppingsString += ", Mushroms"; }
            if (chkOlives.Checked) { toppingsString += ", Olives"; }
            if (chkTomatoes.Checked) { toppingsString += ", Tomatoes"; }
            if (chkPeppers.Checked) { toppingsString += ", Green Tomatoes"; }

            if (toppingsString.StartsWith(","))
                toppingsString = toppingsString.Substring(1, toppingsString.Length - 1).Trim();

            if (toppingsString == "")
                toppingsString = "No Toppings";

            lblToppings.Text = toppingsString;




        }

        private void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            rbMedium.Checked = true;

            rbThinCrust.Checked = true;

            chkCheese.Checked = false;
            chkOnions.Checked = false;
            chkOlives.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkPeppers.Checked = false;

            rbEatIn.Checked = true;

            btnOrder.Enabled = true;
        }

        private void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateEatPlace();
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }


        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }
        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }


        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatPlace();
        }
        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatPlace();
        }


        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrder.Enabled = false;

            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

            ResetForm();

        }


    }
}
