using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data;
using System.IO;     

namespace FerramentasUC4X
{
    public partial class AtualizadorControle : Form
    {
        public AtualizadorControle()
        {
            InitializeComponent();
        }

        private async void btn_imp_vethor_Click(object sender, EventArgs e)
         
        {
            try
            {
                OpenFileDialog Dialogo_abertura = new OpenFileDialog();


                Dialogo_abertura.Filter = "Excel Files|*.xls;*.xlsx";
                Dialogo_abertura.Title = "Selecione um arquivo Excel";


                if (Dialogo_abertura.ShowDialog() == DialogResult.OK)
                {

                    string filePath = Dialogo_abertura.FileName;

                    VariaveisGlobais.caminhovethor = filePath;


                    var filtro = Utils.ConfiguracoesAtuais.ConfiguracoesControleExpedicao.FiltrosStatusVethor;

                    await CarregarDadosFiltrados_gridAsync(filePath, filtro);
                    vethor_status_label.ForeColor = Color.Green;
                    MessageBox.Show("Arquivo selecionado: " + filePath, "Sucesso", MessageBoxButtons.OK);
                    vethor_status_label.Text = "Ok";

                }
            }
            catch
            {
                MessageBox.Show("Erro, verifique se a planilha esta aberta em outro programa ou se importou a planilha correta","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







        private async Task CarregarDadosFiltrados_gridAsync(string caminhoArquivo, List<String> Filtro)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                Invoke((Action)(() =>
                {
                    barra_progresso.Maximum = 100;
                    barra_progresso.Value = 0;
                    barra_progresso.Style = ProgressBarStyle.Marquee;
                }));

                await Task.Run(() =>
                {
                    using (var workbook = new XLWorkbook(caminhoArquivo))
                    {
                        var worksheet = workbook.Worksheet(1);

                        int totalLinhas = worksheet.RowsUsed().Count() - 1;

                        Invoke((Action)(() =>
                        {
                            barra_progresso.Style = ProgressBarStyle.Continuous;
                            barra_progresso.Maximum = totalLinhas + 100;
                            barra_progresso.Value = 0;
                        }));

                        int linhasProcessadas = 0;
                        foreach (var row in worksheet.RowsUsed().Skip(1))
                        {
                            string colunaE = row.Cell(133).GetValue<string>();
                            string colunaA = row.Cell(1).GetValue<string>();

                            if (Filtro.Contains(colunaE))
                            {
                                Invoke((Action)(() =>
                                {
                                    grid_nao_iniciados.Rows.Add(colunaA);
                                }));
                            }

                            linhasProcessadas++;

                            Invoke((Action)(() =>
                            {
                                barra_progresso.Value = linhasProcessadas;
                            }));

                            Application.DoEvents();
                        }
                    }
                });
            }
            finally
            {
                Invoke((Action)(() =>
                {
                    barra_progresso.Value = barra_progresso.Maximum;
                    barra_progresso.Value = 0;
                }));
                Cursor = Cursors.Default;
            }
        }







        private void btn_imp_controle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.Title = "Selecione um arquivo Excel";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog.FileName;

                VariaveisGlobais.caminhocontrole = filePath;
                controle_status_label.Text = "Ok";
                controle_status_label.ForeColor = Color.Green;
                MessageBox.Show("Arquivo selecionado: " + filePath, "selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
        }









        private async void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(VariaveisGlobais.caminhocontrole != null && VariaveisGlobais.caminhovethor != null)
            {
                try
                {
                    List<string> colunasInteressadas = Utils.ConfiguracoesAtuais.ConfiguracoesControleExpedicao.ColunasInteressadas;

                await PreencherControleAsync(VariaveisGlobais.caminhovethor, VariaveisGlobais.caminhocontrole,colunasInteressadas);
                }
                catch (Exception E)
                {
                    MessageBox.Show("Erro, verifique se alguma das planilhas esta aberta em outra janela","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("erro, verifique se esqueceu de importar alguma planilha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }


        private async Task PreencherControleAsync(string caminhoVethor, string caminhoControle, List<string> colunasInteressadas)
        {
            var ColunasDestaque = Utils.ConfiguracoesAtuais.ConfiguracoesControleExpedicao.ColunasComDestaque
                .ToDictionary(
                    kvp => kvp.Value["NomeColuna"].ToString(),
                    kvp => new
                    {
                        ValoresParaDestaque = (kvp.Value["ValoresParaDestaque"] as IEnumerable<object>)?
                                              .Select(v => v.ToString()).ToList() ?? new List<string>(),
                        Cor = kvp.Value.ContainsKey("cor") ? kvp.Value["cor"].ToString() : "Nenhuma"
                    }
                );

            Cursor = Cursors.WaitCursor;
            try
            {
                Invoke((Action)(() =>
                {
                    barra_progresso.Maximum = 100;
                    barra_progresso.Value = 0;
                    barra_progresso.Style = ProgressBarStyle.Marquee;
                }));

                await Task.Run(() =>
                {
                    using (var workbookVethor = new XLWorkbook(caminhoVethor))
                    {
                        var worksheetVethor = workbookVethor.Worksheet(1);
                        var headerRowVethor = worksheetVethor.Row(1);
                        var colunaAIndex = 1; // Coluna A é o ID (ajustar se o Vethor mudar)

                        // Armazenar índices das colunas interessadas
                        var colunasVethor = colunasInteressadas
                            .ToDictionary(
                                nomeColuna => nomeColuna,
                                nomeColuna => headerRowVethor.Cells().First(c => c.GetValue<string>() == nomeColuna).Address.ColumnNumber
                            );

                        // Criar dicionário para acesso rápido baseado em ID
                        var vethorData = worksheetVethor.RowsUsed().Skip(1)
                           .GroupBy(linha => linha.Cell(colunaAIndex).GetValue<string>())
                           .ToDictionary(grupo => grupo.Key, grupo => grupo.First());

                        using (var workbookControle = new XLWorkbook(caminhoControle))
                        {
                            var worksheetControle = workbookControle.Worksheet("fluxo");
                            var tabelaControle = worksheetControle.Table("tabela1");
                            var headerRowControle = tabelaControle.Row(1);
                            var colunaIDIndexControle = headerRowControle.Cells().First(c => c.GetValue<string>() == " ID").Address.ColumnNumber - 1;

                            // Localizar a coluna "CONSOLIDADO"
                            var colunaConsolidadoIndex = headerRowControle.Cells().FirstOrDefault(c => c.GetValue<string>() == "CONSOLIDADO")?.Address.ColumnNumber ;
                            if (colunaConsolidadoIndex == null)
                            {
                                MessageBox.Show("A coluna 'CONSOLIDADO' não foi encontrada na planilha de controle.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Armazenar índices das colunas na planilha de controle
                            var colunasControle = colunasInteressadas
                                .ToDictionary(
                                    nomeColuna => nomeColuna,
                                    nomeColuna => headerRowControle.Cells().First(c => c.GetValue<string>() == nomeColuna).Address.ColumnNumber
                                );

                            // Verificar se a tabela de controle está vazia
                            if (!tabelaControle.DataRange.Rows().Any())
                            {
                                // Insere uma linha de cabeçalhos, se a tabela estiver vazia
                                tabelaControle.DataRange.InsertRowsBelow(1);
                            }

                            int totalLinhas = grid_nao_iniciados.Rows.Count;
                            int linhasProcessadas = 0;

                            foreach (DataGridViewRow gridRow in grid_nao_iniciados.Rows)
                            {
                                if (gridRow.IsNewRow) continue;
                                bool existente = false;
                                string dddTerminalGrid = gridRow.Cells[0].Value.ToString();
                                IXLRangeRow linhaControle = null; // Variável para a linha de controle

                                if (vethorData.TryGetValue(dddTerminalGrid, out var linhaVethor))
                                {
                                    string valorColunaEC = linhaVethor.Cell(133).GetValue<string>();

                                    if (Utils.ConfiguracoesAtuais.ConfiguracoesControleExpedicao.StatusNaoVerificarDuplicidade.Contains(valorColunaEC))
                                    {
                                        // Adiciona uma nova linha dentro da tabela
                                        tabelaControle.DataRange.LastRow().InsertRowsBelow(1);
                                        linhaControle = tabelaControle.DataRange.Rows().Last();

                                        linhaControle.Cell(colunaIDIndexControle).Value = dddTerminalGrid;

                                        foreach (var nomeColuna in colunasInteressadas)
                                        {
                                            
                                            var valorColunaVethor = linhaVethor.Cell(colunasVethor[nomeColuna]).GetValue<string>();
                                            linhaControle.Cell(colunasControle[nomeColuna]).Value = valorColunaVethor;
                                        }
                                    }
                                    else
                                    {
                                        
                                        var linhaControleExistente = tabelaControle.DataRange.Rows()
                                            .FirstOrDefault(row => row.Cell(colunaIDIndexControle+1).GetValue<string>() == dddTerminalGrid);

                                        if (linhaControleExistente != null)
                                        {
                                            linhaControle = linhaControleExistente;
                                            existente = true;
                                            
                                        }
                                        else
                                        {
                                            tabelaControle.DataRange.LastRow().InsertRowsBelow(1);
                                            linhaControle = tabelaControle.DataRange.Rows().Last();

                                            linhaControle.Cell(colunaIDIndexControle).Value = dddTerminalGrid;

                                            foreach (var nomeColuna in colunasInteressadas)
                                            {
                                                var valorColunaVethor = linhaVethor.Cell(colunasVethor[nomeColuna]).GetValue<string>();

                                                if (long.TryParse(valorColunaVethor, out long valorNumericoLong))
                                                {
                                                    linhaControle.Cell(colunasControle[nomeColuna]).Value = valorNumericoLong;
                                                   
                                                }
                                                else if (double.TryParse(valorColunaVethor, out double valorNumericoDouble))
                                                {
                                                    linhaControle.Cell(colunasControle[nomeColuna]).Value = valorNumericoDouble;
                                                  
                                                }
                                                else
                                                {
                                                    linhaControle.Cell(colunasControle[nomeColuna]).Value = valorColunaVethor;
                                                    
                                                }


                                            }
                                        }
                                    }

                                    bool corAplicada = false;
                                    foreach (var nomeColuna in colunasInteressadas)
                                    {
                                        var valorCelula = linhaVethor.Cell(colunasVethor[nomeColuna]).GetValue<string>();

                                        if (ColunasDestaque.ContainsKey(nomeColuna) && ColunasDestaque[nomeColuna].ValoresParaDestaque.Contains(valorCelula))
                                        {
                                            corAplicada = true; // Indica que a cor será aplicada
                                            switch (ColunasDestaque[nomeColuna].Cor.ToLower())
                                            {
                                                case "vermelho":
                                                    linhaControle.Style.Fill.BackgroundColor = XLColor.Red;
                                                    break;
                                                case "verde":
                                                    linhaControle.Style.Fill.BackgroundColor = XLColor.Green;
                                                    break;
                                                case "amarelo":
                                                    linhaControle.Style.Fill.BackgroundColor = XLColor.Yellow;
                                                    break;
                                            }
                                            break;
                                        }
                                    }
                                    
                                

                                    // Preencher a coluna "CONSOLIDADO" com "NÃO"
                                    if (existente == false)
                                    {
                                       
                                        linhaControle.Cell(colunaConsolidadoIndex.Value).Value = "NÃO";
                                        if (!corAplicada)
                                        {
                                            linhaControle.Style.Fill.BackgroundColor = XLColor.NoColor;
                                        }
                                    }
                                    
                                }

                                linhasProcessadas++;

                                // Atualizar a barra de progresso apenas a cada 10 linhas
                                if (linhasProcessadas % 10 == 0 || linhasProcessadas == totalLinhas)
                                {
                                    Invoke((Action)(() =>
                                    {
                                        barra_progresso.Value = (int)((double)linhasProcessadas / totalLinhas * 100);
                                        barra_progresso.Style = ProgressBarStyle.Continuous;
                                    }));
                                }
                            }

                            workbookControle.Save();
                            MessageBox.Show("Atualização concluída", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } // Fim do using workbookControle
                    } // Fim do using workbookVethor
                }); // Fim do Task.Run
            }
            finally
            {
                Invoke((Action)(() =>
                {
                    barra_progresso.Value = barra_progresso.Maximum;
                    barra_progresso.Style = ProgressBarStyle.Continuous;
                    barra_progresso.Value = 0;
                }));
                Cursor = Cursors.Default;
            }
        }


        private void AtualizadorControle_FormClosed(object sender, FormClosedEventArgs e)
        {
            VariaveisGlobais.caminhocontrole = "";
            
            VariaveisGlobais.caminhovethor = "";
        }
    }
}
