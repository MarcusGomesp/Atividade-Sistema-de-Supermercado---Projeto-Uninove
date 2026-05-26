using System;
using System.IO;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class NotaFiscal : Form
    {
        public NotaFiscal()
        {
            InitializeComponent();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            Compras telaCompras = new Compras();

            telaCompras.Show();

            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();

            salvar.Filter = "Arquivo TXT|*.txt";

            salvar.Title = "Salvar Nota";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer =
                    new StreamWriter(salvar.FileName);

                int i = 0;

                while (i < dvgNota.Rows.Count)
                {
                    if (dvgNota.Rows[i].Cells[0].Value != null)
                    {
                        writer.WriteLine(
                            dvgNota.Rows[i].Cells[0].Value.ToString()
                            + ": " +
                            dvgNota.Rows[i].Cells[1].Value.ToString()
                        );
                    }

                    i++;
                }

                writer.Close();

                MessageBox.Show(
                    "Arquivo baixado com sucesso!");
            }
        }

        private void NotaFiscal_Load(object sender, EventArgs e)
        {

        }
    }
}