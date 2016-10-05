namespace FameBase
{
	partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.addUser = new System.Windows.Forms.ToolStripButton();
            this.set_1 = new System.Windows.Forms.ToolStripButton();
            this.set_2 = new System.Windows.Forms.ToolStripButton();
            this.run = new System.Windows.Forms.ToolStripButton();
            this.modelViewLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.manualLabel = new System.Windows.Forms.Label();
            this.threeDViewPanel = new System.Windows.Forms.Panel();
            this.viewlLabel = new System.Windows.Forms.Label();
            this.glViewer = new FameBase.GLViewer();
            this.statsLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.threeDViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUser,
            this.set_1,
            this.set_2,
            this.run});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(796, 39);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            // 
            // addUser
            // 
            this.addUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(36, 36);
            this.addUser.Text = "toolStripButton1";
            this.addUser.ToolTipText = "Register a user";
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // set_1
            // 
            this.set_1.Image = ((System.Drawing.Image)(resources.GetObject("set_1.Image")));
            this.set_1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.set_1.Name = "set_1";
            this.set_1.Size = new System.Drawing.Size(36, 36);
            this.set_1.Text = "Set 1";
            this.set_1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.set_1.Click += new System.EventHandler(this.set_1_Click);
            // 
            // set_2
            // 
            this.set_2.Image = ((System.Drawing.Image)(resources.GetObject("set_2.Image")));
            this.set_2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.set_2.Name = "set_2";
            this.set_2.Size = new System.Drawing.Size(36, 36);
            this.set_2.Text = "Set 2";
            this.set_2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.set_2.Click += new System.EventHandler(this.set_2_Click);
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.ForeColor = System.Drawing.Color.Chocolate;
            this.run.Image = ((System.Drawing.Image)(resources.GetObject("run.Image")));
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(38, 36);
            this.run.Text = "RUN";
            this.run.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // modelViewLayoutPanel
            // 
            this.modelViewLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelViewLayoutPanel.AutoScroll = true;
            this.modelViewLayoutPanel.BackColor = System.Drawing.Color.White;
            this.modelViewLayoutPanel.Location = new System.Drawing.Point(6, 3);
            this.modelViewLayoutPanel.Name = "modelViewLayoutPanel";
            this.modelViewLayoutPanel.Size = new System.Drawing.Size(790, 539);
            this.modelViewLayoutPanel.TabIndex = 13;
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.Controls.Add(this.manualLabel);
            this.viewPanel.Controls.Add(this.threeDViewPanel);
            this.viewPanel.Controls.Add(this.modelViewLayoutPanel);
            this.viewPanel.Location = new System.Drawing.Point(0, 42);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(796, 542);
            this.viewPanel.TabIndex = 17;
            // 
            // manualLabel
            // 
            this.manualLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.manualLabel.AutoSize = true;
            this.manualLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.manualLabel.Location = new System.Drawing.Point(3, 461);
            this.manualLabel.Name = "manualLabel";
            this.manualLabel.Size = new System.Drawing.Size(192, 78);
            this.manualLabel.TabIndex = 0;
            this.manualLabel.Text = "Manual:\r\n1. click the first button to register a user\r\n2. load a set\r\n3. click \"R" +
    "UN\"\r\n4. click on preferred shapes\r\n5. repeat 3-4 until satisfied.\r\n";
            // 
            // threeDViewPanel
            // 
            this.threeDViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.threeDViewPanel.Controls.Add(this.statsLabel);
            this.threeDViewPanel.Controls.Add(this.viewlLabel);
            this.threeDViewPanel.Controls.Add(this.glViewer);
            this.threeDViewPanel.Location = new System.Drawing.Point(396, 142);
            this.threeDViewPanel.Name = "threeDViewPanel";
            this.threeDViewPanel.Size = new System.Drawing.Size(400, 400);
            this.threeDViewPanel.TabIndex = 15;
            // 
            // viewlLabel
            // 
            this.viewlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewlLabel.AutoSize = true;
            this.viewlLabel.BackColor = System.Drawing.Color.White;
            this.viewlLabel.Location = new System.Drawing.Point(344, 6);
            this.viewlLabel.Name = "viewlLabel";
            this.viewlLabel.Size = new System.Drawing.Size(47, 13);
            this.viewlLabel.TabIndex = 14;
            this.viewlLabel.Text = "3D View";
            // 
            // glViewer
            // 
            this.glViewer.AccumBits = ((byte)(0));
            this.glViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glViewer.AutoCheckErrors = false;
            this.glViewer.AutoFinish = false;
            this.glViewer.AutoMakeCurrent = true;
            this.glViewer.AutoSwapBuffers = true;
            this.glViewer.BackColor = System.Drawing.Color.White;
            this.glViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glViewer.ColorBits = ((byte)(32));
            this.glViewer.CurrentUIMode = FameBase.GLViewer.UIMode.Viewing;
            this.glViewer.DepthBits = ((byte)(16));
            this.glViewer.Location = new System.Drawing.Point(3, 3);
            this.glViewer.Name = "glViewer";
            this.glViewer.Size = new System.Drawing.Size(392, 394);
            this.glViewer.StencilBits = ((byte)(0));
            this.glViewer.TabIndex = 0;
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.statsLabel.Location = new System.Drawing.Point(8, 7);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(34, 13);
            this.statsLabel.TabIndex = 16;
            this.statsLabel.Text = "Stats:";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 584);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface";
            this.Text = "Fame Demo";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.threeDViewPanel.ResumeLayout(false);
            this.threeDViewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion


        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.FlowLayoutPanel modelViewLayoutPanel;
        private System.Windows.Forms.ToolStripButton run;
        private System.Windows.Forms.ToolStripButton set_1;
        private System.Windows.Forms.ToolStripButton set_2;
        private System.Windows.Forms.Panel viewPanel;
        private GLViewer glViewer;
        private System.Windows.Forms.Label viewlLabel;
        private System.Windows.Forms.Panel threeDViewPanel;
        private System.Windows.Forms.ToolStripButton addUser;
        private System.Windows.Forms.Label manualLabel;
        private System.Windows.Forms.Label statsLabel;
	}
}

