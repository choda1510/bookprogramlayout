
namespace 도서관리화면설계ver2
{
    partial class 대출관리_Form
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
            this.검색_button = new System.Windows.Forms.Button();
            this.출판사_검색_label = new System.Windows.Forms.Label();
            this.저자_검색_label = new System.Windows.Forms.Label();
            this.도서이름_검색_label = new System.Windows.Forms.Label();
            this.ISBN_검색_label = new System.Windows.Forms.Label();
            this.ISBN_대출반납_label = new System.Windows.Forms.Label();
            this.ISBN_대출반납_textBox = new System.Windows.Forms.TextBox();
            this.아이디_textBox = new System.Windows.Forms.TextBox();
            this.아이디_label = new System.Windows.Forms.Label();
            this.대출_button = new System.Windows.Forms.Button();
            this.반납_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 도서_dataGridView
            // 
            this.도서_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.도서_dataGridView.Location = new System.Drawing.Point(12, 102);
            this.도서_dataGridView.Name = "도서_dataGridView";
            this.도서_dataGridView.RowTemplate.Height = 23;
            this.도서_dataGridView.Size = new System.Drawing.Size(656, 336);
            this.도서_dataGridView.TabIndex = 13;
            // 
            // 출판사_검색_textBox
            // 
            this.출판사_검색_textBox.Location = new System.Drawing.Point(491, 75);
            this.출판사_검색_textBox.Name = "출판사_검색_textBox";
            this.출판사_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.출판사_검색_textBox.TabIndex = 9;
            // 
            // 저자_검색_textBox
            // 
            this.저자_검색_textBox.Location = new System.Drawing.Point(347, 75);
            this.저자_검색_textBox.Name = "저자_검색_textBox";
            this.저자_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.저자_검색_textBox.TabIndex = 10;
            // 
            // 도서이름_검색_textBox
            // 
            this.도서이름_검색_textBox.Location = new System.Drawing.Point(210, 75);
            this.도서이름_검색_textBox.Name = "도서이름_검색_textBox";
            this.도서이름_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.도서이름_검색_textBox.TabIndex = 11;
            // 
            // ISBN_검색_textBox
            // 
            this.ISBN_검색_textBox.Location = new System.Drawing.Point(49, 75);
            this.ISBN_검색_textBox.Name = "ISBN_검색_textBox";
            this.ISBN_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.ISBN_검색_textBox.TabIndex = 12;
            // 
            // 검색_button
            // 
            this.검색_button.Location = new System.Drawing.Point(593, 75);
            this.검색_button.Name = "검색_button";
            this.검색_button.Size = new System.Drawing.Size(75, 23);
            this.검색_button.TabIndex = 8;
            this.검색_button.Text = "검색";
            this.검색_button.UseVisualStyleBackColor = true;
            this.검색_button.Click += new System.EventHandler(this.검색_button_Click);
            // 
            // 출판사_검색_label
            // 
            this.출판사_검색_label.AutoSize = true;
            this.출판사_검색_label.Location = new System.Drawing.Point(449, 78);
            this.출판사_검색_label.Name = "출판사_검색_label";
            this.출판사_검색_label.Size = new System.Drawing.Size(41, 12);
            this.출판사_검색_label.TabIndex = 4;
            this.출판사_검색_label.Text = "출판사";
            // 
            // 저자_검색_label
            // 
            this.저자_검색_label.AutoSize = true;
            this.저자_검색_label.Location = new System.Drawing.Point(312, 78);
            this.저자_검색_label.Name = "저자_검색_label";
            this.저자_검색_label.Size = new System.Drawing.Size(29, 12);
            this.저자_검색_label.TabIndex = 5;
            this.저자_검색_label.Text = "저자";
            // 
            // 도서이름_검색_label
            // 
            this.도서이름_검색_label.AutoSize = true;
            this.도서이름_검색_label.Location = new System.Drawing.Point(151, 78);
            this.도서이름_검색_label.Name = "도서이름_검색_label";
            this.도서이름_검색_label.Size = new System.Drawing.Size(53, 12);
            this.도서이름_검색_label.TabIndex = 6;
            this.도서이름_검색_label.Text = "도서이름";
            // 
            // ISBN_검색_label
            // 
            this.ISBN_검색_label.AutoSize = true;
            this.ISBN_검색_label.Location = new System.Drawing.Point(10, 78);
            this.ISBN_검색_label.Name = "ISBN_검색_label";
            this.ISBN_검색_label.Size = new System.Drawing.Size(33, 12);
            this.ISBN_검색_label.TabIndex = 7;
            this.ISBN_검색_label.Text = "ISBN";
            // 
            // ISBN_대출반납_label
            // 
            this.ISBN_대출반납_label.AutoSize = true;
            this.ISBN_대출반납_label.Location = new System.Drawing.Point(677, 116);
            this.ISBN_대출반납_label.Name = "ISBN_대출반납_label";
            this.ISBN_대출반납_label.Size = new System.Drawing.Size(33, 12);
            this.ISBN_대출반납_label.TabIndex = 7;
            this.ISBN_대출반납_label.Text = "ISBN";
            // 
            // ISBN_대출반납_textBox
            // 
            this.ISBN_대출반납_textBox.Location = new System.Drawing.Point(679, 131);
            this.ISBN_대출반납_textBox.Name = "ISBN_대출반납_textBox";
            this.ISBN_대출반납_textBox.Size = new System.Drawing.Size(96, 21);
            this.ISBN_대출반납_textBox.TabIndex = 12;
            // 
            // 아이디_textBox
            // 
            this.아이디_textBox.Location = new System.Drawing.Point(679, 186);
            this.아이디_textBox.Name = "아이디_textBox";
            this.아이디_textBox.Size = new System.Drawing.Size(100, 21);
            this.아이디_textBox.TabIndex = 16;
            // 
            // 아이디_label
            // 
            this.아이디_label.AutoSize = true;
            this.아이디_label.Location = new System.Drawing.Point(677, 171);
            this.아이디_label.Name = "아이디_label";
            this.아이디_label.Size = new System.Drawing.Size(41, 12);
            this.아이디_label.TabIndex = 15;
            this.아이디_label.Text = "아이디";
            // 
            // 대출_button
            // 
            this.대출_button.Location = new System.Drawing.Point(700, 330);
            this.대출_button.Name = "대출_button";
            this.대출_button.Size = new System.Drawing.Size(75, 23);
            this.대출_button.TabIndex = 8;
            this.대출_button.Text = "대출";
            this.대출_button.UseVisualStyleBackColor = true;
            this.대출_button.Click += new System.EventHandler(this.검색_button_Click);
            // 
            // 반납_button
            // 
            this.반납_button.Location = new System.Drawing.Point(700, 388);
            this.반납_button.Name = "반납_button";
            this.반납_button.Size = new System.Drawing.Size(75, 23);
            this.반납_button.TabIndex = 8;
            this.반납_button.Text = "반납";
            this.반납_button.UseVisualStyleBackColor = true;
            this.반납_button.Click += new System.EventHandler(this.검색_button_Click);
            // 
            // 대출관리_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.아이디_textBox);
            this.Controls.Add(this.아이디_label);
            this.Controls.Add(this.도서_dataGridView);
            this.Controls.Add(this.출판사_검색_textBox);
            this.Controls.Add(this.저자_검색_textBox);
            this.Controls.Add(this.도서이름_검색_textBox);
            this.Controls.Add(this.ISBN_대출반납_textBox);
            this.Controls.Add(this.ISBN_검색_textBox);
            this.Controls.Add(this.반납_button);
            this.Controls.Add(this.대출_button);
            this.Controls.Add(this.검색_button);
            this.Controls.Add(this.출판사_검색_label);
            this.Controls.Add(this.저자_검색_label);
            this.Controls.Add(this.도서이름_검색_label);
            this.Controls.Add(this.ISBN_대출반납_label);
            this.Controls.Add(this.ISBN_검색_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "대출관리_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "대출";
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView 도서_dataGridView;
        private System.Windows.Forms.TextBox 출판사_검색_textBox;
        private System.Windows.Forms.TextBox 저자_검색_textBox;
        private System.Windows.Forms.TextBox 도서이름_검색_textBox;
        private System.Windows.Forms.TextBox ISBN_검색_textBox;
        private System.Windows.Forms.Button 검색_button;
        private System.Windows.Forms.Label 출판사_검색_label;
        private System.Windows.Forms.Label 저자_검색_label;
        private System.Windows.Forms.Label 도서이름_검색_label;
        private System.Windows.Forms.Label ISBN_검색_label;
        private System.Windows.Forms.Label ISBN_대출반납_label;
        private System.Windows.Forms.TextBox ISBN_대출반납_textBox;
        private System.Windows.Forms.TextBox 아이디_textBox;
        private System.Windows.Forms.Label 아이디_label;
        private System.Windows.Forms.Button 대출_button;
        private System.Windows.Forms.Button 반납_button;
    }
}