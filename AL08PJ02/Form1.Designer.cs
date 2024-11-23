using System.Drawing;
using System.Windows.Forms;

namespace AL08PJ02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lstPlacar = new System.Windows.Forms.ListView();
            this.colJogador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAcertos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colErros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEntrada.Font = new System.Drawing.Font("Hack", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.Color.White;
            this.lblEntrada.Location = new System.Drawing.Point(0, 0);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(800, 91);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Show do Milhão";
            this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEntrada.Click += new System.EventHandler(this.lblEntrada_Click);
            // 
            // lstPlacar
            // 
            this.lstPlacar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstPlacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lstPlacar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPlacar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJogador,
            this.colAcertos,
            this.colErros,
            this.colPonto});
            this.lstPlacar.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlacar.ForeColor = System.Drawing.Color.White;
            this.lstPlacar.HideSelection = false;
            this.lstPlacar.Location = new System.Drawing.Point(16, 105);
            this.lstPlacar.Name = "lstPlacar";
            this.lstPlacar.Size = new System.Drawing.Size(768, 391);
            this.lstPlacar.TabIndex = 3;
            this.lstPlacar.UseCompatibleStateImageBehavior = false;
            this.lstPlacar.View = System.Windows.Forms.View.Details;
            // 
            // colJogador
            // 
            this.colJogador.Text = "Jogador";
            this.colJogador.Width = 256;
            // 
            // colAcertos
            // 
            this.colAcertos.Text = "Acertos";
            this.colAcertos.Width = 128;
            // 
            // colErros
            // 
            this.colErros.Text = "Erros";
            this.colErros.Width = 128;
            // 
            // colPonto
            // 
            this.colPonto.Text = "Pontuação";
            this.colPonto.Width = 256;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AL08PJ02.Properties.Resources.LISTA;
            this.pictureBox1.Location = new System.Drawing.Point(1, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackgroundImage = global::AL08PJ02.Properties.Resources.BT1;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(314, 520);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 59);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar Placar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLimpar_MouseDown);
            this.btnLimpar.MouseEnter += new System.EventHandler(this.btnLimpar_MouseEnter);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.btnLimpar_MouseLeave);
            this.btnLimpar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLimpar_MouseUp);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackgroundImage = global::AL08PJ02.Properties.Resources.BT2;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(492, 520);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(172, 59);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            this.btnSair.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSair_MouseDown);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            this.btnSair.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSair_MouseUp);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackgroundImage = global::AL08PJ02.Properties.Resources.BT1;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(136, 520);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 59);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lstPlacar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEntrada);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblEntrada;
        private Button btnStart;
        private ListView lstPlacar;
        private ColumnHeader colJogador;
        private ColumnHeader colAcertos;
        private ColumnHeader colErros;
        private ColumnHeader colPonto;
        private Button btnSair;
        private Button btnLimpar;
        private PictureBox pictureBox1;
    }
}
