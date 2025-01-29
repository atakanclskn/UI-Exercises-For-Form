namespace Exercise_7._6___ListBox_Object
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(700, 12);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 0;
            button1.Text = "100 Random Generate";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(700, 68);
            button2.Name = "button2";
            button2.Size = new Size(250, 50);
            button2.TabIndex = 1;
            button2.Text = "Move Even Items";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(700, 124);
            button3.Name = "button3";
            button3.Size = new Size(250, 50);
            button3.TabIndex = 2;
            button3.Text = "Move Odd Items";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(700, 180);
            button4.Name = "button4";
            button4.Size = new Size(250, 50);
            button4.TabIndex = 3;
            button4.Text = "Display First";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(700, 236);
            button5.Name = "button5";
            button5.Size = new Size(250, 50);
            button5.TabIndex = 4;
            button5.Text = "Display Last";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(700, 292);
            button6.Name = "button6";
            button6.Size = new Size(250, 50);
            button6.TabIndex = 5;
            button6.Text = "Display Selected";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(700, 348);
            button7.Name = "button7";
            button7.Size = new Size(250, 50);
            button7.TabIndex = 6;
            button7.Text = "Move Item";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(700, 404);
            button8.Name = "button8";
            button8.Size = new Size(250, 50);
            button8.TabIndex = 7;
            button8.Text = "Move Item Reverse";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(700, 460);
            button9.Name = "button9";
            button9.Size = new Size(250, 50);
            button9.TabIndex = 8;
            button9.Text = "Display Minimum";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(700, 516);
            button10.Name = "button10";
            button10.Size = new Size(250, 50);
            button10.TabIndex = 9;
            button10.Text = "Display Maximum";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(700, 572);
            button11.Name = "button11";
            button11.Size = new Size(250, 50);
            button11.TabIndex = 10;
            button11.Text = "New Item";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(700, 628);
            button12.Name = "button12";
            button12.Size = new Size(250, 50);
            button12.TabIndex = 11;
            button12.Text = "Reset";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(29, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(306, 604);
            listBox1.TabIndex = 12;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Location = new Point(386, 68);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(290, 604);
            listBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 35);
            textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 686);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "ListBox Object Example";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
    }
}
