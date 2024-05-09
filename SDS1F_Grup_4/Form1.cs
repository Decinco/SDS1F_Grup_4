using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLS_Daniel_Mugueta;

namespace SDS1F_Grup_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBBDD Form = new FrmBBDD();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLista Form = new FrmLista();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMantenimiento Form = new FrmMantenimiento();
            Form.Show();
        }
    }
}
