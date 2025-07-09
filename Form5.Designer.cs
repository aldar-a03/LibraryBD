namespace LibraryBD
{
    partial class Form5
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
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label dateOfReservLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label nameLabel;
            this.libraryDataSet = new LibraryBD.LibraryDataSet();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.ReaderTableAdapter();
            this.tableAdapterManager = new LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager();
            this.bookReservationTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.BookReservationTableAdapter();
            this.bookTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.BookTableAdapter();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.bookReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfReserv = new System.Windows.Forms.DateTimePicker();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.myCommand = new System.Data.SqlClient.SqlCommand();
            phoneNumberLabel = new System.Windows.Forms.Label();
            dateOfReservLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(298, 206);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(96, 13);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Номер телефона:";
            // 
            // dateOfReservLabel
            // 
            dateOfReservLabel.AutoSize = true;
            dateOfReservLabel.Location = new System.Drawing.Point(354, 239);
            dateOfReservLabel.Name = "dateOfReservLabel";
            dateOfReservLabel.Size = new System.Drawing.Size(36, 13);
            dateOfReservLabel.TabIndex = 4;
            dateOfReservLabel.Text = "Дата:";
            dateOfReservLabel.Click += new System.EventHandler(this.dateOfReservLabel_Click);
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(354, 144);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(40, 13);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Автор:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(354, 177);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(40, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Книга:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "Reader";
            this.readerBindingSource.DataSource = this.libraryDataSet;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArrivalAtWarehouseTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookReservationTableAdapter = this.bookReservationTableAdapter;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.IssuanceDeliveryTableAdapter = null;
            this.tableAdapterManager.ReaderTableAdapter = this.readerTableAdapter;
            this.tableAdapterManager.UpdateOrder = LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookReservationTableAdapter
            // 
            this.bookReservationTableAdapter.ClearBeforeFill = true;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readerBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(400, 203);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(123, 20);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // bookReservationBindingSource
            // 
            this.bookReservationBindingSource.DataMember = "BookReservation";
            this.bookReservationBindingSource.DataSource = this.libraryDataSet;
            // 
            // dateOfReserv
            // 
            this.dateOfReserv.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookReservationBindingSource, "DateOfReserv", true));
            this.dateOfReserv.Location = new System.Drawing.Point(400, 237);
            this.dateOfReserv.Name = "dateOfReserv";
            this.dateOfReserv.Size = new System.Drawing.Size(123, 20);
            this.dateOfReserv.TabIndex = 5;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDataSet;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(400, 141);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(123, 20);
            this.authorTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(400, 174);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=ANCHAEVPC\\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            this.mySqlConnection.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // myCommand
            // 
            this.myCommand.CommandText = "DeleteReservation";
            this.myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.myCommand.Connection = this.mySqlConnection;
            this.myCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@author", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 12),
            new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(dateOfReservLabel);
            this.Controls.Add(this.dateOfReserv);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Name = "Form5";
            this.Text = "Удаление резервирования";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private LibraryDataSetTableAdapters.ReaderTableAdapter readerTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private LibraryDataSetTableAdapters.BookReservationTableAdapter bookReservationTableAdapter;
        private System.Windows.Forms.BindingSource bookReservationBindingSource;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DateTimePicker dateOfReserv;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand myCommand;
    }
}