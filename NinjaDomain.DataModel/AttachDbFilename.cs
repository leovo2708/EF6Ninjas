﻿using System;
using System.IO;

namespace NinjaDomain.DataModel
{
    internal static class AttachDbFilename
    {
        internal static void SetDataDirectory()
        {
            // Set the |DataDirectory| path used in connection strings to point to the correct directory for console app and migrations
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var relative = @"..\App_Data";

            if (string.IsNullOrEmpty(AppDomain.CurrentDomain.RelativeSearchPath))
                relative = @"..\..\..\App_Data";

            var absolute = Path.GetFullPath(Path.Combine(baseDirectory, relative));
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        }
    }
}
