
namespace BessyMartinez
{
    partial class FormularioInteres
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
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaDepositoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calcularButton = new System.Windows.Forms.Button();
            this.resultadosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital a depositar";
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Location = new System.Drawing.Point(195, 39);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(200, 20);
            this.capitalTextBox.TabIndex = 1;
            this.capitalTextBox.TextChanged += new System.EventHandler(this.capitalTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de depósito";
            // 
            // fechaDepositoDateTimePicker
            // 
            this.fechaDepositoDateTimePicker.Location = new System.Drawing.Point(195, 76);
            this.fechaDepositoDateTimePicker.Name = "fechaDepositoDateTimePicker";
            this.fechaDepositoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDepositoDateTimePicker.TabIndex = 3;
            // 
            // calcularButton
            // 
            this.calcularButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(129, 122);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(133, 38);
            this.calcularButton.TabIndex = 4;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // resultadosListBox
            // 
            this.resultadosListBox.FormattingEnabled = true;
            this.resultadosListBox.Location = new System.Drawing.Point(38, 186);
            this.resultadosListBox.Name = "resultadosListBox";
            this.resultadosListBox.Size = new System.Drawing.Size(327, 264);
            this.resultadosListBox.TabIndex = 5;
            // 
            // FormularioInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 479);
            this.Controls.Add(this.resultadosListBox);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.fechaDepositoDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capitalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormularioInteres";
            this.Text = "Formulario de Interes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaDepositoDateTimePicker;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.ListBox resultadosListBox;
    }
}

