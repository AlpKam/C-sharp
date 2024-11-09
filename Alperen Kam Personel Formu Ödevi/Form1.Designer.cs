namespace WinFormsApp2
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            label12 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12.25F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 71);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 3;
            label2.Text = "Telefon";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 308);
            button1.Name = "button1";
            button1.Size = new Size(512, 45);
            button1.TabIndex = 5;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 34);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 6;
            label3.Text = "Adı  Soyadı  ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 67);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 7;
            label4.Text = "Telefonu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(19, 108);
            label8.Name = "label8";
            label8.Size = new Size(46, 21);
            label8.TabIndex = 11;
            label8.Text = "Şehir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(19, 150);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 12;
            label9.Text = "Adres";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(118, 150);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(142, 96);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Artvin", "Ardahan", "Erzurum", "Kars", "Rize" });
            comboBox1.Location = new Point(118, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 15;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(118, 71);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(142, 23);
            maskedTextBox1.TabIndex = 16;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Location = new Point(9, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(43, 19);
            radioButton3.TabIndex = 18;
            radioButton3.TabStop = true;
            radioButton3.Text = "Evli";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Location = new Point(9, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(54, 19);
            radioButton4.TabIndex = 19;
            radioButton4.TabStop = true;
            radioButton4.Text = "Bekar";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(312, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(122, 80);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medeni Hal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(0, 22);
            label12.Name = "label12";
            label12.Size = new Size(97, 21);
            label12.TabIndex = 23;
            label12.Text = "Çocuk Sayısı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(106, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Eşi Çalışıyor";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(15, 102);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 27;
            label7.Text = "Şehri";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(15, 137);
            label13.Name = "label13";
            label13.Size = new Size(68, 25);
            label13.TabIndex = 28;
            label13.Text = "Adresi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(15, 252);
            label14.Name = "label14";
            label14.Size = new Size(126, 25);
            label14.TabIndex = 29;
            label14.Text = "Eş iş durumu";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(13, 211);
            label15.Name = "label15";
            label15.Size = new Size(122, 25);
            label15.TabIndex = 30;
            label15.Text = "Çocuk Sayısı";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(13, 174);
            label16.Name = "label16";
            label16.Size = new Size(119, 25);
            label16.TabIndex = 31;
            label16.Text = "Medeni Hali";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(312, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 110);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aile Bilgiler";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(591, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 331);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personel Bilgiler";
            // 
            // button2
            // 
            button2.Location = new Point(15, 286);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 32;
            button2.TabStop = false;
            button2.Text = "KAPAT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(815, 382);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Personel Formu";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label9;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox2;
        private Label label12;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Label label7;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button button2;
    }
}
