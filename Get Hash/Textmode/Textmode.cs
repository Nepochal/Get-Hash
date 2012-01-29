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

The complete source code can be found at https://github.com/Nepochal/Get-Hash.
The installer for the current version can be found at <http://mischolz.de/?page_id=46>
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nepochal.GetHash
{
  public partial class Textmode : Form
  {
    #region member Variables
    private bool mbUnused = true;
    #endregion

    #region ctors
    public Textmode()
    {
      InitializeComponent();
      GlobalStatics.FillHashMethods(comboBoxHashtype);

      Location = Program.mcConfiguration.TextPosition;
      Width = Program.mcConfiguration.TextSize.X;
      Height = Program.mcConfiguration.TextSize.Y;
      comboBoxHashtype.SelectedItem = Program.mcConfiguration.LastHashType;

      comboBoxHashtype.SelectedValueChanged += new EventHandler(comboBoxHashtype_SelectedValueChanged);
    }
    #endregion

    #region Methods

    #endregion

    #region Designer Methods
    private void textBoxText_TextChanged(object sender, EventArgs e)
    {
      mbUnused = false;
      textBoxResult.Text = GlobalStatics.CalculateHashText(textBoxText.Text, ((Hashtype)comboBoxHashtype.SelectedItem));
    }

    private void comboBoxHashtype_SelectedValueChanged(object sender, EventArgs e)
    {
      if (comboBoxHashtype.SelectedItem.ToString() != ((string)comboBoxHashtype.Tag))
      {
        comboBoxHashtype.Tag = comboBoxHashtype.SelectedItem.ToString();
        if (mbUnused)
          return;
        textBoxText_TextChanged(this, null);
      }
    }

    private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.None;
      Close();
    }

    private void textBoxText_Click(object sender, EventArgs e)
    {
      if (mbUnused)
      {
        mbUnused = false;
        textBoxText.Text = string.Empty;
        textBoxResult.Text = string.Empty;
      }
    }

    private void überGetHashToolStripMenuAbout_Click(object sender, EventArgs e)
    {
      About lAbout = new About("Get Hash", Program.msVersion);
      lAbout.ShowDialog(this);
    }

    private void Textmode_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (DialogResult == DialogResult.None)
        Program.mbRunning = false;
    }

    private void Textmode_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (WindowState == FormWindowState.Normal)
      {
        Program.mcConfiguration.TextPosition = Location;
        Program.mcConfiguration.TextSize = new Point(Width, Height);
      }
        Program.mcConfiguration.LastHashType = (Hashtype)comboBoxHashtype.SelectedItem;
    }

    private void ToolStripMenuItemFileMode_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Program.mcConfiguration.LastMode = Programmode.File;
      Close();
    }

    private void Textmode_Load(object sender, EventArgs e)
    {
      Program.mcConfiguration.LastMode = Programmode.Text;
    }

    #endregion

  }
}
