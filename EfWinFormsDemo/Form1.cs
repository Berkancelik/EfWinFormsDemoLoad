using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfWinFormsDemo
{
    public partial class Form1 : Form
    {
        WinFormsDBEntities dbEntities = new WinFormsDBEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dbEntities.tblDetails.ToList();
        }

        public  void LoadData()
        {
            dataGridView1.DataSource =  dbEntities.tblDetails.ToList();
        }

        //public async void LoadData()
        //{
        //    dataGridView1.DataSource = await dbEntities.tblDetails.ToListAsync();
        //}

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
            tblDetails details  = new tblDetails();
            details.Name = txtUname.Text;
            details.City = txtCity.Text;
            dbEntities.tblDetails.Add(details);
            dbEntities.SaveChanges();
            MessageBox.Show("Data inserted");
            LoadData();
            Reset();
        }

        public void Reset()
        {
            txtCity.Text = "";
            txtUname.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
