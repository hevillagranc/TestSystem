using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Inventario.Logica
{
    public class Conexion
    {
        SqlConnection cnn;

        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source =VILLAGRANES\\SQLEXPRESS; initial catalog= Inventario ;user =sa ;password= andres80");
                cnn.Open();
                MessageBox.Show("Conexion exitosa","Sistema inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error de conexion", "Sistema Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

       

        }
        
        

    }
}
