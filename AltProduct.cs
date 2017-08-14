using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Parcel
{
    public partial class AltProduct : Form
    {
       
        public AltProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service altproduct = new Service();
            insertProduct param = new insertProduct(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox4.Text), textBox3.Text);
            JavaScriptSerializer ser = new JavaScriptSerializer();

            string body = ser.Serialize(param);

            string resultados = altproduct.callService(body);

            var log = ser.Deserialize<List<resultInsertProduc>>(resultados);

            //int txtpass = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                MessageBox.Show("Producto Registrado");
            }
        }
    }
}
