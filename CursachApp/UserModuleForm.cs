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

namespace CursachApp
{
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Вы действительно хотите вставить новую запись?", "Вставка",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Staff(StaffID,Familia,Imya,Otchestvo,Dolznost,Mail)VALUES(@StaffID,@Familia,@Imya,@Otchestvo,@Dolznost,@Mail)", con);
                    cm.Parameters.AddWithValue("@StaffID", txtID.Text);
                    cm.Parameters.AddWithValue("@Familia", txtImya.Text);
                    cm.Parameters.AddWithValue("@Imya", txtFam.Text);
                    cm.Parameters.AddWithValue("@Otchestvo", txtOtc.Text);
                    cm.Parameters.AddWithValue("@Dolznost", txtDol.Text);
                    cm.Parameters.AddWithValue("@Mail", txtMal.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была сохранена!");
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            button3.Enabled = true;
            btnUpd.Enabled = false;

        }
        public void Clear()
        {
            txtImya.Clear();
            txtFam.Clear();
            txtOtc.Clear();
            txtDol.Clear();
            txtMal.Clear();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Staff SET StaffID=@StaffID, Familia=@Familia, Imya=@Imya, Otchestvo=@Otchestvo, Dolznost=@Dolznost, Mail=@Mail WHERE Familia LIKE '"+ txtFam.Text + "' ", con);
                    cm.Parameters.AddWithValue("@StaffID", txtID.Text);
                    cm.Parameters.AddWithValue("@Imya", txtFam.Text);
                    cm.Parameters.AddWithValue("@Otchestvo", txtOtc.Text);
                    cm.Parameters.AddWithValue("@Dolznost", txtDol.Text);
                    cm.Parameters.AddWithValue("@Mail", txtMal.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была изменена!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
