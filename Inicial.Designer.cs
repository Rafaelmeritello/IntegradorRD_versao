
namespace FerramentasUC4X
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.atualizadorFluxoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizadorPlanilhaUploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(807, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizadorFluxoToolStripMenuItem,
            this.atualizadorPlanilhaUploadToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton1.Text = "Modulos";
            // 
            // atualizadorFluxoToolStripMenuItem
            // 
            this.atualizadorFluxoToolStripMenuItem.Name = "atualizadorFluxoToolStripMenuItem";
            this.atualizadorFluxoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.atualizadorFluxoToolStripMenuItem.Text = "Atualizador planilha controle";
            this.atualizadorFluxoToolStripMenuItem.Click += new System.EventHandler(this.atualizadorFluxoToolStripMenuItem_Click);
            // 
            // atualizadorPlanilhaUploadToolStripMenuItem
            // 
            this.atualizadorPlanilhaUploadToolStripMenuItem.Name = "atualizadorPlanilhaUploadToolStripMenuItem";
            this.atualizadorPlanilhaUploadToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.atualizadorPlanilhaUploadToolStripMenuItem.Text = "Atualizador planilha upload";
            this.atualizadorPlanilhaUploadToolStripMenuItem.Click += new System.EventHandler(this.atualizadorPlanilhaUploadToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::FerramentasUC4X.Properties.Resources.ico;
            this.pictureBox1.Location = new System.Drawing.Point(175, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(807, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.Text = "Ferramentas UC4X";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem atualizadorFluxoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizadorPlanilhaUploadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}