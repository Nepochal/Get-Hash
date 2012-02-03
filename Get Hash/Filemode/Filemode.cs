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
The installer for the current version can be found at <http://mischolz.de/?page_id=46>
*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Shell32;

namespace Nepochal.GetHash
{
  public partial class Filemode : Form
  {

    #region Delegates

    private delegate Hashtype VoidToHashtypeDelegate();
    private delegate void StringToVoidDelegate(string psString);
    private delegate void BoolToVoidDelegate(bool pbBoolean);
    private delegate void EventDelegate(object sender, EventArgs e);
    private delegate void StringColorToVoidDelegate(string psString, Color pcColor);

    #endregion

    #region Accessors

    #endregion

    #region Member Variables
    private bool mbCalculating = false;
    private bool mbFinishedCalculating = false;
    private Thread mtCalculationThread;
    private string msFilePath;
    #endregion

    #region ctors
    public Filemode()
    {
      InitializeComponent();
      GlobalStatics.FillHashMethods(comboBoxHashtype);

      Location = Program.mcConfiguration.FilePosition;
      Width = Program.mcConfiguration.FileSize.X;
      Height = Program.mcConfiguration.FileSize.Y;
      comboBoxHashtype.SelectedItem = Program.mcConfiguration.LastHashType;

    }

    public Filemode(string psFilePath)
    {
      InitializeComponent();
      GlobalStatics.FillHashMethods(comboBoxHashtype);

      Location = Program.mcConfiguration.FilePosition;
      Width = Program.mcConfiguration.FileSize.X;
      Height = Program.mcConfiguration.FileSize.Y;
      comboBoxHashtype.SelectedItem = Program.mcConfiguration.LastHashType;

      msFilePath = psFilePath;
      labelFilename.Text = Path.GetFileName(msFilePath);
      Calculating(true);
    }
    #endregion

    #region Methods
    public void Calculating(bool pbCalculating)
    {
      if (buttonChooseFile.InvokeRequired)
      {
        buttonChooseFile.Invoke(new BoolToVoidDelegate(Calculating), pbCalculating);
        return;
      }

      buttonChooseFile.Enabled = !pbCalculating;
      buttonCancel.Enabled = pbCalculating;
      comboBoxHashtype.Enabled = !pbCalculating;
      toolStripMenuItemTextMode.Enabled = !pbCalculating;
      toolStripMenuItemFileMode.Enabled = !pbCalculating;

      switch (pbCalculating)
      {
        case true:
          SetInfoText("Hash wird berechnet...", Color.FromKnownColor(KnownColor.ControlText));
          mbCalculating = true;
          StartCalculationThread();
          break;

        case false:
          if (mbCalculating)
          {
            mtCalculationThread.Abort();
            textBoxResult.Text = string.Empty;
            SetInfoText("Hashberechnung abgebrochen!", Color.FromKnownColor(KnownColor.ControlText));
            mbCalculating = false;
          }
          break;
      }
    }

    public void SetInfoText(string psText, Color pcTextColor)
    {
      if (labelInfo.InvokeRequired)
      {
        labelInfo.Invoke(new StringColorToVoidDelegate(SetInfoText), psText, pcTextColor);
        return;
      }
      labelInfo.ForeColor = pcTextColor;
      labelInfo.Text = psText;
    }

    public bool CompareHashes()
    {
      if (textBoxCompare.Text.Trim() == textBoxResult.Text)
      {
        SetInfoText("Die Datei ist in Ordnung.", Color.Green);
        return true;
      }
      else
      {
        SetInfoText("Die Datei ist beschädigt.", Color.Red);
        return false;
      }
    }
    #endregion

    #region Designer Methods

    private void Filemode_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (DialogResult == DialogResult.None)
        Program.mbRunning = false;
    }

    private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.None;
      Close();
    }

    private void überGetHashToolStripMenuAbout_Click(object sender, EventArgs e)
    {
      About lAbout = new About("Get Hash", Program.msVersion);
      lAbout.ShowDialog(this);
    }

    private void textBoxCompare_Enter(object sender, EventArgs e)
    {
      if (textBoxCompare.InvokeRequired)
      {
        textBoxCompare.Invoke(new EventDelegate(textBoxCompare_Enter), sender, e);
        return;
      }
      textBoxCompare.Text = string.Empty;
      textBoxCompare.Enter -= textBoxCompare_Enter;
    }

    private void buttonChooseFile_Click(object sender, EventArgs e)
    {
      if (openFileDialogChooseFile.ShowDialog() == DialogResult.OK)
      {
        msFilePath = openFileDialogChooseFile.FileName;
        labelFilename.Text = Path.GetFileName(msFilePath);
        Calculating(true);
      }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      Invalidate();
      Calculating(false);
    }

    private void textBoxCompare_TextChanged(object sender, EventArgs e)
    {
      CompareHashes();
    }

    private void comboBoxHashtype_SelectedValueChanged(object sender, EventArgs e)
    {
      if (mbFinishedCalculating)
        Calculating(true);
    }

    private void Filemode_DragEnter(object sender, DragEventArgs e)
    {
      if (e.KeyState % 2 == 0 || mbCalculating)
      {
        e.Effect = DragDropEffects.None;
        return;
      }
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        string[] lsFilename = ((string[])e.Data.GetData(DataFormats.FileDrop));
        if (lsFilename.Length != 1 || Directory.Exists(lsFilename[0]) || Path.GetExtension(lsFilename[0]).ToLower() == ".ghf")
          e.Effect = DragDropEffects.None;
        else
          e.Effect = DragDropEffects.Move;
      }
    }

    private void Filemode_DragDrop(object sender, DragEventArgs e)
    {
      msFilePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
      if (Path.GetExtension(msFilePath) == ".lnk")
      {
        Shell32.Folder lsF = (new ShellClass()).NameSpace(Path.GetDirectoryName(msFilePath));
        ShellLinkObject lsloObject = (ShellLinkObject)lsF.Items().Item(Path.GetFileName(msFilePath)).GetLink;
        msFilePath = lsloObject.Path;
      }
      labelFilename.Text = Path.GetFileName(msFilePath);
      Calculating(true);
    }

    private void toolStripMenuItemTextMode_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Program.mcConfiguration.LastMode = Programmode.Text;
      Close();
    }

    private void Filemode_Load(object sender, EventArgs e)
    {
      Program.mcConfiguration.LastMode = Programmode.File;
    }

    private void Filemode_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (WindowState == FormWindowState.Normal)
      {
        Program.mcConfiguration.FilePosition = Location;
        Program.mcConfiguration.FileSize = new Point(Width, Height);
      }
      Program.mcConfiguration.LastHashType = (Hashtype)comboBoxHashtype.SelectedItem;
    }

    #endregion

    #region Calculation-Thread
    public void StartCalculationThread()
    {
      mtCalculationThread = new Thread(CalculationThreadWorkflow);
      mtCalculationThread.Name = "Calculation-Thread";
      mtCalculationThread.IsBackground = true;
      mtCalculationThread.Start();
    }

    public void CalculationThreadWorkflow()
    {
      try
      {
        mbFinishedCalculating = false;
        textBoxCompare.TextChanged -= new EventHandler(textBoxCompare_TextChanged);

        if (textBoxCompare.Text == "Vergleichswert")
          textBoxCompare_Enter(this, null);
        string lsReturn = GlobalStatics.CalculateHashFile(msFilePath, GetSelectedHashType());
        SetCalculatedHash(lsReturn);
        mbCalculating = false;
        Calculating(false);

        if (textBoxCompare.Text == string.Empty)
          SetInfoText("Berechnung erfolgreich beendet.", Color.FromKnownColor(KnownColor.ControlText));
        else
          CompareHashes();

        mbFinishedCalculating = true;
        textBoxCompare.TextChanged += new EventHandler(textBoxCompare_TextChanged);
      }
      catch (ThreadAbortException)
      {
        mbCalculating = false;
      }
    }

    private Hashtype GetSelectedHashType()
    {
      if (comboBoxHashtype.InvokeRequired)
        return ((Hashtype)comboBoxHashtype.Invoke(new VoidToHashtypeDelegate(GetSelectedHashType)));
      else
        return ((Hashtype)comboBoxHashtype.SelectedItem);
    }

    private void SetCalculatedHash(string psHashValue)
    {
      if (textBoxResult.InvokeRequired)
        textBoxResult.Invoke(new StringToVoidDelegate(SetCalculatedHash), psHashValue);
      else
        textBoxResult.Text = psHashValue;
    }
    #endregion

  }
}
