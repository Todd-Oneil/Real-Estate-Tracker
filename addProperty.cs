using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class addProperty : Form
    {
        private readonly Dashboard _parent;
        int loggedID;

        public addProperty()
        {
            InitializeComponent();
        }

        public addProperty(Dashboard parent, int ID)
        {
            InitializeComponent();
            _parent = parent;
            loggedID = ID;
        }

        private void DownPaymentDD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            1. casts the downpayment to a deciaml type to be rounded to 2 decimal places. Then takes the result and casts it back into a double
            2. gets the value from the selected index of the dropdown menu when it closes and converts it to a string
            3. calculates Loan to Value ratio for determining the amount for mortgage insurance for anything under 20% down payment by
                subtracting the down payment amount from the list price and then dividing the result by the original list price.
            */
            double loan;
            double insurance;
            double loanToValue;
            int purchase;
            bool check;

            check = EnsureNumbers();

            if(check == true)
            {
                purchase = int.Parse(txtListPrice.Text.Trim());
                if (!txtListPrice.Text.Equals("") || purchase > 0)
                {
                    switch (downPaymentDD.Items[downPaymentDD.SelectedIndex].ToString())// 2
                    {
                        case "5%":
                            {
                                double downPayment = purchase * 0.05;
                                downPayment = (double)Decimal.Round((decimal)downPayment, 2);// 1
                                txtDownPayment.Text = downPayment.ToString();
                                loan = purchase - downPayment;
                                loanToValue = loan / purchase;// 3
                                if (loanToValue > 0.9 && loanToValue <= 0.95)
                                {
                                    insurance = loan * 0.04;
                                    loan += insurance;
                                    txtInsurance.Text = insurance.ToString();
                                    txtLoanAmount.Text = loan.ToString();
                                }
                                break;
                            }
                        case "10%":
                            {
                                double downPayment = purchase * 0.1;
                                downPayment = (double)Decimal.Round((decimal)downPayment, 2);// 1
                                txtDownPayment.Text = downPayment.ToString();
                                loan = purchase - downPayment;
                                loanToValue = loan / purchase;// 3
                                if (loanToValue > 0.85 && loanToValue <= 0.9)
                                {
                                    insurance = loan * 0.031;
                                    loan += insurance;
                                    txtInsurance.Text = insurance.ToString();
                                    txtLoanAmount.Text = loan.ToString();
                                }
                                break;
                            }
                        case "15%":
                            {
                                double downPayment = purchase * 0.15;
                                downPayment = (double)Decimal.Round((decimal)downPayment, 2);// 1
                                txtDownPayment.Text = downPayment.ToString();
                                loan = purchase - downPayment;
                                loanToValue = loan / purchase;// 3
                                if (loanToValue > 0.8 && loanToValue <= 0.85)
                                {
                                    insurance = loan * 0.028;
                                    loan += insurance;
                                    txtInsurance.Text = insurance.ToString();
                                    txtLoanAmount.Text = loan.ToString();
                                }
                                break;
                            }
                        case "20%":
                            {
                                double downPayment = purchase * 0.2;
                                downPayment = (double)Decimal.Round((decimal)downPayment, 2);// 1
                                txtDownPayment.Text = downPayment.ToString();
                                loan = purchase - downPayment;

                                insurance = 0.00;
                                txtInsurance.Text = insurance.ToString();
                                txtLoanAmount.Text = loan.ToString();
                                break;
                            }
                        case "25%":
                            {
                                double downPayment = purchase * 0.25;
                                downPayment = (double)Decimal.Round((decimal)downPayment, 2);// 1
                                txtDownPayment.Text = downPayment.ToString();
                                loan = purchase - downPayment;

                                insurance = 0;
                                txtInsurance.Text = insurance.ToString();
                                txtLoanAmount.Text = loan.ToString();
                                break;
                            }
                        case "30%":
                            {
                                double downPayment = purchase * 0.3;
                                downPayment = (double)Decimal.Round((decimal)downPayment, 2);// 1
                                txtDownPayment.Text = downPayment.ToString();
                                loan = purchase - downPayment;

                                insurance = 0;
                                txtInsurance.Text = insurance.ToString();
                                txtLoanAmount.Text = loan.ToString();
                                break;
                            }
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("List Price Cannot be Empty, or Less than 0. Please Enter a Price", "No List Price", MessageBoxButtons.OK);
                    if (error == DialogResult.OK)
                        this.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("List Price must be above 0", "Invalid Price!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    this.Show();
            }
        }
      
        private void TxtMortTermDD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
             * 1. takes the interest rate text input and divides by 100 to convert it to a decimal for calculation
             * 2. takes the loan amount that was calculated by specifying the down payment amount
             * 3. calculates the monthly payments based on the length of the mortgage term
            */
            bool check;

            check = EnsureNumbers();
            if (check == true)
            {
                if (Double.Parse(txtMortRate.Text) >= 0 && !txtLoanAmount.Text.Equals(""))
                {
                    double loan = Convert.ToDouble(txtLoanAmount.Text);// 1
                    double rate = Convert.ToDouble(txtMortRate.Text) / 100;// 2
                    int yearlyPayments = 12;
                    int totalPayments;
                    double payment;

                    switch (txtMortTermDD.Items[txtMortTermDD.SelectedIndex].ToString())// 2
                    {
                        case "5 years":
                            {
                                int time = 5;
                                totalPayments = yearlyPayments * time;
                                payment = ((loan * (rate / yearlyPayments)) * Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) /
                                    ((Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) - 1);// 3
                                payment = (double)Decimal.Round((decimal)payment, 2);
                                txtMortPayment.Text = payment.ToString();
                                break;
                            }
                        case "10 years":
                            {
                                int time = 10;
                                totalPayments = yearlyPayments * time;
                                payment = ((loan * (rate / yearlyPayments)) * Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) /
                                    ((Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) - 1);// 3
                                payment = (double)Decimal.Round((decimal)payment, 2);
                                txtMortPayment.Text = payment.ToString();
                                break;
                            }
                        case "15 years":
                            {
                                int time = 15;
                                totalPayments = yearlyPayments * time;
                                payment = ((loan * (rate / yearlyPayments)) * Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) /
                                    ((Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) - 1);// 3
                                payment = (double)Decimal.Round((decimal)payment, 2);
                                txtMortPayment.Text = payment.ToString();
                                break;
                            }
                        case "20 years":
                            {
                                int time = 20;
                                totalPayments = yearlyPayments * time;
                                payment = ((loan * (rate / yearlyPayments)) * Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) /
                                    ((Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) - 1);// 3
                                payment = (double)Decimal.Round((decimal)payment, 2);
                                txtMortPayment.Text = payment.ToString();
                                break;
                            }
                        case "25 years":
                            {
                                int time = 25;
                                totalPayments = yearlyPayments * time;
                                payment = ((loan * (rate / yearlyPayments)) * Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) /
                                    ((Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) - 1);// 3
                                payment = (double)Decimal.Round((decimal)payment, 2);
                                txtMortPayment.Text = payment.ToString();
                                break;
                            }
                        case "30 years":
                            {
                                int time = 30;
                                totalPayments = yearlyPayments * time;
                                payment = ((loan * (rate / yearlyPayments)) * Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) /
                                    ((Math.Pow((1 + (rate / yearlyPayments)), totalPayments)) - 1);// 3
                                payment = (double)Decimal.Round((decimal)payment, 2);
                                txtMortPayment.Text = payment.ToString();
                                break;
                            }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Rate cannot be less than 0, Loan cannot be 0 or less", "Invalid Interest Rate / Loan Amount", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                        this.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Value Must be a number above 0", "Field Error!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    this.Show();
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            bool check;

            check = EnsureNumbers();
            if (check == true)
            {
                double totalExpenses = (Double.Parse(txtMortPayment.Text) + Double.Parse(txtCondoFee.Text) + Double.Parse(txtMgmtFee.Text) +
                    Double.Parse(txtMonthlyUtil.Text) + Double.Parse(txtPropMonthly.Text));
                totalExpenses = (double)Decimal.Round((decimal)totalExpenses, 2);

                int rent = int.Parse(txtMonthlyRent.Text);

                double profitLoss = (double)(rent - totalExpenses);
                profitLoss = (double)Decimal.Round((decimal)profitLoss, 2);

                txtProfitLoss.Text = profitLoss.ToString();
            }
            else
            {
                DialogResult result = MessageBox.Show("Invalid data, please check enteries", "invalid data", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void CalculateMonthly(object sender, EventArgs e)
        {
            /*
             * 1. Checks if the field is empty of null.  If it's not divide the value by 12, if it is assign the field value 0
             * 2. Assign the field value to the result
             */
            if (!string.IsNullOrEmpty(txtPropTax.Text))// 1
            {
                double monthly;
                if(Double.TryParse(txtPropTax.Text, out monthly))// 1
                {
                    monthly /= 12;// 1
                    monthly = (double)Decimal.Round((decimal)monthly, 2);
                    txtPropMonthly.Text = monthly.ToString();// 2
                }
                else
                {
                    txtPropMonthly.Text = "0";//2
                }
            }
            else
                txtPropMonthly.Text = "0";// 1
        }
     
        private void Addbtn_Click(object sender, EventArgs e)
        {
            /*
        * 1. checks required fields to see if they are empty. If they are display a message widnow.
        *      if they aren't proceed to check if the optional fields are empty.
        * 2. If optional fields are empty assign their values to 0
        * 3. Create property object
        * 4. check to see if the property exists in the database checking against the city, address and user_ID
        *      if it exists display message that it cannot be added because it already exists
        * 5. Add the property to the database
        * 6. Update the Dashboard window with the newly added record
        */
            bool exists = false;

            if(string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtListPrice.Text) ||
                string.IsNullOrEmpty(txtLoanAmount.Text) || string.IsNullOrEmpty(txtMortRate.Text) || 
                string.IsNullOrEmpty(txtMortTermDD.Items[txtMortTermDD.SelectedIndex].ToString()) || string.IsNullOrEmpty(txtMortPayment.Text) ||
                string.IsNullOrEmpty(txtMonthlyRent.Text) || string.IsNullOrEmpty(txtPropTax.Text)) // 1
            {
                MessageBox.Show("Required Fields Are Empty", "Form Incomplete", MessageBoxButtons.OK);
            }
            else
            {
                string city = txtCity.Text.Trim();
                string address = txtAddress.Text.Trim();
                int listPrice = int.Parse(txtListPrice.Text.Trim());
                double purchase = double.Parse(txtLoanAmount.Text.Trim());
                double downPayment = double.Parse(txtDownPayment.Text.Trim());
                double rate = double.Parse(txtMortRate.Text.Trim());
                int term = 5;
                double payment = double.Parse(txtMortPayment.Text.Trim());
                double rent = double.Parse(txtMonthlyRent.Text.Trim());
                double condoFee;
                double mgmtFee;
                double utilities;
                double propTax = double.Parse(txtPropMonthly.Text.Trim());
                double profit;
                int user = loggedID;

                switch (txtMortTermDD.Items[txtMortTermDD.SelectedIndex].ToString())
                {
                    case "5 years":
                        {
                            term = 5;
                            break;
                        }
                    case "10 years":
                        {
                            term = 10;
                            break;
                        }
                    case "15 years":
                        {
                            term = 15;
                            break;
                        }
                    case "20 years":
                        {
                            term = 20;
                            break;
                        }
                    case "25 years":
                        {
                            term = 25;
                            break;
                        }
                    case "30 years":
                        {
                            term = 30;
                            break;
                        }
                }

                if(string.IsNullOrEmpty(txtCondoFee.Text.Trim()))// 2
                {
                    condoFee = 0.0;
                }
                else
                {
                    condoFee = double.Parse(txtCondoFee.Text.Trim());
                }

                if(string.IsNullOrEmpty(txtMgmtFee.Text.Trim()))// 2
                {
                    mgmtFee = 0.0;
                }
                else
                {
                    mgmtFee = double.Parse(txtMgmtFee.Text.Trim());
                }

                if(string.IsNullOrEmpty(txtMonthlyUtil.Text.Trim()))// 2
                {
                    utilities = 0.0;
                }
                else
                {
                    utilities = double.Parse(txtMonthlyUtil.Text.Trim());
                }

                if(string.IsNullOrEmpty(txtProfitLoss.Text.Trim()))// 2
                {
                    profit = 0.0;
                }
                else
                {
                    profit = double.Parse(txtProfitLoss.Text.Trim());
                }

                Property prop = new Property(city, address, listPrice, purchase, downPayment, rate,
                    term, payment, rent, condoFee, mgmtFee, utilities, propTax, profit, user);// 3

                exists = DatabaseConnection.PropertyCheck(prop.GetCity, prop.GetAddress, loggedID);// 4
                if(exists == false)
                {
                    DatabaseConnection.AddProperty(prop);// 5
                }
            }
            Clear();
            _parent.Show();// 6
            _parent.Display();// 6
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        public void Clear()
        {
            txtCity.Text = txtAddress.Text = txtCondoFee.Text = txtDownPayment.Text = txtInsurance.Text = txtListPrice.Text = txtLoanAmount.Text =
                txtMgmtFee.Text = txtMonthlyRent.Text = txtMonthlyUtil.Text = txtMortPayment.Text = txtMortRate.Text = txtProfitLoss.Text = txtPropMonthly.Text =
                txtPropTax.Text = string.Empty;
        }

        public bool EnsureNumbers()
        {
            bool check = false;
            double number;
            if(double.TryParse(txtListPrice.Text.Trim(), out number))
            {
                check = true;
            }
            if (double.TryParse(txtMortRate.Text.Trim(), out number))
            {
                check = true;
            }
            if (double.TryParse(txtMonthlyRent.Text.Trim(), out number))
            {
                check = true;
            }
            if (double.TryParse(txtPropTax.Text.Trim(), out number))
            {
                check = true;
            }

            return check;
        }
    }
}
