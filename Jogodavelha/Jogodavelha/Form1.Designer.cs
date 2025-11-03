namespace Jogodavelha
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            buttonIniciar = new Button();
            groupBoxJogadores = new GroupBox();
            groupBoxPlacar = new GroupBox();
            groupBoxEmpate = new GroupBox();
            groupBoxOpcoes = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            jogadorUm = new TextBox();
            jogadorDois = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBoxJogadores.SuspendLayout();
            groupBoxPlacar.SuspendLayout();
            groupBoxEmpate.SuspendLayout();
            groupBoxOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(-3, 229);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(809, 254);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonIniciar
            // 
            buttonIniciar.BackColor = Color.White;
            buttonIniciar.FlatStyle = FlatStyle.Popup;
            buttonIniciar.Location = new Point(377, 181);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(132, 42);
            buttonIniciar.TabIndex = 7;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = false;
            // 
            // groupBoxJogadores
            // 
            groupBoxJogadores.Controls.Add(jogadorDois);
            groupBoxJogadores.Controls.Add(jogadorUm);
            groupBoxJogadores.Font = new Font("SansSerif", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            groupBoxJogadores.Location = new Point(8, 12);
            groupBoxJogadores.Name = "groupBoxJogadores";
            groupBoxJogadores.Size = new Size(257, 113);
            groupBoxJogadores.TabIndex = 8;
            groupBoxJogadores.TabStop = false;
            groupBoxJogadores.Text = "Jogadores";
            // 
            // groupBoxPlacar
            // 
            groupBoxPlacar.Controls.Add(label2);
            groupBoxPlacar.Controls.Add(label1);
            groupBoxPlacar.Font = new Font("SansSerif", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            groupBoxPlacar.Location = new Point(271, 12);
            groupBoxPlacar.Name = "groupBoxPlacar";
            groupBoxPlacar.Size = new Size(257, 113);
            groupBoxPlacar.TabIndex = 9;
            groupBoxPlacar.TabStop = false;
            groupBoxPlacar.Text = "Placar";
            // 
            // groupBoxEmpate
            // 
            groupBoxEmpate.Controls.Add(label3);
            groupBoxEmpate.Font = new Font("SansSerif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxEmpate.Location = new Point(534, 12);
            groupBoxEmpate.Name = "groupBoxEmpate";
            groupBoxEmpate.Size = new Size(257, 113);
            groupBoxEmpate.TabIndex = 10;
            groupBoxEmpate.TabStop = false;
            groupBoxEmpate.Text = "Empate";
            // 
            // groupBoxOpcoes
            // 
            groupBoxOpcoes.Controls.Add(checkBox2);
            groupBoxOpcoes.Controls.Add(checkBox1);
            groupBoxOpcoes.Font = new Font("SansSerif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxOpcoes.Location = new Point(12, 147);
            groupBoxOpcoes.Name = "groupBoxOpcoes";
            groupBoxOpcoes.Size = new Size(172, 76);
            groupBoxOpcoes.TabIndex = 11;
            groupBoxOpcoes.TabStop = false;
            groupBoxOpcoes.Text = "Opções";
            groupBoxOpcoes.Enter += groupBox1_Enter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(16, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 49);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "X";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(91, 21);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 49);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "O";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Red;
            textBox2.Location = new Point(248, 246);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 69);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Red;
            textBox3.Location = new Point(354, 246);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 69);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Red;
            textBox4.Location = new Point(460, 246);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 69);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Red;
            textBox5.Location = new Point(460, 321);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 69);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Red;
            textBox6.Location = new Point(354, 321);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 69);
            textBox6.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Red;
            textBox8.Location = new Point(248, 396);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 69);
            textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Red;
            textBox9.Location = new Point(354, 396);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 69);
            textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Red;
            textBox10.Location = new Point(460, 395);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 69);
            textBox10.TabIndex = 19;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Red;
            textBox7.Location = new Point(248, 321);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 69);
            textBox7.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(515, 181);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 21;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(653, 181);
            button2.Name = "button2";
            button2.Size = new Size(132, 42);
            button2.TabIndex = 22;
            button2.Text = "Iniciar";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(220, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download;
            pictureBox2.Location = new Point(622, 321);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download;
            pictureBox3.Location = new Point(49, 321);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // jogadorUm
            // 
            jogadorUm.Location = new Point(7, 29);
            jogadorUm.Name = "jogadorUm";
            jogadorUm.Size = new Size(230, 30);
            jogadorUm.TabIndex = 15;
            // 
            // jogadorDois
            // 
            jogadorDois.Location = new Point(7, 65);
            jogadorDois.Name = "jogadorDois";
            jogadorDois.Size = new Size(230, 30);
            jogadorDois.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 42);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 17;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 18;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(102, 51);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 19;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 476);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(groupBoxOpcoes);
            Controls.Add(groupBoxEmpate);
            Controls.Add(groupBoxPlacar);
            Controls.Add(groupBoxJogadores);
            Controls.Add(buttonIniciar);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxJogadores.ResumeLayout(false);
            groupBoxJogadores.PerformLayout();
            groupBoxPlacar.ResumeLayout(false);
            groupBoxPlacar.PerformLayout();
            groupBoxEmpate.ResumeLayout(false);
            groupBoxEmpate.PerformLayout();
            groupBoxOpcoes.ResumeLayout(false);
            groupBoxOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private TextBox textBox1;
        private Button buttonIniciar;
        private GroupBox groupBoxJogadores;
        private GroupBox groupBoxPlacar;
        private GroupBox groupBoxEmpate;
        private GroupBox groupBoxOpcoes;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox jogadorUm;
        private TextBox jogadorDois;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}