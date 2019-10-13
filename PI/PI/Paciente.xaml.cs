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
    /// Lógica interna para Paciente.xaml
    /// </summary>
    public partial class Paciente : Window
    {
        private string operacao;
        public Paciente()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, RoutedEventArgs e)
        {
            PACIENTE a = new PACIENTE();
            a.EMDERECO = txtEndereco.Text;
            a.ESCOLARIDADE = txtEscolaridade.Text;
            a.ESTADO_CIVIL = txtCivil.Text;
            a.FILHOS = txtFilho.Text;
            a.LOCOMOCAO = txtLocomocao.Text;
            a.NASCIMENTO = DateTime.Now;
            a.NOME = txtNome.Text;
            a.PROFISSAO = txtProfissao.Text;
            a.RELIGIAO = txtReligiao.Text;
            a.RENDA_FAMILIAR = txtRenda.Text;
            a.SEXO = txtSexo.Text;
            a.TELEFONE = txtTelefone.Text;
            using (PIEntities ctx = new PIEntities())
            {
                ctx.PACIENTEs.Add(a);
                ctx.SaveChanges();

            }
            this.ListarContatos();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ListarContatos();
        }

        private void ListarContatos()
        {
            using (PIEntities ctx = new PIEntities())
            {
                var consulta = ctx.PACIENTEs;
                dgDados.ItemsSource = consulta.ToList();
            }
        }

        private void btExlcuir_Click(object sender, RoutedEventArgs e)
        {
            using (PIEntities ctx = new PIEntities())
            {

                PACIENTE a = ctx.PACIENTEs.Find(Convert.ToInt32(txtID.Text));
                if (a != null)
                {
                    ctx.PACIENTEs.Remove(a);
                    ctx.SaveChanges();
                }
                this.ListarContatos();
            }
        }
    }
}
