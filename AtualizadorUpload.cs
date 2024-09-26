using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FerramentasUC4X.modulos
{
    public partial class AtualizadorUpload : Form
    {
        public AtualizadorUpload()
        {
            InitializeComponent();
        }

        private void btn_imp_controle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoabrir = new OpenFileDialog();

            dialogoabrir.Filter = "Excel Files|*.xls;*.xlsx";
            dialogoabrir.Title = "Selecione um arquivo Excel (Planilha controle)";
            if(dialogoabrir.ShowDialog() == DialogResult.OK)
            {
                VariaveisGlobais.caminhocontroleatualizado = dialogoabrir.FileName;
                MessageBox.Show("Controle importado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                statuscontrole.Text = Path.GetFileName( dialogoabrir.FileName);
                statuscontrole.ForeColor = Color.Green;
            }
        }

        private void btn_importar_upload_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dialogoabrir = new OpenFileDialog();

                dialogoabrir.Filter = "Excel Files|*.xls;*.xlsx";
                dialogoabrir.Title = "Selecione um arquivo Excel (Planilha upload)";
                if (dialogoabrir.ShowDialog() == DialogResult.OK)
                {
                    VariaveisGlobais.caminhoplanilhaupload = dialogoabrir.FileName;
                    MessageBox.Show("Upload importado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                    statusupload.Text = Path.GetFileName(dialogoabrir.FileName);
                    statusupload.ForeColor = Color.Green;
                }
            }

        }

        private async void btn_consolidar_Click(object sender, EventArgs e)
        {
            try
            {
                await Consolidar();
            }
            catch
            {
                MessageBox.Show("Erro ao consolidar, verifique se alguma planilha ja esta aberta em outro programa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        

        }
        public async Task Consolidar()
        {
            Invoke((Action)(() =>
            {
                barra_progresso.Maximum = 100;
                barra_progresso.Value = 0;
                barra_progresso.Style = ProgressBarStyle.Marquee; 
            }));

            await Task.Run(() =>
            {
                using (var workbookControle = new XLWorkbook(VariaveisGlobais.caminhocontroleatualizado))
                {
                    
                    Invoke((Action)(() =>
                    {
                        barra_progresso.Style = ProgressBarStyle.Blocks; 
                        barra_progresso.Value = 0; 
                    }));

                    var sheetcontrole = workbookControle.Worksheet("fluxo");
                    var tabelacontrole = sheetcontrole.Table("tabela1");
                    var cabecalhocontrole = tabelacontrole.Row(1);
                    var colunaconsolidadoid = cabecalhocontrole.Cells()
                        .FirstOrDefault(c => c.Value.ToString() == "CONSOLIDADO").Address.ColumnNumber;

                    using (var workbookUpload = new XLWorkbook(VariaveisGlobais.caminhoplanilhaupload))
                    {
                        var sheetupload = workbookUpload.Worksheet(1);
                        var cabecalhoupload = sheetupload.Row(1);

                        // Criar um dicionário para mapear os índices das colunas da planilha de upload
                        var indicesColunasUpload = new Dictionary<string, List<int>>();

                        foreach (var cell in cabecalhoupload.Cells())
                        {
                            var nomeCabecalho = cell.GetString();
                            var index = cell.Address.ColumnNumber;

                            if (!indicesColunasUpload.ContainsKey(nomeCabecalho))
                            {
                                indicesColunasUpload[nomeCabecalho] = new List<int>();
                            }
                            indicesColunasUpload[nomeCabecalho].Add(index);
                        }

                
                        var dadosParaUpload = new List<List<object>>();

                        // Contar o número total de linhas a serem processadas
                        var totalLinhas = tabelacontrole.DataRange.RowCount() - 1; // -1 para ignorar o cabeçalho
                        int linhaAtual = 0;

                        // Iterar sobre as linhas da tabela, começando da linha 2
                        foreach (var linha in tabelacontrole.DataRange.Rows().Skip(1))
                        {
                            linhaAtual++;
                      
                            // Verificar se o valor na coluna "CONSOLIDADO" é "NÃO"
                            if (linha.Cell(colunaconsolidadoid).Value.ToString().Equals("NÃO", StringComparison.OrdinalIgnoreCase))
                            {
                                // Adicionar os dados da linha na lista
                                linha.Cell(colunaconsolidadoid).SetValue("SIM");
                                var linhaDados = linha.Cells().Select(c => (object)c.Value).ToList();
                                dadosParaUpload.Add(linhaDados);
                            }

                          
                            var progresso = (int)((linhaAtual / (float)totalLinhas) * 100);
                            Invoke((Action)(() => barra_progresso.Value = progresso));
                        }

                       
                        int linhaUpload = 2;
                        foreach (var dados in dadosParaUpload)
                        {
                            for (int i = 0; i < dados.Count; i++)
                            {
                               
                                var nomeCabecalho = cabecalhocontrole.Cell(i + 1).GetString();
                                if (indicesColunasUpload.TryGetValue(nomeCabecalho.Trim(), out var colunasUpload))
                                {
                        
                                    foreach (var colunaUpload in colunasUpload)
                                    {
                                        
                                            
                                            if(sheetupload.Row(1).Cell(colunaUpload).Value.ToString().Trim() == "ID")
                                            {
                                              
                                               
                                            Invoke((Action)(() => IdsNecessarios.Rows.Add(dados[i].ToString())));
                                        }
                                          
                                            if (dados[i] is string)
                                            {
                                                sheetupload.Cell(linhaUpload, colunaUpload).SetValue((string)dados[i]);
                                            }
                                            else if (dados[i] is int)
                                            {
                                                sheetupload.Cell(linhaUpload, colunaUpload).SetValue((int)dados[i]);
                                            }
                                            else if (dados[i] is double)
                                            {
                                                sheetupload.Cell(linhaUpload, colunaUpload).SetValue((double)dados[i]);
                                            }
                                            else if (dados[i] is DateTime)
                                            {
                                                sheetupload.Cell(linhaUpload, colunaUpload).SetValue((DateTime)dados[i]);
                                            }
                                            else if (dados[i] is long)
                                            {
                                                sheetupload.Cell(linhaUpload, colunaUpload).SetValue((long)dados[i]);
                                            }
                                        else
                                            {
                                                sheetupload.Cell(linhaUpload, colunaUpload).SetValue(dados[i]?.ToString());
                                            }
                                        }
                                    
                                    
                                }
                                else
                                {
                    
                                }
                            }

                            // Preencher colunas padrão
                            sheetupload.Cell(linhaUpload, indicesColunasUpload["Integrador"][0]).SetValue("METODO");
                            sheetupload.Cell(linhaUpload, indicesColunasUpload["TRATAMENTO | ID Identificação Parceiro"][0]).SetValue("METODO");
                            sheetupload.Cell(linhaUpload, indicesColunasUpload["ABERTURA | Avançar para próxima etapa?"][0]).SetValue("SIM");

                            linhaUpload++;
          
                            var progressoPreenchimento = (int)((linhaUpload - 2) / (float)dadosParaUpload.Count * 100);
                            Invoke((Action)(() => barra_progresso.Value = progressoPreenchimento));
                        }
                        workbookUpload.Save();
                        workbookControle.Save();
                        
                        Invoke((Action)(() => barra_progresso.Value = 0)); 
                    }
                }
            });


            MessageBox.Show("Consolidação concluída com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
