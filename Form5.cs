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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void readerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            //this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookReservation". При необходимости она может быть перемещена или удалена.
            this.bookReservationTableAdapter.Fill(this.libraryDataSet.BookReservation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.libraryDataSet.Reader);

        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(authorTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myCommand.Parameters["@author"].Value = authorTextBox.Text;
                    myCommand.Parameters["@name"].Value = nameTextBox.Text;
                    myCommand.Parameters["@phone"].Value = phoneNumberTextBox.Text;
                    myCommand.Parameters["@date"].Value = Convert.ToDateTime(dateOfReserv.Text);
                    //myCommand.Parameters["@message"].Value = ();
                    mySqlConnection.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Reservation deleted")
                    {
                        MessageBox.Show("Резервация удалена", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "No such registration")
                    {
                        MessageBox.Show("Резервации не существует", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "No such book exists")
                    {
                        MessageBox.Show("Такой книги не существует", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect phone")
                    {
                        MessageBox.Show("Неправильный номер телефона", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

            catch
            {
                MessageBox.Show("Ошибка", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateOfReservLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
