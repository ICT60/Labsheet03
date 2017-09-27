namespace Labsheet03
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputA = new System.Windows.Forms.TextBox();
            this.txtInputB = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMutilply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnGretherThan = new System.Windows.Forms.Button();
            this.btnLessThan = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnStringConcat = new System.Windows.Forms.Button();
            this.btnMultipleStringConcat = new System.Windows.Forms.Button();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input2";
            // 
            // txtInputA
            // 
            this.txtInputA.Location = new System.Drawing.Point(33, 46);
            this.txtInputA.Name = "txtInputA";
            this.txtInputA.Size = new System.Drawing.Size(100, 20);
            this.txtInputA.TabIndex = 2;
            // 
            // txtInputB
            // 
            this.txtInputB.Location = new System.Drawing.Point(341, 46);
            this.txtInputB.Name = "txtInputB";
            this.txtInputB.Size = new System.Drawing.Size(100, 20);
            this.txtInputB.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(80, 155);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(161, 155);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMutilply
            // 
            this.btnMutilply.Location = new System.Drawing.Point(242, 155);
            this.btnMutilply.Name = "btnMutilply";
            this.btnMutilply.Size = new System.Drawing.Size(75, 23);
            this.btnMutilply.TabIndex = 6;
            this.btnMutilply.Text = "*";
            this.btnMutilply.UseVisualStyleBackColor = true;
            this.btnMutilply.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnMutilply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(323, 155);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(323, 184);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 23);
            this.btnEqual.TabIndex = 11;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            //
            // btnGretherThan
            // 
            this.btnGretherThan.Location = new System.Drawing.Point(242, 184);
            this.btnGretherThan.Name = "btnGretherThan";
            this.btnGretherThan.Size = new System.Drawing.Size(75, 23);
            this.btnGretherThan.TabIndex = 10;
            this.btnGretherThan.Text = ">";
            this.btnGretherThan.UseVisualStyleBackColor = true;
            this.btnGretherThan.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnGretherThan.Click += new System.EventHandler(this.btnGreatherThan_Click);
            // 
            // btnLessThan
            // 
            this.btnLessThan.Location = new System.Drawing.Point(161, 184);
            this.btnLessThan.Name = "btnLessThan";
            this.btnLessThan.Size = new System.Drawing.Size(75, 23);
            this.btnLessThan.TabIndex = 9;
            this.btnLessThan.Text = "<";
            this.btnLessThan.UseVisualStyleBackColor = true;
            this.btnLessThan.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnLessThan.Click += new System.EventHandler(this.btnLessThan_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(80, 184);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this._On_AnyButton_Pressed);
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(42, 117);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(399, 20);
            this.txtResult.TabIndex = 13;
            // 
            // btnStringConcat
            // 
            this.btnStringConcat.Location = new System.Drawing.Point(80, 213);
            this.btnStringConcat.Name = "btnStringConcat";
            this.btnStringConcat.Size = new System.Drawing.Size(156, 23);
            this.btnStringConcat.TabIndex = 14;
            this.btnStringConcat.Text = "Text + Text";
            this.btnStringConcat.UseVisualStyleBackColor = true;
            this.btnStringConcat.Click += new System.EventHandler(this.btnStringConcat_Click);
            // 
            // btnMultipleStringConcat
            // 
            this.btnMultipleStringConcat.Location = new System.Drawing.Point(242, 213);
            this.btnMultipleStringConcat.Name = "btnMultipleStringConcat";
            this.btnMultipleStringConcat.Size = new System.Drawing.Size(156, 23);
            this.btnMultipleStringConcat.TabIndex = 15;
            this.btnMultipleStringConcat.Text = "Text + Text + Text....";
            this.btnMultipleStringConcat.UseVisualStyleBackColor = true;
            this.btnMultipleStringConcat.Click += new System.EventHandler(this.btnMultipleStringConcat_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(213, 46);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(48, 13);
            this.lblOperator.TabIndex = 16;
            this.lblOperator.Text = "Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "=";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 260);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.btnMultipleStringConcat);
            this.Controls.Add(this.btnStringConcat);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnGretherThan);
            this.Controls.Add(this.btnLessThan);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMutilply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtInputB);
            this.Controls.Add(this.txtInputA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Labsheet03_6002526";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMutilply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnGretherThan;
        private System.Windows.Forms.Button btnLessThan;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnStringConcat;
        private System.Windows.Forms.Button btnMultipleStringConcat;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label4;
    }
}

