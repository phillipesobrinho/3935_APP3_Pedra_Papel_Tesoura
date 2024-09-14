namespace _3935_APP3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_pedra = new System.Windows.Forms.RadioButton();
            this.rbt_papel = new System.Windows.Forms.RadioButton();
            this.rbt_tesoura = new System.Windows.Forms.RadioButton();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.lbl_jogador = new System.Windows.Forms.Label();
            this.lbl_computador = new System.Windows.Forms.Label();
            this.lbl_escolha_jogador = new System.Windows.Forms.Label();
            this.lbl_escolha_computador = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedra, Papel, Tesoura";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_3935_APP3.Properties.Resources.tesoura;
            this.pictureBox3.Location = new System.Drawing.Point(16, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_3935_APP3.Properties.Resources.papel;
            this.pictureBox2.Location = new System.Drawing.Point(16, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3935_APP3.Properties.Resources.pedra;
            this.pictureBox1.Location = new System.Drawing.Point(16, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_computador);
            this.groupBox2.Controls.Add(this.lbl_jogador);
            this.groupBox2.Controls.Add(this.btn_jogar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(131, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computador";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_resultado);
            this.groupBox3.Controls.Add(this.lbl_escolha_computador);
            this.groupBox3.Controls.Add(this.lbl_escolha_jogador);
            this.groupBox3.Controls.Add(this.rbt_tesoura);
            this.groupBox3.Controls.Add(this.rbt_papel);
            this.groupBox3.Controls.Add(this.rbt_pedra);
            this.groupBox3.Location = new System.Drawing.Point(132, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 166);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // rbt_pedra
            // 
            this.rbt_pedra.AutoSize = true;
            this.rbt_pedra.Location = new System.Drawing.Point(21, 35);
            this.rbt_pedra.Name = "rbt_pedra";
            this.rbt_pedra.Size = new System.Drawing.Size(53, 17);
            this.rbt_pedra.TabIndex = 0;
            this.rbt_pedra.TabStop = true;
            this.rbt_pedra.Text = "Pedra";
            this.rbt_pedra.UseVisualStyleBackColor = true;
            this.rbt_pedra.CheckedChanged += new System.EventHandler(this.rbt_pedra_CheckedChanged);
            // 
            // rbt_papel
            // 
            this.rbt_papel.AutoSize = true;
            this.rbt_papel.Location = new System.Drawing.Point(21, 76);
            this.rbt_papel.Name = "rbt_papel";
            this.rbt_papel.Size = new System.Drawing.Size(52, 17);
            this.rbt_papel.TabIndex = 1;
            this.rbt_papel.TabStop = true;
            this.rbt_papel.Text = "Papel";
            this.rbt_papel.UseVisualStyleBackColor = true;
            this.rbt_papel.CheckedChanged += new System.EventHandler(this.rbt_papel_CheckedChanged);
            // 
            // rbt_tesoura
            // 
            this.rbt_tesoura.AutoSize = true;
            this.rbt_tesoura.Location = new System.Drawing.Point(21, 116);
            this.rbt_tesoura.Name = "rbt_tesoura";
            this.rbt_tesoura.Size = new System.Drawing.Size(64, 17);
            this.rbt_tesoura.TabIndex = 2;
            this.rbt_tesoura.TabStop = true;
            this.rbt_tesoura.Text = "Tesoura";
            this.rbt_tesoura.UseVisualStyleBackColor = true;
            this.rbt_tesoura.CheckedChanged += new System.EventHandler(this.rbt_tesoura_CheckedChanged);
            // 
            // btn_jogar
            // 
            this.btn_jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.ForeColor = System.Drawing.Color.Green;
            this.btn_jogar.Location = new System.Drawing.Point(252, 23);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(188, 47);
            this.btn_jogar.TabIndex = 2;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = true;
            this.btn_jogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_jogador.Location = new System.Drawing.Point(9, 38);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(42, 23);
            this.lbl_jogador.TabIndex = 3;
            this.lbl_jogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_computador
            // 
            this.lbl_computador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_computador.Location = new System.Drawing.Point(70, 38);
            this.lbl_computador.Name = "lbl_computador";
            this.lbl_computador.Size = new System.Drawing.Size(42, 23);
            this.lbl_computador.TabIndex = 4;
            this.lbl_computador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_escolha_jogador
            // 
            this.lbl_escolha_jogador.AutoSize = true;
            this.lbl_escolha_jogador.Location = new System.Drawing.Point(212, 35);
            this.lbl_escolha_jogador.Name = "lbl_escolha_jogador";
            this.lbl_escolha_jogador.Size = new System.Drawing.Size(10, 13);
            this.lbl_escolha_jogador.TabIndex = 3;
            this.lbl_escolha_jogador.Text = "-";
            // 
            // lbl_escolha_computador
            // 
            this.lbl_escolha_computador.AutoSize = true;
            this.lbl_escolha_computador.Location = new System.Drawing.Point(212, 76);
            this.lbl_escolha_computador.Name = "lbl_escolha_computador";
            this.lbl_escolha_computador.Size = new System.Drawing.Size(10, 13);
            this.lbl_escolha_computador.TabIndex = 4;
            this.lbl_escolha_computador.Text = "-";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(212, 116);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(10, 13);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "-";
            // 
            // btn_reset
            // 
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_reset.Location = new System.Drawing.Point(387, 15);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(184, 29);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 393);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, Papel, Tesoura.";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbt_tesoura;
        private System.Windows.Forms.RadioButton rbt_papel;
        private System.Windows.Forms.RadioButton rbt_pedra;
        private System.Windows.Forms.Label lbl_jogador;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Label lbl_computador;
        private System.Windows.Forms.Label lbl_escolha_jogador;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_escolha_computador;
        private System.Windows.Forms.Button btn_reset;
    }
}

