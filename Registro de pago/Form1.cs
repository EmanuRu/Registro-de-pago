using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_pago
{
    public partial class Form1 : Form
    {
        String Nombre;
        int Monto;
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarEfectivo() {//este metodo toma el nombre y precio ingresado, a este ultimo le
                                      //realiza un descuento de 10%
            if (!tbNombre.Text.Equals("") && !tbMonto.Text.Equals(""))
            {//corroboro que los textbox no esten vacios
                Nombre = tbNombre.Text;//guardo el nombre
                int valorIngresado = int.Parse(tbMonto.Text);//convierte el textbo a entero
                int descuento = (valorIngresado * 10) / 100;//guardo lo que se va a descontar
                Monto = valorIngresado - descuento;//hago el descuento
                String total = "Total: " + Monto.ToString();//convierto todo a un String
                lblTotal.Text = total;//lo muestro en la label
            }
        }

        public void CargarTarjeta() {
            if (!tbNombre.Text.Equals("") && !tbMonto.Text.Equals(""))
            {//corroboro que los textbox no esten vacios
                Nombre = tbNombre.Text;//guardo el nombre
                Monto = int.Parse(tbMonto.Text);//convierte el textbox a entero
                String total = "Total: " + Monto.ToString();//convierto todo a un String
                lblTotal.Text = total;//lo muestro en la label
            }
        }

        public void Agregar() {
            if (!tbNombre.Text.Equals("")&&!tbMonto.Text.Equals(""))
            { //corroboro que los textbox no esten vacios
                lblPagos.Text += Nombre+"  "+Monto+ "\n";//guardo el nombre y pago en un label que hace de lista
                tbNombre.Text = "";//limpio los demas elementos
                tbMonto.Text = "";
                lblTotal.Text = "Total:";
                Nombre = "";
                Monto = 0;
            }
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            CargarEfectivo();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            CargarTarjeta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}
