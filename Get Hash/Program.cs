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
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Nepochal.GetHash
{
  static class Program
  {
    #region Global Information

    public static readonly string msVersion = "2.0.3";

    public static Configuration mcConfiguration;

    #endregion

    #region Static Members
    public static bool mbRunning = true;
    #endregion

    [STAThread]
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      if (!LoadConfiguration())
      {
        MessageBox.Show(string.Format("Bitte beachten Sie:{0}Wir garantieren nicht, dass jeder Hashwert korrekt berechnet wird.{0}{0}Wenn Sie Fehler finden, würden wir uns über eine E-mail an nepochal@mischolz.de oder über einen Patch für unser Git-Repository freuen.", Environment.NewLine), "Hinweis");
        mcConfiguration = new Configuration();
      }

      if (args.Length == 1 && File.Exists(args[0]))
        if (Path.GetExtension(args[0]).ToLower() != ".ghf")
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
      SaveConfiguration();
    }

    #region Methods

    private static void SaveConfiguration()
    {
      string lsPath = Path.Combine(Application.StartupPath, "config.ini");
      FileStream lfsStream = new FileStream(lsPath, FileMode.Create, FileAccess.Write, FileShare.None);
      StreamWriter lswWriter = new StreamWriter(lfsStream, Encoding.UTF8);
      XmlSerializer lxSerializer = new XmlSerializer(typeof(Configuration));

      lxSerializer.Serialize(lswWriter, mcConfiguration);

      lswWriter.Close();
      lswWriter.Dispose();
      lfsStream.Dispose();
    }

    private static bool LoadConfiguration()
    {
      try
      {
        string lsPath = Path.Combine(Application.StartupPath, "config.ini");
        if(!File.Exists(lsPath))
          return false;
        FileStream lfsStream = new FileStream(lsPath, FileMode.Open, FileAccess.Read, FileShare.None);
        StreamReader lssReader = new StreamReader(lfsStream, Encoding.UTF8);
        XmlSerializer lxSerializer = new XmlSerializer(typeof(Configuration));

        mcConfiguration = (Configuration)lxSerializer.Deserialize(lssReader);

        lssReader.Close();
        lssReader.Dispose();
        lfsStream.Dispose();
        return true;
      }
      catch
      {
        return false;
      }
    }

    #endregion

  }
}
