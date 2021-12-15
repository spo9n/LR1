using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Surgai_ZVD2
{
    public partial class Form1 : Form
    {
        Queue<Worker> allWorkers = new Queue<Worker>();
        List<Worker> neededWorkers = new List<Worker>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text.Length == 0 || nameTextBox.Text.Length == 0 || patronymicTextBox.Text.Length == 0 || streetTextBox.Text.Length == 0 || buildingTextBox.Text.Length == 0 || flatTextBox.Text.Length == 0)
            {
                MessageBox.Show("Необхідно заповнити усі поля!");
            }
            else
            {
                Worker worker = new Worker(surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, streetTextBox.Text, buildingTextBox.Text, flatTextBox.Text);

                allWorkers.Enqueue(worker);

                allWorkersDataGridView.Rows.Add(surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, streetTextBox.Text, buildingTextBox.Text, flatTextBox.Text);

                surnameTextBox.Clear();
                nameTextBox.Clear();
                patronymicTextBox.Clear();
                streetTextBox.Clear();
                buildingTextBox.Clear();
                flatTextBox.Clear();

                MessageBox.Show("Запис створено!");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            foreach(Worker wrk in allWorkers)
            {
                if (wrk.GetAddress().GetStreet() == "Червоної")
                {
                    neededWorkers.Add(wrk);
                }    
            }

            neededWorkers = neededWorkers.OrderBy(x => x.GetSurname()).ToList();
            
            foreach (Worker wrk in neededWorkers)
            {
                neededWorkersDataGridView.Rows.Add(wrk.GetSurname(), wrk.GetName(), wrk.GetPatronymic(), wrk.GetAddress().GetStreet(), wrk.GetAddress().GetBuilding(), wrk.GetAddress().GetFlat());
            }
        }
    }
}