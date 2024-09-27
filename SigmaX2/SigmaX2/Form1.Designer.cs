namespace SigmaX2
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            label2 = new Label();
            minimize = new Button();
            X = new Button();
            button1 = new Button();
            clear = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaptionText;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(3, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(855, 341);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(minimize);
            panel1.Controls.Add(X);
            panel1.Location = new Point(73, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 46);
            panel1.TabIndex = 1;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 7);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 10;
            label2.Text = "SigmaX";
            // 
            // minimize
            // 
            minimize.BackColor = Color.Black;
            minimize.FlatStyle = FlatStyle.Popup;
            minimize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimize.ForeColor = Color.White;
            minimize.Location = new Point(698, 3);
            minimize.Name = "minimize";
            minimize.Size = new Size(45, 36);
            minimize.TabIndex = 7;
            minimize.Text = "-";
            minimize.UseVisualStyleBackColor = false;
            minimize.Click += button5_Click;
            // 
            // X
            // 
            X.BackColor = Color.Black;
            X.FlatStyle = FlatStyle.Popup;
            X.ForeColor = Color.WhiteSmoke;
            X.Location = new Point(749, 3);
            X.Name = "X";
            X.Size = new Size(45, 36);
            X.TabIndex = 6;
            X.Text = "X";
            X.UseVisualStyleBackColor = false;
            X.Click += X_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 402);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 2;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            clear.BackColor = Color.Black;
            clear.FlatStyle = FlatStyle.Flat;
            clear.ForeColor = Color.White;
            clear.Location = new Point(114, 402);
            clear.Name = "clear";
            clear.Size = new Size(96, 36);
            clear.TabIndex = 3;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(216, 402);
            button3.Name = "button3";
            button3.Size = new Size(96, 36);
            button3.TabIndex = 4;
            button3.Text = "Save File";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(318, 402);
            button4.Name = "button4";
            button4.Size = new Size(96, 36);
            button4.TabIndex = 5;
            button4.Text = "Open File";
            button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(804, 405);
            button6.Name = "button6";
            button6.Size = new Size(54, 36);
            button6.TabIndex = 8;
            button6.Text = "Attach";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sigmx1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(868, 453);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(clear);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private Button button1;
        private Button clear;
        private Button button3;
        private Button button4;
        private Button X;
        private Button minimize;
        private Button button6;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
