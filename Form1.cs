using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web.Script.Serialization;

namespace Parcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else {
                pE.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltProduct altProduct = new AltProduct();
            Service makelogin = new Service();
            ParamsLogin param = new ParamsLogin(textBox1.Text, int.Parse(textBox2.Text));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(param);

            string resultados = makelogin.callService(body);

            var log = ser.Deserialize<List<resultLogin>>(resultados);

            int txtpass = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar ambos campos");
            }else
            if (log.Count == 0)
            {
                MessageBox.Show("Datos de usuario incorrectos");
            }
            else {
                MessageBox.Show("Welcome");
                altProduct.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service makelogin = new Service();
            insertUser param = new insertUser(textBox3.Text, textBox4.Text, textBox1.Text, int.Parse(textBox2.Text));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(param);

            string resultados = makelogin.callService(body);

            var log = ser.Deserialize<List<resultInsert>>(resultados);

            //int txtpass = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "" || textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }else
            {
                MessageBox.Show("Registrado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            AltProduct altProduct = new AltProduct();
            Service makelogin = new Service();
            ParamsLogin param = new ParamsLogin(textBox1.Text, int.Parse(textBox2.Text));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(param);

            string resultados = makelogin.callService(body);

            var log = ser.Deserialize<List<resultLogin>>(resultados);

            int txtpass = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar ambos campos");
            }else
            if (log.Count == 0)
            {
                MessageBox.Show("Datos de usuario incorrectos");
            }
            else
            {
                MessageBox.Show("Welcome");
                altProduct.Show();
            }
        }
    }
}
