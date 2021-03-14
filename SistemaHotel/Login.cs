using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width /2 -166, this.Height/2 -170 ) ;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21,114,160);
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Mostrar na tela quando alguma tecla for pressionada
            {
                ChamarLogin();
            } //
        }

        private void ChamarLogin()
        {

            if (txtLogin.Text == "")
            {
                MessageBox.Show("Preencha o usuário");
                txtLogin.Focus(); // coloca o mouse no campo 
                return; // retorna para preencher o campo usuario
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo senha");
                txtSenha.Focus();
                return;
            }

            // CODIGO PARA LOGIN

            FrmMenu form = new FrmMenu(); // Chamando a tela Menu
            // this.Hide(); // Irá fechar a tela anterior após abrir a nova
            Limpar();
            form.Show(); // Ira chamar a tela requisitada
        }

        private void Limpar() // Vai limpar os campos de login e senha ao retornar para a tela De login
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtLogin.Focus();
        }
    }
}

