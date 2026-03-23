namespace Controlelistatarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelContainer;
        private Label lblTitulo;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblDataCriacao;
        private DateTimePicker dtpDataCriacao;
        private Label lblDataConclusao;
        private DateTimePicker dtpDataConclusao;
        private Button btnSalvar;
        private Button btnNovo;
        private Label lblLista;
        private DataGridView dgvTarefas;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContainer = new Panel();
            lblLista = new Label();
            btnNovo = new Button();
            btnSalvar = new Button();
            dtpDataConclusao = new DateTimePicker();
            lblDataConclusao = new Label();
            dtpDataCriacao = new DateTimePicker();
            lblDataCriacao = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            lblTitulo = new Label();
            dgvTarefas = new DataGridView();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = Color.White;
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(lblLista);
            panelContainer.Controls.Add(btnNovo);
            panelContainer.Controls.Add(btnSalvar);
            panelContainer.Controls.Add(dtpDataConclusao);
            panelContainer.Controls.Add(lblDataConclusao);
            panelContainer.Controls.Add(dtpDataCriacao);
            panelContainer.Controls.Add(lblDataCriacao);
            panelContainer.Controls.Add(txtDescricao);
            panelContainer.Controls.Add(lblDescricao);
            panelContainer.Controls.Add(lblTitulo);
            panelContainer.Controls.Add(dgvTarefas);
            panelContainer.Location = new Point(18, 15);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(826, 466);
            panelContainer.TabIndex = 0;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLista.ForeColor = Color.FromArgb(45, 45, 48);
            lblLista.Location = new Point(24, 152);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(116, 20);
            lblLista.TabIndex = 10;
            lblLista.Text = "Lista de tarefas";
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Gray;
            btnNovo.Cursor = Cursors.Hand;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(582, 109);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(105, 30);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(76, 175, 80);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(693, 109);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 30);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dtpDataConclusao
            // 
            dtpDataConclusao.CalendarFont = new Font("Segoe UI", 9F);
            dtpDataConclusao.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataConclusao.Font = new Font("Segoe UI", 10F);
            dtpDataConclusao.Format = DateTimePickerFormat.Custom;
            dtpDataConclusao.Location = new Point(434, 71);
            dtpDataConclusao.Margin = new Padding(3, 2, 3, 2);
            dtpDataConclusao.Name = "dtpDataConclusao";
            dtpDataConclusao.Size = new Size(193, 25);
            dtpDataConclusao.TabIndex = 6;
            // 
            // lblDataConclusao
            // 
            lblDataConclusao.AutoSize = true;
            lblDataConclusao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDataConclusao.ForeColor = Color.FromArgb(45, 45, 48);
            lblDataConclusao.Location = new Point(434, 51);
            lblDataConclusao.Name = "lblDataConclusao";
            lblDataConclusao.Size = new Size(112, 19);
            lblDataConclusao.TabIndex = 5;
            lblDataConclusao.Text = "Data Conclusão";
            // 
            // dtpDataCriacao
            // 
            dtpDataCriacao.CalendarFont = new Font("Segoe UI", 9F);
            dtpDataCriacao.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataCriacao.Font = new Font("Segoe UI", 10F);
            dtpDataCriacao.Format = DateTimePickerFormat.Custom;
            dtpDataCriacao.Location = new Point(220, 71);
            dtpDataCriacao.Margin = new Padding(3, 2, 3, 2);
            dtpDataCriacao.Name = "dtpDataCriacao";
            dtpDataCriacao.Size = new Size(193, 25);
            dtpDataCriacao.TabIndex = 4;
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDataCriacao.ForeColor = Color.FromArgb(45, 45, 48);
            lblDataCriacao.Location = new Point(220, 51);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(95, 19);
            lblDataCriacao.TabIndex = 3;
            lblDataCriacao.Text = "Data Criação";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 10F);
            txtDescricao.Location = new Point(24, 71);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Digite a descrição da tarefa";
            txtDescricao.Size = new Size(176, 25);
            txtDescricao.TabIndex = 2;
            txtDescricao.KeyDown += txtDescricao_KeyDown;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescricao.ForeColor = Color.FromArgb(45, 45, 48);
            lblDescricao.Location = new Point(24, 51);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 19);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 45, 48);
            lblTitulo.Location = new Point(24, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(236, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Controle de Tarefas";
            // 
            // dgvTarefas
            // 
            dgvTarefas.AllowUserToAddRows = false;
            dgvTarefas.AllowUserToDeleteRows = false;
            dgvTarefas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTarefas.BackgroundColor = Color.White;
            dgvTarefas.BorderStyle = BorderStyle.None;
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.Location = new Point(24, 177);
            dgvTarefas.Margin = new Padding(3, 2, 3, 2);
            dgvTarefas.MultiSelect = false;
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.ReadOnly = true;
            dgvTarefas.RowHeadersWidth = 51;
            dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarefas.Size = new Size(774, 264);
            dgvTarefas.TabIndex = 11;
            dgvTarefas.CellClick += dgvTarefas_CellClick;
            dgvTarefas.RowPrePaint += dgvTarefas_RowPrePaint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(861, 496);
            Controls.Add(panelContainer);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 535);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Tarefas";
            Load += Form1_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}