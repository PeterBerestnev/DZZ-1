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
            groupBox1 = new GroupBox();
            loadButton = new Button();
            label1 = new Label();
            listView1 = new ListView();
            openFileDialog1 = new OpenFileDialog();
            picture = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            numericUpDown1 = new NumericUpDown();
            buttonRotateStep = new Button();
            buttonRotateAuto = new Button();
            observ = new CheckBox();
            xCord = new Label();
            yCord = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loadButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(528, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 70);
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
            listView1.Location = new Point(97, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(260, 41);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // picture
            // 
            picture.BorderStyle = BorderStyle.Fixed3D;
            picture.Location = new Point(12, 12);
            picture.Name = "picture";
            picture.Size = new Size(500, 561);
            picture.TabIndex = 8;
            picture.TabStop = false;
            picture.MouseClick += picture_MouseClick;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(528, 88);
            numericUpDown1.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // buttonRotateStep
            // 
            buttonRotateStep.Location = new Point(528, 117);
            buttonRotateStep.Name = "buttonRotateStep";
            buttonRotateStep.Size = new Size(120, 56);
            buttonRotateStep.TabIndex = 10;
            buttonRotateStep.Text = "Поворот на указанный угол";
            buttonRotateStep.UseVisualStyleBackColor = true;
            buttonRotateStep.Click += buttonRotateStep_Click;
            // 
            // buttonRotateAuto
            // 
            buttonRotateAuto.Location = new Point(528, 179);
            buttonRotateAuto.Name = "buttonRotateAuto";
            buttonRotateAuto.Size = new Size(120, 44);
            buttonRotateAuto.TabIndex = 12;
            buttonRotateAuto.Text = "Автоматический режим";
            buttonRotateAuto.UseVisualStyleBackColor = true;
            buttonRotateAuto.Click += buttonRotateAuto_Click;
            // 
            // observ
            // 
            observ.AutoSize = true;
            observ.Location = new Point(529, 227);
            observ.Name = "observ";
            observ.Size = new Size(71, 19);
            observ.TabIndex = 13;
            observ.Text = "observe";
            observ.UseVisualStyleBackColor = true;
            observ.CheckedChanged += observ_CheckedChanged;
            // 
            // xCord
            // 
            xCord.AutoSize = true;
            xCord.Location = new Point(6, 19);
            xCord.Name = "xCord";
            xCord.Size = new Size(27, 15);
            xCord.TabIndex = 14;
            xCord.Text = "x: 0";
            // 
            // yCord
            // 
            yCord.AutoSize = true;
            yCord.Location = new Point(72, 19);
            yCord.Name = "yCord";
            yCord.Size = new Size(26, 15);
            yCord.TabIndex = 15;
            yCord.Text = "y: 0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(xCord);
            groupBox2.Controls.Add(yCord);
            groupBox2.Location = new Point(654, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Центр вращения";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 607);
            Controls.Add(groupBox2);
            Controls.Add(observ);
            Controls.Add(buttonRotateAuto);
            Controls.Add(buttonRotateStep);
            Controls.Add(numericUpDown1);
            Controls.Add(picture);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Button loadButton;
        private VScrollBar vScrollBar1;
        private OpenFileDialog openFileDialog1;
        private ListView listView1;
        private PictureBox originalImage;
        private PictureBox picture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown numericUpDown1;
        private Button buttonRotateStep;
        private Button buttonRotateAuto;
        private CheckBox observ;
        private Label xCord;
        private Label yCord;
        private GroupBox groupBox2;
    }
}
