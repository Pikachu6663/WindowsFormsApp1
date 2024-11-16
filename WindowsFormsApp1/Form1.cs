using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBContext;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 model1 = new Model1();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddUsers form = new FormAddUsers(); 
            form.ShowDialog();
            dataGridView1.DataSource = model1.Users.ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model1.Users.ToList();
        }
    }
}
