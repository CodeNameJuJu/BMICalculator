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
using System.Configuration;

namespace BMICalc
{

    public partial class Form1 : Form
    {

        string status;

        SqlCommand cmd;
        SqlDataReader dr;

        private static string myConnString = ConfigurationManager.ConnectionStrings["ConStrng"].ConnectionString;
        SqlConnection cn = new SqlConnection(myConnString);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (HeightTxt.Text.Contains(","))
                {
                    HeightTxt.Text = HeightTxt.Text.Replace(",", ".");
                }

                if (WeightTxt.Text.Contains(","))
                {
                    WeightTxt.Text = WeightTxt.Text.Replace(",", ".");
                }

                cmd = new SqlCommand("Select * From [dbo].[PatientInfo] Where [PatientID]='" + IdTxt.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {

                    dr.Close();

                    cmd = new SqlCommand("INSERT INTO [dbo].[PatientInfo] VALUES(@PatientID, @PatientHeight, @PatientWeight, @PatientStatus)", cn);
                    cmd.Parameters.AddWithValue("@PatientID", IdTxt.Text);
                    cmd.Parameters.AddWithValue("@PatientHeight", Math.Round(float.Parse(HeightTxt.Text), 2));
                    cmd.Parameters.AddWithValue("@PatientWeight", float.Parse(WeightTxt.Text));


                    string h = HeightTxt.Text;
                    string w = WeightTxt.Text;
                    float height = float.Parse(h);
                    float weight = float.Parse(w);
                    float BMI = weight / (height * height);


                    if (BMI < 18.5)
                    {

                        status = "underweight";
                        MessageBox.Show("Your BMI is: " + BMI + "\nYou are " + status + ".", "BMI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (BMI <= 24.9 && BMI >= 18.5)
                    {

                        status = "normal";
                        MessageBox.Show("Your BMI is: " + BMI + "\nYou are " + status + ".", "BMI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {

                        status = "Overweight";
                        MessageBox.Show("Your BMI is: " + BMI + "\nYou are " + status + ".", "BMI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (BMI > 30)
                    {

                        status = "Obese";
                        MessageBox.Show("Your BMI is: " + BMI + "\nYou are " + status + ".", "BMI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    cmd.Parameters.AddWithValue("@PatientStatus", status);

                    cmd.ExecuteNonQuery();
                }

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

            

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IdTxt.Clear();
            HeightTxt.Clear();
            WeightTxt.Clear();
        }

        private void IdTxt_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (IdTxt.Text.Length != 13)
                {
                    errorProvider.SetError(IdTxt, "Patient ID must be 13 digits.");

                }
                else
                {
                    errorProvider.Clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void HeightTxt_Validating(object sender, CancelEventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(HeightTxt.Text))
                {
                    errorProvider.SetError(HeightTxt, "Height can not be left blank.");
                }
                else
                {
                    errorProvider.Clear();
                }

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }

        private void WeightTxt_Validating(object sender, CancelEventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(WeightTxt.Text))
                {
                    errorProvider.SetError(WeightTxt, "Weight can not be left blank.");
                }
                else
                {
                    errorProvider.Clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Srchbtn_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStrng"].ConnectionString);

                cn.Open();
                bool temp = false;

                cmd = new SqlCommand("SELECT PatientHeight, PatientWeight FROM [dbo].[PatientInfo] WHERE PatientID=@PatientID", cn);
                cmd.Parameters.AddWithValue("@PatientID", Int64.Parse(IdTxt.Text));
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    HeightTxt.Text = dr["PatientHeight"].ToString();
                    WeightTxt.Text = dr["PatientWeight"].ToString();
                    temp = true;
                }

                if (temp == false)
                {
                    MessageBox.Show("ID not found", "404 Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cn.Close();
                }
            } 
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }
    }
}
