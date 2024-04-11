using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerarArquivosXml_ou_Json.BBL
{
    internal class BBL_Alunos
    {
        #region Metodos Públicos
        //Carregar grid
        public void CarregarGridAlunos(DataGridView pGrid, String parquivoTXT)
        {

            try
            {
                //Limpando o DataGridView antes de adicionar novos dados
                pGrid.Rows.Clear();
                //Carrega os registros no grid
                LerArquivoTXT(pGrid, parquivoTXT);
                pGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                pGrid.AllowUserToResizeColumns = false;
                pGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                pGrid.AllowUserToResizeRows = false;
                pGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                //Atualiliza o grid
                pGrid.Refresh();

            }
            catch (Exception ex)
            {
                // Trate a exceção ou registre-a de alguma forma
                MessageBox.Show($"Erro ao montar lista de alunos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool LerArquivoTXT(DataGridView pGrid, String parquivoTXT)
        {
            try
            {
                // Limpando o DataGridView antes de adicionar novos dados
                pGrid.Rows.Clear();

                // Lendo o arquivo
                if (parquivoTXT != null)
                {

                    // Ler o arquivo
                    string[] linhas = File.ReadAllLines(parquivoTXT);

                    // Adicionando as linhas do arquivo ao DataGridView
                    foreach (string linha in linhas)
                    {
                        string[] dados = linha.Split(';');
                        if (dados.Length == 4)
                        {
                            string nome = dados[0];
                            string email = dados[1];
                            string telefone = dados[2];
                            string cpf = dados[3];
                            // Adiciona dados no grid
                            pGrid.Rows.Add(nome, email, telefone, cpf);

                        }
                        else
                        {
                            MessageBox.Show("O arquivo selecionado não possui o formato esperado.");
                            return false;
                        }
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                // Trate a exceção ou registre-a de alguma forma
                MessageBox.Show($"Erro ao ler arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para exportar os dados do DataGridView para um arquivo XML
        public void GerarXML(DataGridView pGrid)
        {
            // Verificar se há dados no DataGridView
            if (pGrid.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado para exportar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Criar um novo documento XML
                XmlDocument xmlDocument = new XmlDocument();

                // Criar o elemento raiz
                XmlElement rootElement = xmlDocument.CreateElement("Dados");

                // Percorrer as linhas do DataGridView
                foreach (DataGridViewRow row in pGrid.Rows)
                {
                    // Criar um elemento para cada linha
                    XmlElement rowElement = xmlDocument.CreateElement("Item");

                    // Percorrer as células da linha atual
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Criar um elemento para cada célula com o nome da coluna como tag
                        XmlElement cellElement = xmlDocument.CreateElement(pGrid.Columns[cell.ColumnIndex].HeaderText);
                        cellElement.InnerText = cell.Value.ToString();
                        rowElement.AppendChild(cellElement);
                    }

                    // Adicionar a linha ao elemento raiz
                    rootElement.AppendChild(rowElement);
                }

                // Adicionar o elemento raiz ao documento XML
                xmlDocument.AppendChild(rootElement);

                // Criar o nome do arquivo com data e hora
                string nomeArquivo = $"dadosAluno_{DateTime.Now:yyyyMMdd_HHmmss}.xml";

                // Obter o diretório onde o arquivo será salvo
                //string caminhoDiretorio = @"C:\MeuDiretorio\"; 
                string caminhoDiretorio = Path.Combine(Application.StartupPath, "ArquivoXML"); // Será criado no diretório de execução do aplicativo

                // Verificar se o diretório existe, se não, criar
                if (!Directory.Exists(caminhoDiretorio))
                {
                    Directory.CreateDirectory(caminhoDiretorio);
                }

                // Salvar o documento XML no arquivo
                string filePath = Path.Combine(caminhoDiretorio, nomeArquivo);
                xmlDocument.Save(filePath);

                MessageBox.Show($"Arquivo XML exportado com sucesso para: {nomeArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar para XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para exportar os dados do DataGridView para um arquivo JSON
        public void GerarJSON(DataGridView pGrid)
        {
            // Verificar se há dados no DataGridView
            if (pGrid.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado para exportar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Criar uma lista de dicionários para armazenar os dados do DataGridView (o elemento raiz)
                var dataList = new List<Dictionary<string, object>>();

                // Percorrer as linhas do DataGridView
                foreach (DataGridViewRow row in pGrid.Rows)
                {
                    // Criar um dicionário para armazenar os dados da linha atual (um elemento para cada linha)
                    var rowData = new Dictionary<string, object>();

                    // Percorrer as células da linha atual
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Adicionar os dados da célula ao dicionário
                        rowData[pGrid.Columns[cell.ColumnIndex].HeaderText] = cell.Value;
                    }

                    // Adicionar o dicionário à lista
                    dataList.Add(rowData);
                }

                // Criar o nome do arquivo com data e hora
                string nomeArquivo = $"dadosAluno_{DateTime.Now:yyyyMMdd_HHmmss}.json";

                // Obter o diretório onde o arquivo será salvo
                //string caminhoDiretorio = @"C:\MeuDiretorio\"; 
                string caminhoDiretorio = Path.Combine(Application.StartupPath, "ArquivoJSON"); // Será criado no diretório de execução do aplicativo

                // Verificar se o diretório existe, se não, criar
                if (!Directory.Exists(caminhoDiretorio))
                {
                    Directory.CreateDirectory(caminhoDiretorio);
                }

                // Serializar a lista de dados para JSON
                string jsonData = JsonConvert.SerializeObject(dataList, Newtonsoft.Json.Formatting.Indented);

                // Salvar os dados serializados no arquivo JSON
                string filePath = Path.Combine(caminhoDiretorio, nomeArquivo);
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show($"Arquivo JSON exportado com sucesso para: {nomeArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar para JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
