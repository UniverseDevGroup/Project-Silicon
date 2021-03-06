﻿/************************************************************************
 *  
 *  PortEngine
 *  Copyright (C) 2018 UniverseDG
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 * 
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortEngine.QuantumAPI.Sites;

namespace PortEngine
{
    public class QuantumnetAPI
    {

        public static void loadSite(UserControl site, Panel pnlSiteArea)
        {
           /* if (pnlSiteArea == null)
            {
                pnlSiteArea.Controls.Add(site);

            }
            else
            {*/
                pnlSiteArea.Controls.Clear();
                pnlSiteArea.Controls.Add(site);
            //}
        }

        public static void navigateToSite(TextBox txtNavigateToThis, Panel pnlLoadSiteHere)
        {
            switch (txtNavigateToThis.Text)
            {
                case "qt.quantumconnections/home":
                    loadSite(new QuantumAPI.Sites.QuantumISP(), pnlLoadSiteHere);
                    break;
                case "qt.malwarebits/home":
                    loadSite(new Malwarebits(), pnlLoadSiteHere);
                    break;
                case "qt.portosdefender/home":
                    loadSite(new QuantumAPI.Sites.SiliconOSDefender(), pnlLoadSiteHere);
                    break;
                default:
                    loadSite(new QuantumAPI.Sites._404Error(), pnlLoadSiteHere);
                    break;
            }

        }
    }
}
