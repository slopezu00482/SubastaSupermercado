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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbRol = new ComboBox();
            txtNombreUsuario = new TextBox();
            txtOferta = new TextBox();
            btnOfertar = new Button();
            lstSubastas = new ListBox();
            lblInfo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Oferta";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(184, 81);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(290, 28);
            cmbRol.TabIndex = 3;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged_1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(184, 155);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(290, 27);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtOferta
            // 
            txtOferta.Location = new Point(184, 227);
            txtOferta.Name = "txtOferta";
            txtOferta.Size = new Size(290, 27);
            txtOferta.TabIndex = 5;
            // 
            // btnOfertar
            // 
            btnOfertar.Location = new Point(111, 310);
            btnOfertar.Name = "btnOfertar";
            btnOfertar.Size = new Size(193, 54);
            btnOfertar.TabIndex = 6;
            btnOfertar.Text = "OFERTAR";
            btnOfertar.UseVisualStyleBackColor = true;
            btnOfertar.Click += btnOfertar_Click;
            // 
            // lstSubastas
            // 
            lstSubastas.FormattingEnabled = true;
            lstSubastas.Location = new Point(611, 68);
            lstSubastas.Name = "lstSubastas";
            lstSubastas.Size = new Size(588, 304);
            lstSubastas.TabIndex = 7;
            lstSubastas.SelectedIndexChanged += lstSubastas_SelectedIndexChanged;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(611, 411);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(35, 20);
            lblInfo.TabIndex = 8;
            lblInfo.Text = "Info";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 540);
            Controls.Add(lblInfo);
            Controls.Add(lstSubastas);
            Controls.Add(btnOfertar);
            Controls.Add(txtOferta);
            Controls.Add(txtNombreUsuario);
            Controls.Add(cmbRol);
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
        private ComboBox cmbRol;
        private TextBox txtNombreUsuario;
        private TextBox txtOferta;
        private Button btnOfertar;
        private ListBox lstSubastas;
        private Label lblInfo;
        private System.Windows.Forms.Timer timer1;
    }
}
