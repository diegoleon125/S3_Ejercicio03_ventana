namespace S3_Ejercicio03_ventana
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
            txtedad = new TextBox();
            label2 = new Label();
            txtaciert = new TextBox();
            button1 = new Button();
            lblresult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese edad:";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(171, 27);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(100, 23);
            txtedad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 73);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese aciertos:";
            // 
            // txtaciert
            // 
            txtaciert.Location = new Point(171, 70);
            txtaciert.Name = "txtaciert";
            txtaciert.Size = new Size(100, 23);
            txtaciert.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(159, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(118, 171);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(80, 15);
            lblresult.TabIndex = 5;
            lblresult.Text = "El premio es...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 261);
            Controls.Add(lblresult);
            Controls.Add(button1);
            Controls.Add(txtaciert);
            Controls.Add(label2);
            Controls.Add(txtedad);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtedad;
        private Label label2;
        private TextBox txtaciert;
        private Button button1;
        private Label lblresult;
    }
}