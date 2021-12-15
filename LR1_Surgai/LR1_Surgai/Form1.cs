using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Surgai
{
    public partial class Form1 : Form
    {
        struct Znak
        {
            public string Surname;
            public string Name;
            public string ZodiacSign;
            public DateTime DateOfBirth;
        }

        List<Znak> znaks = new List<Znak>(8);


        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text.Length == 0 || nameTextBox.Text .Length == 0 || zodiacSignTextBox.Text.Length == 0 || dateOfBirthDateTimePicker.Value >= DateTime.Now)
            {
                MessageBox.Show("Необхідно заповнити усі поля!");
            }
            else
                if (znaks.Count < 9)
                {
                    Znak znak = new Znak();
                    znak.Surname = surnameTextBox.Text;
                    znak.Name = nameTextBox.Text;
                    znak.ZodiacSign = zodiacSignTextBox.Text;
                    znak.DateOfBirth = dateOfBirthDateTimePicker.Value;
                    znaks.Add(znak);

                    dataGridView.Rows.Add(surnameTextBox.Text, nameTextBox.Text, zodiacSignTextBox.Text, dateOfBirthDateTimePicker.Value.ToShortDateString());

                    surnameTextBox.Clear();
                    nameTextBox.Clear();
                    zodiacSignTextBox.Clear();
                    dateOfBirthDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Досягнута максимальна кількість записів!");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchSignTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заповніть поле для пошуку!");
            }
            else
            {
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (dataGridView.Rows[i].Cells[2].Value.ToString() != searchSignTextBox.Text)
                    {
                        dataGridView.Rows[i].Visible = false;
                    }
                }
            }
            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) == 0)
            {
                MessageBox.Show("Людей з таким знаком Зодіаку не знайдено!");
            }

            searchSignTextBox.Clear();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Visible = true;
            }
        }
    }
}
