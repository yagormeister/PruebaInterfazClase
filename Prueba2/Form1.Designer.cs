
namespace Prueba2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.lbApellido2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido1 = new System.Windows.Forms.TextBox();
            this.apellido2 = new System.Windows.Forms.TextBox();
            this.cbCambiaOrden = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTitulo.Location = new System.Drawing.Point(31, 29);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.ReadOnly = true;
            this.tbTitulo.Size = new System.Drawing.Size(572, 71);
            this.tbTitulo.TabIndex = 27;
            this.tbTitulo.Text = "GESTIÓN DE NOMBRES";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(120, 128);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Location = new System.Drawing.Point(120, 178);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(60, 15);
            this.lbApellido1.TabIndex = 2;
            this.lbApellido1.Text = "Apellido 1";
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.Location = new System.Drawing.Point(120, 216);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(60, 15);
            this.lbApellido2.TabIndex = 3;
            this.lbApellido2.Text = "Apellido 2";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(194, 307);
            this.resultado.Name = "resultado";
            this.resultado.PlaceholderText = "Nombre Completo";
            this.resultado.Size = new System.Drawing.Size(220, 23);
            this.resultado.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(194, 128);
            this.nombre.Name = "nombre";
            this.nombre.PlaceholderText = "Nombre";
            this.nombre.Size = new System.Drawing.Size(220, 23);
            this.nombre.TabIndex = 1;
            this.nombre.TextChanged += new System.EventHandler(this.mostrarTextoCompleto);
            // 
            // apellido1
            // 
            this.apellido1.Location = new System.Drawing.Point(194, 170);
            this.apellido1.Name = "apellido1";
            this.apellido1.PlaceholderText = "Primer Apellido";
            this.apellido1.Size = new System.Drawing.Size(220, 23);
            this.apellido1.TabIndex = 2;
            this.apellido1.TextChanged += new System.EventHandler(this.mostrarTextoCompleto);
            // 
            // apellido2
            // 
            this.apellido2.Location = new System.Drawing.Point(194, 208);
            this.apellido2.Name = "apellido2";
            this.apellido2.PlaceholderText = "Segundo Apellido";
            this.apellido2.Size = new System.Drawing.Size(220, 23);
            this.apellido2.TabIndex = 3;
            this.apellido2.TextChanged += new System.EventHandler(this.mostrarTextoCompleto);
            // 
            // cbCambiaOrden
            // 
            this.cbCambiaOrden.AutoSize = true;
            this.cbCambiaOrden.Location = new System.Drawing.Point(194, 257);
            this.cbCambiaOrden.Name = "cbCambiaOrden";
            this.cbCambiaOrden.Size = new System.Drawing.Size(132, 19);
            this.cbCambiaOrden.TabIndex = 4;
            this.cbCambiaOrden.Text = "App1 App2 Nombre";
            this.cbCambiaOrden.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.cbCambiaOrden);
            this.Controls.Add(this.apellido2);
            this.Controls.Add(this.apellido1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.lbApellido2);
            this.Controls.Add(this.lbApellido1);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.Label lbApellido2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido1;
        private System.Windows.Forms.TextBox apellido2;
        private System.Windows.Forms.CheckBox cbCambiaOrden;
    }
}

