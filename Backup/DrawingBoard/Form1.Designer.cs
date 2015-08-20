namespace DrawingBoard
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
            this.pnl_painter = new System.Windows.Forms.Panel();
            this.rdo_large = new System.Windows.Forms.RadioButton();
            this.rdo_middle = new System.Windows.Forms.RadioButton();
            this.rdo_small = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_blue = new System.Windows.Forms.RadioButton();
            this.rdo_red = new System.Windows.Forms.RadioButton();
            this.rdo_black = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_painter
            // 
            this.pnl_painter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_painter.Location = new System.Drawing.Point(87, 12);
            this.pnl_painter.Name = "pnl_painter";
            this.pnl_painter.Size = new System.Drawing.Size(267, 290);
            this.pnl_painter.TabIndex = 0;
            this.pnl_painter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_painter_MouseMove);
            this.pnl_painter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_painter_MouseDown);
            this.pnl_painter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_painter_MouseUp);
            // 
            // rdo_large
            // 
            this.rdo_large.AutoSize = true;
            this.rdo_large.Location = new System.Drawing.Point(6, 64);
            this.rdo_large.Name = "rdo_large";
            this.rdo_large.Size = new System.Drawing.Size(53, 16);
            this.rdo_large.TabIndex = 2;
            this.rdo_large.TabStop = true;
            this.rdo_large.Text = "Large";
            this.rdo_large.UseVisualStyleBackColor = true;
            // 
            // rdo_middle
            // 
            this.rdo_middle.AutoSize = true;
            this.rdo_middle.Location = new System.Drawing.Point(6, 42);
            this.rdo_middle.Name = "rdo_middle";
            this.rdo_middle.Size = new System.Drawing.Size(59, 16);
            this.rdo_middle.TabIndex = 1;
            this.rdo_middle.TabStop = true;
            this.rdo_middle.Text = "Middle";
            this.rdo_middle.UseVisualStyleBackColor = true;
            // 
            // rdo_small
            // 
            this.rdo_small.AutoSize = true;
            this.rdo_small.Checked = true;
            this.rdo_small.Location = new System.Drawing.Point(6, 20);
            this.rdo_small.Name = "rdo_small";
            this.rdo_small.Size = new System.Drawing.Size(53, 16);
            this.rdo_small.TabIndex = 0;
            this.rdo_small.TabStop = true;
            this.rdo_small.Text = "Small";
            this.rdo_small.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_blue);
            this.groupBox1.Controls.Add(this.rdo_red);
            this.groupBox1.Controls.Add(this.rdo_black);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // rdo_blue
            // 
            this.rdo_blue.AutoSize = true;
            this.rdo_blue.Location = new System.Drawing.Point(6, 61);
            this.rdo_blue.Name = "rdo_blue";
            this.rdo_blue.Size = new System.Drawing.Size(47, 16);
            this.rdo_blue.TabIndex = 2;
            this.rdo_blue.Text = "Blue";
            this.rdo_blue.UseVisualStyleBackColor = true;
            // 
            // rdo_red
            // 
            this.rdo_red.AutoSize = true;
            this.rdo_red.Location = new System.Drawing.Point(6, 39);
            this.rdo_red.Name = "rdo_red";
            this.rdo_red.Size = new System.Drawing.Size(41, 16);
            this.rdo_red.TabIndex = 1;
            this.rdo_red.Text = "Red";
            this.rdo_red.UseVisualStyleBackColor = true;
            // 
            // rdo_black
            // 
            this.rdo_black.AutoSize = true;
            this.rdo_black.Checked = true;
            this.rdo_black.Location = new System.Drawing.Point(6, 17);
            this.rdo_black.Name = "rdo_black";
            this.rdo_black.Size = new System.Drawing.Size(53, 16);
            this.rdo_black.TabIndex = 0;
            this.rdo_black.TabStop = true;
            this.rdo_black.Text = "Black";
            this.rdo_black.UseVisualStyleBackColor = true;
            this.rdo_black.CheckedChanged += new System.EventHandler(this.rdo_black_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_small);
            this.groupBox2.Controls.Add(this.rdo_middle);
            this.groupBox2.Controls.Add(this.rdo_large);
            this.groupBox2.Location = new System.Drawing.Point(6, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_painter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_painter;
        private System.Windows.Forms.RadioButton rdo_small;
        private System.Windows.Forms.RadioButton rdo_large;
        private System.Windows.Forms.RadioButton rdo_middle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_blue;
        private System.Windows.Forms.RadioButton rdo_red;
        private System.Windows.Forms.RadioButton rdo_black;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

