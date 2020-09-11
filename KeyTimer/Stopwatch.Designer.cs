namespace KeyTimer
{
    partial class Stopwatch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHotkey = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.timerKeyListener = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(462, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHotkey
            // 
            this.btnHotkey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHotkey.Location = new System.Drawing.Point(381, 14);
            this.btnHotkey.Name = "btnHotkey";
            this.btnHotkey.Size = new System.Drawing.Size(75, 23);
            this.btnHotkey.TabIndex = 2;
            this.btnHotkey.Text = "Hotkey";
            this.btnHotkey.UseVisualStyleBackColor = true;
            this.btnHotkey.Click += new System.EventHandler(this.btnHotkey_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelName.Location = new System.Drawing.Point(110, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "PA1";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTime.Location = new System.Drawing.Point(295, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(80, 24);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // colorBox
            // 
            this.colorBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colorBox.BackColor = System.Drawing.Color.Turquoise;
            this.colorBox.Location = new System.Drawing.Point(3, 0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(64, 53);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // timerTimer
            // 
            this.timerTimer.Enabled = true;
            this.timerTimer.Interval = 1000;
            this.timerTimer.Tick += new System.EventHandler(this.timerTimer_Tick);
            // 
            // timerKeyListener
            // 
            this.timerKeyListener.Enabled = true;
            this.timerKeyListener.Interval = 10;
            this.timerKeyListener.Tick += new System.EventHandler(this.timerKeyListener_Tick);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnHotkey);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelName);
            this.Name = "Stopwatch";
            this.Size = new System.Drawing.Size(491, 52);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHotkey;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Timer timerTimer;
        private System.Windows.Forms.Timer timerKeyListener;
    }
}
