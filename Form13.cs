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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.ArrivalAtWarehouse". При необходимости она может быть перемещена или удалена.
            this.arrivalAtWarehouseTableAdapter.Fill(this.libraryDataSet.ArrivalAtWarehouse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.libraryDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            //this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command1 = new SqlCommand();
            command1.Connection = connection;
            command1.CommandType = System.Data.CommandType.Text;
            command1.CommandText = "SELECT Id_Book AS [Айди книги], Employee.PhoneNumber AS [Номер телефона], ArrivalAtWarehouse.Number AS [Количество],  ArrivalAtWarehouse.DateOfArrival AS [Дата поступления] FROM ArrivalAtWarehouse INNER JOIN Employee ON ArrivalAtWarehouse.Id_Employee = Employee.Id_Employee";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT Book.Id_Book AS [Айди книги], Book.Author AS [Автор книги], Book.Name AS [Название книги], Book.Genre AS [Жанр], Book.Number AS [Наличие] From Book";
            connection.Open();
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id_BookTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(numberTextBox.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myCommand.Parameters["@id_book"].Value = id_BookTextBox.Text;
                    myCommand.Parameters["@phone"].Value = phoneNumberTextBox.Text;
                    myCommand.Parameters["@date"].Value = dateOfArrival.Text;
                    myCommand.Parameters["@number"].Value = numberTextBox.Text;
                    mySqlConnection.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect date of arrival")
                    {
                        MessageBox.Show("Ошибка! Некорректная дата", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect number of books")
                    {
                        MessageBox.Show("Ошибка! Некорректное количество книг", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Employee fired")
                    {
                        MessageBox.Show("Ошибка! Сотрудник уволен", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Arrival succeded")
                    {
                        MessageBox.Show("Поступление успешно добавлено", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect ID employee")
                    {
                        MessageBox.Show("Ошибка! Некорректный номер телефона", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect ID book")
                    {
                        MessageBox.Show("Ошибка! Такой книги не существует", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            command.CommandText = "SELECT Id_Book AS [Айди книги], Employee.PhoneNumber AS [Номер телефона], ArrivalAtWarehouse.Number AS [Количество] FROM ArrivalAtWarehouse INNER JOIN Employee ON ArrivalAtWarehouse.Id_Employee = Employee.Id_Employee";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(authorTextBox.Text)) && !(string.IsNullOrWhiteSpace(nameTextBox.Text)))
            {
                string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Book.Id_Book AS [Айди книги], Author AS [Автор], Name AS [Название книги], Genre AS [Жанр], Number AS [Наличие] FROM Book WHERE Author LIKE '%" + authorTextBox.Text + "%' AND Name LIKE '%" + nameTextBox.Text + "%'";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            else if (!(string.IsNullOrWhiteSpace(authorTextBox.Text)) && string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Book.Id_Book AS [Айди книги], Author AS [Автор], Name AS [Название книги], Genre AS [Жанр], Number AS [Наличие] FROM Book WHERE Author LIKE '%" + authorTextBox.Text + "%'";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            else if (string.IsNullOrWhiteSpace(authorTextBox.Text) && !(string.IsNullOrWhiteSpace(nameTextBox.Text)))
            {
                string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Book.Id_Book AS [Айди книги], Author AS [Автор], Name AS [Название книги], Genre AS [Жанр], Number AS [Наличие] FROM Book WHERE Name LIKE '%" + nameTextBox.Text + "%'";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }

            else if (string.IsNullOrWhiteSpace(authorTextBox.Text) && string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Book.Id_Book AS [Айди книги], Author AS [Автор], Name AS [Название книги], Genre AS [Жанр], Number AS [Наличие] FROM Book";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

