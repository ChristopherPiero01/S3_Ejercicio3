namespace S3_Ejercicio3
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
            label2 = new Label();
            txtAdivinanza = new TextBox();
            txtEdad = new TextBox();
            button1 = new Button();
            label3 = new Label();
            txtPremio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "Adivinanzas acertadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 91);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 1;
            label2.Text = "Edad:";
            // 
            // txtAdivinanza
            // 
            txtAdivinanza.Location = new Point(210, 43);
            txtAdivinanza.Name = "txtAdivinanza";
            txtAdivinanza.Size = new Size(100, 23);
            txtAdivinanza.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(210, 93);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(223, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 4;
            button1.Text = "Calcular premio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(141, 214);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 5;
            label3.Text = "Premio:";
            // 
            // txtPremio
            // 
            txtPremio.Location = new Point(210, 216);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(100, 23);
            txtPremio.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 387);
            Controls.Add(txtPremio);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtEdad);
            Controls.Add(txtAdivinanza);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdivinanza;
        private TextBox txtEdad;
        private Button button1;
        private Label label3;
        private TextBox txtPremio;
    }
}