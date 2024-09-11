namespace Shop
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(722, 150);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(97, 312);
            button1.Name = "button1";
            button1.Size = new Size(90, 44);
            button1.TabIndex = 1;
            button1.Text = "เพิ่มสินค้า";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(193, 312);
            button2.Name = "button2";
            button2.Size = new Size(90, 44);
            button2.TabIndex = 1;
            button2.Text = "แก้ไขสินค้า";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(289, 312);
            button3.Name = "button3";
            button3.Size = new Size(90, 44);
            button3.TabIndex = 1;
            button3.Text = "นำสินค้าออก";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(631, 312);
            button4.Name = "button4";
            button4.Size = new Size(102, 44);
            button4.TabIndex = 1;
            button4.Text = "โหลดข้อมูลสินค้า";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(694, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 48);
            button5.TabIndex = 2;
            button5.Text = "Button";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}