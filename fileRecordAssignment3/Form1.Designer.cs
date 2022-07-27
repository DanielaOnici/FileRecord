namespace fileRecordAssignment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtbRecords = new System.Windows.Forms.RichTextBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblPathName = new System.Windows.Forms.Label();
            this.txtbPathName = new System.Windows.Forms.TextBox();
            this.btnFileExists = new System.Windows.Forms.Button();
            this.btnReloadRecords = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtbMemberId = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbDateRegistered = new System.Windows.Forms.TextBox();
            this.txtbNumberClasses = new System.Windows.Forms.TextBox();
            this.txtbTotalPerClass = new System.Windows.Forms.TextBox();
            this.txtbTotalPaid = new System.Windows.Forms.TextBox();
            this.txtbTotalAllClasses = new System.Windows.Forms.TextBox();
            this.txtbAmountOut = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblNumberClasses = new System.Windows.Forms.Label();
            this.lblTotalPerClass = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblTotalAllClasses = new System.Windows.Forms.Label();
            this.lblAmountOut = new System.Windows.Forms.Label();
            this.btnEmptyFile = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.gpbMessages = new System.Windows.Forms.GroupBox();
            this.lblErrorMessageFour = new System.Windows.Forms.Label();
            this.lblErrorMessageThree = new System.Windows.Forms.Label();
            this.lblErrorMessageTwo = new System.Windows.Forms.Label();
            this.lblErrorMessageOne = new System.Windows.Forms.Label();
            this.gpbMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtbRecords
            // 
            this.rtxtbRecords.Location = new System.Drawing.Point(29, 107);
            this.rtxtbRecords.Name = "rtxtbRecords";
            this.rtxtbRecords.Size = new System.Drawing.Size(1325, 255);
            this.rtxtbRecords.TabIndex = 0;
            this.rtxtbRecords.Text = "";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(29, 89);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(125, 15);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "Records From Text File";
            // 
            // lblPathName
            // 
            this.lblPathName.AutoSize = true;
            this.lblPathName.Location = new System.Drawing.Point(29, 37);
            this.lblPathName.Name = "lblPathName";
            this.lblPathName.Size = new System.Drawing.Size(110, 15);
            this.lblPathName.TabIndex = 2;
            this.lblPathName.Text = "File Path and Name";
            // 
            // txtbPathName
            // 
            this.txtbPathName.Location = new System.Drawing.Point(145, 29);
            this.txtbPathName.Name = "txtbPathName";
            this.txtbPathName.Size = new System.Drawing.Size(523, 23);
            this.txtbPathName.TabIndex = 3;
            // 
            // btnFileExists
            // 
            this.btnFileExists.BackColor = System.Drawing.SystemColors.Control;
            this.btnFileExists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFileExists.Location = new System.Drawing.Point(674, 29);
            this.btnFileExists.Name = "btnFileExists";
            this.btnFileExists.Size = new System.Drawing.Size(229, 23);
            this.btnFileExists.TabIndex = 4;
            this.btnFileExists.Text = "Confirm File Exists";
            this.btnFileExists.UseVisualStyleBackColor = false;
            this.btnFileExists.Click += new System.EventHandler(this.btnFileExists_Click);
            // 
            // btnReloadRecords
            // 
            this.btnReloadRecords.Location = new System.Drawing.Point(920, 29);
            this.btnReloadRecords.Name = "btnReloadRecords";
            this.btnReloadRecords.Size = new System.Drawing.Size(137, 60);
            this.btnReloadRecords.TabIndex = 5;
            this.btnReloadRecords.Text = "Reload Records";
            this.btnReloadRecords.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1063, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtbMemberId
            // 
            this.txtbMemberId.Location = new System.Drawing.Point(139, 371);
            this.txtbMemberId.Name = "txtbMemberId";
            this.txtbMemberId.Size = new System.Drawing.Size(529, 23);
            this.txtbMemberId.TabIndex = 7;
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(139, 426);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(228, 23);
            this.txtbFirstName.TabIndex = 8;
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(139, 455);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(228, 23);
            this.txtbLastName.TabIndex = 9;
            // 
            // txtbDateRegistered
            // 
            this.txtbDateRegistered.Location = new System.Drawing.Point(139, 484);
            this.txtbDateRegistered.Name = "txtbDateRegistered";
            this.txtbDateRegistered.Size = new System.Drawing.Size(228, 23);
            this.txtbDateRegistered.TabIndex = 10;
            // 
            // txtbNumberClasses
            // 
            this.txtbNumberClasses.Location = new System.Drawing.Point(139, 513);
            this.txtbNumberClasses.Name = "txtbNumberClasses";
            this.txtbNumberClasses.Size = new System.Drawing.Size(228, 23);
            this.txtbNumberClasses.TabIndex = 11;
            // 
            // txtbTotalPerClass
            // 
            this.txtbTotalPerClass.Location = new System.Drawing.Point(139, 542);
            this.txtbTotalPerClass.Name = "txtbTotalPerClass";
            this.txtbTotalPerClass.Size = new System.Drawing.Size(228, 23);
            this.txtbTotalPerClass.TabIndex = 12;
            // 
            // txtbTotalPaid
            // 
            this.txtbTotalPaid.Location = new System.Drawing.Point(139, 571);
            this.txtbTotalPaid.Name = "txtbTotalPaid";
            this.txtbTotalPaid.Size = new System.Drawing.Size(228, 23);
            this.txtbTotalPaid.TabIndex = 13;
            // 
            // txtbTotalAllClasses
            // 
            this.txtbTotalAllClasses.Location = new System.Drawing.Point(573, 426);
            this.txtbTotalAllClasses.Name = "txtbTotalAllClasses";
            this.txtbTotalAllClasses.Size = new System.Drawing.Size(228, 23);
            this.txtbTotalAllClasses.TabIndex = 14;
            // 
            // txtbAmountOut
            // 
            this.txtbAmountOut.Location = new System.Drawing.Point(573, 455);
            this.txtbAmountOut.Name = "txtbAmountOut";
            this.txtbAmountOut.Size = new System.Drawing.Size(228, 23);
            this.txtbAmountOut.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(686, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 25);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(68, 429);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(69, 458);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(43, 487);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(89, 15);
            this.lblDateRegistered.TabIndex = 19;
            this.lblDateRegistered.Text = "Date Registered";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(66, 374);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(66, 15);
            this.lblMemberId.TabIndex = 20;
            this.lblMemberId.Text = "Member ID";
            // 
            // lblNumberClasses
            // 
            this.lblNumberClasses.AutoSize = true;
            this.lblNumberClasses.Location = new System.Drawing.Point(26, 516);
            this.lblNumberClasses.Name = "lblNumberClasses";
            this.lblNumberClasses.Size = new System.Drawing.Size(106, 15);
            this.lblNumberClasses.TabIndex = 21;
            this.lblNumberClasses.Text = "Number of Classes";
            // 
            // lblTotalPerClass
            // 
            this.lblTotalPerClass.AutoSize = true;
            this.lblTotalPerClass.Location = new System.Drawing.Point(23, 545);
            this.lblTotalPerClass.Name = "lblTotalPerClass";
            this.lblTotalPerClass.Size = new System.Drawing.Size(109, 15);
            this.lblTotalPerClass.TabIndex = 22;
            this.lblTotalPerClass.Text = "Total Cost per Class";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Location = new System.Drawing.Point(74, 574);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(58, 15);
            this.lblTotalPaid.TabIndex = 23;
            this.lblTotalPaid.Text = "Total Paid";
            // 
            // lblTotalAllClasses
            // 
            this.lblTotalAllClasses.AutoSize = true;
            this.lblTotalAllClasses.Location = new System.Drawing.Point(463, 429);
            this.lblTotalAllClasses.Name = "lblTotalAllClasses";
            this.lblTotalAllClasses.Size = new System.Drawing.Size(104, 15);
            this.lblTotalAllClasses.TabIndex = 24;
            this.lblTotalAllClasses.Text = "Total of All Classes";
            // 
            // lblAmountOut
            // 
            this.lblAmountOut.AutoSize = true;
            this.lblAmountOut.Location = new System.Drawing.Point(447, 458);
            this.lblAmountOut.Name = "lblAmountOut";
            this.lblAmountOut.Size = new System.Drawing.Size(120, 15);
            this.lblAmountOut.TabIndex = 25;
            this.lblAmountOut.Text = "Amount Outstanding";
            // 
            // btnEmptyFile
            // 
            this.btnEmptyFile.Location = new System.Drawing.Point(139, 603);
            this.btnEmptyFile.Name = "btnEmptyFile";
            this.btnEmptyFile.Size = new System.Drawing.Size(662, 31);
            this.btnEmptyFile.TabIndex = 26;
            this.btnEmptyFile.Text = "Empty File";
            this.btnEmptyFile.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(447, 510);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(354, 26);
            this.btnAddUpdate.TabIndex = 27;
            this.btnAddUpdate.Text = "Save (Add/Update)";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // gpbMessages
            // 
            this.gpbMessages.Controls.Add(this.lblErrorMessageFour);
            this.gpbMessages.Controls.Add(this.lblErrorMessageThree);
            this.gpbMessages.Controls.Add(this.lblErrorMessageTwo);
            this.gpbMessages.Controls.Add(this.lblErrorMessageOne);
            this.gpbMessages.Location = new System.Drawing.Point(839, 385);
            this.gpbMessages.Name = "gpbMessages";
            this.gpbMessages.Size = new System.Drawing.Size(515, 151);
            this.gpbMessages.TabIndex = 28;
            this.gpbMessages.TabStop = false;
            this.gpbMessages.Text = "Messages";
            // 
            // lblErrorMessageFour
            // 
            this.lblErrorMessageFour.AutoSize = true;
            this.lblErrorMessageFour.Location = new System.Drawing.Point(6, 104);
            this.lblErrorMessageFour.Name = "lblErrorMessageFour";
            this.lblErrorMessageFour.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageFour.TabIndex = 3;
            // 
            // lblErrorMessageThree
            // 
            this.lblErrorMessageThree.AutoSize = true;
            this.lblErrorMessageThree.Location = new System.Drawing.Point(6, 76);
            this.lblErrorMessageThree.Name = "lblErrorMessageThree";
            this.lblErrorMessageThree.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageThree.TabIndex = 2;
            // 
            // lblErrorMessageTwo
            // 
            this.lblErrorMessageTwo.AutoSize = true;
            this.lblErrorMessageTwo.Location = new System.Drawing.Point(6, 49);
            this.lblErrorMessageTwo.Name = "lblErrorMessageTwo";
            this.lblErrorMessageTwo.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageTwo.TabIndex = 1;
            // 
            // lblErrorMessageOne
            // 
            this.lblErrorMessageOne.AutoSize = true;
            this.lblErrorMessageOne.Location = new System.Drawing.Point(6, 24);
            this.lblErrorMessageOne.Name = "lblErrorMessageOne";
            this.lblErrorMessageOne.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageOne.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 646);
            this.Controls.Add(this.gpbMessages);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.btnEmptyFile);
            this.Controls.Add(this.lblAmountOut);
            this.Controls.Add(this.lblTotalAllClasses);
            this.Controls.Add(this.lblTotalPaid);
            this.Controls.Add(this.lblTotalPerClass);
            this.Controls.Add(this.lblNumberClasses);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtbAmountOut);
            this.Controls.Add(this.txtbTotalAllClasses);
            this.Controls.Add(this.txtbTotalPaid);
            this.Controls.Add(this.txtbTotalPerClass);
            this.Controls.Add(this.txtbNumberClasses);
            this.Controls.Add(this.txtbDateRegistered);
            this.Controls.Add(this.txtbLastName);
            this.Controls.Add(this.txtbFirstName);
            this.Controls.Add(this.txtbMemberId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReloadRecords);
            this.Controls.Add(this.btnFileExists);
            this.Controls.Add(this.txtbPathName);
            this.Controls.Add(this.lblPathName);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.rtxtbRecords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbMessages.ResumeLayout(false);
            this.gpbMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtxtbRecords;
        private Label lblRecords;
        private Label lblPathName;
        private TextBox txtbPathName;
        private Button btnFileExists;
        private Button btnReloadRecords;
        private Button btnExit;
        private TextBox txtbMemberId;
        private TextBox txtbFirstName;
        private TextBox txtbLastName;
        private TextBox txtbDateRegistered;
        private TextBox txtbNumberClasses;
        private TextBox txtbTotalPerClass;
        private TextBox txtbTotalPaid;
        private TextBox txtbTotalAllClasses;
        private TextBox txtbAmountOut;
        private Button btnDelete;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDateRegistered;
        private Label lblMemberId;
        private Label lblNumberClasses;
        private Label lblTotalPerClass;
        private Label lblTotalPaid;
        private Label lblTotalAllClasses;
        private Label lblAmountOut;
        private Button btnEmptyFile;
        private Button btnAddUpdate;
        private GroupBox gpbMessages;
        private Label lblErrorMessageFour;
        private Label lblErrorMessageThree;
        private Label lblErrorMessageTwo;
        private Label lblErrorMessageOne;
    }
}