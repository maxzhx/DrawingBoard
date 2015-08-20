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
            this.pic_painter = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cld1 = new System.Windows.Forms.ColorDialog();
            this.btn_color = new System.Windows.Forms.Button();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画笔粗细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_rec = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_ell = new System.Windows.Forms.Button();
            this.btn_StraightLine = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.打开oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_painter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_painter
            // 
            this.pic_painter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic_painter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_painter.Location = new System.Drawing.Point(87, 36);
            this.pic_painter.Name = "pic_painter";
            this.pic_painter.Size = new System.Drawing.Size(351, 381);
            this.pic_painter.TabIndex = 3;
            this.pic_painter.TabStop = false;
            this.pic_painter.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_painter_Paint);
            this.pic_painter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_painter_MouseDown);
            this.pic_painter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_painter_MouseMove);
            this.pic_painter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_painter_MouseUp);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(6, 368);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 49);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // sfd1
            // 
            this.sfd1.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif|BMP|*.bmp";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(6, 315);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 49);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(6, 260);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(75, 49);
            this.btn_color.TabIndex = 7;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开oToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.颜色ToolStripMenuItem,
            this.画笔粗细ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "清空(&C)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.颜色ToolStripMenuItem.Text = "颜色(&O)";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 画笔粗细ToolStripMenuItem
            // 
            this.画笔粗细ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小号ToolStripMenuItem,
            this.中号ToolStripMenuItem,
            this.大号ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.画笔粗细ToolStripMenuItem.Name = "画笔粗细ToolStripMenuItem";
            this.画笔粗细ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.画笔粗细ToolStripMenuItem.Text = "笔尖粗细(&S)";
            // 
            // 小号ToolStripMenuItem
            // 
            this.小号ToolStripMenuItem.Checked = true;
            this.小号ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.小号ToolStripMenuItem.Name = "小号ToolStripMenuItem";
            this.小号ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.小号ToolStripMenuItem.Text = "小号";
            this.小号ToolStripMenuItem.Click += new System.EventHandler(this.小号ToolStripMenuItem_Click);
            // 
            // 中号ToolStripMenuItem
            // 
            this.中号ToolStripMenuItem.Name = "中号ToolStripMenuItem";
            this.中号ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.中号ToolStripMenuItem.Text = "中号";
            this.中号ToolStripMenuItem.Click += new System.EventHandler(this.中号ToolStripMenuItem_Click);
            // 
            // 大号ToolStripMenuItem
            // 
            this.大号ToolStripMenuItem.Name = "大号ToolStripMenuItem";
            this.大号ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.大号ToolStripMenuItem.Text = "大号";
            this.大号ToolStripMenuItem.Click += new System.EventHandler(this.大号ToolStripMenuItem_Click);
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.其他ToolStripMenuItem.Text = "其他";
            this.其他ToolStripMenuItem.Click += new System.EventHandler(this.其他ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "关于(&A)";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_rec
            // 
            this.btn_rec.Location = new System.Drawing.Point(6, 94);
            this.btn_rec.Name = "btn_rec";
            this.btn_rec.Size = new System.Drawing.Size(75, 23);
            this.btn_rec.TabIndex = 9;
            this.btn_rec.Text = "矩形";
            this.btn_rec.UseVisualStyleBackColor = true;
            this.btn_rec.Click += new System.EventHandler(this.btn_rec_Click);
            // 
            // btn_line
            // 
            this.btn_line.Location = new System.Drawing.Point(6, 36);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(75, 23);
            this.btn_line.TabIndex = 10;
            this.btn_line.Text = "画笔";
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_ell
            // 
            this.btn_ell.Location = new System.Drawing.Point(6, 123);
            this.btn_ell.Name = "btn_ell";
            this.btn_ell.Size = new System.Drawing.Size(75, 23);
            this.btn_ell.TabIndex = 11;
            this.btn_ell.Text = "圆形";
            this.btn_ell.UseVisualStyleBackColor = true;
            this.btn_ell.Click += new System.EventHandler(this.btn_ell_Click);
            // 
            // btn_StraightLine
            // 
            this.btn_StraightLine.Location = new System.Drawing.Point(6, 65);
            this.btn_StraightLine.Name = "btn_StraightLine";
            this.btn_StraightLine.Size = new System.Drawing.Size(75, 23);
            this.btn_StraightLine.TabIndex = 12;
            this.btn_StraightLine.Text = "直线";
            this.btn_StraightLine.UseVisualStyleBackColor = true;
            this.btn_StraightLine.Click += new System.EventHandler(this.btn_StraightLine_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Location = new System.Drawing.Point(6, 152);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(75, 23);
            this.btn_eraser.TabIndex = 13;
            this.btn_eraser.Text = "橡皮";
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // 打开oToolStripMenuItem
            // 
            this.打开oToolStripMenuItem.Name = "打开oToolStripMenuItem";
            this.打开oToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开oToolStripMenuItem.Text = "打开(&O)";
            this.打开oToolStripMenuItem.Click += new System.EventHandler(this.打开oToolStripMenuItem_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif|BMP|*.bmp";
            this.ofd1.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 434);
            this.Controls.Add(this.btn_eraser);
            this.Controls.Add(this.btn_StraightLine);
            this.Controls.Add(this.btn_ell);
            this.Controls.Add(this.btn_line);
            this.Controls.Add(this.btn_rec);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pic_painter);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(466, 472);
            this.MinimumSize = new System.Drawing.Size(466, 472);
            this.Name = "Form1";
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_painter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_painter;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ColorDialog cld1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画笔粗细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.Button btn_rec;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_ell;
        private System.Windows.Forms.Button btn_StraightLine;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.ToolStripMenuItem 打开oToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd1;

    }
}

