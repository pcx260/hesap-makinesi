namespace hesap_makinesi
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            zero = new Button();
            label1 = new Label();
            plus = new Button();
            eksi = new Button();
            carp = new Button();
            bol = new Button();
            esit = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 54);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 54);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 54);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 89);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(112, 89);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(212, 89);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 124);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(112, 124);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(212, 124);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // zero
            // 
            zero.Location = new Point(112, 159);
            zero.Name = "zero";
            zero.Size = new Size(94, 29);
            zero.TabIndex = 9;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // plus
            // 
            plus.Location = new Point(312, 54);
            plus.Name = "plus";
            plus.Size = new Size(94, 29);
            plus.TabIndex = 11;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // eksi
            // 
            eksi.Location = new Point(312, 124);
            eksi.Name = "eksi";
            eksi.Size = new Size(94, 29);
            eksi.TabIndex = 12;
            eksi.Text = "-";
            eksi.UseVisualStyleBackColor = true;
            eksi.Click += eksi_Click;
            // 
            // carp
            // 
            carp.Location = new Point(312, 89);
            carp.Name = "carp";
            carp.Size = new Size(94, 29);
            carp.TabIndex = 13;
            carp.Text = "x";
            carp.UseVisualStyleBackColor = true;
            carp.Click += carp_Click;
            // 
            // bol
            // 
            bol.Location = new Point(312, 159);
            bol.Name = "bol";
            bol.Size = new Size(94, 29);
            bol.TabIndex = 14;
            bol.Text = "/";
            bol.UseVisualStyleBackColor = true;
            bol.Click += bol_Click;
            // 
            // esit
            // 
            esit.Location = new Point(312, 194);
            esit.Name = "esit";
            esit.Size = new Size(94, 29);
            esit.TabIndex = 15;
            esit.Text = "=";
            esit.UseVisualStyleBackColor = true;
            esit.Click += esit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 308);
            Controls.Add(esit);
            Controls.Add(bol);
            Controls.Add(carp);
            Controls.Add(eksi);
            Controls.Add(plus);
            Controls.Add(label1);
            Controls.Add(zero);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button zero;
        private Label label1;
        private Button plus;
        private Button eksi;
        private Button carp;
        private Button bol;
        private Button esit;
    }
}
