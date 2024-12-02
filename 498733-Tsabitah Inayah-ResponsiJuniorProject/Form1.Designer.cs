namespace _498733_Tsabitah_Inayah_ResponsiJuniorProject
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 76);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 117);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan   :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ButtonFace;
            btnInsert.ForeColor = SystemColors.ControlText;
            btnInsert.Location = new Point(31, 177);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(125, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ButtonFace;
            btnEdit.Location = new Point(209, 177);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(386, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(480, 194);
            dataGridView1.TabIndex = 7;
            dataGridView1.Tag = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.AppWorkspace;
            richTextBox1.Location = new Point(372, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(139, 122);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "ID Departemen :\nHR : HR\nENG : Engineer\nDEV : Developer\nPM : Product M\nFIN : Finance\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 43);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 24);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 10;
            label3.Text = "logo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
