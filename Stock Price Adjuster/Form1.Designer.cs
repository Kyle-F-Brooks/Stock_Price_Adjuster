
namespace Stock_Price_Adjuster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.oldStockQtyTextBox = new System.Windows.Forms.TextBox();
            this.newStockQtyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldStockValTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newStockValTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.markupTextBox = new System.Windows.Forms.TextBox();
            this.avgTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buildText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Stock Quantity";
            // 
            // oldStockQtyTextBox
            // 
            this.oldStockQtyTextBox.Location = new System.Drawing.Point(182, 12);
            this.oldStockQtyTextBox.Name = "oldStockQtyTextBox";
            this.oldStockQtyTextBox.Size = new System.Drawing.Size(70, 20);
            this.oldStockQtyTextBox.TabIndex = 1;
            this.oldStockQtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldStockQtyTextBox_KeyPress);
            // 
            // newStockQtyTextBox
            // 
            this.newStockQtyTextBox.Location = new System.Drawing.Point(182, 64);
            this.newStockQtyTextBox.Name = "newStockQtyTextBox";
            this.newStockQtyTextBox.Size = new System.Drawing.Size(70, 20);
            this.newStockQtyTextBox.TabIndex = 3;
            this.newStockQtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newStockQtyTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Stock Quantity";
            // 
            // oldStockValTextBox
            // 
            this.oldStockValTextBox.Location = new System.Drawing.Point(182, 38);
            this.oldStockValTextBox.Name = "oldStockValTextBox";
            this.oldStockValTextBox.Size = new System.Drawing.Size(70, 20);
            this.oldStockValTextBox.TabIndex = 2;
            this.oldStockValTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldStockValTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Old Stock Purcahse Value";
            // 
            // newStockValTextBox
            // 
            this.newStockValTextBox.Location = new System.Drawing.Point(182, 90);
            this.newStockValTextBox.Name = "newStockValTextBox";
            this.newStockValTextBox.Size = new System.Drawing.Size(70, 20);
            this.newStockValTextBox.TabIndex = 4;
            this.newStockValTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newStockValTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Stock Purchase Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.markupTextBox);
            this.groupBox1.Controls.Add(this.avgTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "£";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "£";
            // 
            // markupTextBox
            // 
            this.markupTextBox.Location = new System.Drawing.Point(179, 61);
            this.markupTextBox.Name = "markupTextBox";
            this.markupTextBox.ReadOnly = true;
            this.markupTextBox.Size = new System.Drawing.Size(70, 20);
            this.markupTextBox.TabIndex = 7;
            // 
            // avgTextBox
            // 
            this.avgTextBox.Location = new System.Drawing.Point(179, 24);
            this.avgTextBox.Name = "avgTextBox";
            this.avgTextBox.ReadOnly = true;
            this.avgTextBox.Size = new System.Drawing.Size(70, 20);
            this.avgTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Markup Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Average Purchase Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "£";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "£";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buildText
            // 
            this.buildText.AutoSize = true;
            this.buildText.Location = new System.Drawing.Point(152, 262);
            this.buildText.Name = "buildText";
            this.buildText.Size = new System.Drawing.Size(100, 13);
            this.buildText.TabIndex = 17;
            this.buildText.Text = "Built by Kyle Brooks";
            this.buildText.Click += new System.EventHandler(this.buildText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(264, 281);
            this.Controls.Add(this.buildText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newStockValTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oldStockValTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newStockQtyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldStockQtyTextBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Price Adjuster";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldStockQtyTextBox;
        private System.Windows.Forms.TextBox newStockQtyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldStockValTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newStockValTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox avgTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox markupTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label buildText;
    }
}

