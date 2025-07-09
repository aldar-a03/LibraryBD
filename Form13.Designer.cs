namespace LibraryBD
{
    partial class Form13
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
            System.Windows.Forms.Label id_BookLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label dateOfArrivalLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label nameLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.libraryDataSet = new LibraryBD.LibraryDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager();
            this.arrivalAtWarehouseTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.ArrivalAtWarehouseTableAdapter();
            this.employeeTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.EmployeeTableAdapter();
            this.id_BookTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.arrivalAtWarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfArrival = new System.Windows.Forms.DateTimePicker();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.myCommand = new System.Data.SqlClient.SqlCommand();
            id_BookLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            dateOfArrivalLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalAtWarehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_BookLabel
            // 
            id_BookLabel.AutoSize = true;
            id_BookLabel.Location = new System.Drawing.Point(501, 261);
            id_BookLabel.Name = "id_BookLabel";
            id_BookLabel.Size = new System.Drawing.Size(52, 13);
            id_BookLabel.TabIndex = 6;
            id_BookLabel.Text = "Id Книги:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(396, 292);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(157, 13);
            phoneNumberLabel.TabIndex = 8;
            phoneNumberLabel.Text = "Номер телефона сотрудника:";
            // 
            // dateOfArrivalLabel
            // 
            dateOfArrivalLabel.AutoSize = true;
            dateOfArrivalLabel.Location = new System.Drawing.Point(450, 323);
            dateOfArrivalLabel.Name = "dateOfArrivalLabel";
            dateOfArrivalLabel.Size = new System.Drawing.Size(103, 13);
            dateOfArrivalLabel.TabIndex = 10;
            dateOfArrivalLabel.Text = "Дата поступления:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(484, 352);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(69, 13);
            numberLabel.TabIndex = 12;
            numberLabel.Text = "Количество:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(535, 106);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(40, 13);
            authorLabel.TabIndex = 13;
            authorLabel.Text = "Автор:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(483, 135);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(92, 13);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Название книги:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(339, 200);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить запись о пополнении";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.tableAdapterManager.ArrivalAtWarehouseTableAdapter = this.arrivalAtWarehouseTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookReservationTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.IssuanceDeliveryTableAdapter = null;
            this.tableAdapterManager.ReaderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // arrivalAtWarehouseTableAdapter
            // 
            this.arrivalAtWarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // id_BookTextBox
            // 
            this.id_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Id_Book", true));
            this.id_BookTextBox.Location = new System.Drawing.Point(556, 258);
            this.id_BookTextBox.Name = "id_BookTextBox";
            this.id_BookTextBox.Size = new System.Drawing.Size(126, 20);
            this.id_BookTextBox.TabIndex = 7;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.libraryDataSet;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(556, 289);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(126, 20);
            this.phoneNumberTextBox.TabIndex = 9;
            // 
            // arrivalAtWarehouseBindingSource
            // 
            this.arrivalAtWarehouseBindingSource.DataMember = "ArrivalAtWarehouse";
            this.arrivalAtWarehouseBindingSource.DataSource = this.libraryDataSet;
            // 
            // dateOfArrival
            // 
            this.dateOfArrival.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.arrivalAtWarehouseBindingSource, "DateOfArrival", true));
            this.dateOfArrival.Location = new System.Drawing.Point(556, 320);
            this.dateOfArrival.Name = "dateOfArrival";
            this.dateOfArrival.Size = new System.Drawing.Size(126, 20);
            this.dateOfArrival.TabIndex = 11;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arrivalAtWarehouseBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(556, 349);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(126, 20);
            this.numberTextBox.TabIndex = 13;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(582, 103);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(192, 20);
            this.authorTextBox.TabIndex = 14;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(582, 132);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(192, 20);
            this.nameTextBox.TabIndex = 16;
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=ANCHAEVPC\\SQLALDAR;Initial Catalog=Library;Integrated Security=True;P" +
    "ooling=False";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // myCommand
            // 
            this.myCommand.CommandText = "AddArrivalAtWarehouse";
            this.myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.myCommand.Connection = this.mySqlConnection;
            this.myCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_book", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 12),
            new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(dateOfArrivalLabel);
            this.Controls.Add(this.dateOfArrival);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(id_BookLabel);
            this.Controls.Add(this.id_BookTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form13";
            this.Text = "Принятие книг на склад";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalAtWarehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox id_BookTextBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private LibraryDataSetTableAdapters.ArrivalAtWarehouseTableAdapter arrivalAtWarehouseTableAdapter;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.BindingSource arrivalAtWarehouseBindingSource;
        private System.Windows.Forms.DateTimePicker dateOfArrival;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand myCommand;
    }
}