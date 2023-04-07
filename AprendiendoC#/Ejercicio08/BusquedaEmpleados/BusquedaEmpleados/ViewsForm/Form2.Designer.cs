namespace BusquedaEmpleados.ViewsForm
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCreateUser = new TextBox();
            txtCreatePass = new TextBox();
            txtCreatConfirmPass = new TextBox();
            txtCreateNombre = new TextBox();
            label5 = new Label();
            btnRegistroUsuario = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 74);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 125);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 6;
            label1.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 175);
            label3.Name = "label3";
            label3.Size = new Size(195, 28);
            label3.TabIndex = 7;
            label3.Text = "Confimar Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 220);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            // 
            // txtCreateUser
            // 
            txtCreateUser.Location = new Point(275, 82);
            txtCreateUser.Name = "txtCreateUser";
            txtCreateUser.Size = new Size(191, 23);
            txtCreateUser.TabIndex = 9;
            // 
            // txtCreatePass
            // 
            txtCreatePass.Location = new Point(275, 133);
            txtCreatePass.Name = "txtCreatePass";
            txtCreatePass.Size = new Size(191, 23);
            txtCreatePass.TabIndex = 10;
            // 
            // txtCreatConfirmPass
            // 
            txtCreatConfirmPass.Location = new Point(275, 180);
            txtCreatConfirmPass.Name = "txtCreatConfirmPass";
            txtCreatConfirmPass.Size = new Size(191, 23);
            txtCreatConfirmPass.TabIndex = 11;
            // 
            // txtCreateNombre
            // 
            txtCreateNombre.Location = new Point(275, 228);
            txtCreateNombre.Name = "txtCreateNombre";
            txtCreateNombre.Size = new Size(191, 23);
            txtCreateNombre.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(105, 21);
            label5.Name = "label5";
            label5.Size = new Size(289, 37);
            label5.TabIndex = 13;
            label5.Text = "Registro de Empleados";
            // 
            // btnRegistroUsuario
            // 
            btnRegistroUsuario.Location = new Point(27, 290);
            btnRegistroUsuario.Name = "btnRegistroUsuario";
            btnRegistroUsuario.Size = new Size(439, 40);
            btnRegistroUsuario.TabIndex = 14;
            btnRegistroUsuario.Text = "REGISTRO DE EMPLEADOS";
            btnRegistroUsuario.UseVisualStyleBackColor = true;
            btnRegistroUsuario.Click += btnRegistroUsuario_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 426);
            Controls.Add(btnRegistroUsuario);
            Controls.Add(label5);
            Controls.Add(txtCreateNombre);
            Controls.Add(txtCreatConfirmPass);
            Controls.Add(txtCreatePass);
            Controls.Add(txtCreateUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Registro de Empleados";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtCreateUser;
        private TextBox txtCreatePass;
        private TextBox txtCreatConfirmPass;
        private TextBox txtCreateNombre;
        private Label label5;
        private Button btnRegistroUsuario;
    }
}