using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Involys.Pocos;
using System.Drawing;

namespace Involys.Utility
{
    public static class ConditionsUtility
    {
        public static List<TreeNode> GenerateNodesFromList(List<Condition> all)
        {
            var result = new List<TreeNode>();
            var level1 = all.Where(o => o.Niveau == 1).ToList();
            foreach (var racine in level1)
            {
                TreeNode noderacine = new TreeNode {Name=racine.Ref_Util.ToString(),Text=racine.Libelle,Tag=racine};
                noderacine.ForeColor = Color.Red;
                var children2 = all.Where(o => o.Code_Pere == racine.Ref_Util).ToList();
                foreach (var lv2 in children2)
                {
                    if (lv2.Type=="Table")
                    {
                        TreeNode nodeLevel2 = new TreeNode { Name = lv2.Ref_Util.ToString(), Text = lv2.Libelle, Tag = lv2 };
                        noderacine.Nodes.Add(nodeLevel2);
                    }
                    else//racine
                    {
                        var children3 = all.Where(o=> o.Code_Pere==lv2.Ref_Util).ToList();
                        TreeNode nodeLevel2 = new TreeNode { Name = lv2.Ref_Util.ToString(), Text = lv2.Libelle, Tag = lv2 };
                        nodeLevel2.ForeColor = Color.Red;
                        foreach (var lv3 in children3)
                        {
                            TreeNode nodeLevel3 = new TreeNode { Name = lv3.Ref_Util.ToString(), Text = lv3.Libelle, Tag = lv3 };
                            nodeLevel2.Nodes.Add(nodeLevel3);
                        }
                        noderacine.Nodes.Add(nodeLevel2);
                    }
                }
                if (noderacine.Nodes.Count > 0)
                    result.Add(noderacine);
            }
            return result;
        }
    }
}
