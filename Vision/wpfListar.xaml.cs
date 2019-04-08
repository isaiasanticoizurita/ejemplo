using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace Vision
{
    /// <summary>
    /// Lógica de interacción para wpfListar.xaml
    /// </summary>
    public partial class wpfListar : MetroWindow
    {
        MainWindow ma; //recibimos a MinWindow

        public wpfListar() //metodo constructor de la ventana que se inicio cunado pones NEW __();
         {
            InitializeComponent();
        }//llamado del menú normal

        public wpfListar(MainWindow mw)
        {
            InitializeComponent();
            ma = mw;
        }// llamado desde una ventana auxiliar


        //BOTON PASAR
        private void btnPasar_Click(object sender, RoutedEventArgs e)
        {
            ma.txtRut.Text="11111111";
            ma.txtNombre.Text = "Juan Carlos";
            ma.txtApellido.Text = "Bodoque";
        }
    }
}
