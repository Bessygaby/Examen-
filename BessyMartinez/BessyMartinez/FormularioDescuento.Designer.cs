
namespace BessyMartinez
{
    partial class FormularioDescuento
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
            this.label1 = new System.Windows.Forms.Label();
            this.listaProductosListBox = new System.Windows.Forms.ListBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DEL PRODUCTO";
            // 
            // listaProductosListBox
            // 
            this.listaProductosListBox.FormattingEnabled = true;
            this.listaProductosListBox.Location = new System.Drawing.Point(30, 167);
            this.listaProductosListBox.Name = "listaProductosListBox";
            this.listaProductosListBox.Size = new System.Drawing.Size(263, 238);
            this.listaProductosListBox.TabIndex = 1;
            this.listaProductosListBox.SelectedIndexChanged += new System.EventHandler(this.listaProductosListBox_SelectedIndexChanged);
            // 
            // calcularButton
            // 
            this.calcularButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(322, 350);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(118, 37);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "CALCULAR";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRECIO UNITARIO";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(27, 99);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(64, 22);
            this.resultadoLabel.TabIndex = 4;
            this.resultadoLabel.Text = "TOTAL";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(322, 225);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(118, 37);
            this.agregarButton.TabIndex = 5;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // productoTextBox
            // 
            this.productoTextBox.Location = new System.Drawing.Point(262, 23);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(178, 20);
            this.productoTextBox.TabIndex = 6;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(262, 63);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(178, 20);
            this.precioTextBox.TabIndex = 7;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(262, 101);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(178, 20);
            this.totalTextBox.TabIndex = 8;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.Location = new System.Drawing.Point(322, 288);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(118, 37);
            this.eliminarButton.TabIndex = 9;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // FormularioDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.listaProductosListBox);
            this.Controls.Add(this.label1);
            this.Name = "FormularioDescuento";
            this.Text = "FormularioDescuento";
            this.Load += new System.EventHandler(this.FormularioDescuento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaProductosListBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button eliminarButton;
    }
}