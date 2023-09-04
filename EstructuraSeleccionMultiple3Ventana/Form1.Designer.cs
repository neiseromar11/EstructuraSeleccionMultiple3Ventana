namespace EstructuraSeleccionMultiple3Ventana
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
            button1 = new Button();
            button3 = new Button();
            txtedad = new TextBox();
            txtaciertos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(283, 260);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 0;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(62, 260);
            button3.Name = "button3";
            button3.Size = new Size(105, 45);
            button3.TabIndex = 2;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtedad
            // 
            txtedad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtedad.Location = new Point(300, 50);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(112, 26);
            txtedad.TabIndex = 3;
            // 
            // txtaciertos
            // 
            txtaciertos.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtaciertos.Location = new Point(300, 117);
            txtaciertos.Name = "txtaciertos";
            txtaciertos.Size = new Size(112, 26);
            txtaciertos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(183, 19);
            label1.TabIndex = 5;
            label1.Text = "Ingrese la edad del ganador: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(275, 19);
            label2.TabIndex = 6;
            label2.Text = "Ingrese la cantidad de adivinanzas acertadas";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblresultado.Location = new Point(12, 191);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(214, 19);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Monto total que el ganador recibe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 317);
            Controls.Add(lblresultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtaciertos);
            Controls.Add(txtedad);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private TextBox txtedad;
        private TextBox txtaciertos;
        private Label label1;
        private Label label2;
        private Label lblresultado;
    }
}