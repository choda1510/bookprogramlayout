
namespace 도서관리화면설계ver2
{
    partial class 로그인_Form
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
            this.아이디_label = new System.Windows.Forms.Label();
            this.로그인_button = new System.Windows.Forms.Button();
            this.아이디_textBox = new System.Windows.Forms.TextBox();
            this.비밀번호_label = new System.Windows.Forms.Label();
            this.비밀번호_textBox = new System.Windows.Forms.TextBox();
            this.회원가입_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 아이디_label
            // 
            this.아이디_label.AutoSize = true;
            this.아이디_label.Location = new System.Drawing.Point(23, 59);
            this.아이디_label.Name = "아이디_label";
            this.아이디_label.Size = new System.Drawing.Size(41, 12);
            this.아이디_label.TabIndex = 0;
            this.아이디_label.Text = "아이디";
            // 
            // 로그인_button
            // 
            this.로그인_button.Location = new System.Drawing.Point(91, 230);
            this.로그인_button.Name = "로그인_button";
            this.로그인_button.Size = new System.Drawing.Size(75, 23);
            this.로그인_button.TabIndex = 1;
            this.로그인_button.Text = "로그인";
            this.로그인_button.UseVisualStyleBackColor = true;
            this.로그인_button.Click += new System.EventHandler(this.로그인_button_Click);
            // 
            // 아이디_textBox
            // 
            this.아이디_textBox.Location = new System.Drawing.Point(82, 56);
            this.아이디_textBox.Name = "아이디_textBox";
            this.아이디_textBox.Size = new System.Drawing.Size(96, 21);
            this.아이디_textBox.TabIndex = 2;
            // 
            // 비밀번호_label
            // 
            this.비밀번호_label.AutoSize = true;
            this.비밀번호_label.Location = new System.Drawing.Point(23, 118);
            this.비밀번호_label.Name = "비밀번호_label";
            this.비밀번호_label.Size = new System.Drawing.Size(53, 12);
            this.비밀번호_label.TabIndex = 0;
            this.비밀번호_label.Text = "비밀번호";
            // 
            // 비밀번호_textBox
            // 
            this.비밀번호_textBox.Location = new System.Drawing.Point(82, 115);
            this.비밀번호_textBox.Name = "비밀번호_textBox";
            this.비밀번호_textBox.Size = new System.Drawing.Size(96, 21);
            this.비밀번호_textBox.TabIndex = 2;
            // 
            // 회원가입_label
            // 
            this.회원가입_label.AutoSize = true;
            this.회원가입_label.Location = new System.Drawing.Point(23, 289);
            this.회원가입_label.Name = "회원가입_label";
            this.회원가입_label.Size = new System.Drawing.Size(53, 12);
            this.회원가입_label.TabIndex = 3;
            this.회원가입_label.Text = "회원가입";
            this.회원가입_label.Click += new System.EventHandler(this.회원가입_label_Click);
            // 
            // 로그인_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 326);
            this.Controls.Add(this.회원가입_label);
            this.Controls.Add(this.비밀번호_textBox);
            this.Controls.Add(this.아이디_textBox);
            this.Controls.Add(this.로그인_button);
            this.Controls.Add(this.비밀번호_label);
            this.Controls.Add(this.아이디_label);
            this.Name = "로그인_Form";
            this.Text = "로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.로그인_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 아이디_label;
        private System.Windows.Forms.Button 로그인_button;
        private System.Windows.Forms.TextBox 아이디_textBox;
        private System.Windows.Forms.Label 비밀번호_label;
        private System.Windows.Forms.TextBox 비밀번호_textBox;
        private System.Windows.Forms.Label 회원가입_label;
    }
}