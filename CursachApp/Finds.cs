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
    public partial class Finds : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Finds()
        {
            InitializeComponent();
            LoadFind();
        }
        public void LoadFind()
        {
            int i = 0;
            dgvFinds.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Finds", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvFinds.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FindsModule moduleForm = new FindsModule();
            moduleForm.button3.Enabled = true;
            moduleForm.btnUpd.Enabled = false;
            moduleForm.ShowDialog();
            LoadFind();
        }

        private void dgvFinds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvFinds.Columns[e.ColumnIndex].Name;
            if (colName == "Edit2")
            {
                FindsModule findsModule = new FindsModule();
                findsModule.txtIDF.Text = dgvFinds.Rows[e.RowIndex].Cells[1].Value.ToString();
                findsModule.txtNai.Text = dgvFinds.Rows[e.RowIndex].Cells[2].Value.ToString();
                findsModule.txtKol.Text = dgvFinds.Rows[e.RowIndex].Cells[3].Value.ToString();
                findsModule.txtDes.Text = dgvFinds.Rows[e.RowIndex].Cells[4].Value.ToString();
                findsModule.txtInv.Text = dgvFinds.Rows[e.RowIndex].Cells[5].Value.ToString();
                findsModule.txtGod.Text = dgvFinds.Rows[e.RowIndex].Cells[6].Value.ToString();
                findsModule.txtRas.Text = dgvFinds.Rows[e.RowIndex].Cells[7].Value.ToString();
                findsModule.txtEks.Text = dgvFinds.Rows[e.RowIndex].Cells[8].Value.ToString();

                findsModule.button3.Enabled = false;
                findsModule.btnUpd.Enabled = true;
                findsModule.ShowDialog();
            }
            else if (colName == "Delete2")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Finds WHERE Naimenovanie LIKE '" + dgvFinds.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была удалена");
                }
            }
            LoadFind();
        }
    }
}
