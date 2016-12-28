﻿namespace TweetDck.Core.Other.Settings.Dialogs {
    partial class DialogSettingsExport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbConfig = new System.Windows.Forms.CheckBox();
            this.cbSession = new System.Windows.Forms.CheckBox();
            this.cbPluginData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(216, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.AutoSize = true;
            this.btnApply.Location = new System.Drawing.Point(157, 107);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnApply.Size = new System.Drawing.Size(53, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbConfig
            // 
            this.cbConfig.AutoSize = true;
            this.cbConfig.Location = new System.Drawing.Point(13, 13);
            this.cbConfig.Name = "cbConfig";
            this.cbConfig.Size = new System.Drawing.Size(106, 17);
            this.cbConfig.TabIndex = 2;
            this.cbConfig.Text = "Program Settings";
            this.cbConfig.UseVisualStyleBackColor = true;
            this.cbConfig.CheckedChanged += new System.EventHandler(this.cbConfig_CheckedChanged);
            // 
            // cbSession
            // 
            this.cbSession.AutoSize = true;
            this.cbSession.Location = new System.Drawing.Point(13, 37);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(92, 17);
            this.cbSession.TabIndex = 3;
            this.cbSession.Text = "Login Session";
            this.cbSession.UseVisualStyleBackColor = true;
            this.cbSession.CheckedChanged += new System.EventHandler(this.cbSession_CheckedChanged);
            // 
            // cbPluginData
            // 
            this.cbPluginData.AutoSize = true;
            this.cbPluginData.Location = new System.Drawing.Point(13, 61);
            this.cbPluginData.Name = "cbPluginData";
            this.cbPluginData.Size = new System.Drawing.Size(81, 17);
            this.cbPluginData.TabIndex = 4;
            this.cbPluginData.Text = "Plugin Data";
            this.cbPluginData.UseVisualStyleBackColor = true;
            this.cbPluginData.CheckedChanged += new System.EventHandler(this.cbPluginData_CheckedChanged);
            // 
            // DialogSettingsExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.cbPluginData);
            this.Controls.Add(this.cbSession);
            this.Controls.Add(this.cbConfig);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.MinimumSize = new System.Drawing.Size(200, 170);
            this.Name = "DialogSettingsExport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox cbConfig;
        private System.Windows.Forms.CheckBox cbSession;
        private System.Windows.Forms.CheckBox cbPluginData;
    }
}