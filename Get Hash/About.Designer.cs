/*
This file is part of the Get Hash Source Code.  

Get Hash is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Get Hash is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Get Hash. If not, see <http://www.gnu.org/licenses/gpl.html>.

The complete source code can be found at <https://github.com/Nepochal/Get-Hash>.

The implementation of the CRC32-algorithm was taken
from <http://dotnet-snippets.de/dns/crc32---checksumme-einer-datei-berechnen-SID1306.aspx>
and is copyrighted by Qchen

*/

namespace Nepochal.GetHash
{
  partial class About
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
      this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
      this.labelTitle = new System.Windows.Forms.Label();
      this.labelVersion = new System.Windows.Forms.Label();
      this.labelCopyright = new System.Windows.Forms.Label();
      this.labelText = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.linkLabelHp = new System.Windows.Forms.LinkLabel();
      this.buttonSourceCode = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBoxLogo
      // 
      this.pictureBoxLogo.BackgroundImage = global::Nepochal.GetHash.Properties.Resources.MSLogo;
      this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBoxLogo.InitialImage = null;
      this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
      this.pictureBoxLogo.Name = "pictureBoxLogo";
      this.pictureBoxLogo.Size = new System.Drawing.Size(128, 128);
      this.pictureBoxLogo.TabIndex = 0;
      this.pictureBoxLogo.TabStop = false;
      // 
      // labelTitle
      // 
      this.labelTitle.AutoSize = true;
      this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.Location = new System.Drawing.Point(146, 12);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(51, 19);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "[Title]";
      // 
      // labelVersion
      // 
      this.labelVersion.AutoSize = true;
      this.labelVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelVersion.ForeColor = System.Drawing.Color.Indigo;
      this.labelVersion.Location = new System.Drawing.Point(147, 45);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(63, 16);
      this.labelVersion.TabIndex = 2;
      this.labelVersion.Text = "[Version]";
      // 
      // labelCopyright
      // 
      this.labelCopyright.AutoSize = true;
      this.labelCopyright.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelCopyright.Location = new System.Drawing.Point(147, 105);
      this.labelCopyright.Name = "labelCopyright";
      this.labelCopyright.Size = new System.Drawing.Size(234, 16);
      this.labelCopyright.TabIndex = 3;
      this.labelCopyright.Text = "Copyright © Michael Scholz 2010-2012";
      // 
      // labelText
      // 
      this.labelText.Location = new System.Drawing.Point(12, 146);
      this.labelText.Name = "labelText";
      this.labelText.Size = new System.Drawing.Size(496, 212);
      this.labelText.TabIndex = 4;
      this.labelText.Tag = "About text";
      this.labelText.Text = resources.GetString("labelText.Text");
      // 
      // buttonClose
      // 
      this.buttonClose.Location = new System.Drawing.Point(12, 361);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(76, 21);
      this.buttonClose.TabIndex = 6;
      this.buttonClose.Tag = "Ok";
      this.buttonClose.Text = "&Ok";
      this.buttonClose.UseVisualStyleBackColor = true;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // linkLabelHp
      // 
      this.linkLabelHp.AutoSize = true;
      this.linkLabelHp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabelHp.Location = new System.Drawing.Point(147, 121);
      this.linkLabelHp.Name = "linkLabelHp";
      this.linkLabelHp.Size = new System.Drawing.Size(108, 16);
      this.linkLabelHp.TabIndex = 7;
      this.linkLabelHp.TabStop = true;
      this.linkLabelHp.Text = "www.mischolz.de";
      this.linkLabelHp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHp_LinkClicked);
      // 
      // buttonSourceCode
      // 
      this.buttonSourceCode.Location = new System.Drawing.Point(94, 361);
      this.buttonSourceCode.Name = "buttonSourceCode";
      this.buttonSourceCode.Size = new System.Drawing.Size(76, 21);
      this.buttonSourceCode.TabIndex = 8;
      this.buttonSourceCode.Tag = "Source code";
      this.buttonSourceCode.Text = "Source code";
      this.buttonSourceCode.UseVisualStyleBackColor = true;
      this.buttonSourceCode.Click += new System.EventHandler(this.buttonSourceCode_Click);
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(516, 393);
      this.Controls.Add(this.buttonSourceCode);
      this.Controls.Add(this.linkLabelHp);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.labelText);
      this.Controls.Add(this.labelCopyright);
      this.Controls.Add(this.labelVersion);
      this.Controls.Add(this.labelTitle);
      this.Controls.Add(this.pictureBoxLogo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "About";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Tag = "About";
      this.Text = "About Get Hash";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxLogo;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.Label labelText;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.LinkLabel linkLabelHp;
    private System.Windows.Forms.Button buttonSourceCode;
  }
}