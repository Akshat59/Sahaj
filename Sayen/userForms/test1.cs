using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sahaj.userForms
{
    public partial class test1 : Form
    {
        int counter = 0;
        public test1()
        {
            InitializeComponent();
            counter = counter+1;

        }

        private void test1_Load(object sender, EventArgs e)
        {
            string username = string.Empty;
            //string username = calldatabase()
            if (username.Length>0)
                {

                label1.Text = "Welcome username";
            }

        }

        private void test1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qq = textBox1.Text;

            if (qq == string.Empty)
            {
                MessageBox.Show("enter some value");
            }

            else

            {
                submittodatabase(qq);

            }
        }

        private void submittodatabase(string qq)
        {
            try
            {
                int _ret;
                akshat();
                string sqlQuery = "Insert into d1_app_info(app_owner) values ('" + qq.ToString()+"')";
                string conStrng = @"Server=localhost\SQLExpress; Database=d1_dev; Integrated Security=SSPI;"; //providerName = "System.Data.SqlClient";
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    SqlCommand oCmd = new SqlCommand(sqlQuery, myConnection);
                    oCmd.CommandType = CommandType.Text;                   

                    myConnection.Open();

                    _ret = oCmd.ExecuteNonQuery();
                }

                print("1");

            }
            catch (Exception Ex)
            {

            }
        }


        void print(int a)
        {

        }



        void print(string a)
        {

        }

        private void akshat()
        {
            //throw new NotImplementedException();
        }
    }
}
