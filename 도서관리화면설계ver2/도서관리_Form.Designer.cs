
namespace 도서관리화면설계ver2
{
    partial class 도서관리_Form
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
            this.출판사_검색_textBox = new System.Windows.Forms.TextBox();
            this.저자_검색_textBox = new System.Windows.Forms.TextBox();
            this.도서이름_검색_textBox = new System.Windows.Forms.TextBox();
            this.ISBN_검색_textBox = new System.Windows.Forms.TextBox();
            this.검색_button = new System.Windows.Forms.Button();
            this.출판사_검색_label = new System.Windows.Forms.Label();
            this.저자_검색_label = new System.Windows.Forms.Label();
            this.도서이름_검색_label = new System.Windows.Forms.Label();
            this.ISBN_검색_label = new System.Windows.Forms.Label();
            this.도서_dataGridView = new System.Windows.Forms.DataGridView();
            this.ISBN_추가수정삭제_textBox = new System.Windows.Forms.TextBox();
            this.ISBN_추가수정삭제_label = new System.Windows.Forms.Label();
            this.도서이름_추가수정삭제_textBox = new System.Windows.Forms.TextBox();
            this.도서이름_추가수정삭제_label = new System.Windows.Forms.Label();
            this.저자_추가수정삭제_textBox = new System.Windows.Forms.TextBox();
            this.저자_추가수정삭제_label = new System.Windows.Forms.Label();
            this.출판사_추가수정삭제_textBox = new System.Windows.Forms.TextBox();
            this.출판사_추가수정삭제_label = new System.Windows.Forms.Label();
            this.추가_button = new System.Windows.Forms.Button();
            this.수정_button = new System.Windows.Forms.Button();
            this.삭제_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 출판사_검색_textBox
            // 
            this.출판사_검색_textBox.Location = new System.Drawing.Point(493, 66);
            this.출판사_검색_textBox.Name = "출판사_검색_textBox";
            this.출판사_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.출판사_검색_textBox.TabIndex = 18;
            // 
            // 저자_검색_textBox
            // 
            this.저자_검색_textBox.Location = new System.Drawing.Point(349, 66);
            this.저자_검색_textBox.Name = "저자_검색_textBox";
            this.저자_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.저자_검색_textBox.TabIndex = 19;
            // 
            // 도서이름_검색_textBox
            // 
            this.도서이름_검색_textBox.Location = new System.Drawing.Point(212, 66);
            this.도서이름_검색_textBox.Name = "도서이름_검색_textBox";
            this.도서이름_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.도서이름_검색_textBox.TabIndex = 20;
            // 
            // ISBN_검색_textBox
            // 
            this.ISBN_검색_textBox.Location = new System.Drawing.Point(51, 66);
            this.ISBN_검색_textBox.Name = "ISBN_검색_textBox";
            this.ISBN_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.ISBN_검색_textBox.TabIndex = 21;
            // 
            // 검색_button
            // 
            this.검색_button.Location = new System.Drawing.Point(595, 66);
            this.검색_button.Name = "검색_button";
            this.검색_button.Size = new System.Drawing.Size(75, 23);
            this.검색_button.TabIndex = 17;
            this.검색_button.Text = "검색";
            this.검색_button.UseVisualStyleBackColor = true;
            // 
            // 출판사_검색_label
            // 
            this.출판사_검색_label.AutoSize = true;
            this.출판사_검색_label.Location = new System.Drawing.Point(451, 69);
            this.출판사_검색_label.Name = "출판사_검색_label";
            this.출판사_검색_label.Size = new System.Drawing.Size(41, 12);
            this.출판사_검색_label.TabIndex = 13;
            this.출판사_검색_label.Text = "출판사";
            // 
            // 저자_검색_label
            // 
            this.저자_검색_label.AutoSize = true;
            this.저자_검색_label.Location = new System.Drawing.Point(314, 69);
            this.저자_검색_label.Name = "저자_검색_label";
            this.저자_검색_label.Size = new System.Drawing.Size(29, 12);
            this.저자_검색_label.TabIndex = 14;
            this.저자_검색_label.Text = "저자";
            // 
            // 도서이름_검색_label
            // 
            this.도서이름_검색_label.AutoSize = true;
            this.도서이름_검색_label.Location = new System.Drawing.Point(153, 69);
            this.도서이름_검색_label.Name = "도서이름_검색_label";
            this.도서이름_검색_label.Size = new System.Drawing.Size(53, 12);
            this.도서이름_검색_label.TabIndex = 15;
            this.도서이름_검색_label.Text = "도서이름";
            // 
            // ISBN_검색_label
            // 
            this.ISBN_검색_label.AutoSize = true;
            this.ISBN_검색_label.Location = new System.Drawing.Point(12, 69);
            this.ISBN_검색_label.Name = "ISBN_검색_label";
            this.ISBN_검색_label.Size = new System.Drawing.Size(33, 12);
            this.ISBN_검색_label.TabIndex = 16;
            this.ISBN_검색_label.Text = "ISBN";
            // 
            // 도서_dataGridView
            // 
            this.도서_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.도서_dataGridView.Location = new System.Drawing.Point(12, 102);
            this.도서_dataGridView.Name = "도서_dataGridView";
            this.도서_dataGridView.RowTemplate.Height = 23;
            this.도서_dataGridView.Size = new System.Drawing.Size(656, 336);
            this.도서_dataGridView.TabIndex = 22;
            // 
            // ISBN_추가수정삭제_textBox
            // 
            this.ISBN_추가수정삭제_textBox.Location = new System.Drawing.Point(683, 131);
            this.ISBN_추가수정삭제_textBox.Name = "ISBN_추가수정삭제_textBox";
            this.ISBN_추가수정삭제_textBox.Size = new System.Drawing.Size(96, 21);
            this.ISBN_추가수정삭제_textBox.TabIndex = 24;
            // 
            // ISBN_추가수정삭제_label
            // 
            this.ISBN_추가수정삭제_label.AutoSize = true;
            this.ISBN_추가수정삭제_label.Location = new System.Drawing.Point(681, 116);
            this.ISBN_추가수정삭제_label.Name = "ISBN_추가수정삭제_label";
            this.ISBN_추가수정삭제_label.Size = new System.Drawing.Size(33, 12);
            this.ISBN_추가수정삭제_label.TabIndex = 23;
            this.ISBN_추가수정삭제_label.Text = "ISBN";
            // 
            // 도서이름_추가수정삭제_textBox
            // 
            this.도서이름_추가수정삭제_textBox.Location = new System.Drawing.Point(683, 170);
            this.도서이름_추가수정삭제_textBox.Name = "도서이름_추가수정삭제_textBox";
            this.도서이름_추가수정삭제_textBox.Size = new System.Drawing.Size(96, 21);
            this.도서이름_추가수정삭제_textBox.TabIndex = 26;
            // 
            // 도서이름_추가수정삭제_label
            // 
            this.도서이름_추가수정삭제_label.AutoSize = true;
            this.도서이름_추가수정삭제_label.Location = new System.Drawing.Point(681, 155);
            this.도서이름_추가수정삭제_label.Name = "도서이름_추가수정삭제_label";
            this.도서이름_추가수정삭제_label.Size = new System.Drawing.Size(53, 12);
            this.도서이름_추가수정삭제_label.TabIndex = 25;
            this.도서이름_추가수정삭제_label.Text = "도서이름";
            // 
            // 저자_추가수정삭제_textBox
            // 
            this.저자_추가수정삭제_textBox.Location = new System.Drawing.Point(683, 209);
            this.저자_추가수정삭제_textBox.Name = "저자_추가수정삭제_textBox";
            this.저자_추가수정삭제_textBox.Size = new System.Drawing.Size(96, 21);
            this.저자_추가수정삭제_textBox.TabIndex = 28;
            // 
            // 저자_추가수정삭제_label
            // 
            this.저자_추가수정삭제_label.AutoSize = true;
            this.저자_추가수정삭제_label.Location = new System.Drawing.Point(681, 194);
            this.저자_추가수정삭제_label.Name = "저자_추가수정삭제_label";
            this.저자_추가수정삭제_label.Size = new System.Drawing.Size(29, 12);
            this.저자_추가수정삭제_label.TabIndex = 27;
            this.저자_추가수정삭제_label.Text = "저자";
            // 
            // 출판사_추가수정삭제_textBox
            // 
            this.출판사_추가수정삭제_textBox.Location = new System.Drawing.Point(683, 248);
            this.출판사_추가수정삭제_textBox.Name = "출판사_추가수정삭제_textBox";
            this.출판사_추가수정삭제_textBox.Size = new System.Drawing.Size(96, 21);
            this.출판사_추가수정삭제_textBox.TabIndex = 30;
            // 
            // 출판사_추가수정삭제_label
            // 
            this.출판사_추가수정삭제_label.AutoSize = true;
            this.출판사_추가수정삭제_label.Location = new System.Drawing.Point(681, 233);
            this.출판사_추가수정삭제_label.Name = "출판사_추가수정삭제_label";
            this.출판사_추가수정삭제_label.Size = new System.Drawing.Size(41, 12);
            this.출판사_추가수정삭제_label.TabIndex = 29;
            this.출판사_추가수정삭제_label.Text = "출판사";
            // 
            // 추가_button
            // 
            this.추가_button.Location = new System.Drawing.Point(683, 349);
            this.추가_button.Name = "추가_button";
            this.추가_button.Size = new System.Drawing.Size(75, 23);
            this.추가_button.TabIndex = 17;
            this.추가_button.Text = "추가";
            this.추가_button.UseVisualStyleBackColor = true;
            // 
            // 수정_button
            // 
            this.수정_button.Location = new System.Drawing.Point(683, 378);
            this.수정_button.Name = "수정_button";
            this.수정_button.Size = new System.Drawing.Size(75, 23);
            this.수정_button.TabIndex = 17;
            this.수정_button.Text = "수정";
            this.수정_button.UseVisualStyleBackColor = true;
            // 
            // 삭제_button
            // 
            this.삭제_button.Location = new System.Drawing.Point(683, 407);
            this.삭제_button.Name = "삭제_button";
            this.삭제_button.Size = new System.Drawing.Size(75, 23);
            this.삭제_button.TabIndex = 17;
            this.삭제_button.Text = "삭제";
            this.삭제_button.UseVisualStyleBackColor = true;
            // 
            // 도서관리_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.출판사_추가수정삭제_textBox);
            this.Controls.Add(this.출판사_추가수정삭제_label);
            this.Controls.Add(this.저자_추가수정삭제_textBox);
            this.Controls.Add(this.저자_추가수정삭제_label);
            this.Controls.Add(this.도서이름_추가수정삭제_textBox);
            this.Controls.Add(this.도서이름_추가수정삭제_label);
            this.Controls.Add(this.ISBN_추가수정삭제_textBox);
            this.Controls.Add(this.ISBN_추가수정삭제_label);
            this.Controls.Add(this.도서_dataGridView);
            this.Controls.Add(this.출판사_검색_textBox);
            this.Controls.Add(this.저자_검색_textBox);
            this.Controls.Add(this.도서이름_검색_textBox);
            this.Controls.Add(this.ISBN_검색_textBox);
            this.Controls.Add(this.추가_button);
            this.Controls.Add(this.삭제_button);
            this.Controls.Add(this.수정_button);
            this.Controls.Add(this.검색_button);
            this.Controls.Add(this.출판사_검색_label);
            this.Controls.Add(this.저자_검색_label);
            this.Controls.Add(this.도서이름_검색_label);
            this.Controls.Add(this.ISBN_검색_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "도서관리_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "도서";
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 출판사_검색_textBox;
        private System.Windows.Forms.TextBox 저자_검색_textBox;
        private System.Windows.Forms.TextBox 도서이름_검색_textBox;
        private System.Windows.Forms.TextBox ISBN_검색_textBox;
        private System.Windows.Forms.Button 검색_button;
        private System.Windows.Forms.Label 출판사_검색_label;
        private System.Windows.Forms.Label 저자_검색_label;
        private System.Windows.Forms.Label 도서이름_검색_label;
        private System.Windows.Forms.Label ISBN_검색_label;
        private System.Windows.Forms.DataGridView 도서_dataGridView;
        private System.Windows.Forms.TextBox ISBN_추가수정삭제_textBox;
        private System.Windows.Forms.Label ISBN_추가수정삭제_label;
        private System.Windows.Forms.TextBox 도서이름_추가수정삭제_textBox;
        private System.Windows.Forms.Label 도서이름_추가수정삭제_label;
        private System.Windows.Forms.TextBox 저자_추가수정삭제_textBox;
        private System.Windows.Forms.Label 저자_추가수정삭제_label;
        private System.Windows.Forms.TextBox 출판사_추가수정삭제_textBox;
        private System.Windows.Forms.Label 출판사_추가수정삭제_label;
        private System.Windows.Forms.Button 추가_button;
        private System.Windows.Forms.Button 수정_button;
        private System.Windows.Forms.Button 삭제_button;
    }
}