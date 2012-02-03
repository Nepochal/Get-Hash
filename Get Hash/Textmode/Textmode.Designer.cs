namespace Nepochal.GetHash
{
  partial class Textmode
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Textmode));
      this.textBoxText = new System.Windows.Forms.TextBox();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.comboBoxHashtype = new System.Windows.Forms.ComboBox();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemSelectLanguage = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemMode = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemTextMode = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemFileMode = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.überGetHashToolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxText
      // 
      this.textBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxText.Location = new System.Drawing.Point(7, 34);
      this.textBoxText.Multiline = true;
      this.textBoxText.Name = "textBoxText";
      this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxText.Size = new System.Drawing.Size(406, 169);
      this.textBoxText.TabIndex = 1;
      this.textBoxText.Tag = "Enter text";
      this.textBoxText.Text = "Hier bitte den Text eingeben.";
      this.toolTip.SetToolTip(this.textBoxText, "Text");
      this.textBoxText.Click += new System.EventHandler(this.textBoxText_Click);
      this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
      // 
      // textBoxResult
      // 
      this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
      this.textBoxResult.Location = new System.Drawing.Point(99, 209);
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ReadOnly = true;
      this.textBoxResult.Size = new System.Drawing.Size(314, 20);
      this.textBoxResult.TabIndex = 3;
      this.textBoxResult.Tag = "Hash value";
      this.textBoxResult.Text = "Hashwert";
      this.toolTip.SetToolTip(this.textBoxResult, "Hashwert");
      // 
      // comboBoxHashtype
      // 
      this.comboBoxHashtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.comboBoxHashtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxHashtype.FormattingEnabled = true;
      this.comboBoxHashtype.Location = new System.Drawing.Point(7, 209);
      this.comboBoxHashtype.Name = "comboBoxHashtype";
      this.comboBoxHashtype.Size = new System.Drawing.Size(86, 21);
      this.comboBoxHashtype.Sorted = true;
      this.comboBoxHashtype.TabIndex = 2;
      this.toolTip.SetToolTip(this.comboBoxHashtype, "Hashverfahren");
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemMode,
            this.ToolStripMenuItemHelp});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(420, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // ToolStripMenuItemFile
      // 
      this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSelectLanguage,
            this.toolStripMenuItem2,
            this.ToolStripMenuItemExit});
      this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
      this.ToolStripMenuItemFile.Size = new System.Drawing.Size(46, 20);
      this.ToolStripMenuItemFile.Tag = "File";
      this.ToolStripMenuItemFile.Text = "&Datei";
      // 
      // ToolStripMenuItemSelectLanguage
      // 
      this.ToolStripMenuItemSelectLanguage.Name = "ToolStripMenuItemSelectLanguage";
      this.ToolStripMenuItemSelectLanguage.Size = new System.Drawing.Size(157, 22);
      this.ToolStripMenuItemSelectLanguage.Tag = "Select language";
      this.ToolStripMenuItemSelectLanguage.Text = "Sprache wählen";
      this.ToolStripMenuItemSelectLanguage.Click += new System.EventHandler(this.ToolStripMenuItemSelectLanguage_Click);
      // 
      // ToolStripMenuItemExit
      // 
      this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
      this.ToolStripMenuItemExit.Size = new System.Drawing.Size(157, 22);
      this.ToolStripMenuItemExit.Tag = "Exit";
      this.ToolStripMenuItemExit.Text = "Beenden";
      this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
      // 
      // ToolStripMenuItemMode
      // 
      this.ToolStripMenuItemMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTextMode,
            this.ToolStripMenuItemFileMode});
      this.ToolStripMenuItemMode.Name = "ToolStripMenuItemMode";
      this.ToolStripMenuItemMode.Size = new System.Drawing.Size(56, 20);
      this.ToolStripMenuItemMode.Tag = "Mode";
      this.ToolStripMenuItemMode.Text = "&Modus";
      // 
      // ToolStripMenuItemTextMode
      // 
      this.ToolStripMenuItemTextMode.Checked = true;
      this.ToolStripMenuItemTextMode.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ToolStripMenuItemTextMode.Name = "ToolStripMenuItemTextMode";
      this.ToolStripMenuItemTextMode.ShortcutKeys = System.Windows.Forms.Keys.F2;
      this.ToolStripMenuItemTextMode.Size = new System.Drawing.Size(157, 22);
      this.ToolStripMenuItemTextMode.Tag = "Textmode";
      this.ToolStripMenuItemTextMode.Text = "Textmodus";
      // 
      // ToolStripMenuItemFileMode
      // 
      this.ToolStripMenuItemFileMode.Name = "ToolStripMenuItemFileMode";
      this.ToolStripMenuItemFileMode.ShortcutKeys = System.Windows.Forms.Keys.F3;
      this.ToolStripMenuItemFileMode.Size = new System.Drawing.Size(157, 22);
      this.ToolStripMenuItemFileMode.Tag = "Filemode";
      this.ToolStripMenuItemFileMode.Text = "Dateimodus";
      this.ToolStripMenuItemFileMode.Click += new System.EventHandler(this.ToolStripMenuItemFileMode_Click);
      // 
      // ToolStripMenuItemHelp
      // 
      this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überGetHashToolStripMenuAbout});
      this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
      this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
      this.ToolStripMenuItemHelp.Tag = "Help";
      this.ToolStripMenuItemHelp.Text = "&Hilfe";
      // 
      // überGetHashToolStripMenuAbout
      // 
      this.überGetHashToolStripMenuAbout.Name = "überGetHashToolStripMenuAbout";
      this.überGetHashToolStripMenuAbout.Size = new System.Drawing.Size(150, 22);
      this.überGetHashToolStripMenuAbout.Tag = "About";
      this.überGetHashToolStripMenuAbout.Text = "Über Get Hash";
      this.überGetHashToolStripMenuAbout.Click += new System.EventHandler(this.überGetHashToolStripMenuAbout_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
      // 
      // Textmode
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(420, 237);
      this.Controls.Add(this.comboBoxHashtype);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.textBoxText);
      this.Controls.Add(this.menuStrip);
      this.DoubleBuffered = true;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.MinimumSize = new System.Drawing.Size(182, 116);
      this.Name = "Textmode";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Get Hash";
      this.TransparencyKey = System.Drawing.Color.Magenta;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Textmode_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Textmode_FormClosed);
      this.Load += new System.EventHandler(this.Textmode_Load);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxText;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.ComboBox comboBoxHashtype;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMode;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTextMode;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileMode;
    private System.Windows.Forms.ToolStripMenuItem überGetHashToolStripMenuAbout;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSelectLanguage;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
  }
}

