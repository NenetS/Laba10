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
    public partial class ExhibitModule : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public ExhibitModule()
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
                if (MessageBox.Show("Вы действительно хотите вставить новую запись?", "Вставка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Exhibits(ID_Exhibit,Named,PlaceExposure,DateExposure,CollectionsID,FindsID)VALUES(@ID_Exhibit,@Named,@PlaceExposure,@DateExposure,@CollectionsID,@FindsID)", con);
                    cm.Parameters.AddWithValue("@ID_Exhibit", txtIDE.Text);
                    cm.Parameters.AddWithValue("@Named", txtNai2.Text);
                    cm.Parameters.AddWithValue("@PlaceExposure", txtPlace.Text);
                    cm.Parameters.AddWithValue("@DateExposure", txtDate.Text);
                    cm.Parameters.AddWithValue("@CollectionsID", txtCol.Text);
                    cm.Parameters.AddWithValue("@FindsID", txtFin.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была сохранена!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
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
            txtIDE.Clear();
            txtNai2.Clear();
            txtPlace.Clear();
            txtCol.Clear();
            txtFin.Clear();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Exhibit SET ID_Exhibit=@ID_Exhibit, Named=@Named, PlaceExposure=@PlaceExposure, DateExposure=@DateExposure, CollectionsID=@CollectionsID, FindsID=@FindsID WHERE ID_Exhibit LIKE '" + txtIDE.Text + "' ", con);
                    cm.Parameters.AddWithValue("@ID_Exhibit", txtIDE.Text);
                    cm.Parameters.AddWithValue("@Named", txtNai2.Text);
                    cm.Parameters.AddWithValue("@PlaceExposure", txtPlace.Text);
                    cm.Parameters.AddWithValue("@DateExposure", txtDate.Text);
                    cm.Parameters.AddWithValue("@CollectionsID", txtCol.Text);
                    cm.Parameters.AddWithValue("@FindsID", txtFin.Text);
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
