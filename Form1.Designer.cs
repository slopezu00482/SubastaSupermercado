namespace SubastaSupermercado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtOferta = new TextBox();
            cmbTipoDeUsuario = new ComboBox();
            lstInventario = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Valor de Oferta";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtOferta
            // 
            txtOferta.Location = new Point(194, 180);
            txtOferta.Name = "txtOferta";
            txtOferta.Size = new Size(179, 27);
            txtOferta.TabIndex = 4;
            // 
            // cmbTipoDeUsuario
            // 
            cmbTipoDeUsuario.FormattingEnabled = true;
            cmbTipoDeUsuario.Location = new Point(194, 38);
            cmbTipoDeUsuario.Name = "cmbTipoDeUsuario";
            cmbTipoDeUsuario.Size = new Size(179, 28);
            cmbTipoDeUsuario.TabIndex = 5;
            // 
            // lstInventario
            // 
            lstInventario.FormattingEnabled = true;
            lstInventario.Location = new Point(549, 38);
            lstInventario.Name = "lstInventario";
            lstInventario.Size = new Size(599, 204);
            lstInventario.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 540);
            Controls.Add(lstInventario);
            Controls.Add(cmbTipoDeUsuario);
            Controls.Add(txtOferta);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtOferta;
        private ComboBox cmbTipoDeUsuario;
        private ListBox lstInventario;
    }
}
