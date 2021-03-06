﻿namespace MyControls.ContainerControls
{
    partial class UserBaseControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TittleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.dragPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dragPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 30);
            this.panel1.TabIndex = 0;
            // 
            // dragPanel
            // 
            this.dragPanel.Controls.Add(this.TittleLabel);
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(705, 30);
            this.dragPanel.TabIndex = 0;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Minimize);
            this.panel3.Controls.Add(this.Maximize);
            this.panel3.Controls.Add(this.Exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(695, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 30);
            this.panel3.TabIndex = 3;
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Minimize.Location = new System.Drawing.Point(13, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.TabIndex = 0;
            this.Minimize.Text = "—";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Maximize.Image = global::MyControls.Properties.Resources.Maximize;
            this.Maximize.Location = new System.Drawing.Point(43, 2);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(24, 24);
            this.Maximize.TabIndex = 2;
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(73, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 24);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "×";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 418);
            this.panel2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Location = new System.Drawing.Point(8, 8);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(29, 12);
            this.TittleLabel.TabIndex = 0;
            this.TittleLabel.Text = "标题";
            // 
            // UserBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserBaseControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserBaseControl_Load);
            this.panel1.ResumeLayout(false);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label TittleLabel;
    }
}
