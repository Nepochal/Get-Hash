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
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Nepochal.GetHash
{
  static class Program
  {
    #region Global Information

    public static readonly string msVersion = "2.1.1";

    public static Configuration mcConfiguration;
    public static Translation mtTranslation;

    #endregion

    #region Static Members
    public static bool mbRunning = true;
    #endregion

    [STAThread]
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      Configuration.Load(out mcConfiguration);

      if (string.IsNullOrEmpty(mcConfiguration.LanguageFile) || !File.Exists(mcConfiguration.LanguageFile) || !Translation.Load(mcConfiguration.LanguageFile, out mtTranslation))
      {
        Language lfLanguage = new Language();
        if (lfLanguage.ShowDialog() != DialogResult.OK)
          return;
        mcConfiguration.LanguageFile = lfLanguage.TranslationPath;
        mtTranslation = lfLanguage.Translation;
      }

      if (args.Length == 1 && File.Exists(args[0]))
        Application.Run(new Filemode(args[0]));

      while (mbRunning)
        switch (mcConfiguration.LastMode)
        {
          case Programmode.Text:
            Application.Run(new Textmode());
            break;
          case Programmode.File:
            Application.Run(new Filemode());
            break;
        }
      Configuration.Save(mcConfiguration);
      if (mtTranslation.Changed)
        Translation.Save(mtTranslation, mcConfiguration.LanguageFile);
    }

  }
}
