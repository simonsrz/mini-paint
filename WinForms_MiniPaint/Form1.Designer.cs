
namespace WinForms_MiniPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripLabel();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.loadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tools = new System.Windows.Forms.ToolStripLabel();
            this.brushButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.chooseThickness = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.chosenColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.enLang = new System.Windows.Forms.ToolStripButton();
            this.plLang = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.paintingArea = new System.Windows.Forms.PictureBox();
            this.colorSection = new System.Windows.Forms.GroupBox();
            this.ColorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintingArea)).BeginInit();
            this.colorSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.saveButton,
            this.loadButton,
            this.toolStripSeparator1,
            this.Tools,
            this.brushButton,
            this.rectangleButton,
            this.ellipseButton,
            this.clearButton,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.chooseThickness,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.chosenColor,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.enLang,
            this.plLang});
            this.toolStrip.Name = "toolStrip";
            // 
            // File
            // 
            resources.ApplyResources(this.File, "File");
            this.File.Name = "File";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Name = "saveButton";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadButton.Name = "loadButton";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // Tools
            // 
            resources.ApplyResources(this.Tools, "Tools");
            this.Tools.Name = "Tools";
            // 
            // brushButton
            // 
            resources.ApplyResources(this.brushButton, "brushButton");
            this.brushButton.CheckOnClick = true;
            this.brushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushButton.Name = "brushButton";
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // rectangleButton
            // 
            resources.ApplyResources(this.rectangleButton, "rectangleButton");
            this.rectangleButton.CheckOnClick = true;
            this.rectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // ellipseButton
            // 
            resources.ApplyResources(this.ellipseButton, "ellipseButton");
            this.ellipseButton.CheckOnClick = true;
            this.ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearButton.Name = "clearButton";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            // 
            // chooseThickness
            // 
            resources.ApplyResources(this.chooseThickness, "chooseThickness");
            this.chooseThickness.Items.AddRange(new object[] {
            resources.GetString("chooseThickness.Items"),
            resources.GetString("chooseThickness.Items1"),
            resources.GetString("chooseThickness.Items2")});
            this.chooseThickness.Name = "chooseThickness";
            this.chooseThickness.SelectedIndexChanged += new System.EventHandler(this.chooseThickness_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripLabel2
            // 
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            this.toolStripLabel2.Name = "toolStripLabel2";
            // 
            // chosenColor
            // 
            resources.ApplyResources(this.chosenColor, "chosenColor");
            this.chosenColor.BackColor = System.Drawing.Color.Transparent;
            this.chosenColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.chosenColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chosenColor.Name = "chosenColor";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // toolStripLabel3
            // 
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            this.toolStripLabel3.Name = "toolStripLabel3";
            // 
            // enLang
            // 
            resources.ApplyResources(this.enLang, "enLang");
            this.enLang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enLang.Name = "enLang";
            this.enLang.Click += new System.EventHandler(this.enLang_Click);
            // 
            // plLang
            // 
            resources.ApplyResources(this.plLang, "plLang");
            this.plLang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plLang.Name = "plLang";
            this.plLang.Click += new System.EventHandler(this.plLang_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.paintingArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorSection, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // paintingArea
            // 
            resources.ApplyResources(this.paintingArea, "paintingArea");
            this.paintingArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.paintingArea.Name = "paintingArea";
            this.paintingArea.TabStop = false;
            this.paintingArea.SizeChanged += new System.EventHandler(this.paintingArea_SizeChanged);
            this.paintingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.paintingArea_Paint);
            this.paintingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintingArea_MouseDown);
            this.paintingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintingArea_MouseMove);
            this.paintingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintingArea_MouseUp);
            // 
            // colorSection
            // 
            resources.ApplyResources(this.colorSection, "colorSection");
            this.colorSection.Controls.Add(this.ColorPanel);
            this.colorSection.Name = "colorSection";
            this.colorSection.TabStop = false;
            // 
            // ColorPanel
            // 
            resources.ApplyResources(this.ColorPanel, "ColorPanel");
            this.ColorPanel.BackColor = System.Drawing.Color.White;
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorPanel_Scroll);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paintingArea)).EndInit();
            this.colorSection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox paintingArea;
        private System.Windows.Forms.GroupBox colorSection;
        private System.Windows.Forms.ToolStripButton brushButton;
        private System.Windows.Forms.ToolStripLabel Tools;
        private System.Windows.Forms.FlowLayoutPanel ColorPanel;
        private System.Windows.Forms.ToolStripLabel File;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton loadButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton rectangleButton;
        private System.Windows.Forms.ToolStripButton ellipseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ToolStripComboBox chooseThickness;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton chosenColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton enLang;
        private System.Windows.Forms.ToolStripButton plLang;
    }
}

