namespace MayorMenor
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
            txtNumberA = new TextBox();
            txtNumer2 = new TextBox();
            txtNumber3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            txtResultado = new Label();
            SuspendLayout();
            // 
            // txtNumberA
            // 
            txtNumberA.Location = new Point(250, 59);
            txtNumberA.Name = "txtNumberA";
            txtNumberA.Size = new Size(100, 23);
            txtNumberA.TabIndex = 0;
            // 
            // txtNumer2
            // 
            txtNumer2.Location = new Point(250, 105);
            txtNumer2.Name = "txtNumer2";
            txtNumer2.Size = new Size(100, 23);
            txtNumer2.TabIndex = 1;
            // 
            // txtNumber3
            // 
            txtNumber3.Location = new Point(250, 151);
            txtNumber3.Name = "txtNumber3";
            txtNumber3.Size = new Size(100, 23);
            txtNumber3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 62);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Numero A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 113);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Numero B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 159);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Numero C";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(159, 195);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(191, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Location = new Point(222, 248);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(59, 15);
            txtResultado.TabIndex = 7;
            txtResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumber3);
            Controls.Add(txtNumer2);
            Controls.Add(txtNumberA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberA;
        private TextBox txtNumer2;
        private TextBox txtNumber3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label txtResultado;
    }
}