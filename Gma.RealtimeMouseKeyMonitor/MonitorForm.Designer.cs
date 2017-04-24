namespace Gma.RealtimeMouseKeyMonitor
{
    partial class MonitorForm
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
            this.cbspacebar = new System.Windows.Forms.CheckBox();
            this.cbenter = new System.Windows.Forms.CheckBox();
            this.cbleftmouse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbspacebar
            // 
            this.cbspacebar.AutoSize = true;
            this.cbspacebar.Enabled = false;
            this.cbspacebar.Location = new System.Drawing.Point(12, 12);
            this.cbspacebar.Name = "cbspacebar";
            this.cbspacebar.Size = new System.Drawing.Size(117, 27);
            this.cbspacebar.TabIndex = 0;
            this.cbspacebar.Text = "Space Key";
            this.cbspacebar.UseVisualStyleBackColor = true;
            // 
            // cbenter
            // 
            this.cbenter.AutoSize = true;
            this.cbenter.Enabled = false;
            this.cbenter.Location = new System.Drawing.Point(12, 46);
            this.cbenter.Name = "cbenter";
            this.cbenter.Size = new System.Drawing.Size(110, 27);
            this.cbenter.TabIndex = 1;
            this.cbenter.Text = "Enter Key";
            this.cbenter.UseVisualStyleBackColor = true;
            // 
            // cbleftmouse
            // 
            this.cbleftmouse.AutoSize = true;
            this.cbleftmouse.Enabled = false;
            this.cbleftmouse.Location = new System.Drawing.Point(12, 80);
            this.cbleftmouse.Name = "cbleftmouse";
            this.cbleftmouse.Size = new System.Drawing.Size(121, 27);
            this.cbleftmouse.TabIndex = 2;
            this.cbleftmouse.Text = "Left Mouse";
            this.cbleftmouse.UseVisualStyleBackColor = true;
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 122);
            this.Controls.Add(this.cbleftmouse);
            this.Controls.Add(this.cbenter);
            this.Controls.Add(this.cbspacebar);
            this.MaximizeBox = false;
            this.Name = "MonitorForm";
            this.Text = "Key Monitor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbspacebar;
        private System.Windows.Forms.CheckBox cbenter;
        private System.Windows.Forms.CheckBox cbleftmouse;
    }
}