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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandelform));
            this.MandelPic = new System.Windows.Forms.PictureBox();
            this.Draw = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBit = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMid = new System.Windows.Forms.ToolStripTextBox();
            this.yMiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yMid = new System.Windows.Forms.ToolStripTextBox();
            this.iterationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Iterations = new System.Windows.Forms.ToolStripTextBox();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomScale = new System.Windows.Forms.ToolStripTextBox();
            this.pickDefaultColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Redraw = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultcolorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentalcolorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackwhitecolorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redhueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenhueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bluehueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MiddenPuntStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MousePoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.Help_Button = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.DefaultColorsBox = new System.Windows.Forms.CheckedListBox();
            this.AcceptColors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MandelPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MandelPic
            // 
            this.MandelPic.BackColor = System.Drawing.SystemColors.MenuText;
            this.MandelPic.Location = new System.Drawing.Point(0, 26);
            this.MandelPic.Name = "MandelPic";
            this.MandelPic.Size = new System.Drawing.Size(662, 627);
            this.MandelPic.TabIndex = 0;
            this.MandelPic.TabStop = false;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(405, 1);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 5;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(490, 1);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // SaveBit
            // 
            this.SaveBit.Name = "SaveBit";
            this.SaveBit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveBit.Size = new System.Drawing.Size(160, 22);
            this.SaveBit.Text = "&Save As..";
            this.SaveBit.Click += new System.EventHandler(this.SaveBit_Click);
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMiddenToolStripMenuItem,
            this.yMiddenToolStripMenuItem,
            this.iterationsToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.pickDefaultColorsToolStripMenuItem,
            this.toolStripSeparator1,
            this.Redraw});
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.variablesToolStripMenuItem.Text = "&Variables";
            // 
            // xMiddenToolStripMenuItem
            // 
            this.xMiddenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMid});
            this.xMiddenToolStripMenuItem.Name = "xMiddenToolStripMenuItem";
            this.xMiddenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.xMiddenToolStripMenuItem.Text = "X_Mid:";
            this.xMiddenToolStripMenuItem.Click += new System.EventHandler(this.xMiddenToolStripMenuItem_Click);
            // 
            // xMid
            // 
            this.xMid.Name = "xMid";
            this.xMid.Size = new System.Drawing.Size(100, 23);
            this.xMid.Text = "0";
            this.xMid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyDown);
            // 
            // yMiddenToolStripMenuItem
            // 
            this.yMiddenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yMid});
            this.yMiddenToolStripMenuItem.Name = "yMiddenToolStripMenuItem";
            this.yMiddenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.yMiddenToolStripMenuItem.Text = "Y_Mid:";
            // 
            // yMid
            // 
            this.yMid.Name = "yMid";
            this.yMid.Size = new System.Drawing.Size(100, 23);
            this.yMid.Text = "0";
            this.yMid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyDown);
            // 
            // iterationsToolStripMenuItem
            // 
            this.iterationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Iterations});
            this.iterationsToolStripMenuItem.Name = "iterationsToolStripMenuItem";
            this.iterationsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.iterationsToolStripMenuItem.Text = "Iterations:";
            // 
            // Iterations
            // 
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(100, 23);
            this.Iterations.Text = "100";
            this.Iterations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyDown);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomScale});
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.scaleToolStripMenuItem.Text = "Zoom:";
            // 
            // ZoomScale
            // 
            this.ZoomScale.Name = "ZoomScale";
            this.ZoomScale.Size = new System.Drawing.Size(100, 23);
            this.ZoomScale.Text = "1";
            this.ZoomScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyDown);
            // 
            // pickDefaultColorsToolStripMenuItem
            // 
            this.pickDefaultColorsToolStripMenuItem.Name = "pickDefaultColorsToolStripMenuItem";
            this.pickDefaultColorsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.pickDefaultColorsToolStripMenuItem.Text = "PickDefaultColors";
            this.pickDefaultColorsToolStripMenuItem.Click += new System.EventHandler(this.pickDefaultColorsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // Redraw
            // 
            this.Redraw.Name = "Redraw";
            this.Redraw.ShortcutKeyDisplayString = "F5";
            this.Redraw.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Redraw.Size = new System.Drawing.Size(176, 22);
            this.Redraw.Text = "Refresh/Redraw";
            this.Redraw.Click += new System.EventHandler(this.Redraw_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultcolorsToolStripMenuItem,
            this.experimentalcolorsToolStripMenuItem,
            this.blackwhitecolorsToolStripMenuItem,
            this.redhueToolStripMenuItem,
            this.greenhueToolStripMenuItem,
            this.bluehueToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "&Colors";
            // 
            // defaultcolorsToolStripMenuItem
            // 
            this.defaultcolorsToolStripMenuItem.Name = "defaultcolorsToolStripMenuItem";
            this.defaultcolorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.defaultcolorsToolStripMenuItem.Text = "Default";
            this.defaultcolorsToolStripMenuItem.Click += new System.EventHandler(this.defaultcolorsToolStripMenuItem_Click);
            // 
            // experimentalcolorsToolStripMenuItem
            // 
            this.experimentalcolorsToolStripMenuItem.Name = "experimentalcolorsToolStripMenuItem";
            this.experimentalcolorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.experimentalcolorsToolStripMenuItem.Text = "Experimental";
            this.experimentalcolorsToolStripMenuItem.Click += new System.EventHandler(this.experimentalcolorsToolStripMenuItem_Click);
            // 
            // blackwhitecolorsToolStripMenuItem
            // 
            this.blackwhitecolorsToolStripMenuItem.Name = "blackwhitecolorsToolStripMenuItem";
            this.blackwhitecolorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.blackwhitecolorsToolStripMenuItem.Text = "Black/White";
            this.blackwhitecolorsToolStripMenuItem.Click += new System.EventHandler(this.blackwhitecolorsToolStripMenuItem_Click);
            // 
            // redhueToolStripMenuItem
            // 
            this.redhueToolStripMenuItem.Name = "redhueToolStripMenuItem";
            this.redhueToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.redhueToolStripMenuItem.Text = "Red-Hue";
            this.redhueToolStripMenuItem.Click += new System.EventHandler(this.redhueToolStripMenuItem_Click);
            // 
            // greenhueToolStripMenuItem
            // 
            this.greenhueToolStripMenuItem.Name = "greenhueToolStripMenuItem";
            this.greenhueToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.greenhueToolStripMenuItem.Text = "Green-Hue";
            this.greenhueToolStripMenuItem.Click += new System.EventHandler(this.greenhueToolStripMenuItem_Click);
            // 
            // bluehueToolStripMenuItem
            // 
            this.bluehueToolStripMenuItem.Name = "bluehueToolStripMenuItem";
            this.bluehueToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bluehueToolStripMenuItem.Text = "Blue-Hue";
            this.bluehueToolStripMenuItem.Click += new System.EventHandler(this.bluehueToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiddenPuntStatus,
            this.MousePoint});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(662, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MiddenPuntStatus
            // 
            this.MiddenPuntStatus.Name = "MiddenPuntStatus";
            this.MiddenPuntStatus.Size = new System.Drawing.Size(25, 17);
            this.MiddenPuntStatus.Text = "0, 0";
            // 
            // MousePoint
            // 
            this.MousePoint.Name = "MousePoint";
            this.MousePoint.Size = new System.Drawing.Size(0, 17);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(575, 1);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(75, 23);
            this.Help_Button.TabIndex = 13;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "bmp";
            this.dlgSaveFile.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif;*.tiff|BMP|*.bmp|JPEG|*.jpg;*.jp" +
    "eg|GIF|*.gif|PNG|*.png|TIFF|*.tif;*.tiff|ALL FILES|*.*";
            // 
            // DefaultColorsBox
            // 
            this.DefaultColorsBox.CheckOnClick = true;
            this.DefaultColorsBox.FormattingEnabled = true;
            this.DefaultColorsBox.Items.AddRange(new object[] {
            "AliceBlue",
            "Aqua",
            "Beige",
            "Black",
            "Blue",
            "BlueViolet",
            "Brown",
            "Chocolate",
            "Cyan",
            "DarkBlue",
            "DarkGray",
            "DarkGreen",
            "DarkOrange",
            "DarkRed",
            "DeepPink",
            "ForestGreen",
            "Gold",
            "Green",
            "GreenYellow",
            "Indigo",
            "LightGreen",
            "Lime",
            "Magenta",
            "Navy",
            "Orange",
            "OrangeRed",
            "Purple",
            "Red",
            "SkyBlue",
            "Tomato",
            "Turquoise",
            "Violet",
            "White",
            "Yellow",
            "YellowGreen"});
            this.DefaultColorsBox.Location = new System.Drawing.Point(267, 267);
            this.DefaultColorsBox.Name = "DefaultColorsBox";
            this.DefaultColorsBox.Size = new System.Drawing.Size(124, 139);
            this.DefaultColorsBox.TabIndex = 14;
            this.DefaultColorsBox.Visible = false;
            // 
            // AcceptColors
            // 
            this.AcceptColors.Location = new System.Drawing.Point(290, 412);
            this.AcceptColors.Name = "AcceptColors";
            this.AcceptColors.Size = new System.Drawing.Size(75, 23);
            this.AcceptColors.TabIndex = 15;
            this.AcceptColors.Text = "Accept";
            this.AcceptColors.UseVisualStyleBackColor = true;
            this.AcceptColors.Visible = false;
            // 
            // Mandelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 677);
            this.Controls.Add(this.AcceptColors);
            this.Controls.Add(this.DefaultColorsBox);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.MandelPic);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private void xMiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        private ToolStripMenuItem blackwhitecolorsToolStripMenuItem;
        private ToolStripMenuItem bluehueToolStripMenuItem;
        private ToolStripMenuItem redhueToolStripMenuItem;
        private ToolStripMenuItem greenhueToolStripMenuItem;
        private ToolStripMenuItem defaultcolorsToolStripMenuItem;
        private ToolStripMenuItem experimentalcolorsToolStripMenuItem;
        private Button Help_Button;
        private ToolStripMenuItem SaveBit;
        internal System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private ToolStripMenuItem pickDefaultColorsToolStripMenuItem;
        private CheckedListBox DefaultColorsBox;
        private Button AcceptColors;
    }
}

