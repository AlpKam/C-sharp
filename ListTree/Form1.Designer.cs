namespace ListTree
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
            listBox1 = new ListBox();
            treeView1 = new TreeView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ControlDark;
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Başkan", "Alp", "Başkan Yardımcısı", "Ali", "YKurulu", "Veli", "Ayşe", "Fatma", "Hasan", "Erhan" });
            listBox1.Location = new Point(161, 73);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(192, 384);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.MidnightBlue;
            treeView1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            treeView1.ForeColor = Color.White;
            treeView1.Location = new Point(548, 77);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(198, 390);
            treeView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(401, 48);
            button1.Name = "button1";
            button1.Size = new Size(93, 26);
            button1.TabIndex = 4;
            button1.Text = "Alt Öge Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(161, 48);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Kök Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(661, 46);
            button3.Name = "button3";
            button3.Size = new Size(85, 26);
            button3.TabIndex = 6;
            button3.Text = "Seçili Öge Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(954, 581);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Controls.Add(listBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private TreeView treeView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
