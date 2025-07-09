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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void readerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookReservation". При необходимости она может быть перемещена или удалена.
            this.bookReservationTableAdapter.Fill(this.libraryDataSet.BookReservation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            //this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.libraryDataSet.Reader);

        }

        private void fIOLabel_Click(object sender, EventArgs e)
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
                  mySqlConnection.Open();
                  myCommand.ExecuteNonQuery();
                  mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Date must be at least today")
                    {
                        MessageBox.Show("Неверная дата", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Added to reservation")
                    {
                        MessageBox.Show("Книга зарезервирована", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Quantity lower than 1")
                    {
                        MessageBox.Show("Книги нет в наличии", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "No such book exists")
                    {
                        MessageBox.Show("Такой книги не существует", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect phone")
                    {
                        MessageBox.Show("Неправильный номер телефона", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "You cannot re-reserve a book")
                    {
                        MessageBox.Show("Нельзя повторно зарезервировать книгу", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

            catch
            {
             MessageBox.Show("Ошибка", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }     
        }

        private void mySqlConnection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
