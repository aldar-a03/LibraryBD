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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id_ReaderTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox1.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myCommand.Parameters["@Id_Reader"].Value = id_ReaderTextBox.Text;
                    myCommand.Parameters["@newPhone"].Value = phoneNumberTextBox1.Text;
                    mySqlConnection.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Phone number is already use")
                    {
                        MessageBox.Show("Ошибка! Читатель с таким номером телефона уже существует!", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Reader not found")
                    {
                        MessageBox.Show("Ошибка! Читателя с таким ID не существует!", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Reader updated")
                    {
                        MessageBox.Show("Номер телефона успешно изменен", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Reader.Id_Reader AS [ID], Reader.FIO AS [Читатель], Reader.PhoneNumber AS [Номер телефона], Reader.Birthday AS [Дата рождения] FROM Reader";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }

            catch
            {
                MessageBox.Show("Ошибка", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connString);
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT Reader.Id_Reader AS [ID], Reader.FIO AS [Читатель], Reader.PhoneNumber AS [Номер телефона], Reader.Birthday AS [Дата рождения] FROM Reader WHERE PhoneNumber LIKE '%" + phoneNumberTextBox.Text + "%'";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.libraryDataSet.Reader);
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT Reader.Id_Reader AS [ID], Reader.FIO AS [Читатель], Reader.PhoneNumber AS [Номер телефона], Reader.Birthday AS [Дата рождения] FROM Reader";
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
    }
}
