
namespace BessyMartinez
{
    partial class FormularioNumeros
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
            this.resultadosListBox = new System.Windows.Forms.ListBox();
            this.mostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultadosListBox
            // 
            this.resultadosListBox.FormattingEnabled = true;
            this.resultadosListBox.Location = new System.Drawing.Point(45, 131);
            this.resultadosListBox.Name = "resultadosListBox";
            this.resultadosListBox.Size = new System.Drawing.Size(252, 264);
            this.resultadosListBox.TabIndex = 0;
            // 
            // mostrarButton
            // 
            this.mostrarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarButton.Location = new System.Drawing.Point(319, 151);
            this.mostrarButton.Name = "mostrarButton";
            this.mostrarButton.Size = new System.Drawing.Size(101, 45);
            this.mostrarButton.TabIndex = 1;
            this.mostrarButton.Text = "MOSTRAR";
            this.mostrarButton.UseVisualStyleBackColor = true;
            this.mostrarButton.Click += new System.EventHandler(this.mostrarButton_Click);
            // 
            // FormularioNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.mostrarButton);
            this.Controls.Add(this.resultadosListBox);
            this.Name = "FormularioNumeros";
            this.Text = "FormularioNumeros";
            this.Load += new System.EventHandler(this.FormularioNumeros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultadosListBox;
        private System.Windows.Forms.Button mostrarButton;
    }
}