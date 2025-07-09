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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.libraryDataSet.Employee);
            string connString = @"Data Source=ANCHAEVPC\SQLALDAR;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT Employee.FIO AS [ФИО], Employee.Position AS [Должность], Employee.PhoneNumber AS [Номер телефона], Employee.PassportNumber AS [Паспорт] FROM Employee";
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
                if (string.IsNullOrWhiteSpace(fIOTextBox.Text) || string.IsNullOrWhiteSpace(positionComboBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(passportNumberTextBox.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myCommand.Parameters["@fio"].Value = fIOTextBox.Text;
                    myCommand.Parameters["@position"].Value = positionComboBox.Text;
                    myCommand.Parameters["@phone"].Value = phoneNumberTextBox.Text;
                    myCommand.Parameters["@passport"].Value = passportNumberTextBox.Text;
                    mySqlConnection.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Number already exists")
                    {
                        MessageBox.Show("Ошибка! Сотрудник с таким телефоном уже существует!", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "no fired position")
                    {
                        MessageBox.Show("Ошибка! Некорректная должность ", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Passport already exists")
                    {
                        MessageBox.Show("Ошибка! Сотрудник с таким паспортом уже существует", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect position")
                    {
                        MessageBox.Show("Ошибка! Некорректная должность", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "The employee added")
                    {
                        MessageBox.Show("Сотрудник успешно добавлен", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            command.CommandText = "SELECT Employee.FIO AS [ФИО], Employee.Position AS [Должность], Employee.PhoneNumber AS [Номер телефона], Employee.PassportNumber AS [Паспорт] FROM Employee";
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
