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

using System.Drawing;

namespace Nepochal.GetHash
{
  public class Configuration
  {

    #region Member Variables

    private Programmode mpLastMode = Programmode.File;
    private Hashtype mhtLastHashtype = Hashtype.CRC32B;

    private Point mpFilePosition = new Point(20, 20);
    private Point mpFileSize = new Point(302, 172);

    private Point mpTextPosition = new Point(20, 20);
    private Point mpTextSize = new Point(428, 264);

    #endregion

    #region Accessors

    public Programmode LastMode
    {
      get { return mpLastMode; }
      set { mpLastMode = value; }
    }

    public Hashtype LastHashType
    {
      get { return mhtLastHashtype; }
      set { mhtLastHashtype = value; }
    }


    public Point FilePosition
    {
      get { return mpFilePosition; }
      set { mpFilePosition = value; }
    }

    public Point FileSize
    {
      get { return mpFileSize; }
      set { mpFileSize = value; }
    }


    public Point TextPosition
    {
      get { return mpTextPosition; }
      set { mpTextPosition = value; }
    }

    public Point TextSize
    {
      get { return mpTextSize; }
      set { mpTextSize = value; }
    }

    #endregion

  }
}
