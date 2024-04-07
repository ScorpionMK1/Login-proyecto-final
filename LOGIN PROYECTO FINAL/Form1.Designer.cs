namespace LOGIN_PROYECTO_FINAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lnkOlvidarContraseña = new LinkLabel();
            btnCrearCuenta = new Button();
            btnAcceder = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(193, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(115, 113);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(220, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(115, 170);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(220, 23);
            txtContraseña.TabIndex = 2;
            // 
            // lnkOlvidarContraseña
            // 
            lnkOlvidarContraseña.AutoSize = true;
            lnkOlvidarContraseña.ForeColor = SystemColors.ButtonHighlight;
            lnkOlvidarContraseña.LinkColor = Color.White;
            lnkOlvidarContraseña.Location = new Point(151, 329);
            lnkOlvidarContraseña.Name = "lnkOlvidarContraseña";
            lnkOlvidarContraseña.Size = new Size(159, 15);
            lnkOlvidarContraseña.TabIndex = 3;
            lnkOlvidarContraseña.TabStop = true;
            lnkOlvidarContraseña.Text = "¿Has olvidado la contraseña?";
            lnkOlvidarContraseña.MouseClick += lnkOlvidarContraseña_MouseClick;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(115, 222);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(93, 46);
            btnCrearCuenta.TabIndex = 6;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(242, 222);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(93, 46);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(115, 152);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(115, 95);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "USUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 288);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(453, 367);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btnAcceder);
            Controls.Add(btnCrearCuenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lnkOlvidarContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private LinkLabel lnkOlvidarContraseña;
        private Button btnCrearCuenta;
        private Button btnAcceder;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
