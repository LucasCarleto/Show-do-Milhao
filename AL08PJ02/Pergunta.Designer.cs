using System.Drawing;
using System.Windows.Forms;

namespace AL08PJ02
{
    partial class Pergunta
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
            this.bkgResp = new System.Windows.Forms.Label();
            this.bkgAjuda = new System.Windows.Forms.Label();
            this.lblCerto = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblAltA = new System.Windows.Forms.Label();
            this.lblAltB = new System.Windows.Forms.Label();
            this.lblAltC = new System.Windows.Forms.Label();
            this.lblAltD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carregar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPula = new System.Windows.Forms.Label();
            this.btnUniversitario = new System.Windows.Forms.Label();
            this.btnCartas = new System.Windows.Forms.Label();
            this.btnPlacas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox1Back = new System.Windows.Forms.PictureBox();
            this.btnErrou = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContinua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.voto4 = new System.Windows.Forms.Label();
            this.voto3 = new System.Windows.Forms.Label();
            this.voto2 = new System.Windows.Forms.Label();
            this.voto1 = new System.Windows.Forms.Label();
            this.car4 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.voltar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1Back)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bkgResp
            // 
            this.bkgResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bkgResp.Dock = System.Windows.Forms.DockStyle.Left;
            this.bkgResp.Location = new System.Drawing.Point(0, 0);
            this.bkgResp.Name = "bkgResp";
            this.bkgResp.Size = new System.Drawing.Size(472, 560);
            this.bkgResp.TabIndex = 1;
            // 
            // bkgAjuda
            // 
            this.bkgAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bkgAjuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.bkgAjuda.Location = new System.Drawing.Point(478, 0);
            this.bkgAjuda.Name = "bkgAjuda";
            this.bkgAjuda.Size = new System.Drawing.Size(322, 560);
            this.bkgAjuda.TabIndex = 2;
            // 
            // lblCerto
            // 
            this.lblCerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.lblCerto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCerto.Location = new System.Drawing.Point(0, 560);
            this.lblCerto.Name = "lblCerto";
            this.lblCerto.Size = new System.Drawing.Size(800, 40);
            this.lblCerto.TabIndex = 3;
            this.lblCerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Hack", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(92, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(616, 104);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "0. PERGUNTA";
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPergunta.Click += new System.EventHandler(this.lblPergunta_Click);
            // 
            // lblAltA
            // 
            this.lblAltA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAltA.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltA.Location = new System.Drawing.Point(0, 104);
            this.lblAltA.Name = "lblAltA";
            this.lblAltA.Size = new System.Drawing.Size(472, 114);
            this.lblAltA.TabIndex = 0;
            this.lblAltA.Text = "Alternativa A";
            this.lblAltA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAltA.Click += new System.EventHandler(this.lblAltA_Click);
            this.lblAltA.Paint += new System.Windows.Forms.PaintEventHandler(this.lblAltA_Paint_1);
            this.lblAltA.DoubleClick += new System.EventHandler(this.lblAltA_DoubleClick);
            // 
            // lblAltB
            // 
            this.lblAltB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAltB.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltB.Location = new System.Drawing.Point(0, 218);
            this.lblAltB.Name = "lblAltB";
            this.lblAltB.Size = new System.Drawing.Size(472, 114);
            this.lblAltB.TabIndex = 1;
            this.lblAltB.Text = "Alternativa B";
            this.lblAltB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAltB.Click += new System.EventHandler(this.lblAltB_Click);
            this.lblAltB.Paint += new System.Windows.Forms.PaintEventHandler(this.lblAltB_Paint);
            this.lblAltB.DoubleClick += new System.EventHandler(this.lblAltB_DoubleClick);
            // 
            // lblAltC
            // 
            this.lblAltC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAltC.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltC.Location = new System.Drawing.Point(0, 332);
            this.lblAltC.Name = "lblAltC";
            this.lblAltC.Size = new System.Drawing.Size(472, 114);
            this.lblAltC.TabIndex = 2;
            this.lblAltC.Text = "Alternativa C";
            this.lblAltC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAltC.Click += new System.EventHandler(this.lblAltC_Click);
            this.lblAltC.Paint += new System.Windows.Forms.PaintEventHandler(this.lblAltC_Paint);
            this.lblAltC.DoubleClick += new System.EventHandler(this.lblAltC_DoubleClick);
            // 
            // lblAltD
            // 
            this.lblAltD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAltD.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltD.Location = new System.Drawing.Point(0, 446);
            this.lblAltD.Name = "lblAltD";
            this.lblAltD.Size = new System.Drawing.Size(472, 114);
            this.lblAltD.TabIndex = 3;
            this.lblAltD.Text = "Alternativa D";
            this.lblAltD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAltD.Click += new System.EventHandler(this.lblAltD_Click);
            this.lblAltD.Paint += new System.Windows.Forms.PaintEventHandler(this.lblAltD_Paint);
            this.lblAltD.DoubleClick += new System.EventHandler(this.lblAltD_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "D";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // carregar
            // 
            this.carregar.Font = new System.Drawing.Font("Hack", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carregar.Location = new System.Drawing.Point(705, 73);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(35, 13);
            this.carregar.TabIndex = 8;
            this.carregar.Text = "Carregando...";
            this.carregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carregar.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(800, 104);
            this.label8.TabIndex = 9;
            // 
            // btnPula
            // 
            this.btnPula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPula.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPula.Location = new System.Drawing.Point(478, 104);
            this.btnPula.Name = "btnPula";
            this.btnPula.Size = new System.Drawing.Size(322, 114);
            this.btnPula.TabIndex = 10;
            this.btnPula.Text = "Pular";
            this.btnPula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPula.Click += new System.EventHandler(this.btnPula_Click);
            // 
            // btnUniversitario
            // 
            this.btnUniversitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUniversitario.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniversitario.Location = new System.Drawing.Point(478, 218);
            this.btnUniversitario.Name = "btnUniversitario";
            this.btnUniversitario.Size = new System.Drawing.Size(322, 114);
            this.btnUniversitario.TabIndex = 10;
            this.btnUniversitario.Text = "Universitários";
            this.btnUniversitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUniversitario.Click += new System.EventHandler(this.btnUniversitario_Click);
            // 
            // btnCartas
            // 
            this.btnCartas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCartas.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartas.Location = new System.Drawing.Point(478, 332);
            this.btnCartas.Name = "btnCartas";
            this.btnCartas.Size = new System.Drawing.Size(322, 114);
            this.btnCartas.TabIndex = 10;
            this.btnCartas.Text = "Cartas";
            this.btnCartas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartas.Click += new System.EventHandler(this.btnCartas_Click);
            // 
            // btnPlacas
            // 
            this.btnPlacas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlacas.Font = new System.Drawing.Font("Hack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlacas.Location = new System.Drawing.Point(478, 446);
            this.btnPlacas.Name = "btnPlacas";
            this.btnPlacas.Size = new System.Drawing.Size(322, 114);
            this.btnPlacas.TabIndex = 10;
            this.btnPlacas.Text = "Placas";
            this.btnPlacas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlacas.Click += new System.EventHandler(this.btnPlacas_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::AL08PJ02.Properties.Resources.PAN;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox1Back);
            this.panel2.Controls.Add(this.btnErrou);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(144, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 256);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Hack", 24F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(113, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 38);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1Back
            // 
            this.textBox1Back.Image = global::AL08PJ02.Properties.Resources.TXT;
            this.textBox1Back.Location = new System.Drawing.Point(106, 119);
            this.textBox1Back.Name = "textBox1Back";
            this.textBox1Back.Size = new System.Drawing.Size(300, 52);
            this.textBox1Back.TabIndex = 4;
            this.textBox1Back.TabStop = false;
            // 
            // btnErrou
            // 
            this.btnErrou.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnErrou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnErrou.BackgroundImage = global::AL08PJ02.Properties.Resources.BT2;
            this.btnErrou.FlatAppearance.BorderSize = 0;
            this.btnErrou.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnErrou.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnErrou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrou.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrou.ForeColor = System.Drawing.Color.White;
            this.btnErrou.Location = new System.Drawing.Point(171, 185);
            this.btnErrou.Name = "btnErrou";
            this.btnErrou.Size = new System.Drawing.Size(170, 48);
            this.btnErrou.TabIndex = 2;
            this.btnErrou.Text = "Voltar";
            this.btnErrou.UseVisualStyleBackColor = false;
            this.btnErrou.Click += new System.EventHandler(this.btnErrou_Click);
            this.btnErrou.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnErrou_MouseDown);
            this.btnErrou.MouseEnter += new System.EventHandler(this.btnErrou_MouseEnter);
            this.btnErrou.MouseLeave += new System.EventHandler(this.btnErrou_MouseLeave);
            this.btnErrou.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnErrou_MouseUp);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Hack", 24F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(10, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(493, 44);
            this.label7.TabIndex = 0;
            this.label7.Text = "Digite seu nome:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Hack", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(493, 58);
            this.label6.TabIndex = 0;
            this.label6.Text = "QUE PENA, VOCÊ ERROU!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.panel1.BackgroundImage = global::AL08PJ02.Properties.Resources.PAN;
            this.panel1.Controls.Add(this.btnContinua);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(144, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 256);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // btnContinua
            // 
            this.btnContinua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnContinua.BackgroundImage = global::AL08PJ02.Properties.Resources.BT1;
            this.btnContinua.FlatAppearance.BorderSize = 0;
            this.btnContinua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnContinua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.btnContinua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinua.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinua.ForeColor = System.Drawing.Color.White;
            this.btnContinua.Location = new System.Drawing.Point(171, 149);
            this.btnContinua.Name = "btnContinua";
            this.btnContinua.Size = new System.Drawing.Size(170, 48);
            this.btnContinua.TabIndex = 2;
            this.btnContinua.Text = "Prosseguir";
            this.btnContinua.UseVisualStyleBackColor = false;
            this.btnContinua.Click += new System.EventHandler(this.btnContinua_Click);
            this.btnContinua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnContinua_MouseDown);
            this.btnContinua.MouseEnter += new System.EventHandler(this.btnContinua_MouseEnter);
            this.btnContinua.MouseLeave += new System.EventHandler(this.btnContinua_MouseLeave);
            this.btnContinua.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnContinua_MouseUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Hack", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 58);
            this.label5.TabIndex = 0;
            this.label5.Text = "CERTA RESPOSTA!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AL08PJ02.Properties.Resources.PAN2;
            this.panel3.Controls.Add(this.voto4);
            this.panel3.Controls.Add(this.voto3);
            this.panel3.Controls.Add(this.voto2);
            this.panel3.Controls.Add(this.voto1);
            this.panel3.Controls.Add(this.car4);
            this.panel3.Controls.Add(this.car3);
            this.panel3.Controls.Add(this.car1);
            this.panel3.Controls.Add(this.car2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(144, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 256);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // voto4
            // 
            this.voto4.BackColor = System.Drawing.Color.White;
            this.voto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto4.ForeColor = System.Drawing.Color.Black;
            this.voto4.Location = new System.Drawing.Point(351, 120);
            this.voto4.Name = "voto4";
            this.voto4.Size = new System.Drawing.Size(41, 59);
            this.voto4.TabIndex = 3;
            this.voto4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voto4.Visible = false;
            // 
            // voto3
            // 
            this.voto3.BackColor = System.Drawing.Color.White;
            this.voto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto3.ForeColor = System.Drawing.Color.Black;
            this.voto3.Location = new System.Drawing.Point(274, 120);
            this.voto3.Name = "voto3";
            this.voto3.Size = new System.Drawing.Size(41, 59);
            this.voto3.TabIndex = 3;
            this.voto3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voto3.Visible = false;
            // 
            // voto2
            // 
            this.voto2.BackColor = System.Drawing.Color.White;
            this.voto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto2.ForeColor = System.Drawing.Color.Black;
            this.voto2.Location = new System.Drawing.Point(197, 120);
            this.voto2.Name = "voto2";
            this.voto2.Size = new System.Drawing.Size(41, 59);
            this.voto2.TabIndex = 3;
            this.voto2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voto2.Visible = false;
            // 
            // voto1
            // 
            this.voto1.BackColor = System.Drawing.Color.White;
            this.voto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto1.ForeColor = System.Drawing.Color.Black;
            this.voto1.Location = new System.Drawing.Point(120, 120);
            this.voto1.Name = "voto1";
            this.voto1.Size = new System.Drawing.Size(41, 59);
            this.voto1.TabIndex = 3;
            this.voto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voto1.Visible = false;
            // 
            // car4
            // 
            this.car4.Image = global::AL08PJ02.Properties.Resources.CARB;
            this.car4.Location = new System.Drawing.Point(336, 101);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(71, 96);
            this.car4.TabIndex = 2;
            this.car4.TabStop = false;
            this.car4.Click += new System.EventHandler(this.car4_Click);
            // 
            // car3
            // 
            this.car3.Image = global::AL08PJ02.Properties.Resources.CARB;
            this.car3.Location = new System.Drawing.Point(259, 101);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(71, 96);
            this.car3.TabIndex = 2;
            this.car3.TabStop = false;
            this.car3.Click += new System.EventHandler(this.car3_Click);
            // 
            // car1
            // 
            this.car1.Image = global::AL08PJ02.Properties.Resources.CARB;
            this.car1.Location = new System.Drawing.Point(105, 101);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(71, 96);
            this.car1.TabIndex = 2;
            this.car1.TabStop = false;
            this.car1.Click += new System.EventHandler(this.car1_Click);
            // 
            // car2
            // 
            this.car2.Image = global::AL08PJ02.Properties.Resources.CARB;
            this.car2.Location = new System.Drawing.Point(182, 101);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(71, 96);
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            this.car2.Click += new System.EventHandler(this.car2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(484, 58);
            this.label9.TabIndex = 1;
            this.label9.Text = "SELECIONE UMA DAS CARTAS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.Black;
            this.panelSombra.BackgroundImage = global::AL08PJ02.Properties.Resources.PANSOM;
            this.panelSombra.Enabled = false;
            this.panelSombra.Location = new System.Drawing.Point(164, 192);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(512, 256);
            this.panelSombra.TabIndex = 11;
            this.panelSombra.Visible = false;
            // 
            // voltar
            // 
            this.voltar.BackgroundImage = global::AL08PJ02.Resources.SETA;
            this.voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltar.Image = global::AL08PJ02.Properties.Resources.SETAAC;
            this.voltar.Location = new System.Drawing.Point(24, 28);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(48, 48);
            this.voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voltar.TabIndex = 5;
            this.voltar.TabStop = false;
            this.voltar.Click += new System.EventHandler(this.pictureBox5_Click);
            this.voltar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.voltar_MouseDown);
            this.voltar.MouseEnter += new System.EventHandler(this.voltar_MouseEnter);
            this.voltar.MouseLeave += new System.EventHandler(this.voltar_MouseLeave);
            this.voltar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.voltar_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::AL08PJ02.Properties.Resources.ALTER;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(15, 471);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::AL08PJ02.Properties.Resources.ALTER;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(15, 357);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AL08PJ02.Properties.Resources.ALTER;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AL08PJ02.Properties.Resources.ALTER;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Pergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.carregar);
            this.Controls.Add(this.btnPlacas);
            this.Controls.Add(this.btnCartas);
            this.Controls.Add(this.btnUniversitario);
            this.Controls.Add(this.btnPula);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblAltD);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblAltC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAltB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAltA);
            this.Controls.Add(this.bkgAjuda);
            this.Controls.Add(this.bkgResp);
            this.Controls.Add(this.lblCerto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Pergunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pergunta_FormClosing);
            this.Load += new System.EventHandler(this.Pergunta_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1Back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label bkgResp;
        private Label bkgAjuda;
        private Label lblCerto;
        private Label lblPergunta;
        private Label lblAltA;
        private PictureBox pictureBox1;
        private Label lblAltB;
        private PictureBox pictureBox2;
        private Label lblAltC;
        private PictureBox pictureBox3;
        private Label lblAltD;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox voltar;
        private Panel panel1;
        private Label label5;
        private Button btnContinua;
        private Panel panel2;
        private Button btnErrou;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Label carregar;
        private Label label8;
        private Label btnPula;
        private Label btnUniversitario;
        private Label btnCartas;
        private Label btnPlacas;
        private Panel panel3;
        private Label label9;
        private PictureBox car2;
        private PictureBox car4;
        private PictureBox car3;
        private PictureBox car1;
        private Label voto4;
        private Label voto3;
        private Label voto2;
        private Label voto1;
        private Panel panelSombra;
        private PictureBox textBox1Back;
    }
}