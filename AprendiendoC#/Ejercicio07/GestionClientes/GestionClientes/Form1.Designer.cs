namespace GestionClientes
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(47, 172);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(214, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sessión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(47, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(47, 79);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(214, 23);
            txtUser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 26);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 3;
            label1.Text = "Gestion de Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 231);
            label2.Name = "label2";
            label2.Size = new Size(201, 15);
            label2.TabIndex = 4;
            label2.Text = "Creado por GestionEmpresarial S.A.C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 294);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
    }
}