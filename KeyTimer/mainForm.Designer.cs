namespace KeyTimer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cmsRmb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadDefaultTimersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStopwatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRmb.SuspendLayout();
            this.cmsAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ContextMenuStrip = this.cmsAdd;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(695, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 53);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(669, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "github.com/Daylend";
            // 
            // flPanel
            // 
            this.flPanel.AutoScrollMargin = new System.Drawing.Size(500, 0);
            this.flPanel.AutoSize = true;
            this.flPanel.ColumnCount = 1;
            this.flPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.flPanel.Location = new System.Drawing.Point(12, 12);
            this.flPanel.Name = "flPanel";
            this.flPanel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.flPanel.RowCount = 7;
            this.flPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flPanel.Size = new System.Drawing.Size(650, 352);
            this.flPanel.TabIndex = 3;
            // 
            // cmsRmb
            // 
            this.cmsRmb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultTimersToolStripMenuItem});
            this.cmsRmb.Name = "cmsRmb";
            this.cmsRmb.Size = new System.Drawing.Size(180, 26);
            // 
            // loadDefaultTimersToolStripMenuItem
            // 
            this.loadDefaultTimersToolStripMenuItem.Name = "loadDefaultTimersToolStripMenuItem";
            this.loadDefaultTimersToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadDefaultTimersToolStripMenuItem.Text = "Load Default Timers";
            this.loadDefaultTimersToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultTimersToolStripMenuItem_Click);
            // 
            // cmsAdd
            // 
            this.cmsAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTimerToolStripMenuItem,
            this.addStopwatchToolStripMenuItem});
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(156, 48);
            // 
            // addTimerToolStripMenuItem
            // 
            this.addTimerToolStripMenuItem.Name = "addTimerToolStripMenuItem";
            this.addTimerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addTimerToolStripMenuItem.Text = "Add Timer";
            this.addTimerToolStripMenuItem.Click += new System.EventHandler(this.addTimerToolStripMenuItem_Click);
            // 
            // addStopwatchToolStripMenuItem
            // 
            this.addStopwatchToolStripMenuItem.Name = "addStopwatchToolStripMenuItem";
            this.addStopwatchToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addStopwatchToolStripMenuItem.Text = "Add Stopwatch";
            this.addStopwatchToolStripMenuItem.Click += new System.EventHandler(this.addStopwatchToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(784, 389);
            this.ContextMenuStrip = this.cmsRmb;
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(100000, 1200);
            this.MinimumSize = new System.Drawing.Size(800, 325);
            this.Name = "MainForm";
            this.Text = "Hotkey Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsRmb.ResumeLayout(false);
            this.cmsAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel flPanel;
        private System.Windows.Forms.ContextMenuStrip cmsRmb;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultTimersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem addTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStopwatchToolStripMenuItem;
    }
}

