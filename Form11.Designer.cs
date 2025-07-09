namespace LibraryBD
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateOfIssueLabel;
            System.Windows.Forms.Label dateOfDeliveryLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.Label id_IssuanceDeliveryLabel;
            this.libraryDataSet = new LibraryBD.LibraryDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager();
            this.issuanceDeliveryTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.IssuanceDeliveryTableAdapter();
            this.readerTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.ReaderTableAdapter();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuanceDeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dateOfDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.EmployeeTableAdapter();
            this.phoneNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.myCommand = new System.Data.SqlClient.SqlCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.id_IssuanceDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.mySqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.myCommand1 = new System.Data.SqlClient.SqlCommand();
            this.myCommand2 = new System.Data.SqlClient.SqlCommand();
            authorLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateOfIssueLabel = new System.Windows.Forms.Label();
            dateOfDeliveryLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            id_IssuanceDeliveryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceDeliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(550, 94);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(40, 13);
            authorLabel.TabIndex = 1;
            authorLabel.Text = "Автор:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(503, 123);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(92, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название книги:";
            // 
            // dateOfIssueLabel
            // 
            dateOfIssueLabel.AutoSize = true;
            dateOfIssueLabel.Location = new System.Drawing.Point(514, 215);
            dateOfIssueLabel.Name = "dateOfIssueLabel";
            dateOfIssueLabel.Size = new System.Drawing.Size(76, 13);
            dateOfIssueLabel.TabIndex = 7;
            dateOfIssueLabel.Text = "Дата выдачи:";
            // 
            // dateOfDeliveryLabel
            // 
            dateOfDeliveryLabel.AutoSize = true;
            dateOfDeliveryLabel.Location = new System.Drawing.Point(522, 246);
            dateOfDeliveryLabel.Name = "dateOfDeliveryLabel";
            dateOfDeliveryLabel.Size = new System.Drawing.Size(68, 13);
            dateOfDeliveryLabel.TabIndex = 9;
            dateOfDeliveryLabel.Text = "Дата сдачи:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(492, 154);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(103, 13);
            phoneNumberLabel.TabIndex = 13;
            phoneNumberLabel.Text = "Телефон читателя:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(484, 183);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(111, 13);
            phoneNumberLabel1.TabIndex = 16;
            phoneNumberLabel1.Text = "Телефон работника:";
            // 
            // id_IssuanceDeliveryLabel
            // 
            id_IssuanceDeliveryLabel.AutoSize = true;
            id_IssuanceDeliveryLabel.Location = new System.Drawing.Point(495, 336);
            id_IssuanceDeliveryLabel.Name = "id_IssuanceDeliveryLabel";
            id_IssuanceDeliveryLabel.Size = new System.Drawing.Size(95, 13);
            id_IssuanceDeliveryLabel.TabIndex = 19;
            id_IssuanceDeliveryLabel.Text = "Id Выдачи/Сдачи:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArrivalAtWarehouseTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookReservationTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.IssuanceDeliveryTableAdapter = this.issuanceDeliveryTableAdapter;
            this.tableAdapterManager.ReaderTableAdapter = this.readerTableAdapter;
            this.tableAdapterManager.UpdateOrder = LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issuanceDeliveryTableAdapter
            // 
            this.issuanceDeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(602, 91);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(602, 120);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "Reader";
            this.readerBindingSource.DataSource = this.libraryDataSet;
            // 
            // issuanceDeliveryBindingSource
            // 
            this.issuanceDeliveryBindingSource.DataMember = "IssuanceDelivery";
            this.issuanceDeliveryBindingSource.DataSource = this.libraryDataSet;
            // 
            // dateOfIssueDate
            // 
            this.dateOfIssueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.issuanceDeliveryBindingSource, "DateOfIssue", true));
            this.dateOfIssueDate.Location = new System.Drawing.Point(602, 211);
            this.dateOfIssueDate.Name = "dateOfIssueDate";
            this.dateOfIssueDate.Size = new System.Drawing.Size(134, 20);
            this.dateOfIssueDate.TabIndex = 8;
            // 
            // dateOfDeliveryDate
            // 
            this.dateOfDeliveryDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.issuanceDeliveryBindingSource, "DateOfDelivery", true));
            this.dateOfDeliveryDate.Location = new System.Drawing.Point(602, 241);
            this.dateOfDeliveryDate.Name = "dateOfDeliveryDate";
            this.dateOfDeliveryDate.Size = new System.Drawing.Size(134, 20);
            this.dateOfDeliveryDate.TabIndex = 10;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readerBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(602, 154);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Выдать книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 386);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.libraryDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // phoneNumberTextBox1
            // 
            this.phoneNumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox1.Location = new System.Drawing.Point(602, 180);
            this.phoneNumberTextBox1.Name = "phoneNumberTextBox1";
            this.phoneNumberTextBox1.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Принять книгу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=ANCHAEVPC\\SQLALDAR;Initial Catalog=Library;Integrated Security=True;P" +
    "ooling=False";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            this.mySqlConnection.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.mySqlConnection_InfoMessage);
            // 
            // myCommand
            // 
            this.myCommand.CommandText = "BookIssuance";
            this.myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.myCommand.Connection = this.mySqlConnection;
            this.myCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@author", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@phoneReader", System.Data.SqlDbType.VarChar, 12),
            new System.Data.SqlClient.SqlParameter("@phoneEmployee", System.Data.SqlDbType.VarChar, 12),
            new System.Data.SqlClient.SqlParameter("@dateIssuance", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@dateDelivery", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(718, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 19;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_IssuanceDeliveryTextBox
            // 
            this.id_IssuanceDeliveryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuanceDeliveryBindingSource, "Id_IssuanceDelivery", true));
            this.id_IssuanceDeliveryTextBox.Location = new System.Drawing.Point(602, 333);
            this.id_IssuanceDeliveryTextBox.Name = "id_IssuanceDeliveryTextBox";
            this.id_IssuanceDeliveryTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_IssuanceDeliveryTextBox.TabIndex = 20;
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "Data Source=ANCHAEVPC\\SQLALDAR;Initial Catalog=Library;Integrated Security=True;P" +
    "ooling=False";
            this.mySqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // myCommand1
            // 
            this.myCommand1.CommandText = "AcceptTheBook";
            this.myCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.myCommand1.Connection = this.mySqlConnection;
            // 
            // myCommand2
            // 
            this.myCommand2.CommandText = "AcceptTheBook";
            this.myCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.myCommand2.Connection = this.mySqlConnection1;
            this.myCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 452);
            this.Controls.Add(id_IssuanceDeliveryLabel);
            this.Controls.Add(this.id_IssuanceDeliveryTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(phoneNumberLabel1);
            this.Controls.Add(this.phoneNumberTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(dateOfDeliveryLabel);
            this.Controls.Add(this.dateOfDeliveryDate);
            this.Controls.Add(dateOfIssueLabel);
            this.Controls.Add(this.dateOfIssueDate);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Name = "Form11";
            this.Text = "Выдача книги";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceDeliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox authorTextBox;
        private LibraryDataSetTableAdapters.ReaderTableAdapter readerTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private LibraryDataSetTableAdapters.IssuanceDeliveryTableAdapter issuanceDeliveryTableAdapter;
        private System.Windows.Forms.BindingSource issuanceDeliveryBindingSource;
        private System.Windows.Forms.DateTimePicker dateOfIssueDate;
        private System.Windows.Forms.DateTimePicker dateOfDeliveryDate;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private LibraryDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox phoneNumberTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand myCommand;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox id_IssuanceDeliveryTextBox;
        private System.Data.SqlClient.SqlConnection mySqlConnection1;
        private System.Data.SqlClient.SqlCommand myCommand1;
        private System.Data.SqlClient.SqlCommand myCommand2;
    }
}