namespace FacturaciónProductos
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
            btnAgregar = new Button();
            btnCalcular = new Button();
            cboProductos = new ComboBox();
            listCarritoCompras = new ListBox();
            txtCodigoPromocional = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(404, 163);
            label1.Name = "label1";
            label1.Size = new Size(262, 37);
            label1.TabIndex = 1;
            label1.Text = "Codigo Promocional";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(431, 106);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(216, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(431, 135);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(216, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Caclular Precio Final";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(431, 66);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(216, 23);
            cboProductos.TabIndex = 5;
            // 
            // listCarritoCompras
            // 
            listCarritoCompras.FormattingEnabled = true;
            listCarritoCompras.ItemHeight = 15;
            listCarritoCompras.Location = new Point(12, 12);
            listCarritoCompras.Name = "listCarritoCompras";
            listCarritoCompras.Size = new Size(292, 589);
            listCarritoCompras.TabIndex = 6;
            // 
            // txtCodigoPromocional
            // 
            txtCodigoPromocional.Location = new Point(431, 208);
            txtCodigoPromocional.Name = "txtCodigoPromocional";
            txtCodigoPromocional.Size = new Size(216, 23);
            txtCodigoPromocional.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 608);
            Controls.Add(txtCodigoPromocional);
            Controls.Add(listCarritoCompras);
            Controls.Add(cboProductos);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAgregar;
        private Button btnCalcular;
        private ComboBox cboProductos;
        private ListBox listCarritoCompras;
        private TextBox txtCodigoPromocional;
    }
}