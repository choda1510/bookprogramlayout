
namespace 도서관리화면설계ver2
{
    partial class 연체관리_Form
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
            this.도서_dataGridView = new System.Windows.Forms.DataGridView();
            this.출판사_검색_textBox = new System.Windows.Forms.TextBox();
            this.저자_검색_textBox = new System.Windows.Forms.TextBox();
            this.도서이름_검색_textBox = new System.Windows.Forms.TextBox();
            this.ISBN_검색_textBox = new System.Windows.Forms.TextBox();
            this.도서_검색_button = new System.Windows.Forms.Button();
            this.출판사_검색_label = new System.Windows.Forms.Label();
            this.저자_검색_label = new System.Windows.Forms.Label();
            this.도서이름_검색_label = new System.Windows.Forms.Label();
            this.ISBN_검색_label = new System.Windows.Forms.Label();
            this.회원_dataGridView = new System.Windows.Forms.DataGridView();
            this.주소_검색_textBox = new System.Windows.Forms.TextBox();
            this.전화번호_검색_textBox = new System.Windows.Forms.TextBox();
            this.이름_검색_textBox = new System.Windows.Forms.TextBox();
            this.아이디_검색_textBox = new System.Windows.Forms.TextBox();
            this.회원_검색_button = new System.Windows.Forms.Button();
            this.주소_검색_label = new System.Windows.Forms.Label();
            this.전화번호_검색_label = new System.Windows.Forms.Label();
            this.이름_검색_label = new System.Windows.Forms.Label();
            this.아이디_검색_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.회원_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 도서_dataGridView
            // 
            this.도서_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.도서_dataGridView.Location = new System.Drawing.Point(12, 298);
            this.도서_dataGridView.Name = "도서_dataGridView";
            this.도서_dataGridView.RowTemplate.Height = 23;
            this.도서_dataGridView.Size = new System.Drawing.Size(656, 140);
            this.도서_dataGridView.TabIndex = 23;
            // 
            // 출판사_검색_textBox
            // 
            this.출판사_검색_textBox.Location = new System.Drawing.Point(491, 271);
            this.출판사_검색_textBox.Name = "출판사_검색_textBox";
            this.출판사_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.출판사_검색_textBox.TabIndex = 19;
            // 
            // 저자_검색_textBox
            // 
            this.저자_검색_textBox.Location = new System.Drawing.Point(347, 271);
            this.저자_검색_textBox.Name = "저자_검색_textBox";
            this.저자_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.저자_검색_textBox.TabIndex = 20;
            // 
            // 도서이름_검색_textBox
            // 
            this.도서이름_검색_textBox.Location = new System.Drawing.Point(210, 271);
            this.도서이름_검색_textBox.Name = "도서이름_검색_textBox";
            this.도서이름_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.도서이름_검색_textBox.TabIndex = 21;
            // 
            // ISBN_검색_textBox
            // 
            this.ISBN_검색_textBox.Location = new System.Drawing.Point(49, 271);
            this.ISBN_검색_textBox.Name = "ISBN_검색_textBox";
            this.ISBN_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.ISBN_검색_textBox.TabIndex = 22;
            // 
            // 도서_검색_button
            // 
            this.도서_검색_button.Location = new System.Drawing.Point(593, 271);
            this.도서_검색_button.Name = "도서_검색_button";
            this.도서_검색_button.Size = new System.Drawing.Size(75, 23);
            this.도서_검색_button.TabIndex = 18;
            this.도서_검색_button.Text = "검색";
            this.도서_검색_button.UseVisualStyleBackColor = true;
            // 
            // 출판사_검색_label
            // 
            this.출판사_검색_label.AutoSize = true;
            this.출판사_검색_label.Location = new System.Drawing.Point(449, 274);
            this.출판사_검색_label.Name = "출판사_검색_label";
            this.출판사_검색_label.Size = new System.Drawing.Size(41, 12);
            this.출판사_검색_label.TabIndex = 14;
            this.출판사_검색_label.Text = "출판사";
            // 
            // 저자_검색_label
            // 
            this.저자_검색_label.AutoSize = true;
            this.저자_검색_label.Location = new System.Drawing.Point(312, 274);
            this.저자_검색_label.Name = "저자_검색_label";
            this.저자_검색_label.Size = new System.Drawing.Size(29, 12);
            this.저자_검색_label.TabIndex = 15;
            this.저자_검색_label.Text = "저자";
            // 
            // 도서이름_검색_label
            // 
            this.도서이름_검색_label.AutoSize = true;
            this.도서이름_검색_label.Location = new System.Drawing.Point(151, 274);
            this.도서이름_검색_label.Name = "도서이름_검색_label";
            this.도서이름_검색_label.Size = new System.Drawing.Size(53, 12);
            this.도서이름_검색_label.TabIndex = 16;
            this.도서이름_검색_label.Text = "도서이름";
            // 
            // ISBN_검색_label
            // 
            this.ISBN_검색_label.AutoSize = true;
            this.ISBN_검색_label.Location = new System.Drawing.Point(10, 274);
            this.ISBN_검색_label.Name = "ISBN_검색_label";
            this.ISBN_검색_label.Size = new System.Drawing.Size(33, 12);
            this.ISBN_검색_label.TabIndex = 17;
            this.ISBN_검색_label.Text = "ISBN";
            // 
            // 회원_dataGridView
            // 
            this.회원_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.회원_dataGridView.Location = new System.Drawing.Point(12, 102);
            this.회원_dataGridView.Name = "회원_dataGridView";
            this.회원_dataGridView.RowTemplate.Height = 23;
            this.회원_dataGridView.Size = new System.Drawing.Size(656, 163);
            this.회원_dataGridView.TabIndex = 43;
            // 
            // 주소_검색_textBox
            // 
            this.주소_검색_textBox.Location = new System.Drawing.Point(491, 75);
            this.주소_검색_textBox.Name = "주소_검색_textBox";
            this.주소_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.주소_검색_textBox.TabIndex = 39;
            // 
            // 전화번호_검색_textBox
            // 
            this.전화번호_검색_textBox.Location = new System.Drawing.Point(346, 75);
            this.전화번호_검색_textBox.Name = "전화번호_검색_textBox";
            this.전화번호_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.전화번호_검색_textBox.TabIndex = 40;
            // 
            // 이름_검색_textBox
            // 
            this.이름_검색_textBox.Location = new System.Drawing.Point(186, 75);
            this.이름_검색_textBox.Name = "이름_검색_textBox";
            this.이름_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.이름_검색_textBox.TabIndex = 41;
            // 
            // 아이디_검색_textBox
            // 
            this.아이디_검색_textBox.Location = new System.Drawing.Point(49, 75);
            this.아이디_검색_textBox.Name = "아이디_검색_textBox";
            this.아이디_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.아이디_검색_textBox.TabIndex = 42;
            // 
            // 회원_검색_button
            // 
            this.회원_검색_button.Location = new System.Drawing.Point(593, 75);
            this.회원_검색_button.Name = "회원_검색_button";
            this.회원_검색_button.Size = new System.Drawing.Size(75, 23);
            this.회원_검색_button.TabIndex = 38;
            this.회원_검색_button.Text = "검색";
            this.회원_검색_button.UseVisualStyleBackColor = true;
            // 
            // 주소_검색_label
            // 
            this.주소_검색_label.AutoSize = true;
            this.주소_검색_label.Location = new System.Drawing.Point(449, 78);
            this.주소_검색_label.Name = "주소_검색_label";
            this.주소_검색_label.Size = new System.Drawing.Size(29, 12);
            this.주소_검색_label.TabIndex = 34;
            this.주소_검색_label.Text = "주소";
            // 
            // 전화번호_검색_label
            // 
            this.전화번호_검색_label.AutoSize = true;
            this.전화번호_검색_label.Location = new System.Drawing.Point(287, 78);
            this.전화번호_검색_label.Name = "전화번호_검색_label";
            this.전화번호_검색_label.Size = new System.Drawing.Size(53, 12);
            this.전화번호_검색_label.TabIndex = 35;
            this.전화번호_검색_label.Text = "전화번호";
            // 
            // 이름_검색_label
            // 
            this.이름_검색_label.AutoSize = true;
            this.이름_검색_label.Location = new System.Drawing.Point(151, 78);
            this.이름_검색_label.Name = "이름_검색_label";
            this.이름_검색_label.Size = new System.Drawing.Size(29, 12);
            this.이름_검색_label.TabIndex = 36;
            this.이름_검색_label.Text = "이름";
            // 
            // 아이디_검색_label
            // 
            this.아이디_검색_label.AutoSize = true;
            this.아이디_검색_label.Location = new System.Drawing.Point(10, 78);
            this.아이디_검색_label.Name = "아이디_검색_label";
            this.아이디_검색_label.Size = new System.Drawing.Size(41, 12);
            this.아이디_검색_label.TabIndex = 37;
            this.아이디_검색_label.Text = "아이디";
            // 
            // 연체관리_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.회원_dataGridView);
            this.Controls.Add(this.주소_검색_textBox);
            this.Controls.Add(this.전화번호_검색_textBox);
            this.Controls.Add(this.이름_검색_textBox);
            this.Controls.Add(this.아이디_검색_textBox);
            this.Controls.Add(this.회원_검색_button);
            this.Controls.Add(this.주소_검색_label);
            this.Controls.Add(this.전화번호_검색_label);
            this.Controls.Add(this.이름_검색_label);
            this.Controls.Add(this.아이디_검색_label);
            this.Controls.Add(this.도서_dataGridView);
            this.Controls.Add(this.출판사_검색_textBox);
            this.Controls.Add(this.저자_검색_textBox);
            this.Controls.Add(this.도서이름_검색_textBox);
            this.Controls.Add(this.ISBN_검색_textBox);
            this.Controls.Add(this.도서_검색_button);
            this.Controls.Add(this.출판사_검색_label);
            this.Controls.Add(this.저자_검색_label);
            this.Controls.Add(this.도서이름_검색_label);
            this.Controls.Add(this.ISBN_검색_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "연체관리_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "연체";
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.회원_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView 도서_dataGridView;
        private System.Windows.Forms.TextBox 출판사_검색_textBox;
        private System.Windows.Forms.TextBox 저자_검색_textBox;
        private System.Windows.Forms.TextBox 도서이름_검색_textBox;
        private System.Windows.Forms.TextBox ISBN_검색_textBox;
        private System.Windows.Forms.Button 도서_검색_button;
        private System.Windows.Forms.Label 출판사_검색_label;
        private System.Windows.Forms.Label 저자_검색_label;
        private System.Windows.Forms.Label 도서이름_검색_label;
        private System.Windows.Forms.Label ISBN_검색_label;
        private System.Windows.Forms.DataGridView 회원_dataGridView;
        private System.Windows.Forms.TextBox 주소_검색_textBox;
        private System.Windows.Forms.TextBox 전화번호_검색_textBox;
        private System.Windows.Forms.TextBox 이름_검색_textBox;
        private System.Windows.Forms.TextBox 아이디_검색_textBox;
        private System.Windows.Forms.Button 회원_검색_button;
        private System.Windows.Forms.Label 주소_검색_label;
        private System.Windows.Forms.Label 전화번호_검색_label;
        private System.Windows.Forms.Label 이름_검색_label;
        private System.Windows.Forms.Label 아이디_검색_label;
    }
}