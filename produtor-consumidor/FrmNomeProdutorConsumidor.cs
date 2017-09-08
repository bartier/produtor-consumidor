using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produtor_consumidor
{
    public partial class FrmNomeProdutorConsumidor : Form
    {
        private string entidade;

        public FrmNomeProdutorConsumidor(string entidade)
        {
            InitializeComponent();
            this.Text = "Digite o nome do(a) " + entidade;
            lblEntidade.Text = entidade + ":";
        }

        public string Entidade { get => entidade; }

        public string NomeDaEntidade
        {
            get
            {
                return txtBoxNomeEntidade.Text;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxNomeEntidade.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Nome inválido!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
