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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bookReservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookReservationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.libraryDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookReservation". При необходимости она может быть перемещена или удалена.
            this.bookReservationTableAdapter.Fill(this.libraryDataSet.BookReservation);
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = " SELECT Reader.FIO AS [ФИО Читателя], Reader.PhoneNumber AS [Номер телефона],  Book.Author AS [Автор книги],  Book.Name AS [Название книги], DateOfReserv AS [Дата резервирования] FROM   Reader JOIN   BookReservation ON Reader.Id_Reader = BookReservation.Id_Reader JOIN  Book ON BookReservation.Id_Book = Book.Id_Book";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = " SELECT Reader.FIO AS [ФИО Читателя], Reader.PhoneNumber AS [Номер телефона],  Book.Author AS [Автор книги],  Book.Name AS [Название книги], DateOfReserv AS [Дата резервирования] FROM   Reader JOIN   BookReservation ON Reader.Id_Reader = BookReservation.Id_Reader JOIN  Book ON BookReservation.Id_Book = Book.Id_Book";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT Reader.FIO AS [ФИО Читателя], Reader.PhoneNumber AS [Номер телефона], Book.Author AS [Автор книги],  Book.Name AS [Название книги], DateOfReserv AS [Дата резервирования] FROM   Reader JOIN   BookReservation ON Reader.Id_Reader = BookReservation.Id_Reader JOIN  Book ON BookReservation.Id_Book = Book.Id_Book WHERE Reader.FIO LIKE '%" + textBox1.Text + "%'";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
    }
}
