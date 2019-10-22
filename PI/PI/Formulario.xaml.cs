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

namespace PI
{
    /// <summary>
    /// Lógica interna para Formulario.xaml
    /// </summary>
    public partial class Formulario : Window
    {
        public Formulario()
        {
            InitializeComponent();
        }

        public string StartupUri { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartupUri = "Formulariop2.xaml";
        }
    }
}
