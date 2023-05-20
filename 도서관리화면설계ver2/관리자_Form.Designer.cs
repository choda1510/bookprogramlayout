
namespace 도서관리화면설계ver2
{
    partial class 관리자_Form
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
            this.대출_button = new System.Windows.Forms.Button();
            this.연체_button = new System.Windows.Forms.Button();
            this.도서_button = new System.Windows.Forms.Button();
            this.알바_button = new System.Windows.Forms.Button();
            this.회원_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 대출_button
            // 
            this.대출_button.Location = new System.Drawing.Point(12, 12);
            this.대출_button.Name = "대출_button";
            this.대출_button.Size = new System.Drawing.Size(83, 36);
            this.대출_button.TabIndex = 1;
            this.대출_button.Text = "대출";
            this.대출_button.UseVisualStyleBackColor = true;
            this.대출_button.Click += new System.EventHandler(this.대출_button_Click);
            // 
            // 연체_button
            // 
            this.연체_button.Location = new System.Drawing.Point(101, 12);
            this.연체_button.Name = "연체_button";
            this.연체_button.Size = new System.Drawing.Size(83, 36);
            this.연체_button.TabIndex = 1;
            this.연체_button.Text = "연체";
            this.연체_button.UseVisualStyleBackColor = true;
            this.연체_button.Click += new System.EventHandler(this.연체_button_Click);
            // 
            // 도서_button
            // 
            this.도서_button.Location = new System.Drawing.Point(190, 12);
            this.도서_button.Name = "도서_button";
            this.도서_button.Size = new System.Drawing.Size(83, 36);
            this.도서_button.TabIndex = 1;
            this.도서_button.Text = "도서";
            this.도서_button.UseVisualStyleBackColor = true;
            this.도서_button.Click += new System.EventHandler(this.도서_button_Click);
            // 
            // 알바_button
            // 
            this.알바_button.Location = new System.Drawing.Point(279, 12);
            this.알바_button.Name = "알바_button";
            this.알바_button.Size = new System.Drawing.Size(83, 36);
            this.알바_button.TabIndex = 1;
            this.알바_button.Text = "알바";
            this.알바_button.UseVisualStyleBackColor = true;
            this.알바_button.Click += new System.EventHandler(this.알바_button_Click);
            // 
            // 회원_button
            // 
            this.회원_button.Location = new System.Drawing.Point(368, 12);
            this.회원_button.Name = "회원_button";
            this.회원_button.Size = new System.Drawing.Size(83, 36);
            this.회원_button.TabIndex = 1;
            this.회원_button.Text = "회원";
            this.회원_button.UseVisualStyleBackColor = true;
            this.회원_button.Click += new System.EventHandler(this.회원_button_Click);
            // 
            // 관리자_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 498);
            this.Controls.Add(this.회원_button);
            this.Controls.Add(this.알바_button);
            this.Controls.Add(this.도서_button);
            this.Controls.Add(this.연체_button);
            this.Controls.Add(this.대출_button);
            this.IsMdiContainer = true;
            this.Name = "관리자_Form";
            this.Text = "관리자";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.관리자_Form_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 대출_button;
        private System.Windows.Forms.Button 연체_button;
        private System.Windows.Forms.Button 도서_button;
        private System.Windows.Forms.Button 알바_button;
        private System.Windows.Forms.Button 회원_button;
    }
}