namespace paint
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.PBPaintField = new System.Windows.Forms.PictureBox();
            this.bCircle = new System.Windows.Forms.Button();
            this.bRectangle = new System.Windows.Forms.Button();
            this.bLine = new System.Windows.Forms.Button();
            this.bStar = new System.Windows.Forms.Button();
            this.bTriangle = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bColor = new System.Windows.Forms.Button();
            this.lWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBPaintField)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBPaintField
            // 
            this.PBPaintField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBPaintField.Location = new System.Drawing.Point(281, 29);
            this.PBPaintField.Name = "PBPaintField";
            this.PBPaintField.Size = new System.Drawing.Size(853, 584);
            this.PBPaintField.TabIndex = 0;
            this.PBPaintField.TabStop = false;
            this.PBPaintField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBPaintField_MouseDown);
            // 
            // bCircle
            // 
            this.bCircle.Image = ((System.Drawing.Image)(resources.GetObject("bCircle.Image")));
            this.bCircle.Location = new System.Drawing.Point(14, 14);
            this.bCircle.Name = "bCircle";
            this.bCircle.Size = new System.Drawing.Size(24, 25);
            this.bCircle.TabIndex = 1;
            this.bCircle.UseVisualStyleBackColor = true;
            this.bCircle.Click += new System.EventHandler(this.bCircle_Click);
            // 
            // bRectangle
            // 
            this.bRectangle.Image = ((System.Drawing.Image)(resources.GetObject("bRectangle.Image")));
            this.bRectangle.Location = new System.Drawing.Point(44, 14);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(24, 25);
            this.bRectangle.TabIndex = 2;
            this.bRectangle.UseVisualStyleBackColor = true;
            this.bRectangle.Click += new System.EventHandler(this.bRectangle_Click);
            // 
            // bLine
            // 
            this.bLine.Image = ((System.Drawing.Image)(resources.GetObject("bLine.Image")));
            this.bLine.Location = new System.Drawing.Point(14, 45);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(24, 25);
            this.bLine.TabIndex = 3;
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.bLine_Click);
            // 
            // bStar
            // 
            this.bStar.Image = ((System.Drawing.Image)(resources.GetObject("bStar.Image")));
            this.bStar.Location = new System.Drawing.Point(44, 72);
            this.bStar.Name = "bStar";
            this.bStar.Size = new System.Drawing.Size(24, 25);
            this.bStar.TabIndex = 4;
            this.bStar.UseVisualStyleBackColor = true;
            this.bStar.Click += new System.EventHandler(this.bStar_Click);
            // 
            // bTriangle
            // 
            this.bTriangle.Image = ((System.Drawing.Image)(resources.GetObject("bTriangle.Image")));
            this.bTriangle.Location = new System.Drawing.Point(14, 72);
            this.bTriangle.Name = "bTriangle";
            this.bTriangle.Size = new System.Drawing.Size(24, 25);
            this.bTriangle.TabIndex = 5;
            this.bTriangle.UseVisualStyleBackColor = true;
            this.bTriangle.Click += new System.EventHandler(this.bTriangle_Click);
            // 
            // bDot
            // 
            this.bDot.Image = ((System.Drawing.Image)(resources.GetObject("bDot.Image")));
            this.bDot.Location = new System.Drawing.Point(44, 45);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(24, 25);
            this.bDot.TabIndex = 6;
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bCircle);
            this.panel1.Controls.Add(this.bStar);
            this.panel1.Controls.Add(this.bTriangle);
            this.panel1.Controls.Add(this.bDot);
            this.panel1.Controls.Add(this.bRectangle);
            this.panel1.Controls.Add(this.bLine);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 121);
            this.panel1.TabIndex = 7;
            // 
            // bColor
            // 
            this.bColor.Image = ((System.Drawing.Image)(resources.GetObject("bColor.Image")));
            this.bColor.Location = new System.Drawing.Point(3, 150);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(273, 59);
            this.bColor.TabIndex = 8;
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(12, 259);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(53, 13);
            this.lWidth.TabIndex = 10;
            this.lWidth.Text = "Толщина";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(71, 256);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(26, 20);
            this.tbWidth.TabIndex = 11;
            this.tbWidth.Text = "3";
            this.tbWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 659);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBPaintField);
            this.Name = "FMain";
            this.Text = "MyPaint";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPaintField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBPaintField;
        private System.Windows.Forms.Button bCircle;
        private System.Windows.Forms.Button bRectangle;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Button bStar;
        private System.Windows.Forms.Button bTriangle;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.TextBox tbWidth;
    }
}