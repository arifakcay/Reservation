using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Reservation2
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = ConnectDB.SqlDataAdapter();
            dataGridView1.DataSource = dt;
            
        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.firstname = txtfirstName.Text;
            customer.lastname = txtlastName.Text;
            customer.roomid = Convert.ToInt32(txtroomID.Text);
            ConnectDB.Addcustomer(customer);
        }

        private void FilterBox_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.firstname = txtfirstName.Text;
            customer.lastname = txtlastName.Text;
            customer.roomid = Convert.ToInt32(txtroomID.Text);

            dt = ConnectDB.FilterfromDatabase(customer);
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                idBox.Text = e.Row.Cells["customerid"].Value.ToString();
                txtfirstName.Text = e.Row.Cells["firstname"].Value.ToString();
                txtlastName.Text = e.Row.Cells["lastname"].Value.ToString();
                txtroomID.Text = e.Row.Cells["roomid"].Value.ToString();    
                    
             }
        }

        private void UpdateBox_Click(object sender, EventArgs e)
        {
            ConnectDB.Updatecustomer(dt);
        }

        private void TxtupdateBox_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.customerid = Convert.ToInt32(idBox.Text);
            customer.firstname = txtfirstName.Text;
            customer.lastname = txtlastName.Text;
            customer.roomid = Convert.ToInt32(txtroomID.Text);

            ConnectDB.AddUpdate(customer);
        }

        private void DeleteBox_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.customerid = Convert.ToInt32(idBox.Text);
            ConnectDB.Delete(customer);
        }

        private void SelectBox_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
