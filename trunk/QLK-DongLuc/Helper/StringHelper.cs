using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLK_DongLuc.Helper
{
    public static class StringHelper
    {
        public static string GetLastString(string path)
        {
            return path.Split('.').Last();
        }
    }
}
