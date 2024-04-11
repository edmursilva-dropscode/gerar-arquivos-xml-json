using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GerarArquivosXml_ou_Json.BBL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerarArquivosXml_ou_Json
{
    public partial class frmGerarArquivos : Form
    {
        #region Variaveis
        //Objetos das classes        
        BBL_Alunos NegocioAlunos = null;
        //Variáveis de uso comum
        private String arquivoTXT;
        #endregion

        #region Form
        public frmGerarArquivos()
        {
            InitializeComponent();
        }

        private void frmGerarArquivos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmGerarArquivos_Load(object sender, EventArgs e)
        {
            //Altera a cor de fundo do form
            this.BackColor = Color.FromArgb(231, 234, 244);
            //Adiciona o controle label do título a da imagem da barra
            pctBarra.Controls.Add(lblTitulo);
            //Adiciona o controle imagem do icone a da imagem da barra
            pctBarra.Controls.Add(pctIcone);
            //Carrega o grid
            NegocioAlunos = new BBL_Alunos();
            NegocioAlunos. CarregarGridAlunos(dgvAlunos, arquivoTXT);
            dgvAlunos.AllowUserToOrderColumns = true;
            dgvAlunos.Refresh();
        }
        #endregion

        #region Controles
        private void btnXML_Click(object sender, EventArgs e)
        {
            // Mudar o cursor do mouse 
            Cursor.Current = Cursors.WaitCursor;

            //Carrega o grid
            NegocioAlunos = new BBL_Alunos();
            NegocioAlunos.GerarXML(dgvAlunos);

            // Restaurar o cursor do mouse 
            Cursor.Current = Cursors.Default;
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            // Mudar o cursor do mouse 
            Cursor.Current = Cursors.WaitCursor;

            //Carrega o grid
            NegocioAlunos = new BBL_Alunos();
            NegocioAlunos.GerarJSON(dgvAlunos);

            // Restaurar o cursor do mouse 
            Cursor.Current = Cursors.Default;
        }
        private void btnImportarTXT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImportarTXT = new OpenFileDialog();
            openFileDialogImportarTXT.Filter = "Arquivos de texto (*.txt)|*.txt";
            openFileDialogImportarTXT.Title = "Selecione um arquivo de texto";

            if (openFileDialogImportarTXT.ShowDialog() == DialogResult.OK)
            {
                // Mudar o cursor do mouse 
                Cursor.Current = Cursors.WaitCursor;

                //Abre janela para pesquisar arquivo TXT
                arquivoTXT = openFileDialogImportarTXT.FileName;

                //Carrega o grid
                NegocioAlunos = new BBL_Alunos();
                NegocioAlunos.CarregarGridAlunos(dgvAlunos, arquivoTXT);
                dgvAlunos.AllowUserToOrderColumns = true;
                dgvAlunos.Refresh();

                // Restaurar o cursor do mouse 
                Cursor.Current = Cursors.Default;

            }
        }
        #endregion

    }

}
