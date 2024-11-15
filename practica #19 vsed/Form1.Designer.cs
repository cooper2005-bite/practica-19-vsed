namespace practica__19_vsed
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
            calxd = new Label();
            cal2xd = new Label();
            cal3xs = new Label();
            cal4xs = new Label();
            calificaciones1 = new TextBox();
            calificaciones2 = new TextBox();
            calificaciones3 = new TextBox();
            calificaciones4 = new TextBox();
            calcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // calxd
            // 
            calxd.AutoSize = true;
            calxd.Font = new Font("Cooper Black", 14.25F);
            calxd.Location = new Point(52, 51);
            calxd.Name = "calxd";
            calxd.Size = new Size(138, 21);
            calxd.TabIndex = 0;
            calxd.Text = "calificacion 1";
            // 
            // cal2xd
            // 
            cal2xd.AutoSize = true;
            cal2xd.Font = new Font("Cooper Black", 14.25F);
            cal2xd.Location = new Point(52, 109);
            cal2xd.Name = "cal2xd";
            cal2xd.Size = new Size(138, 21);
            cal2xd.TabIndex = 1;
            cal2xd.Text = "calificacion 2";
            // 
            // cal3xs
            // 
            cal3xs.AutoSize = true;
            cal3xs.Font = new Font("Cooper Black", 14.25F);
            cal3xs.Location = new Point(52, 175);
            cal3xs.Name = "cal3xs";
            cal3xs.Size = new Size(138, 21);
            cal3xs.TabIndex = 2;
            cal3xs.Text = "calificacion 3";
            // 
            // cal4xs
            // 
            cal4xs.AutoSize = true;
            cal4xs.Font = new Font("Cooper Black", 14.25F);
            cal4xs.Location = new Point(52, 231);
            cal4xs.Name = "cal4xs";
            cal4xs.Size = new Size(138, 21);
            cal4xs.TabIndex = 3;
            cal4xs.Text = "calificacion 4";
            // 
            // calificaciones1
            // 
            calificaciones1.Font = new Font("Cooper Black", 14.25F);
            calificaciones1.Location = new Point(276, 51);
            calificaciones1.Name = "calificaciones1";
            calificaciones1.Size = new Size(100, 29);
            calificaciones1.TabIndex = 4;
            // 
            // calificaciones2
            // 
            calificaciones2.Font = new Font("Cooper Black", 14.25F);
            calificaciones2.Location = new Point(276, 107);
            calificaciones2.Name = "calificaciones2";
            calificaciones2.Size = new Size(100, 29);
            calificaciones2.TabIndex = 5;
            // 
            // calificaciones3
            // 
            calificaciones3.Font = new Font("Cooper Black", 14.25F);
            calificaciones3.Location = new Point(276, 173);
            calificaciones3.Name = "calificaciones3";
            calificaciones3.Size = new Size(100, 29);
            calificaciones3.TabIndex = 6;
            // 
            // calificaciones4
            // 
            calificaciones4.Font = new Font("Cooper Black", 14.25F);
            calificaciones4.Location = new Point(276, 229);
            calificaciones4.Name = "calificaciones4";
            calificaciones4.Size = new Size(100, 29);
            calificaciones4.TabIndex = 7;
            // 
            // calcular
            // 
            calcular.Font = new Font("Cooper Black", 14.25F);
            calcular.Location = new Point(446, 106);
            calcular.Name = "calcular";
            calcular.Size = new Size(98, 58);
            calcular.TabIndex = 8;
            calcular.Text = "calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F);
            label1.Location = new Point(594, 125);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(calcular);
            Controls.Add(calificaciones4);
            Controls.Add(calificaciones3);
            Controls.Add(calificaciones2);
            Controls.Add(calificaciones1);
            Controls.Add(cal4xs);
            Controls.Add(cal3xs);
            Controls.Add(cal2xd);
            Controls.Add(calxd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label calxd;
        private Label cal2xd;
        private Label cal3xs;
        private Label cal4xs;
        private TextBox calificaciones1;
        private TextBox calificaciones2;
        private TextBox calificaciones3;
        private TextBox calificaciones4;
        private Button calcular;
        private Label label1;
    }
}
