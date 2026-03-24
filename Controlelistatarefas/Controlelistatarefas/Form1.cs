using Controlelistatarefas.Data;
using Controlelistatarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Controlelistatarefas
{
    public partial class Form1 : Form
    {
        private int? _idTarefaSelecionada = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            dtpDataConclusao.ShowCheckBox = true;
            dtpDataConclusao.Checked = false;
            LimparCampos();
            CarregarTarefas();
        }

        private void ConfigurarGrid()
        {
            dgvTarefas.AutoGenerateColumns = false;
            dgvTarefas.Columns.Clear();

            dgvTarefas.EnableHeadersVisualStyles = false;
            dgvTarefas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvTarefas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTarefas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTarefas.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTarefas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dgvTarefas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvTarefas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvTarefas.RowTemplate.Height = 30;

            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 60
            });

            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descricao",
                HeaderText = "Descrição",
                DataPropertyName = "Descricao",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DataCriacao",
                HeaderText = "Data Criação",
                DataPropertyName = "DataCriacao",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DataConclusao",
                HeaderText = "Data Conclusão",
                DataPropertyName = "DataConclusao",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            dgvTarefas.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Excluir",
                HeaderText = "Ação",
                Text = "Excluir",
                UseColumnTextForButtonValue = true,
                Width = 90
            });
        }

        private void CarregarTarefas()
        {
            using var db = new AppDbContext();

            var lista = db.Tarefas
                .AsNoTracking()
                .OrderBy(t => t.DataConclusao.HasValue)
                .ThenByDescending(t => t.DataCriacao)
                .ToList();

            dgvTarefas.DataSource = null;
            dgvTarefas.DataSource = lista;
        }

        private void LimparCampos()
        {
            _idTarefaSelecionada = null;

            txtDescricao.Clear();

            dtpDataCriacao.Value = DateTime.Now;
            dtpDataCriacao.Enabled = true;

            dtpDataConclusao.Value = DateTime.Now;
            dtpDataConclusao.Checked = false;
            dtpDataConclusao.Enabled = true;
            btnSalvar.Enabled = true;

            txtDescricao.Focus();
        }

        private void PreencherCampos(int id, string descricao, DateTime dataCriacao, DateTime? dataConclusao)
        {
            _idTarefaSelecionada = id;

            txtDescricao.Text = descricao;
            dtpDataCriacao.Value = dataCriacao;

            if (dataConclusao.HasValue)
            {
                dtpDataConclusao.Value = dataConclusao.Value;
                dtpDataConclusao.Checked = true;
            }
            else
            {
                dtpDataConclusao.Value = DateTime.Now;
                dtpDataConclusao.Checked = false;
            }

            bool concluida = dataConclusao.HasValue;
            dtpDataCriacao.Enabled = false;
            dtpDataConclusao.Enabled = !concluida;
            btnSalvar.Enabled = !concluida;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição da tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDataCriacao.Value == DateTime.MinValue)
            {
                MessageBox.Show("Informe a data de criação da tarefa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDataConclusao.Checked && dtpDataConclusao.Value < dtpDataCriacao.Value)
            {
                MessageBox.Show("A data de conclusão não pode ser menor que a data de criação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new AppDbContext();

                if (_idTarefaSelecionada.HasValue)
                {
                    var tarefa = db.Tarefas.FirstOrDefault(t => t.Id == _idTarefaSelecionada.Value);

                    if (tarefa == null)
                    {
                        MessageBox.Show("Tarefa não encontrada.");
                        return;
                    }

                    tarefa.Descricao = txtDescricao.Text.Trim();

                    if (!tarefa.DataConclusao.HasValue && dtpDataConclusao.Checked)
                    {
                        tarefa.DataConclusao = dtpDataConclusao.Value;
                    }
                }
                else
                {
                    var novaTarefa = new Tarefa
                    {
                        Descricao = txtDescricao.Text.Trim(),
                        DataCriacao = dtpDataCriacao.Value,
                        DataConclusao = dtpDataConclusao.Checked ? dtpDataConclusao.Value : null
                    };

                    db.Tarefas.Add(novaTarefa);
                }

                db.SaveChanges();

                CarregarTarefas();
                LimparCampos();

                MessageBox.Show("Tarefa salva com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar tarefa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex >= dgvTarefas.Columns.Count) return;

            var tarefa = dgvTarefas.Rows[e.RowIndex].DataBoundItem as Tarefa;
            if (tarefa == null) return;

            string nomeColuna = dgvTarefas.Columns[e.ColumnIndex].Name;

            if (nomeColuna == "Excluir")
            {
                var resultado = MessageBox.Show(
                    "Deseja realmente excluir?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using var db = new AppDbContext();

                        var tarefaExcluir = db.Tarefas.FirstOrDefault(t => t.Id == tarefa.Id);
                        if (tarefaExcluir == null)
                        {
                            MessageBox.Show("Tarefa não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        db.Tarefas.Remove(tarefaExcluir);
                        db.SaveChanges();

                        if (_idTarefaSelecionada == tarefa.Id)
                            LimparCampos();

                        CarregarTarefas();
                        dgvTarefas.ClearSelection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir tarefa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return;
            }

            PreencherCampos(tarefa.Id, tarefa.Descricao, tarefa.DataCriacao, tarefa.DataConclusao);
        }

        private void dgvTarefas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvTarefas.Rows[e.RowIndex];
            var tarefa = row.DataBoundItem as Tarefa;

            if (tarefa == null) return;

            if (tarefa.DataConclusao.HasValue)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235);

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (dgvTarefas.Columns[cell.ColumnIndex].Name != "Excluir")
                    {
                        cell.Style.Font = new Font("Segoe UI", 10, FontStyle.Strikeout);
                    }
                    else
                    {
                        // garante que o botão NÃO tenha traço
                        cell.Style.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    }
                }
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}