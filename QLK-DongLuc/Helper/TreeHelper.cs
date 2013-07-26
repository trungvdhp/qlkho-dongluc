using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace QLK_DongLuc.Helper
{
    public static class TreeHelper
    {
        public static List<T> GetVisibleNodesData<T>(TreeList tree)
        {
            List<T> list = new List<T>();

            foreach (TreeListNode node in tree.Nodes)
            {
                if (node.Visible)
                {
                    list.Add((T)tree.GetDataRecordByNode(node));
                }
            }

            return list;
        }
    }
}
