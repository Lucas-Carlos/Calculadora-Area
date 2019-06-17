namespace Triangulos
{
    partial class Form1
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
            this.lblPerim = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerim = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.rdbEsc = new System.Windows.Forms.RadioButton();
            this.rdbIso = new System.Windows.Forms.RadioButton();
            this.rdbEqui = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblPerim
            // 
            this.lblPerim.AutoSize = true;
            this.lblPerim.Location = new System.Drawing.Point(181, 137);
            this.lblPerim.Name = "lblPerim";
            this.lblPerim.Size = new System.Drawing.Size(53, 13);
            this.lblPerim.TabIndex = 27;
            this.lblPerim.Text = "Perímetro";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(202, 112);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 26;
            this.lblArea.Text = "Área";
            // 
            // txtPerim
            // 
            this.txtPerim.Enabled = false;
            this.txtPerim.Location = new System.Drawing.Point(240, 133);
            this.txtPerim.Name = "txtPerim";
            this.txtPerim.Size = new System.Drawing.Size(100, 20);
            this.txtPerim.TabIndex = 25;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(240, 109);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 24;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(181, 158);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(159, 23);
            this.btnCalcula.TabIndex = 23;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(11, 166);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(40, 13);
            this.lblLado3.TabIndex = 22;
            this.lblLado3.Text = "Lado 3";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(11, 141);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(40, 13);
            this.lblLado2.TabIndex = 21;
            this.lblLado2.Text = "Lado 2";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(11, 118);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(40, 13);
            this.lblLado1.TabIndex = 20;
            this.lblLado1.Text = "Lado 1";
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(57, 161);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 19;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(57, 135);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 18;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(57, 109);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 17;
            // 
            // rdbEsc
            // 
            this.rdbEsc.AutoSize = true;
            this.rdbEsc.Location = new System.Drawing.Point(9, 63);
            this.rdbEsc.Name = "rdbEsc";
            this.rdbEsc.Size = new System.Drawing.Size(69, 17);
            this.rdbEsc.TabIndex = 16;
            this.rdbEsc.TabStop = true;
            this.rdbEsc.Text = "Escaleno";
            this.rdbEsc.UseVisualStyleBackColor = true;
            this.rdbEsc.CheckedChanged += new System.EventHandler(this.rdbEsc_CheckedChanged);
            // 
            // rdbIso
            // 
            this.rdbIso.AutoSize = true;
            this.rdbIso.Location = new System.Drawing.Point(9, 38);
            this.rdbIso.Name = "rdbIso";
            this.rdbIso.Size = new System.Drawing.Size(64, 17);
            this.rdbIso.TabIndex = 15;
            this.rdbIso.TabStop = true;
            this.rdbIso.Text = "Isóceles";
            this.rdbIso.UseVisualStyleBackColor = true;
            this.rdbIso.CheckedChanged += new System.EventHandler(this.rdbIso_CheckedChanged);
            // 
            // rdbEqui
            // 
            this.rdbEqui.AutoSize = true;
            this.rdbEqui.Location = new System.Drawing.Point(9, 15);
            this.rdbEqui.Name = "rdbEqui";
            this.rdbEqui.Size = new System.Drawing.Size(72, 17);
            this.rdbEqui.TabIndex = 14;
            this.rdbEqui.TabStop = true;
            this.rdbEqui.Text = "Equilátero";
            this.rdbEqui.UseVisualStyleBackColor = true;
            this.rdbEqui.CheckedChanged += new System.EventHandler(this.rdbEqui_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 226);
            this.Controls.Add(this.lblPerim);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtPerim);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.rdbEsc);
            this.Controls.Add(this.rdbIso);
            this.Controls.Add(this.rdbEqui);
            this.Name = "Form1";
            this.Text = "Calcular área e perímetro de um triângulo ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerim;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerim;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.RadioButton rdbEsc;
        private System.Windows.Forms.RadioButton rdbIso;
        private System.Windows.Forms.RadioButton rdbEqui;
    }
}

