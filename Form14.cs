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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            //this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT Book.Author AS [Автор книги], Book.Name AS [Название книги], Book.Genre AS [Жанр], Book.ISBN AS [ISBN], Book.UDK AS [UDK], Book.Number AS [Наличие] From Book";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(authorTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(genreTextBox.Text) || string.IsNullOrWhiteSpace(iSBNTextBox.Text) || string.IsNullOrWhiteSpace(uDKTextBox.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myCommand.Parameters["@author"].Value = authorTextBox.Text;
                    myCommand.Parameters["@name"].Value = nameTextBox.Text;
                    myCommand.Parameters["@genre"].Value = genreTextBox.Text;
                    myCommand.Parameters["@ISBN"].Value = iSBNTextBox.Text;
                    myCommand.Parameters["@UDK"].Value = uDKTextBox.Text;
            
                    mySqlConnection.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "The book already exists")
                    {
                        MessageBox.Show("Ошибка! Книга уже добавлена!", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Book added")
                    {
                        MessageBox.Show("Книга успешно добавлена", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            command.CommandText = "SELECT Book.Author AS [Автор книги], Book.Name AS [Название книги], Book.Genre AS [Жанр], Book.ISBN AS [ISBN], Book.UDK AS [UDK], Book.Number AS [Наличие] From Book";
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

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
