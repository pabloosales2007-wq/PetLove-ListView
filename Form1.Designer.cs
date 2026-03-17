namespace PetLove_ListView
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
            this.btnObterDados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvDados = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObterDados
            // 
            this.btnObterDados.BackColor = System.Drawing.Color.Maroon;
            this.btnObterDados.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnObterDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObterDados.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterDados.ForeColor = System.Drawing.Color.White;
            this.btnObterDados.Location = new System.Drawing.Point(353, 376);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(145, 49);
            this.btnObterDados.TabIndex = 1;
            this.btnObterDados.Text = "Extrair Dados";
            this.btnObterDados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObterDados.UseVisualStyleBackColor = false;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = global::PetLove_ListView.Properties.Resources.text_snippet_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.Location = new System.Drawing.Point(464, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lvDados
            // 
            this.lvDados.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDados.ForeColor = System.Drawing.Color.White;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(91, 59);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(687, 287);
            this.lvDados.TabIndex = 0;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(876, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnObterDados);
            this.Controls.Add(this.lvDados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvDados;
    }
}

