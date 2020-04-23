namespace CalculatorApp
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.CE_button = new System.Windows.Forms.Button();
            this.C_button = new System.Windows.Forms.Button();
            this.sumSub_button = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(12, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.LightGray;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Delete_button.Location = new System.Drawing.Point(12, 59);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(58, 48);
            this.Delete_button.TabIndex = 1;
            this.Delete_button.Text = "Del";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // CE_button
            // 
            this.CE_button.BackColor = System.Drawing.Color.LightGray;
            this.CE_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CE_button.Location = new System.Drawing.Point(75, 59);
            this.CE_button.Name = "CE_button";
            this.CE_button.Size = new System.Drawing.Size(58, 48);
            this.CE_button.TabIndex = 2;
            this.CE_button.Text = "CE";
            this.CE_button.UseVisualStyleBackColor = false;
            this.CE_button.Click += new System.EventHandler(this.CE_button_Click);
            // 
            // C_button
            // 
            this.C_button.BackColor = System.Drawing.Color.LightGray;
            this.C_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.C_button.Location = new System.Drawing.Point(139, 59);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(58, 48);
            this.C_button.TabIndex = 3;
            this.C_button.Text = "C";
            this.C_button.UseVisualStyleBackColor = false;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // sumSub_button
            // 
            this.sumSub_button.BackColor = System.Drawing.Color.LightGray;
            this.sumSub_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sumSub_button.Location = new System.Drawing.Point(206, 59);
            this.sumSub_button.Name = "sumSub_button";
            this.sumSub_button.Size = new System.Drawing.Size(58, 48);
            this.sumSub_button.TabIndex = 4;
            this.sumSub_button.Text = "±";
            this.sumSub_button.UseVisualStyleBackColor = false;
            this.sumSub_button.Click += new System.EventHandler(this.sumSub_button_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.LightGray;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num7.Location = new System.Drawing.Point(12, 116);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(58, 48);
            this.num7.TabIndex = 5;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.Calculation);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.LightGray;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num8.Location = new System.Drawing.Point(75, 116);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(58, 48);
            this.num8.TabIndex = 6;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.Calculation);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.LightGray;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num9.Location = new System.Drawing.Point(139, 116);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(58, 48);
            this.num9.TabIndex = 7;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.Calculation);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.LightGray;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sum.Location = new System.Drawing.Point(206, 116);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(58, 48);
            this.sum.TabIndex = 8;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.OperationFunction);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.LightGray;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num4.Location = new System.Drawing.Point(12, 170);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(58, 48);
            this.num4.TabIndex = 9;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.Calculation);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.LightGray;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num5.Location = new System.Drawing.Point(75, 170);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(58, 48);
            this.num5.TabIndex = 10;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.Calculation);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.LightGray;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num6.Location = new System.Drawing.Point(139, 170);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(58, 48);
            this.num6.TabIndex = 11;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.Calculation);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.LightGray;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sub.Location = new System.Drawing.Point(206, 170);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(58, 48);
            this.sub.TabIndex = 12;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.OperationFunction);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.LightGray;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num1.Location = new System.Drawing.Point(12, 224);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(58, 48);
            this.num1.TabIndex = 13;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.Calculation);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.LightGray;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num2.Location = new System.Drawing.Point(75, 224);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(58, 48);
            this.num2.TabIndex = 14;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.Calculation);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.LightGray;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num3.Location = new System.Drawing.Point(139, 224);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(58, 48);
            this.num3.TabIndex = 15;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.Calculation);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.LightGray;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mul.Location = new System.Drawing.Point(206, 224);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(58, 48);
            this.mul.TabIndex = 16;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.OperationFunction);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.LightGray;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.num0.Location = new System.Drawing.Point(12, 278);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(58, 48);
            this.num0.TabIndex = 17;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.Calculation);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.LightGray;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.point.Location = new System.Drawing.Point(75, 278);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(58, 48);
            this.point.TabIndex = 18;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.Calculation);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LightGray;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.result.Location = new System.Drawing.Point(139, 278);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(58, 48);
            this.result.TabIndex = 19;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.LightGray;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.div.Location = new System.Drawing.Point(206, 278);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(58, 48);
            this.div.TabIndex = 20;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.OperationFunction);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(272, 330);
            this.Controls.Add(this.div);
            this.Controls.Add(this.result);
            this.Controls.Add(this.point);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.sumSub_button);
            this.Controls.Add(this.C_button);
            this.Controls.Add(this.CE_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "CalculatorApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button CE_button;
        private System.Windows.Forms.Button C_button;
        private System.Windows.Forms.Button sumSub_button;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button div;
    }
}

