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
            vScrollBar1 = new VScrollBar();
            openFileDialog1 = new OpenFileDialog();
            groupBox8 = new GroupBox();
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar8 = new TrackBar();
            trackBar7 = new TrackBar();
            trackBar6 = new TrackBar();
            trackBar5 = new TrackBar();
            trackBarLabel1 = new Label();
            trackBarLabel2 = new Label();
            trackBarLabel3 = new Label();
            trackBarLabel4 = new Label();
            trackBarLabel5 = new Label();
            trackBarLabel6 = new Label();
            trackBarLabel17 = new Label();
            trackBarLabel8 = new Label();
            groupBox4 = new GroupBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)graphics).BeginInit();
            groupBox1.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // graphics
            // 
            graphics.BorderStyle = BorderStyle.Fixed3D;
            graphics.Location = new Point(518, 12);
            graphics.Name = "graphics";
            graphics.Size = new Size(500, 561);
            graphics.TabIndex = 0;
            graphics.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loadButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(1113, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 70);
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
            listView1.Location = new Point(4, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(421, 41);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1021, 12);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(10, 564);
            vScrollBar1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            groupBox8.Location = new Point(6, 22);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(314, 474);
            groupBox8.TabIndex = 10;
            groupBox8.TabStop = false;
            groupBox8.Text = "Преобразование яркостей";
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
            // trackBar7
            // 
            trackBar7.Location = new Point(200, 213);
            trackBar7.Maximum = 255;
            trackBar7.Name = "trackBar7";
            trackBar7.Orientation = Orientation.Vertical;
            trackBar7.Size = new Size(45, 104);
            trackBar7.TabIndex = 6;
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
            // trackBarLabel1
            // 
            trackBarLabel1.AutoSize = true;
            trackBarLabel1.Location = new Point(10, 323);
            trackBarLabel1.Name = "trackBarLabel1";
            trackBarLabel1.Size = new Size(14, 15);
            trackBarLabel1.TabIndex = 9;
            trackBarLabel1.Text = "0";
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
            // trackBarLabel3
            // 
            trackBarLabel3.AutoSize = true;
            trackBarLabel3.Location = new Point(86, 323);
            trackBarLabel3.Name = "trackBarLabel3";
            trackBarLabel3.Size = new Size(14, 15);
            trackBarLabel3.TabIndex = 11;
            trackBarLabel3.Text = "0";
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
            // trackBarLabel5
            // 
            trackBarLabel5.AutoSize = true;
            trackBarLabel5.Location = new Point(166, 323);
            trackBarLabel5.Name = "trackBarLabel5";
            trackBarLabel5.Size = new Size(14, 15);
            trackBarLabel5.TabIndex = 13;
            trackBarLabel5.Text = "0";
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
            // trackBarLabel17
            // 
            trackBarLabel17.AutoSize = true;
            trackBarLabel17.Location = new Point(238, 323);
            trackBarLabel17.Name = "trackBarLabel17";
            trackBarLabel17.Size = new Size(14, 15);
            trackBarLabel17.TabIndex = 15;
            trackBarLabel17.Text = "0";
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
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Location = new Point(1113, 88);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(344, 507);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Модификации";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 561);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 607);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox4);
            Controls.Add(vScrollBar1);
            Controls.Add(groupBox1);
            Controls.Add(graphics);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)graphics).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar8).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar7).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox graphics;
        private GroupBox groupBox1;
        private Label label1;
        private Button loadButton;
        private VScrollBar vScrollBar1;
        private OpenFileDialog openFileDialog1;
        private ListView listView1;
        private GroupBox groupBox8;
        private Label trackBarLabel8;
        private Label trackBarLabel17;
        private Label trackBarLabel6;
        private Label trackBarLabel5;
        private Label trackBarLabel4;
        private Label trackBarLabel3;
        private Label trackBarLabel2;
        private Label trackBarLabel1;
        private TrackBar trackBar5;
        private TrackBar trackBar6;
        private TrackBar trackBar7;
        private TrackBar trackBar8;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private PictureBox pictureBox2;
    }
}
