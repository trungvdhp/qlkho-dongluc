﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLK_DongLuc.Helper
{
    public static class SpinEditHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="spinEdit"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="mask"></param>
        public static void ConfigSpinEdit(DevExpress.XtraEditors.SpinEdit spinEdit, int min, int max, string mask)
        {
            spinEdit.Properties.EditMask = mask;
            spinEdit.Properties.MinValue = min;
            spinEdit.Properties.MaxValue = max;
            spinEdit.EditValue = min;
        }
    }
}
