﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLicenseID
{
    public class ReportAction
    {

        public static void RunNegativeID(string ActualID)
        {

            string ActualCodeID = "Actual ID number is: " + ActualID;
            Ranorex.Report.Error("STOP THE VERSION: ", ActualID);

        }
    }


    public class UtilityLicense
    {

        public static string SentinelIDCode; // HERE WE DECLARE THIS STRING WHICH NAME IS SentinelIDCode

        public static void SentinelID(string License)
        {

            string checkLicenseID = License;

            int ipos = License.ToLower().IndexOf("unprotected");

            if (ipos >= 0)
            {
                ReportAction.RunNegativeID(checkLicenseID);

            }

            else
                return;

        }
    }
}
