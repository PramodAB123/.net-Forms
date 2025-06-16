using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentdata
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext dc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = new DataClasses1DataContext();
            bindgridview();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void classbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Age_Click(object sender, EventArgs e)
        {

        }
        private void cleartextbox()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    TextBox text = ctr as TextBox;
                    text.Clear();
                }
               
            }
            namebox.Focus();
        }
        private void insertbut_Click(object sender, EventArgs e)
        {
            if(namebox.Text!=" " || (agebox.Text)!="" || genderbox.Text!="" || classbox.Text!="")
            {
                student sd = new student();
                sd.Name = namebox.Text;
                sd.Age = int.Parse(agebox.Text);
                sd.Gender = genderbox.Text;
                sd.Class = int.Parse(classbox.Text);
                sd.roll_no = int.Parse(idbox.Text);
                dc.students.InsertOnSubmit(sd);
                dc.SubmitChanges();
                MessageBox.Show("U have entered the message");
                cleartextbox();
                bindgridview();
            }
            else
            {
                MessageBox.Show("enter the data in correct format");
            }  
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void clearbut_Click(object sender, EventArgs e)
        {
            cleartextbox();
        }
        private void bindgridview()
        {
            dc = new DataClasses1DataContext();
            dataGridView1.DataSource = dc.students;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void updatebut_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dc = new DataClasses1DataContext();
            namebox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            genderbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            agebox.Text =(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            classbox.Text = (dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            idbox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void updatebut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dc = new DataClasses1DataContext();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                student std = dc.students.FirstOrDefault(s => s.roll_no == id);
                std.Name = namebox.Text;
                std.Gender = genderbox.Text;
                std.Class = int.Parse(classbox.Text);
                std.Age = int.Parse(agebox.Text);
                dc.SubmitChanges();
                MessageBox.Show("Changes made");
                cleartextbox();
                bindgridview();
            }
            else
            {
                MessageBox.Show("select the update ");
            }
        }
        private void deletebut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure to delete ?","Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    dc = new DataClasses1DataContext();
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                    student std = dc.students.FirstOrDefault(s => s.roll_no == id);
                    dc.students.DeleteOnSubmit(std);
                    dc.SubmitChanges();
                    MessageBox.Show($"{id} has been deleted");
                    cleartextbox();
                    bindgridview();
                }
                else
                {
                    MessageBox.Show("u didnt delete anything");
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
