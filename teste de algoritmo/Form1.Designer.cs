﻿namespace teste_de_algoritmo
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
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(149, 68);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(59, 16);
            this.n1.TabIndex = 0;
            this.n1.Text = " Numeros";
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(209, 68);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(59, 16);
            this.n2.TabIndex = 1;
            this.n2.Text = " Numeros";
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(269, 68);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(59, 16);
            this.n3.TabIndex = 2;
            this.n3.Text = " Numeros";
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(329, 68);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(59, 16);
            this.n4.TabIndex = 3;
            this.n4.Text = " Numeros";
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(389, 68);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(59, 16);
            this.n5.TabIndex = 4;
            this.n5.Text = " Numeros";
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(158, 111);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(50, 16);
            this.e1.TabIndex = 6;
            this.e1.Text = "Estrelas";
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(218, 111);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(50, 16);
            this.e2.TabIndex = 7;
            this.e2.Text = "Estrelas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sorteio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Button button1;
    }
}

