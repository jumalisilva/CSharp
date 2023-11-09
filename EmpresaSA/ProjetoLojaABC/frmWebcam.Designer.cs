
namespace ProjetoLojaABC
{
    partial class frmWebCam
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
            this.pctCapturaImagem = new System.Windows.Forms.PictureBox();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cbbDispositivo = new System.Windows.Forms.ComboBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.sfdSalvarImagem = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCapturaImagem
            // 
            this.pctCapturaImagem.Location = new System.Drawing.Point(115, 40);
            this.pctCapturaImagem.Name = "pctCapturaImagem";
            this.pctCapturaImagem.Size = new System.Drawing.Size(353, 273);
            this.pctCapturaImagem.TabIndex = 0;
            this.pctCapturaImagem.TabStop = false;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivo.Location = new System.Drawing.Point(111, 342);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(85, 20);
            this.lblDispositivo.TabIndex = 3;
            this.lblDispositivo.Text = "Dispositivo";
            // 
            // cbbDispositivo
            // 
            this.cbbDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDispositivo.FormattingEnabled = true;
            this.cbbDispositivo.Items.AddRange(new object[] {
            "Computador",
            "Notebook"});
            this.cbbDispositivo.Location = new System.Drawing.Point(115, 375);
            this.cbbDispositivo.Name = "cbbDispositivo";
            this.cbbDispositivo.Size = new System.Drawing.Size(200, 24);
            this.cbbDispositivo.TabIndex = 4;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.Location = new System.Drawing.Point(539, 40);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(175, 48);
            this.btnCaptura.TabIndex = 5;
            this.btnCaptura.Text = "Captura";
            this.btnCaptura.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(539, 149);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(175, 48);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(539, 265);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(175, 48);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.cbbDispositivo);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.pctCapturaImagem);
            this.Name = "frmWebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCapturaImagem;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cbbDispositivo;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.SaveFileDialog sfdSalvarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}