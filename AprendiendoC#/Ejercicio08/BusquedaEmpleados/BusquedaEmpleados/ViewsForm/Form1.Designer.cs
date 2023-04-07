namespace BusquedaEmpleados
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
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtRegistrarCuenta = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(283, 37);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Empleados";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(36, 201);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 34);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "INGRESAR AL SISTEMA";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(36, 115);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(283, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(36, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 23);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 141);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // txtRegistrarCuenta
            // 
            txtRegistrarCuenta.AutoSize = true;
            txtRegistrarCuenta.Location = new Point(36, 238);
            txtRegistrarCuenta.Name = "txtRegistrarCuenta";
            txtRegistrarCuenta.Size = new Size(96, 15);
            txtRegistrarCuenta.TabIndex = 6;
            txtRegistrarCuenta.Text = "Registrar Usuario";
            txtRegistrarCuenta.Click += txtRegistrarCuenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 335);
            Controls.Add(txtRegistrarCuenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gestión de Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label txtRegistrarCuenta;
    }
}