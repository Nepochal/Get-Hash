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
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Nepochal.GetHash
{
  public class Translation
  {

    #region Member variables

    private string msLanguage;
    private string msDescription;
    private List<TranslationItem> mtiItems;
    private bool mbChanged = false;

    #endregion

    #region Accessors

    public string Language
    {
      get { return msLanguage; }
      set { msLanguage = value; }
    }
    public string Description
    {
      get { return msDescription; }
      set { msDescription = value; }
    }
    public List<TranslationItem> Items
    {
      get { return mtiItems; }
      set { mtiItems = value; }
    }

    [XmlIgnore]
    public bool Changed
    {
      get { return mbChanged; }
    }

    #endregion

    #region ctors

    /// <summary>
    /// Only for the xml-serializer
    /// </summary>
    public Translation()
    { }

    #endregion

    #region Methods

    public override string ToString()
    {
      return msLanguage;
    }

    public string GetValue(string psKey)
    {
      foreach (TranslationItem ltItem in mtiItems)
      {
        if (ltItem.Key == psKey)
          return ltItem.Value;
      }
      mtiItems.Add(new TranslationItem(psKey, "[TRANSLATION MISSING]"));
      mbChanged = true;
      return "[TRANSLATION MISSING]";
    }

    public void TranslateForm(ref Form pfForm)
    {
      //Translate form-text
      if (pfForm.Tag != null && !string.IsNullOrEmpty(pfForm.Tag.ToString()))
        pfForm.Text = GetValue(pfForm.Tag.ToString());

      //Translate Controls
      for (int liCount = 0; liCount < pfForm.Controls.Count; liCount++)
      {
        if (pfForm.Controls[liCount].Tag != null && pfForm.Controls[liCount].Tag.ToString() != string.Empty)
          pfForm.Controls[liCount].Text = GetValue(pfForm.Controls[liCount].Tag.ToString());

        //Translate MenuStripItems
        if (pfForm.Controls[liCount] is MenuStrip)
          foreach (ToolStripMenuItem ltsmiCur in ((MenuStrip)pfForm.Controls[liCount]).Items)
            TranslateToolStripItem(ltsmiCur);
      }
    }

    private void TranslateToolStripItem(ToolStripMenuItem ptsmiItem)
    {
      if(ptsmiItem.Tag != null && !string.IsNullOrEmpty(ptsmiItem.Tag.ToString()))
        ptsmiItem.Text = GetValue(ptsmiItem.Tag.ToString());

      if (ptsmiItem.HasDropDownItems)
        foreach (ToolStripItem ltsiCur in ptsmiItem.DropDownItems)
          if (ltsiCur is ToolStripMenuItem)
            TranslateToolStripItem((ToolStripMenuItem)ltsiCur);
    }

    #endregion

    #region Static methods

    public static bool Save(Translation ptTranslation, string psFilePath)
    {
      FileStream lfsStream = new FileStream(psFilePath, FileMode.Create, FileAccess.Write);
      StreamWriter lswWriter = new StreamWriter(lfsStream, Encoding.Unicode);
      XmlSerializer lxsSerializer;

      try
      {

        lxsSerializer = new XmlSerializer(typeof(Translation));
        lxsSerializer.Serialize(lswWriter, ptTranslation);
        lswWriter.Close();
        lswWriter.Dispose();
        lfsStream.Dispose();

        return true;
      }
      catch
      {
        if (lfsStream != null && lfsStream.CanWrite)
        {
          lfsStream.Close();
          lfsStream.Dispose();
        }
        return false;
      }
    }

    public static bool Load(string psFilePath, out Translation ptTranslation)
    {

      if (!File.Exists(psFilePath))
      {
        ptTranslation = null;
        return false;
      }

      FileStream lfsStream = new FileStream(psFilePath, FileMode.Open, FileAccess.Read);
      StreamReader lsrReader = new StreamReader(lfsStream, Encoding.Unicode);
      XmlSerializer lxsSerializer;

      try
      {
        lxsSerializer = new XmlSerializer(typeof(Translation));
        ptTranslation = (Translation)lxsSerializer.Deserialize(lsrReader);
        lsrReader.Close();
        lsrReader.Dispose();
        lfsStream.Dispose();

        return true;
      }
      catch (Exception e)
      {
        ptTranslation = null;
        return false;
      }
    }

    #endregion

  }

  public class TranslationItem
  {

    #region member variables

    private string msKey;
    private string msValue;

    #endregion

    #region Accessors

    public string Key
    {
      get { return msKey; }
      set { msKey = value; }
    }

    public string Value
    {
      get { return msValue; }
      set { msValue = value; }
    }

    #endregion

    #region ctors

    /// <summary>
    /// Only for the xml-serializer
    /// </summary>
    public TranslationItem()
    { }

    public TranslationItem(string psKey, string psValue)
    {
      msKey = psKey;
      msValue = psValue;
    }

    #endregion

  }
}
