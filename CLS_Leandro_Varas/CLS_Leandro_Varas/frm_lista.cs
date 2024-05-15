using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLS_Leandro_Varas
{
    public partial class frm_lista : Form
    {
        public frm_lista()
        {
            InitializeComponent();
        }

        private void frm_lista_Load(object sender, EventArgs e)
        {
            //F1CR gp_info = new F1CR();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CLS_Leandro_Varas.frm_mantenimiento form = new frm_mantenimiento();
            form.Show();
        }
    }
}
