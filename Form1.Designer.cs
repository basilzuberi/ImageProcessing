namespace ImageProcessing
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
            this.btnExtractG = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFlipVert = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.btnFlipHoriz = new System.Windows.Forms.Button();
            this.btnExtractB = new System.Windows.Forms.Button();
            this.btnExtractR = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.Invert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPixellate = new System.Windows.Forms.Button();
            this.btnScroll = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtractG
            // 
            this.btnExtractG.Location = new System.Drawing.Point(87, 19);
            this.btnExtractG.Name = "btnExtractG";
            this.btnExtractG.Size = new System.Drawing.Size(75, 23);
            this.btnExtractG.TabIndex = 12;
            this.btnExtractG.Text = "Extract for G";
            this.btnExtractG.UseVisualStyleBackColor = true;
            this.btnExtractG.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(257, 258);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(320, 240);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFlipVert);
            this.groupBox1.Controls.Add(this.btnRotate180);
            this.groupBox1.Controls.Add(this.btnFlipHoriz);
            this.groupBox1.Controls.Add(this.btnExtractB);
            this.groupBox1.Controls.Add(this.btnExtractR);
            this.groupBox1.Controls.Add(this.btnGray);
            this.groupBox1.Controls.Add(this.btnPolarize);
            this.groupBox1.Controls.Add(this.btnSunset);
            this.groupBox1.Controls.Add(this.btnDarken);
            this.groupBox1.Controls.Add(this.btnLighten);
            this.groupBox1.Controls.Add(this.Invert);
            this.groupBox1.Controls.Add(this.btnExtractG);
            this.groupBox1.Location = new System.Drawing.Point(338, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Functions";
            // 
            // btnFlipVert
            // 
            this.btnFlipVert.Location = new System.Drawing.Point(85, 135);
            this.btnFlipVert.Name = "btnFlipVert";
            this.btnFlipVert.Size = new System.Drawing.Size(75, 23);
            this.btnFlipVert.TabIndex = 18;
            this.btnFlipVert.Text = "Flip Vert";
            this.btnFlipVert.UseVisualStyleBackColor = true;
            this.btnFlipVert.Click += new System.EventHandler(this.btnFlipVert_Click);
            // 
            // btnRotate180
            // 
            this.btnRotate180.Location = new System.Drawing.Point(87, 164);
            this.btnRotate180.Name = "btnRotate180";
            this.btnRotate180.Size = new System.Drawing.Size(75, 23);
            this.btnRotate180.TabIndex = 17;
            this.btnRotate180.Text = "Rotate 180";
            this.btnRotate180.UseVisualStyleBackColor = true;
            this.btnRotate180.Click += new System.EventHandler(this.btnRotate180_Click);
            // 
            // btnFlipHoriz
            // 
            this.btnFlipHoriz.Location = new System.Drawing.Point(87, 106);
            this.btnFlipHoriz.Name = "btnFlipHoriz";
            this.btnFlipHoriz.Size = new System.Drawing.Size(75, 23);
            this.btnFlipHoriz.TabIndex = 15;
            this.btnFlipHoriz.Text = "Flip Horiz";
            this.btnFlipHoriz.UseVisualStyleBackColor = true;
            this.btnFlipHoriz.Click += new System.EventHandler(this.btnFlipHoriz_Click);
            // 
            // btnExtractB
            // 
            this.btnExtractB.Location = new System.Drawing.Point(87, 77);
            this.btnExtractB.Name = "btnExtractB";
            this.btnExtractB.Size = new System.Drawing.Size(75, 23);
            this.btnExtractB.TabIndex = 14;
            this.btnExtractB.Text = "Extract for B";
            this.btnExtractB.UseVisualStyleBackColor = true;
            this.btnExtractB.Click += new System.EventHandler(this.btnExtractB_Click);
            // 
            // btnExtractR
            // 
            this.btnExtractR.Location = new System.Drawing.Point(87, 48);
            this.btnExtractR.Name = "btnExtractR";
            this.btnExtractR.Size = new System.Drawing.Size(75, 23);
            this.btnExtractR.TabIndex = 13;
            this.btnExtractR.Text = "Extract for R";
            this.btnExtractR.UseVisualStyleBackColor = true;
            this.btnExtractR.Click += new System.EventHandler(this.btnExtractR_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(6, 164);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 11;
            this.btnGray.Text = "Gray Scale";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(6, 135);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(75, 23);
            this.btnPolarize.TabIndex = 10;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(6, 106);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(75, 23);
            this.btnSunset.TabIndex = 9;
            this.btnSunset.Text = "Sunset";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(6, 77);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(75, 23);
            this.btnDarken.TabIndex = 8;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(6, 48);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(75, 23);
            this.btnLighten.TabIndex = 7;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // Invert
            // 
            this.Invert.Location = new System.Drawing.Point(6, 19);
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(75, 23);
            this.Invert.TabIndex = 6;
            this.Invert.Text = "Invert";
            this.Invert.UseVisualStyleBackColor = true;
            this.Invert.Click += new System.EventHandler(this.Invert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "New Canvas";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPixellate);
            this.groupBox2.Controls.Add(this.btnScroll);
            this.groupBox2.Controls.Add(this.btnSort);
            this.groupBox2.Controls.Add(this.btnSwitch);
            this.groupBox2.Controls.Add(this.btnBlur);
            this.groupBox2.Location = new System.Drawing.Point(338, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 104);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intermediate Funtions";
            // 
            // btnPixellate
            // 
            this.btnPixellate.Location = new System.Drawing.Point(87, 48);
            this.btnPixellate.Name = "btnPixellate";
            this.btnPixellate.Size = new System.Drawing.Size(75, 23);
            this.btnPixellate.TabIndex = 11;
            this.btnPixellate.Text = "Pixellate";
            this.btnPixellate.UseVisualStyleBackColor = true;
            this.btnPixellate.Click += new System.EventHandler(this.btnPixellate_Click);
            // 
            // btnScroll
            // 
            this.btnScroll.Location = new System.Drawing.Point(6, 48);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(75, 23);
            this.btnScroll.TabIndex = 10;
            this.btnScroll.Text = "Scroll";
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(6, 77);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(87, 19);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 9;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(6, 19);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(75, 23);
            this.btnBlur.TabIndex = 8;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExtractG;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button Invert;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnExtractB;
        private System.Windows.Forms.Button btnExtractR;
        private System.Windows.Forms.Button btnRotate180;
        private System.Windows.Forms.Button btnFlipHoriz;
        private System.Windows.Forms.Button btnFlipVert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnScroll;
        private System.Windows.Forms.Button btnPixellate;
    }
}

