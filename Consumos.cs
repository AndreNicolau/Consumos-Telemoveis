using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Consumos_Telemóveis
{
    public partial class Consumos : Form
    {
        int idTelemovel;
        int idConsumo;
        int limiteConsumoMinutos = Telemoveis.LimiteMinutos;
        int limiteConsumoDadosMoveis = Telemoveis.LimiteDadosMoveis;
        string nome;
        string email;
        string numeroTelemovel;
        string mes;
        string consumosMinutos;
        string dadosMoveis;

        public Consumos()
        {
            InitializeComponent();
        }

        private void Consumos_Load(object sender, EventArgs e)
        {
            txtIdTelemovel.Text = Telemoveis.IdTelemovel;
            txtNome.Text = Telemoveis.Nome;
            txtNumero.Text = Telemoveis.NumeroTelemovel;
            txtEmail.Text = Telemoveis.Email;
            cbMes.Text = Telemoveis.Mes;
            txtLimiteConsumoMinutos.Text = limiteConsumoMinutos.ToString();
            txtLimiteConsumoDadosMoveis.Text = limiteConsumoDadosMoveis.ToString();

            this.consumosTableAdapter.FillByIdTelemovel(this.dbConsumosTelemoveisDataSet.consumos, Int32.Parse(txtIdTelemovel.Text));
            consumosTableAdapter.GetDataByIdTelemovel(Int32.Parse(txtIdTelemovel.Text));

            dataGridView1.CurrentCellChanged += dataGridView1_SelectionChanged;
        }

        private void Editar(bool modoEdicao)
        {
            if (modoEdicao)
            {
                tsbEditar.Enabled = false;
                tsbNovo.Enabled = false;

                tsbSalvar.Enabled = true;
                tsbEliminar.Enabled = true;
                tsbCancelar.Enabled = true;

                cbMes.Enabled = true;

                txtConsumoMinutos.ReadOnly = false;
                txtConsumoDadosMoveis.ReadOnly = false;
            }
            else
            {
                tsbEditar.Enabled = true;
                tsbNovo.Enabled = true;

                tsbSalvar.Enabled = false;
                tsbEliminar.Enabled = false;
                tsbCancelar.Enabled = false;

                cbMes.Enabled = false;

                txtConsumoMinutos.ReadOnly = true;
                txtConsumoDadosMoveis.ReadOnly = true;
            }
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            idTelemovel = Int32.Parse(txtIdTelemovel.Text);
            nome = txtNome.Text;
            email = txtEmail.Text;
            numeroTelemovel = txtNumero.Text;
            mes = cbMes.Text;
            consumosMinutos = txtConsumoMinutos.Text;
            dadosMoveis = txtConsumoDadosMoveis.Text;



            consumosTableAdapter.InserirConsumo(idTelemovel, nome, email, numeroTelemovel, mes, "0", "0");
            dataGridView1.DataSource = consumosTableAdapter.GetDataByIdTelemovel(idTelemovel);
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            Editar(true);
            cbMes.Focus();


        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            idConsumo = Int32.Parse(txtIdConsumo.Text);
            idTelemovel = Int32.Parse(txtIdTelemovel.Text);
            nome = txtNome.Text;
            email = txtEmail.Text;
            numeroTelemovel = txtNumero.Text;
            mes = cbMes.Text;
            consumosMinutos = txtConsumoMinutos.Text;
            dadosMoveis = txtConsumoDadosMoveis.Text;

            string mensagem = "Tem a certeza que deseja inserir este registo?";
            string legenda = "Inserir registo";
            MessageBoxButtons butoes = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mensagem, legenda, butoes);
            if (resultado == DialogResult.Yes)
            {
                consumosTableAdapter.AtualizarConsumo(idConsumo, nome, email, numeroTelemovel, mes, consumosMinutos, dadosMoveis);
                dataGridView1.DataSource = consumosTableAdapter.GetDataByIdTelemovel(idTelemovel);
            }
            else
            {
                return;
            }

            Editar(false);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int IdConsumo = Int32.Parse(txtIdConsumo.Text);
            idTelemovel = Int32.Parse(txtIdTelemovel.Text);

            string mensagem = "Tem a certeza que deseja eliminar este registo?";
            string legenda = "Eliminar registo";
            MessageBoxButtons butoes = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mensagem, legenda, butoes);
            if (resultado == DialogResult.Yes)
            {
                consumosTableAdapter.EliminarConsumo(IdConsumo);
                dataGridView1.DataSource = consumosTableAdapter.GetDataByIdTelemovel(idTelemovel);
            }
            else
            {
                return;
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            Editar(true);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Editar(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtIdConsumo.Text = row.Cells[0].Value.ToString();
                cbMes.Text = row.Cells[4].Value.ToString();
                txtConsumoMinutos.Text = row.Cells[5].Value.ToString();
                txtConsumoDadosMoveis.Text = row.Cells[6].Value.ToString();
            }
        }

        private void txtConsumoMinutos_TextChanged(object sender, EventArgs e)
        {
            if (txtConsumoMinutos.Text != "")
            {
                if (Int32.Parse(txtConsumoMinutos.Text) > limiteConsumoMinutos)
                {
                    txtConsumoMinutos.BackColor = Color.Red;
                    txtConsumoMinutos.ForeColor = Color.White;
                }
                else
                {
                    txtConsumoMinutos.BackColor = Color.Green;
                    txtConsumoMinutos.ForeColor = Color.White;
                }
            }
            else
            {
                txtConsumoMinutos.BackColor = DefaultBackColor;
                txtConsumoMinutos.ForeColor = DefaultForeColor;
            }
        }

        private void txtDados_TextChanged(object sender, EventArgs e)
        {
            if (txtConsumoDadosMoveis.Text != "")
            {
                if (Int32.Parse(txtConsumoDadosMoveis.Text) > limiteConsumoDadosMoveis)
                {
                    txtConsumoDadosMoveis.BackColor = Color.Red;
                    txtConsumoDadosMoveis.ForeColor = Color.White;
                }
                else
                {
                    txtConsumoDadosMoveis.BackColor = Color.Green;
                    txtConsumoDadosMoveis.ForeColor = Color.White;
                }
            }
            else
            {
                txtConsumoDadosMoveis.BackColor = DefaultBackColor;
                txtConsumoDadosMoveis.ForeColor = DefaultForeColor;
            }
        }

        // function to send an email to the user with the consumption data and the price of the bill for the month 
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text.Trim();
            email.Replace(" ", "");
            numeroTelemovel = txtNumero.Text;
            mes = cbMes.Text;
            limiteConsumoDadosMoveis = Int32.Parse(txtLimiteConsumoDadosMoveis.Text);
            limiteConsumoMinutos = Int32.Parse(txtLimiteConsumoMinutos.Text);
            dadosMoveis = txtConsumoDadosMoveis.Text;
            consumosMinutos = txtConsumoMinutos.Text;

            string lineBreak = "%0D%0A";

            string mensagem = $"                                                                                                            (Comunicação Interna - Confidencial){lineBreak + lineBreak + lineBreak}Para os devidos efeitos informa - se que nos termos do contrato em vigor, encontra - se contratualizado para o n.º de telemóvel {numeroTelemovel}, que lhe está atrubuído o seguinte plafond:{lineBreak}    - {limiteConsumoMinutos} minutos chamadas; {lineBreak}    - {limiteConsumoDadosMoveis} Kb de Internet {lineBreak + lineBreak}Os gastos com o referido telemóvel para o mês de {mes} foram os seguintes:{lineBreak}   - {consumosMinutos} minutos chamadas; {lineBreak}   - {dadosMoveis} Kb de Internet; {lineBreak + lineBreak}Avenidas Novas, {DateTime.Now.ToString("dd/MM/yyyy")}. {lineBreak + lineBreak}(Informação gerada automaticamente a partir da Base de Dados de Gestão de Telemóveis)";
            string subject = "Consumos Telemóveis";


            Process.Start($"mailto: {email}?subject={subject} &body={mensagem}");
        }
    }
}
