
namespace Calculator
{
    partial class Window
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Emptiness = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.MMinus = new System.Windows.Forms.Button();
            this.MPlus = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Panel.Controls.Add(this.Result);
            this.Panel.Controls.Add(this.buttonDivide);
            this.Panel.Controls.Add(this.buttonMultiply);
            this.Panel.Controls.Add(this.buttonMinus);
            this.Panel.Controls.Add(this.buttonPlus);
            this.Panel.Controls.Add(this.Dot);
            this.Panel.Controls.Add(this.Emptiness);
            this.Panel.Controls.Add(this.button0);
            this.Panel.Controls.Add(this.button9);
            this.Panel.Controls.Add(this.button8);
            this.Panel.Controls.Add(this.button7);
            this.Panel.Controls.Add(this.button6);
            this.Panel.Controls.Add(this.button5);
            this.Panel.Controls.Add(this.button4);
            this.Panel.Controls.Add(this.button3);
            this.Panel.Controls.Add(this.button2);
            this.Panel.Controls.Add(this.button1);
            this.Panel.Controls.Add(this.Remove);
            this.Panel.Controls.Add(this.Clear);
            this.Panel.Controls.Add(this.Sqrt);
            this.Panel.Controls.Add(this.MMinus);
            this.Panel.Controls.Add(this.MPlus);
            this.Panel.Controls.Add(this.MR);
            this.Panel.Controls.Add(this.MC);
            this.Panel.Location = new System.Drawing.Point(-5, -4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(432, 485);
            this.Panel.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Aqua;
            this.Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Result.Location = new System.Drawing.Point(320, 409);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(80, 52);
            this.Result.TabIndex = 23;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Silver;
            this.buttonDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(320, 335);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(80, 45);
            this.buttonDivide.TabIndex = 22;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.Operations);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Silver;
            this.buttonMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(320, 262);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(80, 45);
            this.buttonMultiply.TabIndex = 21;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.Operations);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Silver;
            this.buttonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonMinus.Location = new System.Drawing.Point(320, 190);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(80, 45);
            this.buttonMinus.TabIndex = 20;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.Operations);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Silver;
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonPlus.Location = new System.Drawing.Point(320, 120);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(80, 45);
            this.buttonPlus.TabIndex = 19;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.Operations);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.Dot.Location = new System.Drawing.Point(224, 409);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(80, 53);
            this.Dot.TabIndex = 18;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Emptiness
            // 
            this.Emptiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Emptiness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Emptiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Emptiness.Location = new System.Drawing.Point(30, 408);
            this.Emptiness.Name = "Emptiness";
            this.Emptiness.Size = new System.Drawing.Size(80, 53);
            this.Emptiness.TabIndex = 17;
            this.Emptiness.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            this.button0.AccessibleName = "Numbers";
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(128, 409);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(80, 53);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button9
            // 
            this.button9.AccessibleName = "Numbers";
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(224, 335);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 53);
            this.button9.TabIndex = 15;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button8
            // 
            this.button8.AccessibleName = "Numbers";
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(128, 335);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 53);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button7
            // 
            this.button7.AccessibleName = "Numbers";
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(30, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 53);
            this.button7.TabIndex = 13;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button6
            // 
            this.button6.AccessibleName = "Numbers";
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(224, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 53);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button5
            // 
            this.button5.AccessibleName = "Numbers";
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(128, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 53);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "Numbers";
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(30, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "Numbers";
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(224, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Numbers";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(128, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "Numbers";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(30, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNumbers_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Silver;
            this.Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remove.Location = new System.Drawing.Point(224, 120);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(80, 45);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "<=";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Silver;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(128, 120);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 45);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.Color.Silver;
            this.Sqrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sqrt.Location = new System.Drawing.Point(30, 120);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(80, 45);
            this.Sqrt.TabIndex = 2;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // MMinus
            // 
            this.MMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MMinus.Location = new System.Drawing.Point(320, 72);
            this.MMinus.Name = "MMinus";
            this.MMinus.Size = new System.Drawing.Size(80, 28);
            this.MMinus.TabIndex = 3;
            this.MMinus.Text = "M-";
            this.MMinus.UseVisualStyleBackColor = true;
            this.MMinus.Click += new System.EventHandler(this.MMinus_Click);
            // 
            // MPlus
            // 
            this.MPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MPlus.Location = new System.Drawing.Point(224, 72);
            this.MPlus.Name = "MPlus";
            this.MPlus.Size = new System.Drawing.Size(80, 28);
            this.MPlus.TabIndex = 2;
            this.MPlus.Text = "M+";
            this.MPlus.UseVisualStyleBackColor = true;
            this.MPlus.Click += new System.EventHandler(this.MPlus_Click);
            // 
            // MR
            // 
            this.MR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MR.Location = new System.Drawing.Point(128, 72);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(80, 28);
            this.MR.TabIndex = 1;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // MC
            // 
            this.MC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MC.Location = new System.Drawing.Point(30, 72);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(80, 28);
            this.MC.TabIndex = 0;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(0, 0);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(424, 46);
            this.Input.TabIndex = 1;
            this.Input.Text = "0";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 479);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Panel);
            this.Name = "Window";
            this.Text = "Calculator";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Emptiness;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button MMinus;
        private System.Windows.Forms.Button MPlus;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.TextBox Input;
    }
}

