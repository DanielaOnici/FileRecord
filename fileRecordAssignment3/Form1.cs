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
                    //When the file doesn't exist, it is created and a message is shown to the user
                    using (FileStream newFile = File.Create(path))
                    MessageBox.Show("A new file has been created succesfully");
                    StreamWriter writer = new StreamWriter(path, append:true);
                    writer.Write("Member ID       First Name       Last Name          Date Registered         Number of Classes         Total Cost per Class          Total of all Classes            Total Paid          Amount Outstanding");
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
    }
}