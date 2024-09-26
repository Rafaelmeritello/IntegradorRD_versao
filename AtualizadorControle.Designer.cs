
namespace FerramentasUC4X
{
    partial class AtualizadorControle
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizadorControle));
            this.grid_nao_iniciados = new System.Windows.Forms.DataGridView();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_imp_controle = new System.Windows.Forms.Button();
            this.btn_imp_vethor = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.labelvethor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vethor_status_label = new System.Windows.Forms.Label();
            this.controle_status_label = new System.Windows.Forms.Label();
            this.barra_progresso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nao_iniciados)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_nao_iniciados
            // 
            this.grid_nao_iniciados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_nao_iniciados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_nao_iniciados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_nao_iniciados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefone});
            this.grid_nao_iniciados.Location = new System.Drawing.Point(13, 47);
            this.grid_nao_iniciados.Name = "grid_nao_iniciados";
            this.grid_nao_iniciados.Size = new System.Drawing.Size(554, 195);
            this.grid_nao_iniciados.TabIndex = 0;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "ID";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // btn_imp_controle
            // 
            this.btn_imp_controle.Location = new System.Drawing.Point(13, 310);
            this.btn_imp_controle.Name = "btn_imp_controle";
            this.btn_imp_controle.Size = new System.Drawing.Size(283, 33);
            this.btn_imp_controle.TabIndex = 1;
            this.btn_imp_controle.Text = "Importar planilha controle";
            this.btn_imp_controle.UseVisualStyleBackColor = true;
            this.btn_imp_controle.Click += new System.EventHandler(this.btn_imp_controle_Click);
            // 
            // btn_imp_vethor
            // 
            this.btn_imp_vethor.Location = new System.Drawing.Point(13, 255);
            this.btn_imp_vethor.Name = "btn_imp_vethor";
            this.btn_imp_vethor.Size = new System.Drawing.Size(283, 49);
            this.btn_imp_vethor.TabIndex = 3;
            this.btn_imp_vethor.Text = "Importar Vethor";
            this.btn_imp_vethor.UseVisualStyleBackColor = true;
            this.btn_imp_vethor.Click += new System.EventHandler(this.btn_imp_vethor_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(471, 255);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(95, 88);
            this.btn_atualizar.TabIndex = 4;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // labelvethor
            // 
            this.labelvethor.AutoSize = true;
            this.labelvethor.Location = new System.Drawing.Point(302, 273);
            this.labelvethor.Name = "labelvethor";
            this.labelvethor.Size = new System.Drawing.Size(83, 13);
            this.labelvethor.TabIndex = 5;
            this.labelvethor.Text = "Planilha vethor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Planilha controle: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID\'s Filtrados";
            // 
            // vethor_status_label
            // 
            this.vethor_status_label.AutoSize = true;
            this.vethor_status_label.ForeColor = System.Drawing.Color.Red;
            this.vethor_status_label.Location = new System.Drawing.Point(398, 273);
            this.vethor_status_label.Name = "vethor_status_label";
            this.vethor_status_label.Size = new System.Drawing.Size(53, 13);
            this.vethor_status_label.TabIndex = 9;
            this.vethor_status_label.Text = "Pendente";
            // 
            // controle_status_label
            // 
            this.controle_status_label.AutoSize = true;
            this.controle_status_label.ForeColor = System.Drawing.Color.Red;
            this.controle_status_label.Location = new System.Drawing.Point(398, 320);
            this.controle_status_label.Name = "controle_status_label";
            this.controle_status_label.Size = new System.Drawing.Size(53, 13);
            this.controle_status_label.TabIndex = 10;
            this.controle_status_label.Text = "Pendente";
            // 
            // barra_progresso
            // 
            this.barra_progresso.Location = new System.Drawing.Point(13, 5);
            this.barra_progresso.Name = "barra_progresso";
            this.barra_progresso.Size = new System.Drawing.Size(553, 23);
            this.barra_progresso.TabIndex = 12;
            // 
            // AtualizadorControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 355);
            this.Controls.Add(this.barra_progresso);
            this.Controls.Add(this.controle_status_label);
            this.Controls.Add(this.vethor_status_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelvethor);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_imp_vethor);
            this.Controls.Add(this.btn_imp_controle);
            this.Controls.Add(this.grid_nao_iniciados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AtualizadorControle";
            this.Text = "Atualizador Controle de expedição";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AtualizadorControle_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grid_nao_iniciados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_nao_iniciados;
        private System.Windows.Forms.Button btn_imp_controle;
        private System.Windows.Forms.Button btn_imp_vethor;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label labelvethor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vethor_status_label;
        private System.Windows.Forms.Label controle_status_label;
        private System.Windows.Forms.ProgressBar barra_progresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}

