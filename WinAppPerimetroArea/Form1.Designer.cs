namespace WinAppPerimetroArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelHipotenusa = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelRespuesta2 = new System.Windows.Forms.Label();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxHipotenusa = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelPerimetro = new System.Windows.Forms.Label();
            this.labelRespuesta1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(92, 36);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(433, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Perímetro y Área de un triángulo";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBase.Location = new System.Drawing.Point(51, 111);
            this.labelBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(87, 26);
            this.labelBase.TabIndex = 1;
            this.labelBase.Text = "Base= ";
            // 
            // labelHipotenusa
            // 
            this.labelHipotenusa.AutoSize = true;
            this.labelHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHipotenusa.Location = new System.Drawing.Point(51, 174);
            this.labelHipotenusa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHipotenusa.Name = "labelHipotenusa";
            this.labelHipotenusa.Size = new System.Drawing.Size(153, 26);
            this.labelHipotenusa.TabIndex = 2;
            this.labelHipotenusa.Text = "Hipotenusa= ";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(494, 230);
            this.labelArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(62, 26);
            this.labelArea.TabIndex = 3;
            this.labelArea.Text = "Área";
            // 
            // labelRespuesta2
            // 
            this.labelRespuesta2.AutoSize = true;
            this.labelRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta2.Location = new System.Drawing.Point(500, 267);
            this.labelRespuesta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRespuesta2.Name = "labelRespuesta2";
            this.labelRespuesta2.Size = new System.Drawing.Size(54, 26);
            this.labelRespuesta2.TabIndex = 4;
            this.labelRespuesta2.Text = "0,00";
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(201, 119);
            this.textBoxBase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(76, 20);
            this.textBoxBase.TabIndex = 5;
            this.textBoxBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBase_KeyPress);
            // 
            // textBoxHipotenusa
            // 
            this.textBoxHipotenusa.Location = new System.Drawing.Point(201, 182);
            this.textBoxHipotenusa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHipotenusa.Name = "textBoxHipotenusa";
            this.textBoxHipotenusa.Size = new System.Drawing.Size(76, 20);
            this.textBoxHipotenusa.TabIndex = 6;
            this.textBoxHipotenusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHipotenusa_KeyPress);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(235)))));
            this.buttonCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(130, 242);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(92, 45);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelPerimetro
            // 
            this.labelPerimetro.AutoSize = true;
            this.labelPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerimetro.Location = new System.Drawing.Point(326, 230);
            this.labelPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPerimetro.Name = "labelPerimetro";
            this.labelPerimetro.Size = new System.Drawing.Size(116, 26);
            this.labelPerimetro.TabIndex = 8;
            this.labelPerimetro.Text = "Perímetro";
            // 
            // labelRespuesta1
            // 
            this.labelRespuesta1.AutoSize = true;
            this.labelRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta1.Location = new System.Drawing.Point(354, 268);
            this.labelRespuesta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRespuesta1.Name = "labelRespuesta1";
            this.labelRespuesta1.Size = new System.Drawing.Size(54, 26);
            this.labelRespuesta1.TabIndex = 9;
            this.labelRespuesta1.Text = "0,00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppPerimetroArea.Properties.Resources.triangulo_rectangulo;
            this.pictureBox1.Location = new System.Drawing.Point(349, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRespuesta1);
            this.Controls.Add(this.labelPerimetro);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxHipotenusa);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.labelRespuesta2);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelHipotenusa);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Perímetro y área de un rectángulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelHipotenusa;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelRespuesta2;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxHipotenusa;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelPerimetro;
        private System.Windows.Forms.Label labelRespuesta1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

