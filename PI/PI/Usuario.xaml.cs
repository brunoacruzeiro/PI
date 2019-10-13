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
    /// Lógica interna para Usuario.xaml
    /// </summary>
    public partial class Usuario : Window
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, RoutedEventArgs e)
        {
            USUARIO a = new USUARIO();
            a.ENDERECO = txtEndereco.Text;
            a.NASCIMENTO = DateTime.Now;
            a.NOME = txtNome.Text;
            a.SEXO = txtSexo.Text;
            a.TELEFONE = txtTelefone.Text;
            using (PIEntities ctx = new PIEntities())
            {
                ctx.USUARIOs.Add(a);
                ctx.SaveChanges();

            }
            this.ListarContatos();
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            using (PIEntities ctx = new PIEntities())
            {
                USUARIO a = ctx.USUARIOs.Find(Convert.ToInt32(txtId.Text));
                if (a != null)
                {
                    ctx.USUARIOs.Remove(a);
                    ctx.SaveChanges();
                }
                this.ListarContatos();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ListarContatos();
        }

        private void ListarContatos()
        {
            using (PIEntities ctx = new PIEntities())
            {
                var consulta = ctx.USUARIOs;
                dgDados.ItemsSource = consulta.ToList();
            }
        }
    }
}
