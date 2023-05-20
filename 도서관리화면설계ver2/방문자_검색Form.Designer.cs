
namespace 도서관리화면설계ver2
{
    partial class 방문자_검색Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ISBN_label = new System.Windows.Forms.Label();
            this.검색_button = new System.Windows.Forms.Button();
            this.ISBN_textBox = new System.Windows.Forms.TextBox();
            this.도서이름_label = new System.Windows.Forms.Label();
            this.도서이름_textBox = new System.Windows.Forms.TextBox();
            this.저자_label = new System.Windows.Forms.Label();
            this.저자_textBox = new System.Windows.Forms.TextBox();
            this.출판사_label = new System.Windows.Forms.Label();
            this.출판사_textBox = new System.Windows.Forms.TextBox();
            this.도서_dataGridView = new System.Windows.Forms.DataGridView();
            this.로그인_label = new System.Windows.Forms.Label();
            this.회원가입_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN_label
            // 
            this.ISBN_label.AutoSize = true;
            this.ISBN_label.Location = new System.Drawing.Point(35, 69);
            this.ISBN_label.Name = "ISBN_label";
            this.ISBN_label.Size = new System.Drawing.Size(33, 12);
            this.ISBN_label.TabIndex = 0;
            this.ISBN_label.Text = "ISBN";
            // 
            // 검색_button
            // 
            this.검색_button.Location = new System.Drawing.Point(618, 66);
            this.검색_button.Name = "검색_button";
            this.검색_button.Size = new System.Drawing.Size(75, 23);
            this.검색_button.TabIndex = 1;
            this.검색_button.Text = "검색";
            this.검색_button.UseVisualStyleBackColor = true;
            // 
            // ISBN_textBox
            // 
            this.ISBN_textBox.Location = new System.Drawing.Point(74, 66);
            this.ISBN_textBox.Name = "ISBN_textBox";
            this.ISBN_textBox.Size = new System.Drawing.Size(96, 21);
            this.ISBN_textBox.TabIndex = 2;
            // 
            // 도서이름_label
            // 
            this.도서이름_label.AutoSize = true;
            this.도서이름_label.Location = new System.Drawing.Point(176, 69);
            this.도서이름_label.Name = "도서이름_label";
            this.도서이름_label.Size = new System.Drawing.Size(53, 12);
            this.도서이름_label.TabIndex = 0;
            this.도서이름_label.Text = "도서이름";
            // 
            // 도서이름_textBox
            // 
            this.도서이름_textBox.Location = new System.Drawing.Point(235, 66);
            this.도서이름_textBox.Name = "도서이름_textBox";
            this.도서이름_textBox.Size = new System.Drawing.Size(96, 21);
            this.도서이름_textBox.TabIndex = 2;
            // 
            // 저자_label
            // 
            this.저자_label.AutoSize = true;
            this.저자_label.Location = new System.Drawing.Point(337, 69);
            this.저자_label.Name = "저자_label";
            this.저자_label.Size = new System.Drawing.Size(29, 12);
            this.저자_label.TabIndex = 0;
            this.저자_label.Text = "저자";
            // 
            // 저자_textBox
            // 
            this.저자_textBox.Location = new System.Drawing.Point(372, 66);
            this.저자_textBox.Name = "저자_textBox";
            this.저자_textBox.Size = new System.Drawing.Size(96, 21);
            this.저자_textBox.TabIndex = 2;
            // 
            // 출판사_label
            // 
            this.출판사_label.AutoSize = true;
            this.출판사_label.Location = new System.Drawing.Point(474, 69);
            this.출판사_label.Name = "출판사_label";
            this.출판사_label.Size = new System.Drawing.Size(41, 12);
            this.출판사_label.TabIndex = 0;
            this.출판사_label.Text = "출판사";
            // 
            // 출판사_textBox
            // 
            this.출판사_textBox.Location = new System.Drawing.Point(516, 66);
            this.출판사_textBox.Name = "출판사_textBox";
            this.출판사_textBox.Size = new System.Drawing.Size(96, 21);
            this.출판사_textBox.TabIndex = 2;
            // 
            // 도서_dataGridView
            // 
            this.도서_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.도서_dataGridView.Location = new System.Drawing.Point(37, 93);
            this.도서_dataGridView.Name = "도서_dataGridView";
            this.도서_dataGridView.RowTemplate.Height = 23;
            this.도서_dataGridView.Size = new System.Drawing.Size(656, 336);
            this.도서_dataGridView.TabIndex = 3;
            // 
            // 로그인_label
            // 
            this.로그인_label.AutoSize = true;
            this.로그인_label.Location = new System.Drawing.Point(703, 23);
            this.로그인_label.Name = "로그인_label";
            this.로그인_label.Size = new System.Drawing.Size(41, 12);
            this.로그인_label.TabIndex = 0;
            this.로그인_label.Text = "로그인";
            this.로그인_label.Click += new System.EventHandler(this.로그인_label_Click);
            // 
            // 회원가입_label
            // 
            this.회원가입_label.AutoSize = true;
            this.회원가입_label.Location = new System.Drawing.Point(703, 48);
            this.회원가입_label.Name = "회원가입_label";
            this.회원가입_label.Size = new System.Drawing.Size(53, 12);
            this.회원가입_label.TabIndex = 0;
            this.회원가입_label.Text = "회원가입";
            this.회원가입_label.Click += new System.EventHandler(this.회원가입_label_Click);
            // 
            // 방문자_검색Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.도서_dataGridView);
            this.Controls.Add(this.출판사_textBox);
            this.Controls.Add(this.저자_textBox);
            this.Controls.Add(this.도서이름_textBox);
            this.Controls.Add(this.ISBN_textBox);
            this.Controls.Add(this.검색_button);
            this.Controls.Add(this.회원가입_label);
            this.Controls.Add(this.로그인_label);
            this.Controls.Add(this.출판사_label);
            this.Controls.Add(this.저자_label);
            this.Controls.Add(this.도서이름_label);
            this.Controls.Add(this.ISBN_label);
            this.Name = "방문자_검색Form";
            this.Text = "검색";
            ((System.ComponentModel.ISupportInitialize)(this.도서_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ISBN_label;
        private System.Windows.Forms.Button 검색_button;
        private System.Windows.Forms.TextBox ISBN_textBox;
        private System.Windows.Forms.Label 도서이름_label;
        private System.Windows.Forms.TextBox 도서이름_textBox;
        private System.Windows.Forms.Label 저자_label;
        private System.Windows.Forms.TextBox 저자_textBox;
        private System.Windows.Forms.Label 출판사_label;
        private System.Windows.Forms.TextBox 출판사_textBox;
        private System.Windows.Forms.DataGridView 도서_dataGridView;
        private System.Windows.Forms.Label 로그인_label;
        private System.Windows.Forms.Label 회원가입_label;
    }
}

