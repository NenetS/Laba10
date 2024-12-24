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
    public partial class ExcavationsModule : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public ExcavationsModule()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                    cm = new SqlCommand("INSERT INTO Excavations(ID_Excavations,Place,StartDate,EndDate,Involved)VALUES(@ID_Excavations,@Place,@StartDate,@EndDate,@Involved)", con);
                    cm.Parameters.AddWithValue("@ID_Excavations", txtIDC.Text);
                    cm.Parameters.AddWithValue("@Place", txtStart.Text);
                    cm.Parameters.AddWithValue("@StartDate", txtPL.Text);
                    cm.Parameters.AddWithValue("@EndDate", txtEnd.Text);
                    cm.Parameters.AddWithValue("@Involved", txtInvolved.Text);
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
            txtPL.Clear();
            txtStart.Clear();
            txtEnd.Clear();
            txtInvolved.Clear();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Excavations SET ID_Excavations=@ID_Excavations, Place=@Place, StartDate=@StartDate, EndDate=@EndDate, Involved=@Involved WHERE Place LIKE '" + txtPL.Text + "' ", con);
                    cm.Parameters.AddWithValue("@ID_Excavations", txtIDC.Text);
                    cm.Parameters.AddWithValue("@Place", txtPL.Text);
                    cm.Parameters.AddWithValue("@StartDate", txtStart.Text);
                    cm.Parameters.AddWithValue("@EndDate", txtEnd.Text);
                    cm.Parameters.AddWithValue("@Involved", txtInvolved.Text);
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
