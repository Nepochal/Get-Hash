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
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Nepochal.GetHash
{
  public partial class Language : Form
  {

    #region Member variables

    Dictionary<Translation, string> mdTranslations;

    #endregion

    #region Accessors

    public string TranslationPath
    {
      get
      {
        string lsReturn;
        mdTranslations.TryGetValue((Translation)listBoxLanguages.SelectedItem, out lsReturn);
        return lsReturn;
      }
    }

    public Translation Translation
    {
      get { return (Translation)listBoxLanguages.SelectedItem; }
    }

    #endregion

    #region ctors

    public Language()
    {
      InitializeComponent();

      mdTranslations = new Dictionary<Translation, string>();
      FillLanguageList(string.Empty);
      listBoxLanguages.SelectedIndex = 0;
    }

    public Language(string psOldLanguageFile)
    {
      InitializeComponent();

      Translate();

      mdTranslations = new Dictionary<Translation, string>();
      FillLanguageList(psOldLanguageFile);
    }

    #endregion

    #region Methods

    private void Translate()
    {
      Form lfThis = this;
      Program.mtTranslation.TranslateForm(ref lfThis);
    }

    private void FillLanguageList(string psOldLanguageFile)
    {
      string lsFilePath = Path.Combine(Application.StartupPath, "Language");
      foreach (string lsFile in Directory.GetFiles(lsFilePath))
      {
        if (Path.GetExtension(lsFile).ToLower() != ".xml")
          continue;

        Translation ltTranslation;
        if (Translation.Load(lsFile, out ltTranslation))
        {
          mdTranslations.Add(ltTranslation, lsFile);
          listBoxLanguages.Items.Add(ltTranslation);
          if (lsFile == psOldLanguageFile)
            listBoxLanguages.SelectedItem = ltTranslation;
        }
      }
      if (listBoxLanguages.SelectedItem == null)
        listBoxLanguages.SelectedIndex = 0;
    }

    private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBoxLanguages.SelectedIndex != -1)
        labelDescription.Text = ((Translation)listBoxLanguages.SelectedItem).Description;
    }

    #endregion

    private void listBoxLanguages_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left && listBoxLanguages.IndexFromPoint(e.Location) != -1)
      {
        DialogResult = DialogResult.OK;
        Close();
      }
    }

  }

}
