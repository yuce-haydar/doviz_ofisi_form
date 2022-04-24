using System.Xml;
namespace doviz_ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblusdal.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblusdsat.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroal.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosat.Text = euroalis;

            string saralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/BanknoteBuying").InnerXml;
            lblsaral.Text = saralis;

            string sarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/BanknoteSelling").InnerXml;
            lblsarsat.Text = saralis;






        }

        private void btnusdal_Click(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
            textBox4.Text =lblusdal.Text ;

        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            textBox4.Text = lbleuroal.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblusdsat.Text;
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosat.Text;

        }

        private void btnsaral_Click(object sender, EventArgs e)
        {
            textBox4.Text=lblsaral.Text;

        }

        private void brnsarsat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblsarsat.Text;
        }
        int kasausd, kasatl, kasaero, kasasar=500000;
        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur= Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmktr.Text);
            tutar = miktar * kur;
            txttutar.Text=tutar.ToString();

            if (txtkur.Text.Replace(",",".")==lblusdsat.Text)
            {
                double kasatl = Convert.ToDouble(lblkasatl.Text) - Convert.ToDouble( tutar);
                lblkasatl.Text=kasatl.ToString();

                double kasausd = Convert.ToDouble(lblkasausd.Text) + Convert.ToDouble(miktar);
                lblkasausd.Text = kasausd.ToString();
            }
             if (txtkur.Text.Replace(",", ".") == lblsarsat.Text)
            {
                double kasatl = Convert.ToDouble(lblkasatl.Text) - Convert.ToDouble(tutar);
                lblkasatl.Text = kasatl.ToString();

                double kasasar = Convert.ToDouble(lblkasasar.Text) + Convert.ToDouble(miktar);
                lblkasasar.Text = kasasar.ToString();
            }
            if (txtkur.Text.Replace(",", ".") == lbleurosat.Text)
            {
                double kasatl = Convert.ToDouble(lblkasatl.Text) - Convert.ToDouble(tutar);
                lblkasatl.Text = kasatl.ToString();

                double kasaero = Convert.ToDouble(lblkasaero.Text) + Convert.ToDouble(miktar);
                lblkasaero.Text = kasaero.ToString();
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.Replace(".", ",");
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text=txtkur.Text.Replace(".",",");
        }

        private void btnalýsyp_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(textBox4.Text);
            int miktar= Convert.ToInt32(textBox3.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            textBox2.Text=tutar.ToString();

            double kalan;
            kalan = miktar % kur;
            textBox1.Text=kalan.ToString();
            //müþteri geldi dolar aldý tl artacak dolar azacak
            if (textBox4.Text.Replace(",", ".") == lblusdal.Text)
            {
                double kasatl = Convert.ToDouble(lblkasatl.Text) + Convert.ToDouble(tutar)+Convert.ToDouble(textBox1.Text);
                lblkasatl.Text = kasatl.ToString();

                double kasausd = Convert.ToDouble(lblkasausd.Text) - Convert.ToDouble(miktar);
                lblkasausd.Text = kasausd.ToString();
            }
            if (textBox4.Text.Replace(",", ".") == lbleuroal.Text)
            {
                double kasatl = Convert.ToDouble(lblkasatl.Text) + Convert.ToDouble(tutar) + Convert.ToDouble(textBox1.Text);
                lblkasatl.Text = kasatl.ToString();

                double kasaero = Convert.ToDouble(lblkasaero.Text) - Convert.ToDouble(miktar);
                lblkasaero.Text = kasaero.ToString();
            }
            if (textBox4.Text.Replace(",", ".") == lblsaral.Text)
            {
                double kasatl = Convert.ToDouble(lblkasatl.Text) + Convert.ToDouble(tutar) + Convert.ToDouble(textBox1.Text);
                lblkasatl.Text = kasatl.ToString();

                double kasasar = Convert.ToDouble(lblkasasar.Text) - Convert.ToDouble(miktar);
                lblkasasar.Text = kasasar.ToString();
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}