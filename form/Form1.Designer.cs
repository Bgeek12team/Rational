namespace form
{
    partial class RationalCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_input1 = new System.Windows.Forms.TextBox();
            this.textBox_input2 = new System.Windows.Forms.TextBox();
            this.button_getRes = new System.Windows.Forms.Button();
            this.labelOper = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_diff = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калькулятор рациональных чисел";
            // 
            // textBox_input1
            // 
            this.textBox_input1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_input1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_input1.Location = new System.Drawing.Point(14, 84);
            this.textBox_input1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_input1.Name = "textBox_input1";
            this.textBox_input1.Size = new System.Drawing.Size(103, 49);
            this.textBox_input1.TabIndex = 1;
            this.textBox_input1.TextChanged += new System.EventHandler(this.textBox_input1_TextChanged);
            // 
            // textBox_input2
            // 
            this.textBox_input2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_input2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_input2.Location = new System.Drawing.Point(159, 84);
            this.textBox_input2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_input2.Name = "textBox_input2";
            this.textBox_input2.Size = new System.Drawing.Size(103, 49);
            this.textBox_input2.TabIndex = 2;
            this.textBox_input2.TextChanged += new System.EventHandler(this.textBox_input2_TextChanged);
            // 
            // button_getRes
            // 
            this.button_getRes.Enabled = false;
            this.button_getRes.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_getRes.Location = new System.Drawing.Point(14, 221);
            this.button_getRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_getRes.Name = "button_getRes";
            this.button_getRes.Size = new System.Drawing.Size(249, 61);
            this.button_getRes.TabIndex = 3;
            this.button_getRes.Text = "Результат";
            this.button_getRes.UseVisualStyleBackColor = true;
            this.button_getRes.Click += new System.EventHandler(this.button_getRes_Click);
            // 
            // labelOper
            // 
            this.labelOper.AutoSize = true;
            this.labelOper.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOper.Location = new System.Drawing.Point(125, 95);
            this.labelOper.Name = "labelOper";
            this.labelOper.Size = new System.Drawing.Size(0, 35);
            this.labelOper.TabIndex = 4;
            this.labelOper.Visible = false;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Add.Location = new System.Drawing.Point(14, 147);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(57, 67);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_diff
            // 
            this.button_diff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_diff.Location = new System.Drawing.Point(78, 147);
            this.button_diff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_diff.Name = "button_diff";
            this.button_diff.Size = new System.Drawing.Size(57, 67);
            this.button_diff.TabIndex = 6;
            this.button_diff.Text = "-";
            this.button_diff.UseVisualStyleBackColor = true;
            this.button_diff.Click += new System.EventHandler(this.button_diff_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_div.Location = new System.Drawing.Point(142, 147);
            this.button_div.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(57, 67);
            this.button_div.TabIndex = 7;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_mult
            // 
            this.button_mult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_mult.Location = new System.Drawing.Point(206, 147);
            this.button_mult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(57, 67);
            this.button_mult.TabIndex = 8;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_output.Enabled = false;
            this.textBox_output.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_output.Location = new System.Drawing.Point(306, 84);
            this.textBox_output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(180, 49);
            this.textBox_output.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(270, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // RationalCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(791, 348);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_diff);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.labelOper);
            this.Controls.Add(this.button_getRes);
            this.Controls.Add(this.textBox_input2);
            this.Controls.Add(this.textBox_input1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RationalCalc";
            this.Text = "RationalCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_input1;
        private TextBox textBox_input2;
        private Button button_getRes;
        private Label labelOper;
        private Button button_Add;
        private Button button_diff;
        private Button button_div;
        private Button button_mult;
        private TextBox textBox_output;
        private Label label3;
    }
}