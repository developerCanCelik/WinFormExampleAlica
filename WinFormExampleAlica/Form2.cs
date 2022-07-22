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

namespace WinFormExampleAlica
{
    public partial class Form2 : Form
    {
        public string admin;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_admin.Text = admin;
            GetData();
        }
        public void GetData()
        {
            con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=Northwind; Integrated Security=True");
            da = new SqlDataAdapter("Select *From Customers", con);

            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Customers");

            data_grid_view.DataSource = ds.Tables["Customers"];
            con.Close();

        }
    }
}
