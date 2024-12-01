namespace Practica_Telegrama_ARSDAW2425
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.radioBtnOrdinario = new System.Windows.Forms.RadioButton();
            this.radioBtnUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(94, 64);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(397, 113);
            this.txtTelegrama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(137, 243);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(356, 198);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(135, 45);
            this.btnCalcularPrecio.TabIndex = 5;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // radioBtnOrdinario
            // 
            this.radioBtnOrdinario.AutoSize = true;
            this.radioBtnOrdinario.Checked = true;
            this.radioBtnOrdinario.Location = new System.Drawing.Point(113, 198);
            this.radioBtnOrdinario.Name = "radioBtnOrdinario";
            this.radioBtnOrdinario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioBtnOrdinario.Size = new System.Drawing.Size(67, 17);
            this.radioBtnOrdinario.TabIndex = 6;
            this.radioBtnOrdinario.TabStop = true;
            this.radioBtnOrdinario.Tag = "";
            this.radioBtnOrdinario.Text = "Ordinario";
            this.radioBtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioBtnUrgente
            // 
            this.radioBtnUrgente.AutoSize = true;
            this.radioBtnUrgente.Location = new System.Drawing.Point(186, 197);
            this.radioBtnUrgente.Name = "radioBtnUrgente";
            this.radioBtnUrgente.Size = new System.Drawing.Size(63, 17);
            this.radioBtnUrgente.TabIndex = 7;
            this.radioBtnUrgente.TabStop = true;
            this.radioBtnUrgente.Text = "Urgente";
            this.radioBtnUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBtnUrgente);
            this.Controls.Add(this.radioBtnOrdinario);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.RadioButton radioBtnOrdinario;
        private System.Windows.Forms.RadioButton radioBtnUrgente;
    }
}

