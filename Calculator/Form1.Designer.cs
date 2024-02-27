namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_AllClear = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_Result = new System.Windows.Forms.Button();
            this.explain = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.display.Location = new System.Drawing.Point(0, 20);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(475, 33);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.display.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button_Divide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Dot, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_AllClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Multiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Minus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Plus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 284);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button_Divide
            // 
            this.button_Divide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Divide.Location = new System.Drawing.Point(357, 216);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(112, 65);
            this.button_Divide.TabIndex = 15;
            this.button_Divide.Text = "÷";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_Dot
            // 
            this.button_Dot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Dot.Location = new System.Drawing.Point(239, 216);
            this.button_Dot.Name = "button_Dot";
            this.button_Dot.Size = new System.Drawing.Size(112, 65);
            this.button_Dot.TabIndex = 14;
            this.button_Dot.Text = ".";
            this.button_Dot.UseVisualStyleBackColor = true;
            this.button_Dot.Click += new System.EventHandler(this.button_Dot_Click);
            // 
            // button_0
            // 
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_0.Location = new System.Drawing.Point(121, 216);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(112, 65);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_AllClear
            // 
            this.button_AllClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_AllClear.Location = new System.Drawing.Point(3, 216);
            this.button_AllClear.Name = "button_AllClear";
            this.button_AllClear.Size = new System.Drawing.Size(112, 65);
            this.button_AllClear.TabIndex = 12;
            this.button_AllClear.Text = "AC";
            this.button_AllClear.UseVisualStyleBackColor = true;
            this.button_AllClear.Click += new System.EventHandler(this.button_AllClear_Click);
            // 
            // button_Multiply
            // 
            this.button_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Multiply.Location = new System.Drawing.Point(357, 145);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(112, 65);
            this.button_Multiply.TabIndex = 11;
            this.button_Multiply.Text = "×";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // button_3
            // 
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_3.Location = new System.Drawing.Point(239, 145);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(112, 65);
            this.button_3.TabIndex = 10;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_2.Location = new System.Drawing.Point(121, 145);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(112, 65);
            this.button_2.TabIndex = 9;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_1.Location = new System.Drawing.Point(3, 145);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(112, 65);
            this.button_1.TabIndex = 8;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Minus.Location = new System.Drawing.Point(357, 74);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(112, 65);
            this.button_Minus.TabIndex = 7;
            this.button_Minus.Text = "－";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_6
            // 
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_6.Location = new System.Drawing.Point(239, 74);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(112, 65);
            this.button_6.TabIndex = 6;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_5.Location = new System.Drawing.Point(121, 74);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(112, 65);
            this.button_5.TabIndex = 5;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_4.Location = new System.Drawing.Point(3, 74);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(112, 65);
            this.button_4.TabIndex = 4;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Plus.Location = new System.Drawing.Point(357, 3);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(112, 65);
            this.button_Plus.TabIndex = 3;
            this.button_Plus.Text = "＋";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_9
            // 
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_9.Location = new System.Drawing.Point(239, 3);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(112, 65);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_8.Location = new System.Drawing.Point(121, 3);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(112, 65);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_7
            // 
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_7.Location = new System.Drawing.Point(3, 3);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(112, 65);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button17_Click);
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(6, 346);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(474, 54);
            this.button_Result.TabIndex = 2;
            this.button_Result.Text = "＝";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button17_Click);
            // 
            // explain
            // 
            this.explain.Dock = System.Windows.Forms.DockStyle.Top;
            this.explain.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.explain.Location = new System.Drawing.Point(0, 0);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(477, 20);
            this.explain.TabIndex = 3;
            this.explain.Text = "0";
            this.explain.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.explain.Click += new System.EventHandler(this.explain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 412);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_AllClear;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.Label explain;
        private System.Windows.Forms.Button button_7;
    }
}

