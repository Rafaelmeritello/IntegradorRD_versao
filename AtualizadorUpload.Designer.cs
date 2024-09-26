
namespace FerramentasUC4X.modulos
{
    partial class AtualizadorUpload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizadorUpload));
            this.IdsNecessarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_imp_controle = new System.Windows.Forms.Button();
            this.btn_importar_upload = new System.Windows.Forms.Button();
            this.btn_consolidar = new System.Windows.Forms.Button();
            this.barra_progresso = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statuscontrole = new System.Windows.Forms.Label();
            this.statusupload = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdsNecessarios)).BeginInit();
            this.SuspendLayout();
            // 
            // IdsNecessarios
            // 
            this.IdsNecessarios.AllowUserToAddRows = false;
            this.IdsNecessarios.AllowUserToDeleteRows = false;
            this.IdsNecessarios.AllowUserToResizeColumns = false;
            this.IdsNecessarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IdsNecessarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IdsNecessarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.IdsNecessarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.IdsNecessarios.Location = new System.Drawing.Point(12, 50);
            this.IdsNecessarios.MultiSelect = false;
            this.IdsNecessarios.Name = "IdsNecessarios";
            this.IdsNecessarios.ReadOnly = true;
            this.IdsNecessarios.Size = new System.Drawing.Size(597, 199);
            this.IdsNecessarios.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // btn_imp_controle
            // 
            this.btn_imp_controle.Location = new System.Drawing.Point(12, 255);
            this.btn_imp_controle.Name = "btn_imp_controle";
            this.btn_imp_controle.Size = new System.Drawing.Size(148, 45);
            this.btn_imp_controle.TabIndex = 1;
            this.btn_imp_controle.Text = "Importar Controle";
            this.btn_imp_controle.UseVisualStyleBackColor = true;
            this.btn_imp_controle.Click += new System.EventHandler(this.btn_imp_controle_Click);
            // 
            // btn_importar_upload
            // 
            this.btn_importar_upload.Location = new System.Drawing.Point(12, 306);
            this.btn_importar_upload.Name = "btn_importar_upload";
            this.btn_importar_upload.Size = new System.Drawing.Size(148, 36);
            this.btn_importar_upload.TabIndex = 2;
            this.btn_importar_upload.Text = "Importar upload";
            this.btn_importar_upload.UseVisualStyleBackColor = true;
            this.btn_importar_upload.Click += new System.EventHandler(this.btn_importar_upload_Click);
            // 
            // btn_consolidar
            // 
            this.btn_consolidar.Location = new System.Drawing.Point(518, 265);
            this.btn_consolidar.Name = "btn_consolidar";
            this.btn_consolidar.Size = new System.Drawing.Size(91, 77);
            this.btn_consolidar.TabIndex = 3;
            this.btn_consolidar.Text = "Consolidar";
            this.btn_consolidar.UseVisualStyleBackColor = true;
            this.btn_consolidar.Click += new System.EventHandler(this.btn_consolidar_Click);
            // 
            // barra_progresso
            // 
            this.barra_progresso.Location = new System.Drawing.Point(12, 3);
            this.barra_progresso.Name = "barra_progresso";
            this.barra_progresso.Size = new System.Drawing.Size(597, 23);
            this.barra_progresso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consolidados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Planilha Controle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Planilha upload:";
            // 
            // statuscontrole
            // 
            this.statuscontrole.AutoSize = true;
            this.statuscontrole.Location = new System.Drawing.Point(261, 265);
            this.statuscontrole.Name = "statuscontrole";
            this.statuscontrole.Size = new System.Drawing.Size(53, 13);
            this.statuscontrole.TabIndex = 8;
            this.statuscontrole.Text = "Pendente";
            // 
            // statusupload
            // 
            this.statusupload.AutoSize = true;
            this.statusupload.Location = new System.Drawing.Point(261, 318);
            this.statusupload.Name = "statusupload";
            this.statusupload.Size = new System.Drawing.Size(53, 13);
            this.statusupload.TabIndex = 9;
            this.statusupload.Text = "Pendente";
            // 
            // AtualizadorUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 346);
            this.Controls.Add(this.statusupload);
            this.Controls.Add(this.statuscontrole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barra_progresso);
            this.Controls.Add(this.btn_consolidar);
            this.Controls.Add(this.btn_importar_upload);
            this.Controls.Add(this.btn_imp_controle);
            this.Controls.Add(this.IdsNecessarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AtualizadorUpload";
            this.Text = "AtualizadorUpload";
            ((System.ComponentModel.ISupportInitialize)(this.IdsNecessarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IdsNecessarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btn_imp_controle;
        private System.Windows.Forms.Button btn_importar_upload;
        private System.Windows.Forms.Button btn_consolidar;
        private System.Windows.Forms.ProgressBar barra_progresso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statuscontrole;
        private System.Windows.Forms.Label statusupload;
    }
}