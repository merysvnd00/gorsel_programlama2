namespace KronometreOrnek
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
            components = new System.ComponentModel.Container();
            lblSaat = new Label();
            lblSalise = new Label();
            lblDakika = new Label();
            lblSaniye = new Label();
            lblSaniye2 = new Label();
            lblDakika2 = new Label();
            lblSalise2 = new Label();
            lblSaat2 = new Label();
            btnBasla = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(163, 84);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(25, 20);
            lblSaat.TabIndex = 0;
            lblSaat.Text = "Sa";
            // 
            // lblSalise
            // 
            lblSalise.AutoSize = true;
            lblSalise.Location = new Point(373, 84);
            lblSalise.Name = "lblSalise";
            lblSalise.Size = new Size(21, 20);
            lblSalise.TabIndex = 1;
            lblSalise.Text = "Sl";
            // 
            // lblDakika
            // 
            lblDakika.AutoSize = true;
            lblDakika.Location = new Point(228, 84);
            lblDakika.Name = "lblDakika";
            lblDakika.Size = new Size(27, 20);
            lblDakika.TabIndex = 2;
            lblDakika.Text = "Dk";
            // 
            // lblSaniye
            // 
            lblSaniye.AutoSize = true;
            lblSaniye.Location = new Point(311, 84);
            lblSaniye.Name = "lblSaniye";
            lblSaniye.Size = new Size(25, 20);
            lblSaniye.TabIndex = 3;
            lblSaniye.Text = "Sn";
            // 
            // lblSaniye2
            // 
            lblSaniye2.AutoSize = true;
            lblSaniye2.Location = new Point(311, 137);
            lblSaniye2.Name = "lblSaniye2";
            lblSaniye2.Size = new Size(25, 20);
            lblSaniye2.TabIndex = 7;
            lblSaniye2.Text = "Sn";
            // 
            // lblDakika2
            // 
            lblDakika2.AutoSize = true;
            lblDakika2.Location = new Point(228, 137);
            lblDakika2.Name = "lblDakika2";
            lblDakika2.Size = new Size(27, 20);
            lblDakika2.TabIndex = 6;
            lblDakika2.Text = "Dk";
            // 
            // lblSalise2
            // 
            lblSalise2.AutoSize = true;
            lblSalise2.Location = new Point(373, 137);
            lblSalise2.Name = "lblSalise2";
            lblSalise2.Size = new Size(21, 20);
            lblSalise2.TabIndex = 5;
            lblSalise2.Text = "Sl";
            // 
            // lblSaat2
            // 
            lblSaat2.AutoSize = true;
            lblSaat2.Location = new Point(163, 137);
            lblSaat2.Name = "lblSaat2";
            lblSaat2.Size = new Size(25, 20);
            lblSaat2.TabIndex = 4;
            lblSaat2.Text = "Sa";
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(453, 103);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(94, 29);
            btnBasla.TabIndex = 8;
            btnBasla.Text = "BASLAT";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBasla);
            Controls.Add(lblSaniye2);
            Controls.Add(lblDakika2);
            Controls.Add(lblSalise2);
            Controls.Add(lblSaat2);
            Controls.Add(lblSaniye);
            Controls.Add(lblDakika);
            Controls.Add(lblSalise);
            Controls.Add(lblSaat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaat;
        private Label lblSalise;
        private Label lblDakika;
        private Label lblSaniye;
        private Label lblSaniye2;
        private Label lblDakika2;
        private Label lblSalise2;
        private Label lblSaat2;
        private Button btnBasla;
        private System.Windows.Forms.Timer timer1;
    }
}
