using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadPadoca
{
    public partial class MenuPrincipal : Form
    {
        //  Variaveis Globais: no caso esta instanciando a Usuario para pode usar os metodos/Variaveis da Usuario
        Model.Usuario usuario = new Model.Usuario();
        
        // Model.Usuario usuario = assinatura como se voce estivesse avisando que vai ser usado a variavel
        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblAdm.Text = $"Olá {usuario.NomeCompleto}! Escolha uma opção abaixo:";
        }
    }
}
