// Copyright (C) Microsoft Corporation. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;

namespace WebView2WindowsFormsBrowser
{
    partial class BrowserForm
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
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.blockedDomainsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView2Control = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(788, 25);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(75, 23);
            this.btnEvents.TabIndex = 6;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Reload";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(753, 1);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(37, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(82, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(665, 20);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.Text = "https://www.bing.com/";
            // 
            // blockedDomainsMenuItem
            // 
            this.blockedDomainsMenuItem.Name = "blockedDomainsMenuItem";
            this.blockedDomainsMenuItem.Size = new System.Drawing.Size(359, 44);
            this.blockedDomainsMenuItem.Text = "Blocked Domains";
            this.blockedDomainsMenuItem.Click += new System.EventHandler(this.blockedDomainsMenuItem_Click);
            // 
            // webView2Control
            // 
            this.webView2Control.AllowExternalDrop = true;
            this.webView2Control.CreationProperties = null;
            this.webView2Control.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.webView2Control.Location = new System.Drawing.Point(0, 29);
            this.webView2Control.Margin = new System.Windows.Forms.Padding(2);
            this.webView2Control.Name = "webView2Control";
            this.webView2Control.Size = new System.Drawing.Size(790, 422);
            this.webView2Control.Source = new System.Uri("https://www.bing.com/", System.UriKind.Absolute);
            this.webView2Control.TabIndex = 7;
            this.webView2Control.ZoomFactor = 1D;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.webView2Control);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEvents);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.Load += new System.EventHandler(this.BrowserForm_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Drawing.Bitmap webViewLogoBitmap;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Control;
        private System.Windows.Forms.ToolStripMenuItem blockedDomainsMenuItem;
    }
}
