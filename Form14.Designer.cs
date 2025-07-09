namespace LibraryBD
{
    partial class Form14
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
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label uDKLabel;
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.libraryDataSet = new LibraryBD.LibraryDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryBD.LibraryDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.uDKTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myCommand = new System.Data.SqlClient.SqlCommand();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            authorLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            uDKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(577, 142);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(40, 13);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Автор:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(525, 185);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(92, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Название книги:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(579, 220);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 6;
            genreLabel.Text = "Жанр:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(583, 256);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 8;
            iSBNLabel.Text = "ISBN:";
            // 
            // uDKLabel
            // 
            uDKLabel.AutoSize = true;
            uDKLabel.Location = new System.Drawing.Point(585, 291);
            uDKLabel.Name = "uDKLabel";
            uDKLabel.Size = new System.Drawing.Size(34, 13);
            uDKLabel.TabIndex = 10;
            uDKLabel.Text = "УДК:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.tableAdapterManager.IssuanceDeliveryTableAdapter = null;
            this.tableAdapterManager.ReaderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryBD.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(624, 139);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(150, 20);
            this.authorTextBox.TabIndex = 3;
            this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(624, 178);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(624, 217);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(150, 20);
            this.genreTextBox.TabIndex = 7;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(624, 253);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(150, 20);
            this.iSBNTextBox.TabIndex = 9;
            // 
            // uDKTextBox
            // 
            this.uDKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "UDK", true));
            this.uDKTextBox.Location = new System.Drawing.Point(624, 288);
            this.uDKTextBox.Name = "uDKTextBox";
            this.uDKTextBox.Size = new System.Drawing.Size(150, 20);
            this.uDKTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 400);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // myCommand
            // 
            this.myCommand.CommandText = "AddBook";
            this.myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.myCommand.Connection = this.mySqlConnection;
            this.myCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@author", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@genre", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@ISBN", System.Data.SqlDbType.VarChar, 20),
            new System.Data.SqlClient.SqlParameter("@UDK", System.Data.SqlDbType.VarChar, 20),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=ANCHAEVPC\\SQLALDAR;Initial Catalog=Library;Integrated Security=True;P" +
    "ooling=False";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(uDKLabel);
            this.Controls.Add(this.uDKTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Name = "Form14";
            this.Text = "Добавление книги";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox uDKTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlCommand myCommand;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
    }
}