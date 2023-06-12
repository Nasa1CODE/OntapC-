using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string sqlconnect = @"server=MANHLV\SQLEXPRESS10;database=LabWinform; uid=sa; pwd=12345678";
        SqlDataAdapter da;
        DataSet ds;
        BindingManagerBase bmb;



        private void BindingCategory()
        {
            da = new SqlDataAdapter("select * from Catalog", sqlconnect);
            new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            txtTitle.DataBindings.Add("Text", ds.Tables[0], "Title");
            txtArtist.DataBindings.Add("Text", ds.Tables[0], "Artist");
            txtCountry.DataBindings.Add("Text", ds.Tables[0], "Country");
            txtCompany.DataBindings.Add("Text", ds.Tables[0], "Company");
            txtPrice.DataBindings.Add("Text", ds.Tables[0], "Price");
            txtRelease.DataBindings.Add("Text", ds.Tables[0], "YearRelease");
            dgvCatalog.DataSource = ds.Tables[0];

            bmb = BindingContext[ds.Tables[0]];
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            BindingCategory();
        }


        private void btnAdd_click(object sender, EventArgs e)
        {
            bmb.AddNew();
            txtTitle.Focus();
        }


        private void btnSave_click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            da.Update(ds);
            ds.AcceptChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?", "xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                da.Update(ds);
                ds.AcceptChanges();
            }
        }
    }
}
