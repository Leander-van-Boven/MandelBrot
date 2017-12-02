namespace MandelBrot
{
    partial class Mandelform
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
            this.MandelPic = new System.Windows.Forms.PictureBox();
            this.xMid = new System.Windows.Forms.TextBox();
            this.yMid = new System.Windows.Forms.TextBox();
            this.Herhalingen = new System.Windows.Forms.TextBox();
            this.Zoom = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MandelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MandelPic
            // 
            this.MandelPic.Location = new System.Drawing.Point(12, 89);
            this.MandelPic.Name = "MandelPic";
            this.MandelPic.Size = new System.Drawing.Size(610, 610);
            this.MandelPic.TabIndex = 0;
            this.MandelPic.TabStop = false;
            // 
            // xMid
            // 
            this.xMid.Location = new System.Drawing.Point(13, 13);
            this.xMid.Name = "xMid";
            this.xMid.Size = new System.Drawing.Size(100, 20);
            this.xMid.TabIndex = 1;
            this.xMid.Text = "0";
            // 
            // yMid
            // 
            this.yMid.Location = new System.Drawing.Point(13, 40);
            this.yMid.Name = "yMid";
            this.yMid.Size = new System.Drawing.Size(100, 20);
            this.yMid.TabIndex = 2;
            this.yMid.Text = "0";
            // 
            // Herhalingen
            // 
            this.Herhalingen.Location = new System.Drawing.Point(120, 13);
            this.Herhalingen.Name = "Herhalingen";
            this.Herhalingen.Size = new System.Drawing.Size(100, 20);
            this.Herhalingen.TabIndex = 3;
            this.Herhalingen.Text = "100";
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(120, 40);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(100, 20);
            this.Zoom.TabIndex = 4;
            this.Zoom.Text = "5";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(227, 9);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(227, 36);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Mandelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 711);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.Herhalingen);
            this.Controls.Add(this.yMid);
            this.Controls.Add(this.xMid);
            this.Controls.Add(this.MandelPic);
            this.Name = "Mandelform";
            this.Text = "MandelApp";
            ((System.ComponentModel.ISupportInitialize)(this.MandelPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MandelPic;
        private System.Windows.Forms.TextBox xMid;
        private System.Windows.Forms.TextBox yMid;
        private System.Windows.Forms.TextBox Herhalingen;
        private System.Windows.Forms.TextBox Zoom;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Reset;
    }
}

