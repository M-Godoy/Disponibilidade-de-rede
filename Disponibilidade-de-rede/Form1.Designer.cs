namespace Disponibilidade_de_rede
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
            this.lblstatus = new System.Windows.Forms.Label();
            this.btndesligar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatusmonitoramento = new System.Windows.Forms.Label();
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
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(144, 66);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(167, 16);
            this.lblstatus.TabIndex = 1;
            this.lblstatus.Text = "Status de monitoramento:";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblstatus.Click += new System.EventHandler(this.label1_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status de rede: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblstatusmonitoramento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndesligar);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnligar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnligar;
        private System.Windows.Forms.Timer monitoramento;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btndesligar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatusmonitoramento;
    }
}

