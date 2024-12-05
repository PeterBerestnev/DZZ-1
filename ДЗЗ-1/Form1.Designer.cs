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
            listView1 = new ListView();
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
            button1 = new Button();
            groupBox4 = new GroupBox();
            groupBox8 = new GroupBox();
            trackBarLabel8 = new Label();
            trackBarLabel17 = new Label();
            trackBarLabel6 = new Label();
            trackBarLabel5 = new Label();
            trackBarLabel4 = new Label();
            trackBarLabel3 = new Label();
            trackBarLabel2 = new Label();
            trackBarLabel1 = new Label();
            trackBar5 = new TrackBar();
            trackBar6 = new TrackBar();
            trackBar7 = new TrackBar();
            trackBar8 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            pictureBox1 = new PictureBox();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            compresedGraphics = new PictureBox();
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
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compresedGraphics).BeginInit();
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
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(533, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 70);
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
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.BackColor = SystemColors.Menu;
            listView1.LabelWrap = false;
            listView1.Location = new Point(90, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(421, 41);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
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
            groupBox3.Location = new Point(355, 22);
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
            // button1
            // 
            button1.Location = new Point(12, 82);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Сброс";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(533, 88);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(517, 507);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Модификации";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(trackBarLabel8);
            groupBox8.Controls.Add(trackBarLabel17);
            groupBox8.Controls.Add(trackBarLabel6);
            groupBox8.Controls.Add(trackBarLabel5);
            groupBox8.Controls.Add(trackBarLabel4);
            groupBox8.Controls.Add(trackBarLabel3);
            groupBox8.Controls.Add(trackBarLabel2);
            groupBox8.Controls.Add(trackBarLabel1);
            groupBox8.Controls.Add(trackBar5);
            groupBox8.Controls.Add(trackBar6);
            groupBox8.Controls.Add(trackBar7);
            groupBox8.Controls.Add(trackBar8);
            groupBox8.Controls.Add(trackBar3);
            groupBox8.Controls.Add(trackBar4);
            groupBox8.Controls.Add(trackBar2);
            groupBox8.Controls.Add(trackBar1);
            groupBox8.Controls.Add(pictureBox1);
            groupBox8.Location = new Point(12, 118);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(314, 378);
            groupBox8.TabIndex = 10;
            groupBox8.TabStop = false;
            groupBox8.Text = "Преобразование яркостей";
            // 
            // trackBarLabel8
            // 
            trackBarLabel8.AutoSize = true;
            trackBarLabel8.Location = new Point(276, 323);
            trackBarLabel8.Name = "trackBarLabel8";
            trackBarLabel8.Size = new Size(14, 15);
            trackBarLabel8.TabIndex = 16;
            trackBarLabel8.Text = "0";
            // 
            // trackBarLabel17
            // 
            trackBarLabel17.AutoSize = true;
            trackBarLabel17.Location = new Point(238, 323);
            trackBarLabel17.Name = "trackBarLabel17";
            trackBarLabel17.Size = new Size(14, 15);
            trackBarLabel17.TabIndex = 15;
            trackBarLabel17.Text = "0";
            // 
            // trackBarLabel6
            // 
            trackBarLabel6.AutoSize = true;
            trackBarLabel6.Location = new Point(200, 323);
            trackBarLabel6.Name = "trackBarLabel6";
            trackBarLabel6.Size = new Size(14, 15);
            trackBarLabel6.TabIndex = 14;
            trackBarLabel6.Text = "0";
            // 
            // trackBarLabel5
            // 
            trackBarLabel5.AutoSize = true;
            trackBarLabel5.Location = new Point(166, 323);
            trackBarLabel5.Name = "trackBarLabel5";
            trackBarLabel5.Size = new Size(14, 15);
            trackBarLabel5.TabIndex = 13;
            trackBarLabel5.Text = "0";
            // 
            // trackBarLabel4
            // 
            trackBarLabel4.AutoSize = true;
            trackBarLabel4.Location = new Point(124, 323);
            trackBarLabel4.Name = "trackBarLabel4";
            trackBarLabel4.Size = new Size(14, 15);
            trackBarLabel4.TabIndex = 12;
            trackBarLabel4.Text = "0";
            // 
            // trackBarLabel3
            // 
            trackBarLabel3.AutoSize = true;
            trackBarLabel3.Location = new Point(86, 323);
            trackBarLabel3.Name = "trackBarLabel3";
            trackBarLabel3.Size = new Size(14, 15);
            trackBarLabel3.TabIndex = 11;
            trackBarLabel3.Text = "0";
            // 
            // trackBarLabel2
            // 
            trackBarLabel2.AutoSize = true;
            trackBarLabel2.Location = new Point(48, 323);
            trackBarLabel2.Name = "trackBarLabel2";
            trackBarLabel2.Size = new Size(14, 15);
            trackBarLabel2.TabIndex = 10;
            trackBarLabel2.Text = "0";
            // 
            // trackBarLabel1
            // 
            trackBarLabel1.AutoSize = true;
            trackBarLabel1.Location = new Point(10, 323);
            trackBarLabel1.Name = "trackBarLabel1";
            trackBarLabel1.Size = new Size(14, 15);
            trackBarLabel1.TabIndex = 9;
            trackBarLabel1.Text = "0";
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(276, 213);
            trackBar5.Maximum = 255;
            trackBar5.Name = "trackBar5";
            trackBar5.Orientation = Orientation.Vertical;
            trackBar5.Size = new Size(45, 104);
            trackBar5.TabIndex = 8;
            trackBar5.Scroll += TrackBar_Scroll;
            // 
            // trackBar6
            // 
            trackBar6.Location = new Point(238, 213);
            trackBar6.Maximum = 255;
            trackBar6.Name = "trackBar6";
            trackBar6.Orientation = Orientation.Vertical;
            trackBar6.Size = new Size(45, 104);
            trackBar6.TabIndex = 7;
            trackBar6.Scroll += TrackBar_Scroll;
            // 
            // trackBar7
            // 
            trackBar7.Location = new Point(200, 213);
            trackBar7.Maximum = 255;
            trackBar7.Name = "trackBar7";
            trackBar7.Orientation = Orientation.Vertical;
            trackBar7.Size = new Size(45, 104);
            trackBar7.TabIndex = 6;
            trackBar7.Scroll += numericUpDown1_ValueChanged;
            // 
            // trackBar8
            // 
            trackBar8.Location = new Point(162, 213);
            trackBar8.Maximum = 255;
            trackBar8.Name = "trackBar8";
            trackBar8.Orientation = Orientation.Vertical;
            trackBar8.Size = new Size(45, 104);
            trackBar8.TabIndex = 5;
            trackBar8.Scroll += TrackBar_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(124, 213);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Orientation = Orientation.Vertical;
            trackBar3.Size = new Size(45, 104);
            trackBar3.TabIndex = 4;
            trackBar3.Scroll += TrackBar_Scroll;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(86, 213);
            trackBar4.Maximum = 255;
            trackBar4.Name = "trackBar4";
            trackBar4.Orientation = Orientation.Vertical;
            trackBar4.Size = new Size(45, 104);
            trackBar4.TabIndex = 3;
            trackBar4.Scroll += TrackBar_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(48, 213);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(45, 104);
            trackBar2.TabIndex = 2;
            trackBar2.Scroll += TrackBar_Scroll;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(10, 213);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 104);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += TrackBar_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(10, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 182);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Controls.Add(compresedGraphics);
            groupBox6.Location = new Point(332, 135);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(179, 366);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Обзорное изображение";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(numericUpDown1);
            groupBox7.Location = new Point(4, 306);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(169, 55);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Прореживание";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 24);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 1;
            label7.Text = "m =";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(47, 22);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.UpDownAlign = LeftRightAlignment.Left;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // compresedGraphics
            // 
            compresedGraphics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            compresedGraphics.BorderStyle = BorderStyle.Fixed3D;
            compresedGraphics.Location = new Point(4, 22);
            compresedGraphics.Name = "compresedGraphics";
            compresedGraphics.Size = new Size(169, 278);
            compresedGraphics.TabIndex = 8;
            compresedGraphics.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(206, 93);
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
            checkBox1.Location = new Point(206, 73);
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
            groupBox5.Location = new Point(206, 22);
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
            ClientSize = new Size(1062, 607);
            Controls.Add(groupBox4);
            Controls.Add(vScrollBar1);
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
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar7).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar8).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)compresedGraphics).EndInit();
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
        private PictureBox compresedGraphics;
        private GroupBox groupBox7;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox8;
        private GroupBox groupBox6;
        private PictureBox pictureBox1;
        private Label trackBarLabel1;
        private TrackBar trackBar5;
        private TrackBar trackBar6;
        private TrackBar trackBar7;
        private TrackBar trackBar8;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Label trackBarLabel8;
        private Label trackBarLabel17;
        private Label trackBarLabel6;
        private Label trackBarLabel5;
        private Label trackBarLabel4;
        private Label trackBarLabel3;
        private Label trackBarLabel2;
    }
}
