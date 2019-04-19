namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.TextBox();
            this.procent = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.squared = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.clear1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.changedSign = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Enabled = false;
            this.input.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.input.Location = new System.Drawing.Point(30, 45);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(278, 30);
            this.input.TabIndex = 0;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // history
            // 
            this.history.Enabled = false;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.Location = new System.Drawing.Point(153, 4);
            this.history.Name = "history";
            this.history.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.history.Size = new System.Drawing.Size(155, 35);
            this.history.TabIndex = 1;
            this.history.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // procent
            // 
            this.procent.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procent.Location = new System.Drawing.Point(30, 86);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(56, 40);
            this.procent.TabIndex = 2;
            this.procent.Text = "%";
            this.procent.UseVisualStyleBackColor = true;
            this.procent.Click += new System.EventHandler(this.procent_Click);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.sqrt.Location = new System.Drawing.Point(92, 86);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(56, 40);
            this.sqrt.TabIndex = 3;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // squared
            // 
            this.squared.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.squared.Location = new System.Drawing.Point(153, 86);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(56, 40);
            this.squared.TabIndex = 4;
            this.squared.Text = "x^2";
            this.squared.UseVisualStyleBackColor = true;
            this.squared.Click += new System.EventHandler(this.squared_Click);
            // 
            // reverse
            // 
            this.reverse.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.reverse.Location = new System.Drawing.Point(215, 86);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(56, 40);
            this.reverse.TabIndex = 5;
            this.reverse.Text = "1/x";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // clear1
            // 
            this.clear1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.clear1.Location = new System.Drawing.Point(30, 132);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(56, 40);
            this.clear1.TabIndex = 6;
            this.clear1.Text = "CE";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.clear.Location = new System.Drawing.Point(92, 132);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(56, 40);
            this.clear.TabIndex = 7;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.back.Location = new System.Drawing.Point(153, 132);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(56, 40);
            this.back.TabIndex = 8;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(215, 132);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(56, 40);
            this.divide.TabIndex = 9;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(30, 178);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 40);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(92, 178);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 40);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(154, 178);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 40);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.multiply.Location = new System.Drawing.Point(215, 178);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(56, 40);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(30, 224);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 40);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(92, 224);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 40);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(154, 224);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 40);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.minus.Location = new System.Drawing.Point(215, 224);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(56, 40);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(30, 270);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 40);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(92, 270);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 40);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(154, 270);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 40);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.plus.Location = new System.Drawing.Point(215, 270);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(56, 40);
            this.plus.TabIndex = 21;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // changedSign
            // 
            this.changedSign.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.changedSign.Location = new System.Drawing.Point(30, 316);
            this.changedSign.Name = "changedSign";
            this.changedSign.Size = new System.Drawing.Size(56, 40);
            this.changedSign.TabIndex = 22;
            this.changedSign.Text = "±";
            this.changedSign.UseVisualStyleBackColor = true;
            this.changedSign.Click += new System.EventHandler(this.changedSign_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(92, 316);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 40);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.point.Location = new System.Drawing.Point(154, 316);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(56, 40);
            this.point.TabIndex = 24;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.equal.Location = new System.Drawing.Point(215, 316);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(56, 40);
            this.equal.TabIndex = 25;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.point);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.changedSign);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.back);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.squared);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.history);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Button procent;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button changedSign;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button equal;
    }
}

