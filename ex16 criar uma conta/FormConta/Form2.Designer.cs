namespace ex16_criar_uma_conta.FormConta
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
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(300, 2);
            button2.Name = "button2";
            button2.Size = new Size(35, 24);
            button2.TabIndex = 17;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(251, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 49);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 14;
            label3.Text = "Nome ou Gmail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 49);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 220);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 12;
            label1.Text = "Não tem conta criada?";
            label1.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 120);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 315);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "Form2";
            Text = "Iniciar sessão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}