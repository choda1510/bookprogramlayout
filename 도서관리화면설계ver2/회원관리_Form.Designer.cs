
namespace 도서관리화면설계ver2
{
    partial class 회원관리_Form
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
            this.회원_dataGridView = new System.Windows.Forms.DataGridView();
            this.주소_검색_textBox = new System.Windows.Forms.TextBox();
            this.전화번호_검색_textBox = new System.Windows.Forms.TextBox();
            this.이름_검색_textBox = new System.Windows.Forms.TextBox();
            this.아이디_검색_textBox = new System.Windows.Forms.TextBox();
            this.검색_button = new System.Windows.Forms.Button();
            this.주소_검색_label = new System.Windows.Forms.Label();
            this.전화번호_검색_label = new System.Windows.Forms.Label();
            this.이름_검색_label = new System.Windows.Forms.Label();
            this.아이디_검색_label = new System.Windows.Forms.Label();
            this.주소_textBox = new System.Windows.Forms.TextBox();
            this.주소_label = new System.Windows.Forms.Label();
            this.전화번호_textBox = new System.Windows.Forms.TextBox();
            this.전화번호_label = new System.Windows.Forms.Label();
            this.이름_textBox = new System.Windows.Forms.TextBox();
            this.이름_label = new System.Windows.Forms.Label();
            this.비밀번호_textBox = new System.Windows.Forms.TextBox();
            this.아이디_textBox = new System.Windows.Forms.TextBox();
            this.비밀번호_label = new System.Windows.Forms.Label();
            this.아이디_label = new System.Windows.Forms.Label();
            this.추가_button = new System.Windows.Forms.Button();
            this.삭제_button = new System.Windows.Forms.Button();
            this.수정_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.회원_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 회원_dataGridView
            // 
            this.회원_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.회원_dataGridView.Location = new System.Drawing.Point(12, 102);
            this.회원_dataGridView.Name = "회원_dataGridView";
            this.회원_dataGridView.RowTemplate.Height = 23;
            this.회원_dataGridView.Size = new System.Drawing.Size(656, 336);
            this.회원_dataGridView.TabIndex = 33;
            // 
            // 주소_검색_textBox
            // 
            this.주소_검색_textBox.Location = new System.Drawing.Point(491, 75);
            this.주소_검색_textBox.Name = "주소_검색_textBox";
            this.주소_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.주소_검색_textBox.TabIndex = 29;
            // 
            // 전화번호_검색_textBox
            // 
            this.전화번호_검색_textBox.Location = new System.Drawing.Point(346, 75);
            this.전화번호_검색_textBox.Name = "전화번호_검색_textBox";
            this.전화번호_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.전화번호_검색_textBox.TabIndex = 30;
            // 
            // 이름_검색_textBox
            // 
            this.이름_검색_textBox.Location = new System.Drawing.Point(186, 75);
            this.이름_검색_textBox.Name = "이름_검색_textBox";
            this.이름_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.이름_검색_textBox.TabIndex = 31;
            // 
            // 아이디_검색_textBox
            // 
            this.아이디_검색_textBox.Location = new System.Drawing.Point(49, 75);
            this.아이디_검색_textBox.Name = "아이디_검색_textBox";
            this.아이디_검색_textBox.Size = new System.Drawing.Size(96, 21);
            this.아이디_검색_textBox.TabIndex = 32;
            // 
            // 검색_button
            // 
            this.검색_button.Location = new System.Drawing.Point(593, 75);
            this.검색_button.Name = "검색_button";
            this.검색_button.Size = new System.Drawing.Size(75, 23);
            this.검색_button.TabIndex = 28;
            this.검색_button.Text = "검색";
            this.검색_button.UseVisualStyleBackColor = true;
            // 
            // 주소_검색_label
            // 
            this.주소_검색_label.AutoSize = true;
            this.주소_검색_label.Location = new System.Drawing.Point(449, 78);
            this.주소_검색_label.Name = "주소_검색_label";
            this.주소_검색_label.Size = new System.Drawing.Size(29, 12);
            this.주소_검색_label.TabIndex = 24;
            this.주소_검색_label.Text = "주소";
            // 
            // 전화번호_검색_label
            // 
            this.전화번호_검색_label.AutoSize = true;
            this.전화번호_검색_label.Location = new System.Drawing.Point(287, 78);
            this.전화번호_검색_label.Name = "전화번호_검색_label";
            this.전화번호_검색_label.Size = new System.Drawing.Size(53, 12);
            this.전화번호_검색_label.TabIndex = 25;
            this.전화번호_검색_label.Text = "전화번호";
            // 
            // 이름_검색_label
            // 
            this.이름_검색_label.AutoSize = true;
            this.이름_검색_label.Location = new System.Drawing.Point(151, 78);
            this.이름_검색_label.Name = "이름_검색_label";
            this.이름_검색_label.Size = new System.Drawing.Size(29, 12);
            this.이름_검색_label.TabIndex = 26;
            this.이름_검색_label.Text = "이름";
            // 
            // 아이디_검색_label
            // 
            this.아이디_검색_label.AutoSize = true;
            this.아이디_검색_label.Location = new System.Drawing.Point(10, 78);
            this.아이디_검색_label.Name = "아이디_검색_label";
            this.아이디_검색_label.Size = new System.Drawing.Size(41, 12);
            this.아이디_검색_label.TabIndex = 27;
            this.아이디_검색_label.Text = "아이디";
            // 
            // 주소_textBox
            // 
            this.주소_textBox.Location = new System.Drawing.Point(674, 281);
            this.주소_textBox.Name = "주소_textBox";
            this.주소_textBox.Size = new System.Drawing.Size(96, 21);
            this.주소_textBox.TabIndex = 47;
            // 
            // 주소_label
            // 
            this.주소_label.AutoSize = true;
            this.주소_label.Location = new System.Drawing.Point(672, 266);
            this.주소_label.Name = "주소_label";
            this.주소_label.Size = new System.Drawing.Size(29, 12);
            this.주소_label.TabIndex = 46;
            this.주소_label.Text = "주소";
            // 
            // 전화번호_textBox
            // 
            this.전화번호_textBox.Location = new System.Drawing.Point(674, 242);
            this.전화번호_textBox.Name = "전화번호_textBox";
            this.전화번호_textBox.Size = new System.Drawing.Size(96, 21);
            this.전화번호_textBox.TabIndex = 45;
            // 
            // 전화번호_label
            // 
            this.전화번호_label.AutoSize = true;
            this.전화번호_label.Location = new System.Drawing.Point(672, 227);
            this.전화번호_label.Name = "전화번호_label";
            this.전화번호_label.Size = new System.Drawing.Size(53, 12);
            this.전화번호_label.TabIndex = 44;
            this.전화번호_label.Text = "전화번호";
            // 
            // 이름_textBox
            // 
            this.이름_textBox.Location = new System.Drawing.Point(674, 203);
            this.이름_textBox.Name = "이름_textBox";
            this.이름_textBox.Size = new System.Drawing.Size(96, 21);
            this.이름_textBox.TabIndex = 43;
            // 
            // 이름_label
            // 
            this.이름_label.AutoSize = true;
            this.이름_label.Location = new System.Drawing.Point(672, 186);
            this.이름_label.Name = "이름_label";
            this.이름_label.Size = new System.Drawing.Size(29, 12);
            this.이름_label.TabIndex = 42;
            this.이름_label.Text = "이름";
            // 
            // 비밀번호_textBox
            // 
            this.비밀번호_textBox.Location = new System.Drawing.Point(673, 162);
            this.비밀번호_textBox.Name = "비밀번호_textBox";
            this.비밀번호_textBox.Size = new System.Drawing.Size(96, 21);
            this.비밀번호_textBox.TabIndex = 40;
            // 
            // 아이디_textBox
            // 
            this.아이디_textBox.Location = new System.Drawing.Point(673, 123);
            this.아이디_textBox.Name = "아이디_textBox";
            this.아이디_textBox.Size = new System.Drawing.Size(96, 21);
            this.아이디_textBox.TabIndex = 41;
            // 
            // 비밀번호_label
            // 
            this.비밀번호_label.AutoSize = true;
            this.비밀번호_label.Location = new System.Drawing.Point(674, 147);
            this.비밀번호_label.Name = "비밀번호_label";
            this.비밀번호_label.Size = new System.Drawing.Size(53, 12);
            this.비밀번호_label.TabIndex = 38;
            this.비밀번호_label.Text = "비밀번호";
            // 
            // 아이디_label
            // 
            this.아이디_label.AutoSize = true;
            this.아이디_label.Location = new System.Drawing.Point(674, 108);
            this.아이디_label.Name = "아이디_label";
            this.아이디_label.Size = new System.Drawing.Size(41, 12);
            this.아이디_label.TabIndex = 39;
            this.아이디_label.Text = "아이디";
            // 
            // 추가_button
            // 
            this.추가_button.Location = new System.Drawing.Point(694, 348);
            this.추가_button.Name = "추가_button";
            this.추가_button.Size = new System.Drawing.Size(75, 23);
            this.추가_button.TabIndex = 35;
            this.추가_button.Text = "추가";
            this.추가_button.UseVisualStyleBackColor = true;
            // 
            // 삭제_button
            // 
            this.삭제_button.Location = new System.Drawing.Point(694, 406);
            this.삭제_button.Name = "삭제_button";
            this.삭제_button.Size = new System.Drawing.Size(75, 23);
            this.삭제_button.TabIndex = 36;
            this.삭제_button.Text = "삭제";
            this.삭제_button.UseVisualStyleBackColor = true;
            // 
            // 수정_button
            // 
            this.수정_button.Location = new System.Drawing.Point(694, 377);
            this.수정_button.Name = "수정_button";
            this.수정_button.Size = new System.Drawing.Size(75, 23);
            this.수정_button.TabIndex = 37;
            this.수정_button.Text = "수정";
            this.수정_button.UseVisualStyleBackColor = true;
            // 
            // 회원관리_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.주소_textBox);
            this.Controls.Add(this.주소_label);
            this.Controls.Add(this.전화번호_textBox);
            this.Controls.Add(this.전화번호_label);
            this.Controls.Add(this.이름_textBox);
            this.Controls.Add(this.이름_label);
            this.Controls.Add(this.비밀번호_textBox);
            this.Controls.Add(this.아이디_textBox);
            this.Controls.Add(this.비밀번호_label);
            this.Controls.Add(this.아이디_label);
            this.Controls.Add(this.추가_button);
            this.Controls.Add(this.삭제_button);
            this.Controls.Add(this.수정_button);
            this.Controls.Add(this.회원_dataGridView);
            this.Controls.Add(this.주소_검색_textBox);
            this.Controls.Add(this.전화번호_검색_textBox);
            this.Controls.Add(this.이름_검색_textBox);
            this.Controls.Add(this.아이디_검색_textBox);
            this.Controls.Add(this.검색_button);
            this.Controls.Add(this.주소_검색_label);
            this.Controls.Add(this.전화번호_검색_label);
            this.Controls.Add(this.이름_검색_label);
            this.Controls.Add(this.아이디_검색_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "회원관리_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "회원";
            ((System.ComponentModel.ISupportInitialize)(this.회원_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView 회원_dataGridView;
        private System.Windows.Forms.TextBox 주소_검색_textBox;
        private System.Windows.Forms.TextBox 전화번호_검색_textBox;
        private System.Windows.Forms.TextBox 이름_검색_textBox;
        private System.Windows.Forms.TextBox 아이디_검색_textBox;
        private System.Windows.Forms.Button 검색_button;
        private System.Windows.Forms.Label 주소_검색_label;
        private System.Windows.Forms.Label 전화번호_검색_label;
        private System.Windows.Forms.Label 이름_검색_label;
        private System.Windows.Forms.Label 아이디_검색_label;
        private System.Windows.Forms.TextBox 주소_textBox;
        private System.Windows.Forms.Label 주소_label;
        private System.Windows.Forms.TextBox 전화번호_textBox;
        private System.Windows.Forms.Label 전화번호_label;
        private System.Windows.Forms.TextBox 이름_textBox;
        private System.Windows.Forms.Label 이름_label;
        private System.Windows.Forms.TextBox 비밀번호_textBox;
        private System.Windows.Forms.TextBox 아이디_textBox;
        private System.Windows.Forms.Label 비밀번호_label;
        private System.Windows.Forms.Label 아이디_label;
        private System.Windows.Forms.Button 추가_button;
        private System.Windows.Forms.Button 삭제_button;
        private System.Windows.Forms.Button 수정_button;
    }
}