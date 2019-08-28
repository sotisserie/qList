using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker2
{
    public partial class qTask : Form
    {

        DataTable table;
        string path = @"C:\qList\qListContent.txt";

        public qTask()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Task", typeof(String));
            table.Columns.Add("Time", typeof(int));
            table.Columns.Add("Details", typeof(String));

            dataGridView.DataSource = table;
            dataGridView.Columns["Task"].Width = dataGridView.Width - 50;
            dataGridView.Columns["Time"].Width = dataGridView.Width - dataGridView.Columns["Task"].Width;
            dataGridView.Columns["Details"].Visible = false;
            
            taskTitle.Focus();


            //setup file IO
            //string path = @"C:\qList\qListContent.txt";

            //create file if DNE
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("example task|20|example task details");
                }
            }
            //populate table with file contents
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                string task;
                int time;
                string details;
                char sep = '|';

                while ((s = sr.ReadLine()) != null)
                {
                    task = s.Split(sep)[0];
                    time = Convert.ToInt32(s.Split(sep)[1]);
                    details = s.Split(sep)[2];

                    table.Rows.Add(task, time, details);
                }
            }

        }

        private void clearSpace()
        {
            taskTitle.Clear();
            taskDetails.Clear();
            estTimeBox.ResetText();
            estTimeBox.SelectedIndex = -1;
            taskTitle.Focus();
        }

        private void ButtSave_Click(object sender, EventArgs e)
        {
            if((taskTitle.Text != null) && (estTimeBox.SelectedIndex > -1))
            {

                //first write to table
                table.Rows.Add(taskTitle.Text, estTimeBox.Text, taskDetails.Text);

                //TODO: translate multi-line details to single line for writing with token sep

                //write to file
                string fileTaskString = taskTitle.Text + "|" + estTimeBox.Text + "|" + taskDetails.Text;

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(fileTaskString);
                }
                //cleanup window
                clearSpace();
            }
            else { return; }
        }

        private void ButtRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            if(index > -1)
            {
                taskTitle.Text = table.Rows[index].ItemArray[0].ToString();
                estTimeBox.Text = table.Rows[index].ItemArray[1].ToString();
                taskDetails.Text = table.Rows[index].ItemArray[2].ToString();
                //TODO: Handle multi-line details via token stored in string when saved

                taskDetails.Focus();
            }
        }

        private void ButtDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            //first - remove from app datatable
            table.Rows[index].Delete();

            //then let's make update to our flat file
            //clear file, loop through rows/columns, save all content again to file
            File.Delete(path);

            using (StreamWriter sw = File.CreateText(path))
            {
                int row = 0;
                string task;
                string time;
                string details;
                string fileLineContent;

                while (row != table.Rows.Count)
                {
                    task = table.Rows[row].ItemArray[0].ToString();
                    time = table.Rows[row].ItemArray[1].ToString();
                    details = table.Rows[row].ItemArray[2].ToString();
                    fileLineContent = task + "|" + time + "|" + details;

                    sw.WriteLine(fileLineContent);
                    row++;

                }
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtNew_Click_1(object sender, EventArgs e)
        {
            clearSpace();
        }
    }
}
