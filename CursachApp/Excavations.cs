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
    public partial class Excavations : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Excavations()
        {
            InitializeComponent();
            LoadExca();
        }
        public void LoadExca()
        {
            int i = 0;
            dgvExcav.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Excavations", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvExcav.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvExcav_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvExcav.Columns[e.ColumnIndex].Name;
            if (colName == "Edit4")
            {
                ExcavationsModule excavationsModule = new ExcavationsModule();
                excavationsModule.txtIDC.Text = dgvExcav.Rows[e.RowIndex].Cells[1].Value.ToString();
                excavationsModule.txtPL.Text = dgvExcav.Rows[e.RowIndex].Cells[2].Value.ToString();
                excavationsModule.txtStart.Text = dgvExcav.Rows[e.RowIndex].Cells[3].Value.ToString();
                excavationsModule.txtEnd.Text = dgvExcav.Rows[e.RowIndex].Cells[4].Value.ToString();
                excavationsModule.txtInvolved.Text = dgvExcav.Rows[e.RowIndex].Cells[5].Value.ToString();

                excavationsModule.button3.Enabled = false;
                excavationsModule.btnUpd.Enabled = true;
                excavationsModule.ShowDialog();
            }
            else if (colName == "Delete4")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Excavations WHERE Place LIKE '" + dgvExcav.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была удалена");
                }
            }
            LoadExca();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExcavationsModule moduleForm = new ExcavationsModule();
            moduleForm.button3.Enabled = true;
            moduleForm.btnUpd.Enabled = false;
            moduleForm.ShowDialog();
            LoadExca();
        }
    }
}
