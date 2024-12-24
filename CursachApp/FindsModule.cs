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
    public partial class FindsModule : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QCNPU58\\SQLEXPRESS;Initial Catalog=Cursach;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public FindsModule()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите вставить новую запись?", "Вставка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Finds(ID_Finds,Naimenovanie,Quantity,Description,InventoryNumber,Year,ExcavationsID,ExhibitID)VALUES(@ID_Finds,@Naimenovanie,@Quantity,@Description,@InventoryNumber,@Year,@ExcavationsID,@ExhibitID)", con);
                    cm.Parameters.AddWithValue("@ID_Finds", txtIDF.Text);
                    cm.Parameters.AddWithValue("@Naimenovanie", txtNai.Text);
                    cm.Parameters.AddWithValue("@Quantity", txtKol.Text);
                    cm.Parameters.AddWithValue("@Description", txtDes.Text);
                    cm.Parameters.AddWithValue("@InventoryNumber", txtInv.Text);
                    cm.Parameters.AddWithValue("@Year", txtGod.Text);
                    cm.Parameters.AddWithValue("@ExcavationsID", txtRas.Text);
                    cm.Parameters.AddWithValue("@ExhibitID", txtEks.Text);
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

        public void Clear()
            {
            txtIDF.Clear();
            txtNai.Clear();
            txtKol.Clear();
            txtDes.Clear();
            txtInv.Clear();
            txtGod.Clear();
            txtRas.Clear();
            txtEks.Clear();
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            button3.Enabled = true;
            btnUpd.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Finds SET ID_Finds=@ID_Finds, Naimenovanie=@Naimenovanie, Quantity=@Quantity, Description=@Description, InventoryNumber=@InventoryNumber, Year=@Year, ExcavationsID=@ExcavationsID, ExhibitID=@ExhibitID WHERE ID_Finds LIKE '" + txtIDF.Text + "' ", con);
                    cm.Parameters.AddWithValue("@ID_Finds", txtIDF.Text);
                    cm.Parameters.AddWithValue("@Naimenovanie", txtNai.Text);
                    cm.Parameters.AddWithValue("@Quantity", txtKol.Text);
                    cm.Parameters.AddWithValue("@Description", txtDes.Text);
                    cm.Parameters.AddWithValue("@InventoryNumber", txtInv.Text);
                    cm.Parameters.AddWithValue("@Year", txtGod.Text);
                    cm.Parameters.AddWithValue("@ExcavationsID", txtRas.Text);
                    cm.Parameters.AddWithValue("@ExhibitID", txtEks.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была изменена!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}