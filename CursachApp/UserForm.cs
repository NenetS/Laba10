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

namespace CursachApp
{
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }
        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Staff",con);
            con.Open();
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.button3.Enabled = true;
            userModule.btnUpd.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName=="Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtID.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtImya.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtFam.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtOtc.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.txtDol.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.txtMal.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();

                userModule.button3.Enabled = false;
                userModule.btnUpd.Enabled = true;
                userModule.txtFam.Enabled = false;
                userModule.ShowDialog();
            }
            else if(colName=="Delete")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись", "Удалить",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cm=new SqlCommand("DELETE FROM Staff WHERE Mail Familia '"+ dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString() +"'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была удалена");
                }
            }
        }
    }
}
