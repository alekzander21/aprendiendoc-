namespace GestionClientes
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
            listClientes = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardarCliente = new Button();
            btnEliminarCliente = new Button();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtTarjetaCredito = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(12, 12);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(325, 574);
            listClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(382, 31);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 1;
            label1.Text = "Gestión de Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 108);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(473, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.Location = new Point(382, 278);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(123, 23);
            btnGuardarCliente.TabIndex = 4;
            btnGuardarCliente.Text = "Guardar Cliente";
            btnGuardarCliente.UseVisualStyleBackColor = true;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(511, 278);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(123, 23);
            btnEliminarCliente.TabIndex = 5;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(473, 139);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(123, 23);
            txtApellido.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 142);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(473, 168);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(123, 23);
            txtTelefono.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 171);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // txtTarjetaCredito
            // 
            txtTarjetaCredito.Location = new Point(398, 238);
            txtTarjetaCredito.Name = "txtTarjetaCredito";
            txtTarjetaCredito.Size = new Size(198, 23);
            txtTarjetaCredito.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 210);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 11;
            label5.Text = "Tarjeta de Credito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 76);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 13;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(473, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(123, 23);
            txtId.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 606);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(txtTarjetaCredito);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnGuardarCliente);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listClientes);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardarCliente;
        private Button btnEliminarCliente;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtTarjetaCredito;
        private Label label5;
        private Label label6;
        private TextBox txtId;
    }
}