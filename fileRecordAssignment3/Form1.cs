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

                    rtxtbRecords.Width = 810;

                    StreamWriter writer = new StreamWriter(path, append: true);
                    writer.Write("Member ID\tFirst Name\tLast Name\tDate Registered\tNumber of Classes\tTotal Cost per Class\tTotal of all Classes\tTotal Paid\tAmount Outstanding\n");
                    rtxtbRecords.SelectAll();
                    rtxtbRecords.SelectionTabs = new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90};
                    rtxtbRecords.AcceptsTab = true;
                    rtxtbRecords.Select(0, 0);
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    //If the file exists and it is empty, the columns are created
                    if(new FileInfo(path).Length == 0)
                    {
                        StreamWriter writer = new StreamWriter(path, append: true);
                        writer.Write("Member ID\tFirst Name\tLast Name\tDate Registered\tNumber of Classes\tTotal Cost per Class\tTotal of all Classes\tTotal Paid\tAmount Outstanding\n");
                        rtxtbRecords.SelectAll();
                        rtxtbRecords.SelectionTabs = new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90 };
                        rtxtbRecords.AcceptsTab = true;
                        rtxtbRecords.Select(0, 0);
                        writer.Flush();
                        writer.Close();
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
            }
            catch (DirectoryNotFoundException)
            {
                ErrorMessage("Directory not found)", txtbPathName);
            }
            catch (IOException ex)
            {
                ErrorMessage(ex.Message, txtbPathName);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message, txtbPathName);
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            //Cleaning any error messages before validations
            lblErrorMessageOne.Text = "";
            lblErrorMessageTwo.Text = "";
            lblErrorMessageThree.Text = "";
            lblErrorMessageFour.Text = "";


            string firstName = "", lastName = "", dateRegistered = "", numberOfClasses = "", totalPerClass = "", totalAllClasses = "", totalAmountPaid = "", amountOutstanding = "", memberID = "";
            int numberClasses, perClass, totalClasses, totalPaid, amountOut;
            DateTime dateReg;

            try
            {
                FileStream fs = new FileStream(txtbPathName.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                String str = sr.ReadToEnd();
                int i = (str.IndexOf(txtbMemberId.Text.Trim().ToUpper(), 0));

                if (ValidationHelper.ValidateMember(txtbMemberId.Text.Trim().ToUpper()) == true)
                {
                    if (i > -1)
                    {
                        ErrorMessage("The memberID already exists. Follow the pattern (2letters, 4numbers, Initials of the name)", txtbMemberId);
                    }
                    else
                    {
                        if (ValidationHelper.ValidateInitials(txtbMemberId.Text.Trim().ToUpper(), txtbFirstName.Text.Trim().ToUpper(), txtbLastName.Text.Trim().ToUpper()) == true)
                        {
                            memberID = txtbMemberId.Text.Trim().ToUpper();
                        }
                        else
                        {
                            ErrorMessage("The last 2 letters of the member ID doesn't match the Initials of First Name and Last Name", txtbMemberId);
                        }
                    }
                }
                else
                {
                    ErrorMessage("Create memberID following the pattern (2letters, 4numbers, Initials of the name)", txtbMemberId);
                }

                fs.Close();
                sr.Close();
            }
            catch(IOException ex)
            {
                ErrorMessage(ex.Message, txtbMemberId);
            }
            catch (Exception)
            {
                ErrorMessage("Create memberID following the pattern (2letters, 4numbers, Initials of the name)", txtbMemberId);
            }


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
                dateReg = DateTime.Parse(txtbDateRegistered.Text.Trim());

                //Verifying if the date is not in the future
                if (dateReg > DateTime.Today)
                {
                    ErrorMessage("Invalid date. Date can't be in the future", txtbDateRegistered);
                }
                else
                {
                    dateRegistered = dateReg.ToString("d");
                }
            }
            catch (Exception)
            {
                ErrorMessage("Invalid date. Input date in the format yyyy/mm/dd", txtbDateRegistered);
            }

            try
            {
                //Parsing the input to integer
                numberClasses = int.Parse(txtbNumberClasses.Text.Trim());

                //Verifying if the number is greater or equal to 1
                if (ValidationHelper.ValidateNumber(numberClasses) == true)
                {
                    numberOfClasses = numberClasses.ToString();
                }
                else
                {
                    ErrorMessage("Invalid number of Classes. Input only whole numbers greater or equal to 1", txtbNumberClasses);
                }
            }
            catch (Exception)
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
            catch (Exception)
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
            catch (Exception)
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
                    if (totalPaid >= 0)
                    {
                        totalAmountPaid = totalPaid.ToString("C2");
                    }
                    else
                    {
                        ErrorMessage("Invalid number. Must be equal or greater than 0", txtbTotalPaid);
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Invalid total paid. Please insert only numbers", txtbTotalPaid);
                }

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
                    amountOut = int.Parse(txtbAmountOut.Text.Trim());

                    //Verifying if the amount is the difference between total paid and total of classes
                    if (amountOut == int.Parse(txtbTotalAllClasses.Text.Trim()) - int.Parse(txtbTotalPaid.Text.Trim()))
                    {
                        amountOutstanding = int.Parse(txtbAmountOut.Text.Trim()).ToString("C2");
                    }
                    else if (amountOut <= 0)
                    {
                        amountOut = 0;
                        amountOutstanding = int.Parse(txtbAmountOut.Text.Trim()).ToString("C2");
                    }
                    else
                    {
                        ErrorMessage("The amount outstanding isn't the difference between total of classes and total paid", txtbAmountOut);
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Invalid Amount Outstanding. Please insert only numbers", txtbAmountOut);
                }
            }

            string path = @txtbPathName.Text;
            try
            {
                //Registering data into the file when there is no error message
                if (lblErrorMessageOne.Text == null || lblErrorMessageOne.Text == "")
                {
                    StreamWriter writer = new StreamWriter(path, append: true);
                    writer.Write($"{memberID};\t{firstName};\t{lastName};\t{dateRegistered};\t{numberOfClasses};\t{totalPerClass}\t{totalAllClasses};\t{totalAmountPaid};\t{amountOutstanding}\n");
                    rtxtbRecords.SelectAll();
                    rtxtbRecords.SelectionTabs = new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90 };
                    rtxtbRecords.AcceptsTab = true;
                    rtxtbRecords.Select(0, 0);
                    writer.Flush();
                    writer.Close();

                    //Displaying the data after saving it
                    StreamReader reader = new StreamReader(path);
                    string record = reader.ReadToEnd();
                    rtxtbRecords.Text = record;
                    reader.Dispose();
                    reader.Close();
                }
            }
            catch(IOException ex)
            {
                ErrorMessage(ex.Message, txtbMemberId);
            }
            catch(Exception ex)
            {
                ErrorMessage(ex.Message, txtbMemberId);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Turning the Rich Text Box to read-only
            rtxtbRecords.ReadOnly = true;
            rtxtbRecords.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exiting the program
            Close();
        }
    }
}