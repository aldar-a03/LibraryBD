using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBD
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.libraryDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.IssuanceDelivery". При необходимости она может быть перемещена или удалена.
            this.issuanceDeliveryTableAdapter.Fill(this.libraryDataSet.IssuanceDelivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.libraryDataSet.Reader);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
           // this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT IssuanceDelivery.Id_IssuanceDelivery AS [Айди], Book.Author AS [Автор], Book.Name AS [Название книги], Reader.PhoneNumber AS [Номер телефона читателя], Employee.PhoneNumber AS [Номер телефона работника], IssuanceDelivery.DateOfIssue AS [Дата выдачи], IssuanceDelivery.DateOfDelivery AS [Дата сдачи], Status AS [Книга сдана] FROM Employee INNER JOIN IssuanceDelivery ON Employee.Id_Employee = IssuanceDelivery.Id_Employee INNER JOIN Book ON IssuanceDelivery.Id_Book = Book.Id_Book INNER JOIN Reader ON IssuanceDelivery.Id_Reader = Reader.Id_Reader";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void fIOLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(authorTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox1.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myCommand.Parameters["@author"].Value = authorTextBox.Text;
                    myCommand.Parameters["@name"].Value = nameTextBox.Text;
                    myCommand.Parameters["@phoneReader"].Value = phoneNumberTextBox.Text;
                    myCommand.Parameters["@phoneEmployee"].Value = phoneNumberTextBox1.Text;
                    myCommand.Parameters["@dateIssuance"].Value = Convert.ToDateTime(dateOfIssueDate.Text);
                    myCommand.Parameters["@dateDelivery"].Value = Convert.ToDateTime(dateOfDeliveryDate.Text);                   
                    mySqlConnection.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Date must be at least today")
                    {
                        MessageBox.Show("Ошибка! Дата должна быть не позднее сегодняшнего дня.", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Employee fired")
                    {
                        MessageBox.Show("Ошибка! Сотрудник уволен!", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "dateDelivery less dateIssuance")
                    {
                        MessageBox.Show("Ошибка! Дата сдачи не должна быть меньше даты выдачи", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Book cannot be issued a second time")
                    {
                        MessageBox.Show("Ошибка! Книга уже выдана!", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Quantity lower than 1")
                    {
                        MessageBox.Show("Ошибка! Книги нет в наличии", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "No such book exists")
                    {
                        MessageBox.Show("Ошибка! Такой книги не существует!", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect phone Employee")
                    {
                        MessageBox.Show("Ошибка! Неправильный номер работника", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect phone Reader")
                    {
                        MessageBox.Show("Ошибка! Неправильный номер читателя", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Book has been issued")
                    {
                        MessageBox.Show("Книга успешно выдана.", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch
            {
                MessageBox.Show("Ошибка", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT IssuanceDelivery.Id_IssuanceDelivery AS [Айди], Book.Author AS [Автор], Book.Name AS [Название книги], Reader.PhoneNumber AS [Номер телефона читателя], Employee.PhoneNumber AS [Номер телефона работника], IssuanceDelivery.DateOfIssue AS [Дата выдачи], IssuanceDelivery.DateOfDelivery AS [Дата сдачи], Status AS [Книга сдана] FROM Employee INNER JOIN IssuanceDelivery ON Employee.Id_Employee = IssuanceDelivery.Id_Employee INNER JOIN Book ON IssuanceDelivery.Id_Book = Book.Id_Book INNER JOIN Reader ON IssuanceDelivery.Id_Reader = Reader.Id_Reader";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id_IssuanceDeliveryTextBox.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {      
                    myCommand2.Parameters["@id"].Value = Convert.ToInt32(id_IssuanceDeliveryTextBox.Text);
                    mySqlConnection1.Open();
                    myCommand2.ExecuteNonQuery();
                    mySqlConnection1.Close();
                    if (Convert.ToString(myCommand2.Parameters["@message"].Value) == "Book returned")
                    {
                        MessageBox.Show("Книга успешно сдана.", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand2.Parameters["@message"].Value) == "Book already returned")
                    {
                        MessageBox.Show("Ошибка! Книга уже сдана", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand2.Parameters["@message"].Value) == "Incorrect ID")
                    {
                        MessageBox.Show("Ошибка! Некорректный айди", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }

            catch
            {
                MessageBox.Show("Ошибка", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT IssuanceDelivery.Id_IssuanceDelivery AS [Айди], Book.Author AS [Автор], Book.Name AS [Название книги], Reader.PhoneNumber AS [Номер телефона читателя], Employee.PhoneNumber AS [Номер телефона работника], IssuanceDelivery.DateOfIssue AS [Дата выдачи], IssuanceDelivery.DateOfDelivery AS [Дата сдачи], Status AS [Книга сдана] FROM Employee INNER JOIN IssuanceDelivery ON Employee.Id_Employee = IssuanceDelivery.Id_Employee INNER JOIN Book ON IssuanceDelivery.Id_Book = Book.Id_Book INNER JOIN Reader ON IssuanceDelivery.Id_Reader = Reader.Id_Reader";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT IssuanceDelivery.Id_IssuanceDelivery AS [Айди], Book.Author AS [Автор], Book.Name AS [Название книги], Reader.PhoneNumber AS [Номер телефона читателя], Employee.PhoneNumber AS [Номер телефона работника], IssuanceDelivery.DateOfIssue AS [Дата выдачи], IssuanceDelivery.DateOfDelivery AS [Дата сдачи], Status AS [Книга сдана] FROM Employee INNER JOIN IssuanceDelivery ON Employee.Id_Employee = IssuanceDelivery.Id_Employee INNER JOIN Book ON IssuanceDelivery.Id_Book = Book.Id_Book INNER JOIN Reader ON IssuanceDelivery.Id_Reader = Reader.Id_Reader  WHERE Reader.PhoneNumber LIKE '%" + phoneNumberTextBox.Text + "%'";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void mySqlConnection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }
    }
}
