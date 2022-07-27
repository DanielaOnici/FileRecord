    /*  fileRecordAssignment3.sln
     * 
     *  The program manages records of a member
     * 
     *  Daniela Onici
     *  Student ID# 8754297
     *  
     *  2022/07/25: created
     *  2022/07/27: finished
     * 
     */


namespace fileRecordAssignment3
{
    public partial class Form1 : Form
    {
        //Public method to check the first empty label to show the message and focus on the first error
        public void ErrorMessage(string message, Control control)
        {
            if (lblErrorMessageOne.Text == null || lblErrorMessageOne.Text == "")
            {
                lblErrorMessageOne.Text = message;
                control.Focus();
            }
            else if (lblErrorMessageTwo.Text == null || lblErrorMessageTwo.Text == "")
            {
                lblErrorMessageTwo.Text = message;
            }
            else if (lblErrorMessageThree.Text == null || lblErrorMessageThree.Text == "")
            {
                lblErrorMessageThree.Text = message;
            }
            else
            {
                lblErrorMessageFour.Text = message;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileExists_Click(object sender, EventArgs e)
        {
            string record = "";
            string path = @txtbPathName.Text;


            try
            {
                //Checking if the file exists
                if (!File.Exists(path))
                {
                    //When the file doesn't exist, it is created with the first row and a message is shown to the user
                    using (FileStream newFile = File.Create(path))
                    MessageBox.Show("A new file has been created succesfully");
                    StreamWriter writer = new StreamWriter(path, append:true);
                    writer.Write("Member ID       First Name       Last Name          Date Registered         Number of Classes         Total Cost per Class          Total of all Classes            Total Paid          Amount Outstanding\n");
                    writer.Dispose();

                }
                else
                {
                    //When the file exists, the content is displayed in the richTextBox
                    StreamReader reader = new StreamReader(path);
                    record = reader.ReadToEnd();
                    rtxtbRecords.Text = record;
                    reader.Dispose();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            string firstName = "", lastName = "", numberOfClasses = "", totalPerClass = "", totalAllClasses = "", totalAmountPaid = "", amountOutstanding;
            int numberClasses, perClass, totalClasses, totalPaid, amountOut;

            //Verifying if the First Name is valid
            if (ValidationHelper.ValidateName(txtbFirstName.Text.Trim()) == true)
            {
                firstName = ValidationHelper.Capitalize(txtbFirstName.Text.Trim());
            }
            else
            {
                //When it is not, an error message is shown
                ErrorMessage("Invalid first name. Minimum 2 characters. No number or special characters are valid.", txtbFirstName);
            }

            //Verifying if the Last Name is valid
            if (ValidationHelper.ValidateName(txtbLastName.Text.Trim()) == true)
            {
                lastName = ValidationHelper.Capitalize(txtbLastName.Text.Trim());
            }
            else
            {
                //When it is not, an error message is shown
                ErrorMessage("Invalid last name. Minimum 2 characters. No number or special characters are valid.", txtbLastName);
            }

            try
            {
                //Parsing the input to integer
                numberClasses = int.Parse(txtbNumberClasses.Text.Trim());

                //Verifying if the number is greater or equal to 1
                if(ValidationHelper.ValidateNumber(numberClasses) == true)
                {
                    numberOfClasses = numberClasses.ToString();
                }
                else
                {
                    ErrorMessage("Invalid number of Classes. Input only whole numbers greater or equal to 1", txtbNumberClasses);
                }
            }
            catch(FormatException ex)
            {
                ErrorMessage("Invalid number of Classes. Input only whole numbers greater or equal to 1", txtbNumberClasses);
            }

            try
            {
                //Parsing the input to integer
                perClass = int.Parse(txtbTotalPerClass.Text.Trim());

                //Verifying if the number is greater or equal to 1
                if (ValidationHelper.ValidateNumber(perClass) == true)
                {
                    totalPerClass = perClass.ToString("C2");
                }
                else
                {
                    ErrorMessage("Invalid total per Class. Input only whole numbers greater or equal to 1", txtbTotalPerClass);
                }
            }
            catch (FormatException ex)
            {
                ErrorMessage("Invalid total per Class. Input only whole numbers greater or equal to 1", txtbTotalPerClass);
            }

            try
            {
                //Parsing the input to integer
                totalClasses = int.Parse(txtbTotalAllClasses.Text.Trim());

                //Verifying if the number is greater or equal to 1
                if (ValidationHelper.ValidateNumber(totalClasses) == true)
                {
                    //Verifying if the input is equal to the product of number of classes and total per class
                    if (totalClasses == int.Parse(txtbNumberClasses.Text.Trim()) * int.Parse(txtbTotalPerClass.Text.Trim()))
                    {
                        totalAllClasses = totalClasses.ToString("C2");
                    }
                    else
                    {
                        ErrorMessage("The total of all Classes is not the product of number of classes and total per class", txtbTotalAllClasses);
                    }
                }
                else
                {
                    ErrorMessage("Invalid total per Class. Input only whole numbers greater or equal to 1", txtbTotalAllClasses);
                }
            }
            catch (FormatException ex)
            {
                ErrorMessage("Invalid total per Class. Input only whole numbers greater or equal to 1", txtbTotalAllClasses);
            }

            //Verifying if the total paid is empty/null
            if (txtbTotalPaid.Text == null || txtbTotalPaid.Text == "")
            {
                ErrorMessage("Total paid empty. If no amount was paid, please insert 0", txtbTotalPaid);
            }
            else
            {
                try
                {
                    totalPaid = int.Parse(txtbTotalPaid.Text.Trim());
                    //Verifying if the amount is equal or greater than 0
                    if(totalPaid >= 0)
                    {
                        totalAmountPaid = totalPaid.ToString("C2");
                    }
                    else
                    {
                        ErrorMessage("Invalid number. Must be equal or greater than 0", txtbTotalPaid);
                    }
                }
                catch (FormatException ex)
                {
                    ErrorMessage("Invalid total paid. Please insert only numbers", txtbTotalPaid);
                }

                //Verifying if the amount outstanding is empty/null
                if (txtbAmountOut.Text == null || txtbAmountOut.Text == "")
                {
                    ErrorMessage("Amount outstanding empty. If 0, please insert 0", txtbAmountOut);
                }
                else
                {
                    try
                    {
                        totalPaid = int.Parse(txtbTotalPaid.Text.Trim());
                        //Verifying if the amount is equal or greater than 0
                        if (totalPaid >= 0)
                        {
                            totalAmountPaid = totalPaid.ToString("C2");
                        }
                        else
                        {
                            ErrorMessage("Invalid number. Must be equal or greater than 0", txtbAmountOut);
                        }
                    }
                    catch (FormatException ex)
                    {
                        ErrorMessage("Invalid total paid. Please insert only numbers", txtbAmountOut);
                    }
                }
        }

        private void gpbMessages_Enter(object sender, EventArgs e)
        {

        }
    }
}