using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Cliver.DisruptivePdf
{
    public class Settings
    {
        public static readonly DefaultSettings Default;

        public class DefaultSettings : Cliver.Settings
        {
            public string OutputFolder;
            public string InputPdf;
            public string Password;
        }
    }
}