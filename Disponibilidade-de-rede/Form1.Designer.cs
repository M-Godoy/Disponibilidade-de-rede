﻿namespace Disponibilidade_de_rede
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
            this.components = new System.ComponentModel.Container();
            this.btnligar = new System.Windows.Forms.Button();
            this.monitoramento = new System.Windows.Forms.Timer(this.components);
            this.lblstatussistema = new System.Windows.Forms.Label();
            this.btndesligar = new System.Windows.Forms.Button();
            this.lblstatusrede = new System.Windows.Forms.Label();
            this.lblstatusmonitoramento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnligar
            // 
            this.btnligar.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnligar.Location = new System.Drawing.Point(147, 149);
            this.btnligar.Name = "btnligar";
            this.btnligar.Size = new System.Drawing.Size(131, 84);
            this.btnligar.TabIndex = 0;
            this.btnligar.Text = "Ligar Máquina";
            this.btnligar.UseVisualStyleBackColor = true;
            this.btnligar.Click += new System.EventHandler(this.button1_Click);
            // 
            // monitoramento
            // 
            this.monitoramento.Enabled = true;
            this.monitoramento.Interval = 5;
            this.monitoramento.Tick += new System.EventHandler(this.monitoramento_Tick);
            // 
            // lblstatussistema
            // 
            this.lblstatussistema.AutoSize = true;
            this.lblstatussistema.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatussistema.Location = new System.Drawing.Point(144, 66);
            this.lblstatussistema.Name = "lblstatussistema";
            this.lblstatussistema.Size = new System.Drawing.Size(118, 16);
            this.lblstatussistema.TabIndex = 1;
            this.lblstatussistema.Text = "Status de sistema:";
            this.lblstatussistema.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblstatussistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndesligar
            // 
            this.btndesligar.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesligar.Location = new System.Drawing.Point(474, 156);
            this.btndesligar.Name = "btndesligar";
            this.btndesligar.Size = new System.Drawing.Size(129, 77);
            this.btndesligar.TabIndex = 2;
            this.btndesligar.Text = "Desligar Máquina";
            this.btndesligar.UseVisualStyleBackColor = true;
            this.btndesligar.Click += new System.EventHandler(this.btndesligar_Click);
            // 
            // lblstatusrede
            // 
            this.lblstatusrede.AutoSize = true;
            this.lblstatusrede.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatusrede.Location = new System.Drawing.Point(155, 359);
            this.lblstatusrede.Name = "lblstatusrede";
            this.lblstatusrede.Size = new System.Drawing.Size(103, 16);
            this.lblstatusrede.TabIndex = 3;
            this.lblstatusrede.Text = "Status de rede: ";
            this.lblstatusrede.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblstatusmonitoramento
            // 
            this.lblstatusmonitoramento.AutoSize = true;
            this.lblstatusmonitoramento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblstatusmonitoramento.Location = new System.Drawing.Point(317, 68);
            this.lblstatusmonitoramento.Name = "lblstatusmonitoramento";
            this.lblstatusmonitoramento.Size = new System.Drawing.Size(0, 13);
            this.lblstatusmonitoramento.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblstatusmonitoramento);
            this.Controls.Add(this.lblstatusrede);
            this.Controls.Add(this.btndesligar);
            this.Controls.Add(this.lblstatussistema);
            this.Controls.Add(this.btnligar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnligar;
        private System.Windows.Forms.Timer monitoramento;
        private System.Windows.Forms.Label lblstatussistema;
        private System.Windows.Forms.Button btndesligar;
        private System.Windows.Forms.Label lblstatusrede;
        private System.Windows.Forms.Label lblstatusmonitoramento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

