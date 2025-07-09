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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void readerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.libraryDataSet.Reader);

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fIOTextBox.Text) || string.IsNullOrWhiteSpace(genderComboBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Пустое поле", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myCommand.Parameters["@fio"].Value = fIOTextBox.Text;
                    myCommand.Parameters["@gender"].Value = genderComboBox.Text;
                    myCommand.Parameters["@phone"].Value = phoneNumberTextBox.Text;
                    myCommand.Parameters["@birth"].Value = Convert.ToDateTime(birthdayDate.Text);
                    //myCommand.Parameters["@message"].Value = ();
                    mySqlConnection.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Reader already registered")
                    {
                        MessageBox.Show("Ошибка! Читатель с таким номер телефона уже зарегистрирован.", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Reader registered")
                    {
                        MessageBox.Show("Читатель успешно зарегистрирован.", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToString(myCommand.Parameters["@message"].Value) == "Incorrect gender")
                    {
                        MessageBox.Show("Ошибка! Некорректный пол.", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch
            {
                MessageBox.Show("Ошибка", "Окно уведомлений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
