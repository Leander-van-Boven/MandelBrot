using System;
using System.Windows.Forms;

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
            this.Draw = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMid = new System.Windows.Forms.ToolStripTextBox();
            this.yMiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yMid = new System.Windows.Forms.ToolStripTextBox();
            this.iterationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Iterations = new System.Windows.Forms.ToolStripTextBox();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomScale = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Redraw = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwartWitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blauwtintenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roodtintenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groentintenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kleurrijkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MiddenPuntStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MousePoint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MandelPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MandelPic
            // 
            this.MandelPic.BackColor = System.Drawing.SystemColors.WindowText;
            this.MandelPic.Location = new System.Drawing.Point(0, 32);
            this.MandelPic.Margin = new System.Windows.Forms.Padding(4);
            this.MandelPic.Name = "MandelPic";
            this.MandelPic.Size = new System.Drawing.Size(882, 772);
            this.MandelPic.TabIndex = 0;
            this.MandelPic.TabStop = false;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(660, 0);
            this.Draw.Margin = new System.Windows.Forms.Padding(4);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(100, 28);
            this.Draw.TabIndex = 5;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(770, 0);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 28);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.variablesToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMiddenToolStripMenuItem,
            this.yMiddenToolStripMenuItem,
            this.iterationsToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.toolStripSeparator1,
            this.Redraw});
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.variablesToolStripMenuItem.Text = "Variables";
            // 
            // xMiddenToolStripMenuItem
            // 
            this.xMiddenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMid});
            this.xMiddenToolStripMenuItem.Name = "xMiddenToolStripMenuItem";
            this.xMiddenToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.xMiddenToolStripMenuItem.Text = "X_Mid:";
            this.xMiddenToolStripMenuItem.Click += new System.EventHandler(this.xMiddenToolStripMenuItem_Click);
            // 
            // xMid
            // 
            this.xMid.Name = "xMid";
            this.xMid.Size = new System.Drawing.Size(100, 27);
            this.xMid.Text = "0";
            this.xMid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEnter);
            // 
            // yMiddenToolStripMenuItem
            // 
            this.yMiddenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yMid});
            this.yMiddenToolStripMenuItem.Name = "yMiddenToolStripMenuItem";
            this.yMiddenToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.yMiddenToolStripMenuItem.Text = "Y_Mid:";
            // 
            // yMid
            // 
            this.yMid.Name = "yMid";
            this.yMid.Size = new System.Drawing.Size(100, 27);
            this.yMid.Text = "0";
            this.yMid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEnter);
            // 
            // iterationsToolStripMenuItem
            // 
            this.iterationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Iterations});
            this.iterationsToolStripMenuItem.Name = "iterationsToolStripMenuItem";
            this.iterationsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.iterationsToolStripMenuItem.Text = "Iterations:";
            // 
            // Iterations
            // 
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(100, 27);
            this.Iterations.Text = "100";
            this.Iterations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEnter);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomScale});
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.scaleToolStripMenuItem.Text = "Zoom:";
            // 
            // ZoomScale
            // 
            this.ZoomScale.Name = "ZoomScale";
            this.ZoomScale.Size = new System.Drawing.Size(100, 27);
            this.ZoomScale.Text = "1";
            this.ZoomScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEnter);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // Redraw
            // 
            this.Redraw.Name = "Redraw";
            this.Redraw.ShortcutKeyDisplayString = "F5";
            this.Redraw.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Redraw.Size = new System.Drawing.Size(213, 26);
            this.Redraw.Text = "Refresh/Redraw";
            this.Redraw.Click += new System.EventHandler(this.Redraw_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zwartWitToolStripMenuItem,
            this.blauwtintenToolStripMenuItem,
            this.roodtintenToolStripMenuItem,
            this.groentintenToolStripMenuItem,
            this.kleurrijkToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // zwartWitToolStripMenuItem
            // 
            this.zwartWitToolStripMenuItem.Name = "zwartWitToolStripMenuItem";
            this.zwartWitToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.zwartWitToolStripMenuItem.Text = "Zwart-Wit";
            // 
            // blauwtintenToolStripMenuItem
            // 
            this.blauwtintenToolStripMenuItem.Name = "blauwtintenToolStripMenuItem";
            this.blauwtintenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.blauwtintenToolStripMenuItem.Text = "Blauw-tinten";
            // 
            // roodtintenToolStripMenuItem
            // 
            this.roodtintenToolStripMenuItem.Name = "roodtintenToolStripMenuItem";
            this.roodtintenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.roodtintenToolStripMenuItem.Text = "Rood-tinten";
            // 
            // groentintenToolStripMenuItem
            // 
            this.groentintenToolStripMenuItem.Name = "groentintenToolStripMenuItem";
            this.groentintenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.groentintenToolStripMenuItem.Text = "Groen-tinten";
            // 
            // kleurrijkToolStripMenuItem
            // 
            this.kleurrijkToolStripMenuItem.Name = "kleurrijkToolStripMenuItem";
            this.kleurrijkToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.kleurrijkToolStripMenuItem.Text = "Kleurrijk";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiddenPuntStatus,
            this.MousePoint});
            this.statusStrip1.Location = new System.Drawing.Point(0, 808);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 25);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MiddenPuntStatus
            // 
            this.MiddenPuntStatus.Name = "MiddenPuntStatus";
            this.MiddenPuntStatus.Size = new System.Drawing.Size(32, 20);
            this.MiddenPuntStatus.Text = "0, 0";
            // 
            // MousePoint
            // 
            this.MousePoint.Name = "MousePoint";
            this.MousePoint.Size = new System.Drawing.Size(0, 20);
            // 
            // Mandelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 833);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.MandelPic);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mandelform";
            this.Text = "MandelApp";
            this.Load += new System.EventHandler(this.MandelFormLoad);
            this.ClientSizeChanged += new System.EventHandler(this.SizeChange);
            ((System.ComponentModel.ISupportInitialize)(this.MandelPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox MandelPic;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button Reset;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem variablesToolStripMenuItem;
        private ToolStripMenuItem xMiddenToolStripMenuItem;
        private ToolStripMenuItem yMiddenToolStripMenuItem;
        private ToolStripMenuItem iterationsToolStripMenuItem;
        private ToolStripMenuItem scaleToolStripMenuItem;
        private ToolStripTextBox xMid;
        private ToolStripTextBox yMid;
        private ToolStripTextBox Iterations;
        private ToolStripTextBox ZoomScale;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel MiddenPuntStatus;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem Redraw;
        private ToolStripStatusLabel MousePoint;
        private ToolStripMenuItem zwartWitToolStripMenuItem;
        private ToolStripMenuItem blauwtintenToolStripMenuItem;
        private ToolStripMenuItem roodtintenToolStripMenuItem;
        private ToolStripMenuItem groentintenToolStripMenuItem;
        private ToolStripMenuItem kleurrijkToolStripMenuItem;
    }
}

