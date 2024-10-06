namespace ДЗЗ_1
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
            graphics = new PictureBox();
            groupBox1 = new GroupBox();
            loadButton = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            vScrollBar1 = new VScrollBar();
            openFileDialog1 = new OpenFileDialog();
            listView1 = new ListView();
            button1 = new Button();
            groupBox4 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox5 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)graphics).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // graphics
            // 
            graphics.BorderStyle = BorderStyle.Fixed3D;
            graphics.Location = new Point(12, 12);
            graphics.Name = "graphics";
            graphics.Size = new Size(500, 561);
            graphics.TabIndex = 0;
            graphics.TabStop = false;
            graphics.MouseClick += pictureBox1_MouseClick;
            graphics.MouseMove += pictureBox1_MouseMove;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loadButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(533, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 70);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Файл";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(6, 37);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 2;
            loadButton.Text = "Загрузить";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя файла:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(12, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 54);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сдвигать коды на:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(124, 23);
            radioButton4.Name = "radioButton4";
            radioButton4.RightToLeft = RightToLeft.No;
            radioButton4.Size = new Size(32, 19);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "3";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(86, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(32, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "2";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(48, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(32, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "1";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(10, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(32, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "0";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(533, 253);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(156, 106);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Координаты курсора:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 75);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 3;
            label6.Text = "Яркость = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 49);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 2;
            label5.Text = "Y = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "X  = ";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(515, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(10, 564);
            vScrollBar1.TabIndex = 4;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.BackColor = SystemColors.Menu;
            listView1.LabelWrap = false;
            listView1.Location = new Point(619, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(239, 41);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Сброс";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(533, 88);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(331, 159);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Модификации";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(13, 101);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Нормировать";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckStateChanged += checkBox2_CheckStateChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Интерполировать";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label2);
            groupBox5.Location = new Point(200, 31);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(125, 45);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Приближение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 18);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "x1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 607);
            Controls.Add(groupBox4);
            Controls.Add(listView1);
            Controls.Add(vScrollBar1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(graphics);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)graphics).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox graphics;
        private GroupBox groupBox1;
        private Label label1;
        private Button loadButton;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private OpenFileDialog openFileDialog1;
        private ListView listView1;
        private Button button1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label4;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
