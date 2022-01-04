using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM
{
    class ATMSYSTEM
    {
        public static string AccNum;
        static string sql = @"Data Source=DESKTOP-L21BLDF\SQLEXPRESS;Initial Catalog=ATMDATA;Integrated Security=True";
        SqlConnection sc = new SqlConnection(sql);


        public void insertdata(int accnum, string fname, string lname, int phonenum, string address, string g, string dob, int pin, string e)
        {
            sc.Open();
            string query = $" INSERT INTO atmdata(accountnum, fname , lname , phone , address , gender , dob , pin , email) Values(@accountnum, @fname , @lname , @phone , @address , @gender , @dob , @pin , @email)";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.Parameters.AddWithValue("@accountnum", accnum);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@phone ", phonenum);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", g);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@pin", pin);
            cmd.Parameters.AddWithValue("@email", e);
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Account Created");

        }
        public void login(int acc, int p)
        {

            try
            {

                DataTable dt = new DataTable();
                string query = "SELECT *FROM atmdata WHERE accountnum LIKE " + acc + " AND pin LIKE " + p + "";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    AccNum = acc.ToString() ;
                    Application.OpenForms[0].Hide();
                    home frm = new home();
                    frm.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Check your Accoount Number and PIN");
                }
                sc.Close();



            }
            catch
            {
                MessageBox.Show("Enter Correct information ");
            }

        }
        
        
      
    }
    }

