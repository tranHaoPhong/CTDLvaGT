namespace Dictionary_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtUserSearch = new TextBox();
            lstWord = new ListBox();
            txtTypeWord = new TextBox();
            txtDescription = new TextBox();
            txtExample = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnOpenFormAdd = new Button();
            btnDelete = new Button();
            txtWord = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 70);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // txtUserSearch
            // 
            txtUserSearch.Location = new Point(79, 93);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(264, 27);
            txtUserSearch.TabIndex = 2;
            txtUserSearch.TextChanged += txtUserSearch_TextChanged;
            // 
            // lstWord
            // 
            lstWord.FormattingEnabled = true;
            lstWord.ItemHeight = 20;
            lstWord.Location = new Point(79, 155);
            lstWord.Name = "lstWord";
            lstWord.Size = new Size(264, 244);
            lstWord.TabIndex = 3;
            lstWord.SelectedIndexChanged += lstWord_SelectedIndexChanged;
            // 
            // txtTypeWord
            // 
            txtTypeWord.Location = new Point(519, 93);
            txtTypeWord.Name = "txtTypeWord";
            txtTypeWord.ReadOnly = true;
            txtTypeWord.Size = new Size(125, 27);
            txtTypeWord.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(372, 155);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(125, 244);
            txtDescription.TabIndex = 5;
            // 
            // txtExample
            // 
            txtExample.Location = new Point(519, 155);
            txtExample.Multiline = true;
            txtExample.Name = "txtExample";
            txtExample.ReadOnly = true;
            txtExample.Size = new Size(125, 244);
            txtExample.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 123);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 12;
            label2.Text = "Kết quả tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 70);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 13;
            label3.Text = "Từ loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 123);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 14;
            label4.Text = "Nghĩa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 123);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 15;
            label5.Text = "Ví dụ";
            // 
            // btnOpenFormAdd
            // 
            btnOpenFormAdd.Location = new Point(550, 412);
            btnOpenFormAdd.Name = "btnOpenFormAdd";
            btnOpenFormAdd.Size = new Size(94, 66);
            btnOpenFormAdd.TabIndex = 16;
            btnOpenFormAdd.Text = "Chế độ Thêm/Sửa";
            btnOpenFormAdd.UseVisualStyleBackColor = true;
            btnOpenFormAdd.Click += btnOpenFormAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(79, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 63);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa từ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(372, 93);
            txtWord.Name = "txtWord";
            txtWord.ReadOnly = true;
            txtWord.Size = new Size(125, 27);
            txtWord.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 70);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 19;
            label6.Text = "Từ vựng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(718, 512);
            Controls.Add(label6);
            Controls.Add(txtWord);
            Controls.Add(btnDelete);
            Controls.Add(btnOpenFormAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtExample);
            Controls.Add(txtDescription);
            Controls.Add(txtTypeWord);
            Controls.Add(lstWord);
            Controls.Add(txtUserSearch);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Từ điển Anh - Việt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtUserSearch;
        private ListBox lstWord;
        private TextBox txtTypeWord;
        private TextBox txtDescription;
        private TextBox txtExample;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnOpenFormAdd;
        private Button btnDelete;
        private TextBox txtWord;
        private Label label6;
    }
}