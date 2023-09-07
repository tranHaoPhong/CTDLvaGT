namespace Dictionary_B
{
    partial class FormAddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddWord));
            txtAddWord = new TextBox();
            txtAddDescription = new TextBox();
            txtAddExample = new TextBox();
            cmbAddTypeWord = new ComboBox();
            btnAddEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtAddWord
            // 
            txtAddWord.Location = new Point(181, 124);
            txtAddWord.Multiline = true;
            txtAddWord.Name = "txtAddWord";
            txtAddWord.Size = new Size(191, 27);
            txtAddWord.TabIndex = 0;
            txtAddWord.TextChanged += txtAddWord_TextChanged;
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(181, 177);
            txtAddDescription.Multiline = true;
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(191, 177);
            txtAddDescription.TabIndex = 1;
            // 
            // txtAddExample
            // 
            txtAddExample.Location = new Point(441, 177);
            txtAddExample.Multiline = true;
            txtAddExample.Name = "txtAddExample";
            txtAddExample.Size = new Size(187, 177);
            txtAddExample.TabIndex = 2;
            // 
            // cmbAddTypeWord
            // 
            cmbAddTypeWord.FormattingEnabled = true;
            cmbAddTypeWord.Location = new Point(441, 123);
            cmbAddTypeWord.Name = "cmbAddTypeWord";
            cmbAddTypeWord.Size = new Size(183, 28);
            cmbAddTypeWord.TabIndex = 3;
            // 
            // btnAddEdit
            // 
            btnAddEdit.Location = new Point(673, 259);
            btnAddEdit.Name = "btnAddEdit";
            btnAddEdit.Size = new Size(94, 95);
            btnAddEdit.TabIndex = 4;
            btnAddEdit.Text = "Thêm/Sửa";
            btnAddEdit.UseVisualStyleBackColor = true;
            btnAddEdit.Click += btnAddEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 100);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 5;
            label1.Text = "Từ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 100);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Từ loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Nghĩa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 154);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "Ví dụ";
            // 
            // FormAddWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddEdit);
            Controls.Add(cmbAddTypeWord);
            Controls.Add(txtAddExample);
            Controls.Add(txtAddDescription);
            Controls.Add(txtAddWord);
            Name = "FormAddWord";
            Text = "FormAddWord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddWord;
        private TextBox txtAddDescription;
        private TextBox txtAddExample;
        private ComboBox cmbAddTypeWord;
        private Button btnAddEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}