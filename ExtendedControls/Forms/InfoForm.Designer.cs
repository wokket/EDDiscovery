﻿/*
 * Copyright © 2016 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
namespace ExtendedControls
{ 
    partial class InfoForm
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
            this.buttonOK = new ExtendedControls.ButtonExt();
            this.textBoxInfo = new ExtendedControls.RichTextBoxScroll();
            this.labelCaption = new System.Windows.Forms.Label();
            this.panel_close = new ExtendedControls.DrawnPanel();
            this.panel_minimize = new ExtendedControls.DrawnPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BorderColorScaling = 1.25F;
            this.buttonOK.ButtonColorScaling = 0.5F;
            this.buttonOK.ButtonDisabledScaling = 0.5F;
            this.buttonOK.Location = new System.Drawing.Point(746, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxInfo.BorderColorScaling = 0.5F;
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.HideScrollBar = true;
            this.textBoxInfo.Location = new System.Drawing.Point(0, 30);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = false;
            this.textBoxInfo.ScrollBarArrowBorderColor = System.Drawing.Color.LightBlue;
            this.textBoxInfo.ScrollBarArrowButtonColor = System.Drawing.Color.LightGray;
            this.textBoxInfo.ScrollBarBackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo.ScrollBarBorderColor = System.Drawing.Color.White;
            this.textBoxInfo.ScrollBarFlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textBoxInfo.ScrollBarForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxInfo.ScrollBarMouseOverButtonColor = System.Drawing.Color.Green;
            this.textBoxInfo.ScrollBarMousePressedButtonColor = System.Drawing.Color.Red;
            this.textBoxInfo.ScrollBarSliderColor = System.Drawing.Color.DarkGray;
            this.textBoxInfo.ScrollBarThumbBorderColor = System.Drawing.Color.Yellow;
            this.textBoxInfo.ScrollBarThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.textBoxInfo.ScrollBarWidth = 20;
            this.textBoxInfo.ShowLineCount = false;
            this.textBoxInfo.Size = new System.Drawing.Size(824, 530);
            this.textBoxInfo.TabIndex = 2;
            this.textBoxInfo.TextBoxBackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo.TextBoxForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(3, 3);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(98, 13);
            this.labelCaption.TabIndex = 6;
            this.labelCaption.Text = "Captiony thing here";
            this.labelCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCaption_MouseDown);
            // 
            // panel_close
            // 
            this.panel_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_close.BackColor = System.Drawing.SystemColors.Control;
            this.panel_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_close.Location = new System.Drawing.Point(796, 3);
            this.panel_close.MarginSize = 6;
            this.panel_close.Name = "panel_close";
            this.panel_close.Size = new System.Drawing.Size(24, 24);
            this.panel_close.TabIndex = 29;
            this.panel_close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_close_MouseClick);
            // 
            // panel_minimize
            // 
            this.panel_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_minimize.BackColor = System.Drawing.SystemColors.Control;
            this.panel_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_minimize.ImageSelected = ExtendedControls.DrawnPanel.ImageType.Minimize;
            this.panel_minimize.Location = new System.Drawing.Point(766, 3);
            this.panel_minimize.MarginSize = 6;
            this.panel_minimize.Name = "panel_minimize";
            this.panel_minimize.Size = new System.Drawing.Size(24, 24);
            this.panel_minimize.TabIndex = 28;
            this.panel_minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_minimize_MouseClick);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel_minimize);
            this.panelTop.Controls.Add(this.labelCaption);
            this.panelTop.Controls.Add(this.panel_close);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(824, 30);
            this.panelTop.TabIndex = 30;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 560);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(824, 34);
            this.panelBottom.TabIndex = 31;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 594);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InfoForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ExtendedControls.ButtonExt buttonOK;
        private ExtendedControls.RichTextBoxScroll textBoxInfo;
        private System.Windows.Forms.Label labelCaption;
        private DrawnPanel panel_close;
        private DrawnPanel panel_minimize;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
    }
}