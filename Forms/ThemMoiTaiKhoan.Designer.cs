namespace StoreManagement.Forms
{
    partial class ThemMoiTaiKhoan
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(92, 319);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 0;
            button1.Text = "Lưu dữ liệu";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã đăng nhập";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(197, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(197, 117);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(242, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(197, 76);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(242, 27);
            textBox6.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 79);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 120);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 9;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 162);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 10;
            label4.Text = "Họ tên người dùng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 202);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 11;
            label5.Text = "Điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 245);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 12;
            label6.Text = "Địa chỉ";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(276, 319);
            button2.Name = "button2";
            button2.Size = new Size(163, 29);
            button2.TabIndex = 13;
            button2.Text = "Thoát chức năng";
            button2.UseVisualStyleBackColor = false;
            // 
            // ThemMoiTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 375);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ThemMoiTaiKhoan";
            Text = "ThemMoiTaiKhoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}