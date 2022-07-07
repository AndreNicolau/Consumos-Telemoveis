using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consumos_Telemóveis
{
    public partial class Telemoveis : Form
    {
        public static string IdTelemovel;
        public static string NumeroTelemovel;
        public static string Nome;
        public static string Email;
        public static string Mes;
        public static int LimiteMinutos;
        public static int LimiteDadosMoveis;

        public Telemoveis()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbConsumosTelemoveisDataSet.telemoveis' table. You can move, or remove it, as needed.
            this.telemoveisTableAdapter.Fill(this.dbConsumosTelemoveisDataSet.telemoveis);

            dataGridView1.CurrentCellChanged += dataGridView1_SelectionChanged;
        }

        private void Editar(bool editando)
        {
            if (editando)
            {
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtNumero.Enabled = true;
                txtMinutos.Enabled = true;
                txtDadosMoveis.Enabled = true;
                tsbSalvar.Enabled = true;
                tsbEliminar.Enabled = true;
                tsbCancelar.Enabled = true;

                tsbNovo.Enabled = false;
                tsbEditar.Enabled = false;
            }
            else
            {
                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                txtNumero.Enabled = false;
                txtMinutos.Enabled = false;
                txtDadosMoveis.Enabled = false;
                tsbSalvar.Enabled = false;
                tsbEliminar.Enabled = false;
                tsbCancelar.Enabled = false;

                tsbNovo.Enabled = true;
                tsbEditar.Enabled = true;
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

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            telemoveisTableAdapter.InserirTelemovel("N/I", "N/I", 0, "N/I", "N/I");
            dataGridView1.DataSource = telemoveisTableAdapter.GetData();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            Editar(true);
            txtNome.Focus();
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            int numero = Int32.Parse(txtNumero.Text);
            string minutos = txtMinutos.Text;
            string dados = txtDadosMoveis.Text;
            int Id = Int32.Parse(txtId.Text);


            if (nome != "N/I" && email != "N/I" && numero != 0 && minutos != "N/I" && dados != "N/I")
            {
                string mensagem = "Tem a certeza que deseja fazer estas alterações?";
                string legenda = "Salvar alterações";
                MessageBoxButtons butoes = MessageBoxButtons.YesNo;
                DialogResult resultado;

                resultado = MessageBox.Show(mensagem, legenda, butoes);
                if (resultado == DialogResult.Yes)
                {
                    telemoveisTableAdapter.AtualizarTelemovel(numero, nome, email, minutos, dados, Id);
                    dataGridView1.DataSource = telemoveisTableAdapter.GetData();
                    Editar(false);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Certifique se que inseriu valores em todas as caixas de texto", "Dados em falta");
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int Id = Int32.Parse(txtId.Text);

            string mensagem = "Tem a certeza que deseja eliminar este registo?";
            string legenda = "Eliminar registo";
            MessageBoxButtons butoes = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensagem, legenda, butoes);
            if (resultado == DialogResult.Yes)
            {
                telemoveisTableAdapter.EliminarTelemovel(Id);
                dataGridView1.DataSource = telemoveisTableAdapter.GetData();
                Editar(false);
            }
            else
            {
                return;
            }
        }

        // Insere os valores das linhas nas caixas de texto
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtNumero.Text = row.Cells[3].Value.ToString();
                txtMinutos.Text = row.Cells[4].Value.ToString();
                txtDadosMoveis.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdTelemovel = txtId.Text;
            Nome = txtNome.Text;
            NumeroTelemovel = txtNumero.Text;
            Email = txtEmail.Text;
            LimiteMinutos = Int32.Parse(txtMinutos.Text);
            LimiteDadosMoveis = Int32.Parse(txtDadosMoveis.Text);

            DateTime data = new DateTime();
            Mes = data.ToString("MMMM");

            Consumos consumos = new Consumos();
            consumos.ShowDialog();
            
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            if (txtProcurar.Text != "")
            {
                string numero = txtProcurar.Text;

                var select = "SELECT * FROM telemoveis WHERE numeroTelemovel like '%" + numero + "%'";
                var con = new SqlConnection(Properties.Settings.Default.DbConsumosTelemoveisConnectionString);
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                dataGridView1.DataSource = telemoveisTableAdapter.GetData();
            }
            
        }
    }
}
