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
namespace doviz_ofisi
{
    public partial class kullanicigiris : Form
    {
        public kullanicigiris()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1(); 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "haydar" && textBox2.Text == "123456")
            {
                this.Hide();
                frm1.Show();
            }
            else 
            {
                MessageBox.Show("parola ya da kullanici adi hatali ");
            }
        }

        private void kullanicigiris_Load(object sender, EventArgs e)
        {

        }
    }
}
