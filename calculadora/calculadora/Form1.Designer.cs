namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(174, 54);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(48, 23);
            this.suma.TabIndex = 0;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(174, 86);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(48, 23);
            this.resta.TabIndex = 1;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(174, 115);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(48, 23);
            this.multi.TabIndex = 2;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(174, 144);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(48, 23);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(34, 54);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(100, 20);
            this.pantalla.TabIndex = 4;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(34, 86);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(34, 23);
            this.B1.TabIndex = 5;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(34, 115);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(34, 23);
            this.B4.TabIndex = 6;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(74, 115);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(34, 23);
            this.B5.TabIndex = 7;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(114, 86);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(34, 23);
            this.B3.TabIndex = 8;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(74, 86);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(34, 23);
            this.B2.TabIndex = 9;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // punto
            // 
            this.punto.Location = new System.Drawing.Point(34, 173);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(34, 23);
            this.punto.TabIndex = 10;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(34, 144);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(34, 23);
            this.B7.TabIndex = 11;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(114, 115);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(34, 23);
            this.B6.TabIndex = 12;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(114, 144);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(34, 23);
            this.B9.TabIndex = 13;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(174, 172);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(48, 23);
            this.igual.TabIndex = 14;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // B0
            // 
            this.B0.Location = new System.Drawing.Point(74, 172);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(34, 23);
            this.B0.TabIndex = 15;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.button15_Click);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(74, 143);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(34, 23);
            this.B8.TabIndex = 16;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(114, 172);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(35, 23);
            this.borrar.TabIndex = 17;
            this.borrar.Text = "AC";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 261);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Name = "Form1";
            this.Text = "calculadora ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button borrar;
    }
}

