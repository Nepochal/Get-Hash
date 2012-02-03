namespace Nepochal.GetHash
{
  partial class Language
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
      this.listBoxLanguages = new System.Windows.Forms.ListBox();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonOk = new System.Windows.Forms.Button();
      this.labelDescription = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBoxLanguages
      // 
      this.listBoxLanguages.FormattingEnabled = true;
      this.listBoxLanguages.Location = new System.Drawing.Point(8, 9);
      this.listBoxLanguages.Name = "listBoxLanguages";
      this.listBoxLanguages.Size = new System.Drawing.Size(141, 199);
      this.listBoxLanguages.Sorted = true;
      this.listBoxLanguages.TabIndex = 0;
      this.listBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguages_SelectedIndexChanged);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(325, 216);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 1;
      this.buttonCancel.Tag = "Cancel";
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonOk
      // 
      this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonOk.Location = new System.Drawing.Point(244, 216);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(75, 23);
      this.buttonOk.TabIndex = 2;
      this.buttonOk.Tag = "Ok";
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      // 
      // labelDescription
      // 
      this.labelDescription.Location = new System.Drawing.Point(159, 9);
      this.labelDescription.Name = "labelDescription";
      this.labelDescription.Size = new System.Drawing.Size(241, 199);
      this.labelDescription.TabIndex = 3;
      // 
      // Language
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(409, 248);
      this.Controls.Add(this.labelDescription);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.listBoxLanguages);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Language";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Tag = "Select language";
      this.Text = "Select language";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxLanguages;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.Label labelDescription;
  }
}