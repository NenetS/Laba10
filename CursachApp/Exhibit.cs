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
    public partial class Exhibit : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Exhibit()
        {
            InitializeComponent();
            LoadExhibit();
        }
        public void LoadExhibit()
        {
            int i = 0;
            dgvExhibit.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Exhibits", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvExhibit.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ExhibitModule exhibitForm = new ExhibitModule();
            exhibitForm.button3.Enabled = true;
            exhibitForm.btnUpd.Enabled = false;
            exhibitForm.ShowDialog();
            LoadExhibit();
        }

        private void dgvExhibit_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvExhibit.Columns[e.ColumnIndex].Name;
            if (colName == "Edit3")
            {
                ExhibitModule exhibitModule = new ExhibitModule();
                exhibitModule.txtIDE.Text = dgvExhibit.Rows[e.RowIndex].Cells[1].Value.ToString();
                exhibitModule.txtNai2.Text = dgvExhibit.Rows[e.RowIndex].Cells[2].Value.ToString();
                exhibitModule.txtPlace.Text = dgvExhibit.Rows[e.RowIndex].Cells[3].Value.ToString();
                exhibitModule.txtDate.Text = dgvExhibit.Rows[e.RowIndex].Cells[4].Value.ToString();
                exhibitModule.txtCol.Text = dgvExhibit.Rows[e.RowIndex].Cells[5].Value.ToString();
                exhibitModule.txtFin.Text = dgvExhibit.Rows[e.RowIndex].Cells[6].Value.ToString();

                exhibitModule.button3.Enabled = false;
                exhibitModule.btnUpd.Enabled = true;
                exhibitModule.ShowDialog();
            }
            else if (colName == "Delete3")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Exhibits WHERE Named LIKE '" + dgvExhibit.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была удалена");
                }
            }
            LoadExhibit();
        }
    }
}
