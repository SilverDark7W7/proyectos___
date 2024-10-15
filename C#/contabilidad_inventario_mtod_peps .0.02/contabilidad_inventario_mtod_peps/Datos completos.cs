using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contabilidad_inventario_mtod_peps
{
    public partial class Datos_completos : Form
    {
        public Datos_completos()
        {
            InitializeComponent();
        }
        mostrar_tablas mostrar = new mostrar_tablas();

        private void btn_actua_Click(object sender, EventArgs e)
        {
            dataTodosDatos.DataSource = mostrar.datos1();
        }

        private void Datos_completos_Load(object sender, EventArgs e)
        {
            dataTodosDatos.DataSource = mostrar.datos1();
        }

        private void dataTodosDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
