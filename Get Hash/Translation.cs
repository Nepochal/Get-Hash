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
      //Maybe there are some missing tools, because they do not inherit from control or have controls themself

      for (int liCount = 0; liCount < pfForm.Controls.Count; liCount++)
        if (pfForm.Controls[liCount].Tag != null && pfForm.Controls[liCount].Tag != string.Empty)
          pfForm.Controls[liCount].Text = GetValue(pfForm.Controls[liCount].Tag.ToString());
    }

    #endregion

    #region Static methods

    public static bool Save(Translation ptTranslation, string psFilePath)
    {
      FileStream lfsStream = new FileStream(psFilePath, FileMode.Create, FileAccess.Write);
      XmlSerializer lxsSerializer;

      try
      {

        lxsSerializer = new XmlSerializer(typeof(Translation));
        lxsSerializer.Serialize(lfsStream, ptTranslation);
        lfsStream.Close();
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
      XmlSerializer lxsSerializer;

      try
      {
        lxsSerializer = new XmlSerializer(typeof(Translation));
        ptTranslation = (Translation)lxsSerializer.Deserialize(lfsStream);
        lfsStream.Close();
        lfsStream.Dispose();

        return true;
      }
      catch
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
