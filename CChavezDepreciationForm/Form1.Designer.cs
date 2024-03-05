namespace CChavezDepreciationForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            pictureBox3 = new PictureBox();
            btnAddToInventory = new Button();
            groupBox1 = new GroupBox();
            rbDoubleDeclining = new RadioButton();
            rbStraightLine = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            tbLifetime = new TextBox();
            label6 = new Label();
            tbEndValue = new TextBox();
            label5 = new Label();
            tbStartValue = new TextBox();
            label4 = new Label();
            dtpDateOut = new DateTimePicker();
            dtpDateIn = new DateTimePicker();
            tbTitle = new TextBox();
            label3 = new Label();
            btnRemoveFromInventory = new Button();
            tbInventory = new TextBox();
            tabPage3 = new TabPage();
            pictureBox2 = new PictureBox();
            tbOutput = new TextBox();
            btAssessInventory = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(11, 20);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(681, 409);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(673, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Application Instructions";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.E_D_logo;
            pictureBox1.Location = new Point(256, 290);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Impact", 9F);
            textBox1.Location = new Point(59, 87);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(530, 50);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter the inventory to be assessed on the Inventory tab. Then navigate to the Summary tab to calulate the depreciation for the entire assessed inventroy.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(211, 18);
            label2.Name = "label2";
            label2.Size = new Size(253, 29);
            label2.TabIndex = 1;
            label2.Text = "Depreciation Application";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(197, 248);
            label1.Name = "label1";
            label1.Size = new Size(282, 44);
            label1.TabIndex = 0;
            label1.Text = "Engulf and Devour";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(btnAddToInventory);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(tbLifetime);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tbEndValue);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbStartValue);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dtpDateOut);
            tabPage2.Controls.Add(dtpDateIn);
            tabPage2.Controls.Add(tbTitle);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnRemoveFromInventory);
            tabPage2.Controls.Add(tbInventory);
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(673, 374);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventory";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.E_D_logo;
            pictureBox3.Location = new Point(256, 290);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // btnAddToInventory
            // 
            btnAddToInventory.Font = new Font("Impact", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddToInventory.Location = new Point(403, 326);
            btnAddToInventory.Name = "btnAddToInventory";
            btnAddToInventory.Size = new Size(234, 30);
            btnAddToInventory.TabIndex = 15;
            btnAddToInventory.Text = "Add Item To Inventory";
            btnAddToInventory.UseVisualStyleBackColor = true;
            btnAddToInventory.Click += btnAddToInventory_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDoubleDeclining);
            groupBox1.Controls.Add(rbStraightLine);
            groupBox1.Font = new Font("Impact", 9F);
            groupBox1.Location = new Point(403, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 88);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // rbDoubleDeclining
            // 
            rbDoubleDeclining.AutoSize = true;
            rbDoubleDeclining.Location = new Point(13, 43);
            rbDoubleDeclining.Name = "rbDoubleDeclining";
            rbDoubleDeclining.Size = new Size(159, 26);
            rbDoubleDeclining.TabIndex = 1;
            rbDoubleDeclining.TabStop = true;
            rbDoubleDeclining.Text = "Double Declining";
            rbDoubleDeclining.UseVisualStyleBackColor = true;
            // 
            // rbStraightLine
            // 
            rbStraightLine.AutoSize = true;
            rbStraightLine.Location = new Point(13, 12);
            rbStraightLine.Name = "rbStraightLine";
            rbStraightLine.Size = new Size(128, 26);
            rbStraightLine.TabIndex = 0;
            rbStraightLine.TabStop = true;
            rbStraightLine.Text = "Straight Line ";
            rbStraightLine.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 9F);
            label7.Location = new Point(257, 198);
            label7.Name = "label7";
            label7.Size = new Size(74, 22);
            label7.TabIndex = 13;
            label7.Text = "Date Out:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 9F);
            label8.Location = new Point(257, 165);
            label8.Name = "label8";
            label8.Size = new Size(64, 22);
            label8.TabIndex = 12;
            label8.Text = "Date In:";
            // 
            // tbLifetime
            // 
            tbLifetime.Font = new Font("Impact", 9F);
            tbLifetime.Location = new Point(403, 124);
            tbLifetime.Name = "tbLifetime";
            tbLifetime.Size = new Size(234, 29);
            tbLifetime.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 9F);
            label6.Location = new Point(257, 122);
            label6.Name = "label6";
            label6.Size = new Size(123, 22);
            label6.TabIndex = 10;
            label6.Text = "Lifetime (Years)";
            // 
            // tbEndValue
            // 
            tbEndValue.Font = new Font("Impact", 9F);
            tbEndValue.Location = new Point(403, 92);
            tbEndValue.Name = "tbEndValue";
            tbEndValue.Size = new Size(234, 29);
            tbEndValue.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 9F);
            label5.Location = new Point(257, 90);
            label5.Name = "label5";
            label5.Size = new Size(92, 22);
            label5.TabIndex = 8;
            label5.Text = "End Value $";
            // 
            // tbStartValue
            // 
            tbStartValue.Font = new Font("Impact", 9F);
            tbStartValue.Location = new Point(403, 59);
            tbStartValue.Name = "tbStartValue";
            tbStartValue.Size = new Size(234, 29);
            tbStartValue.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 9F);
            label4.Location = new Point(257, 57);
            label4.Name = "label4";
            label4.Size = new Size(124, 22);
            label4.TabIndex = 6;
            label4.Text = "Starting Value $";
            // 
            // dtpDateOut
            // 
            dtpDateOut.Font = new Font("Impact", 9F);
            dtpDateOut.Location = new Point(344, 194);
            dtpDateOut.Name = "dtpDateOut";
            dtpDateOut.Size = new Size(294, 29);
            dtpDateOut.TabIndex = 5;
            // 
            // dtpDateIn
            // 
            dtpDateIn.Font = new Font("Impact", 9F);
            dtpDateIn.Location = new Point(344, 161);
            dtpDateIn.Name = "dtpDateIn";
            dtpDateIn.Size = new Size(294, 29);
            dtpDateIn.TabIndex = 4;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Impact", 9F);
            tbTitle.Location = new Point(403, 26);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(234, 29);
            tbTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9F);
            label3.Location = new Point(256, 25);
            label3.Name = "label3";
            label3.Size = new Size(42, 22);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // btnRemoveFromInventory
            // 
            btnRemoveFromInventory.Font = new Font("Impact", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveFromInventory.Location = new Point(23, 326);
            btnRemoveFromInventory.Name = "btnRemoveFromInventory";
            btnRemoveFromInventory.Size = new Size(220, 30);
            btnRemoveFromInventory.TabIndex = 1;
            btnRemoveFromInventory.Text = "Remove 'Selected' From Inventroy";
            btnRemoveFromInventory.UseVisualStyleBackColor = true;
            btnRemoveFromInventory.Click += btnRemoveFromInventory_Click;
            // 
            // tbInventory
            // 
            tbInventory.Font = new Font("Impact", 9F);
            tbInventory.Location = new Point(23, 23);
            tbInventory.Multiline = true;
            tbInventory.Name = "tbInventory";
            tbInventory.ScrollBars = ScrollBars.Horizontal;
            tbInventory.Size = new Size(221, 283);
            tbInventory.TabIndex = 0;
            tbInventory.DoubleClick += tbInventory_DoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Controls.Add(tbOutput);
            tabPage3.Controls.Add(btAssessInventory);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(673, 371);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Summary";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.E_D_logo;
            pictureBox2.Location = new Point(256, 290);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // tbOutput
            // 
            tbOutput.Font = new Font("Impact", 9F);
            tbOutput.Location = new Point(86, 130);
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(519, 29);
            tbOutput.TabIndex = 3;
            // 
            // btAssessInventory
            // 
            btAssessInventory.Font = new Font("Impact", 9F);
            btAssessInventory.Location = new Point(258, 83);
            btAssessInventory.Name = "btAssessInventory";
            btAssessInventory.Size = new Size(176, 30);
            btAssessInventory.TabIndex = 0;
            btAssessInventory.Text = "Assess Inventory";
            btAssessInventory.UseVisualStyleBackColor = true;
            btAssessInventory.Click += btAssessInventory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 448);
            Controls.Add(tabControl1);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "E&D Depreciation Application";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button btnRemoveFromInventory;
        private TextBox tbInventory;
        private Label label7;
        private Label label8;
        private TextBox tbLifetime;
        private Label label6;
        private TextBox tbEndValue;
        private Label label5;
        private TextBox tbStartValue;
        private Label label4;
        private DateTimePicker dtpDateOut;
        private DateTimePicker dtpDateIn;
        private TextBox tbTitle;
        private Label label3;
        private Button btnAddToInventory;
        private GroupBox groupBox1;
        private RadioButton rbDoubleDeclining;
        private RadioButton rbStraightLine;
        private TextBox tbOutput;
        private Button btAssessInventory;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
