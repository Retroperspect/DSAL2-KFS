using System;
using System.Collections.Generic;
using System.Text;

namespace DSAL2_KFS
{
    class DecisionTree
    {
        TreeNode tree;

        public string StudentActivity(bool Attend_lectures,bool Read_textbook, bool Make_exercises, bool Hand_ins_made_in_time)
        {
            MakeTree();
            tree = NavigateTree(tree, Attend_lectures);
            tree = NavigateTree(tree, Read_textbook);
            tree = NavigateTree(tree, Make_exercises);
            tree = NavigateTree(tree, Hand_ins_made_in_time);
            return tree.answer;
        }

        public TreeNode NavigateTree(TreeNode treeNode, bool statement)
        {
            if (statement)
            {
                return treeNode.left;
            }
            return treeNode.right;
        }

        public void MakeSmartTree(TreeNode treeNode)
        {
            if (treeNode.question == "Attend lectures")
            {

            }
        }

        public void MakeTree()
        {
            tree = new TreeNode();
            tree.question = "Attend lectures";

            tree.left = new TreeNode();
            tree.right = new TreeNode();
            tree.left.question = "Read textbook";
            tree.right.question = "Read textbook";

            tree.left.left = new TreeNode();
            tree.left.right = new TreeNode();
            tree.left.left.question = "Make exercises";
            tree.left.right.question = "Make exercises";

            tree.right.left = new TreeNode();
            tree.right.right = new TreeNode();
            tree.right.left.question = "Make exercises";
            tree.right.right.question = "Make exercises";

            tree.left.left.left = new TreeNode();
            tree.left.left.right = new TreeNode();
            tree.left.right.left = new TreeNode();
            tree.left.right.right = new TreeNode();
            tree.left.left.left.question = "Hand ins made in time";
            tree.left.left.right.question = "Hand ins made in time";
            tree.left.right.left.question = "Hand ins made in time";
            tree.left.right.right.question = "Hand ins made in time";

            tree.right.left.left = new TreeNode();
            tree.right.left.right = new TreeNode();
            tree.right.right.left = new TreeNode();
            tree.right.right.right = new TreeNode();
            tree.right.left.left.question = "Hand ins made in time";
            tree.right.left.right.question = "Hand ins made in time";
            tree.right.right.left.question = "Hand ins made in time";
            tree.right.right.right.question = "Hand ins made in time";

            tree.left.left.left.left = new TreeNode();
            tree.left.left.left.right = new TreeNode();
            tree.left.left.right.left = new TreeNode();
            tree.left.left.right.right = new TreeNode();
            tree.left.left.left.left.answer = "You should be able to pass the exam";
            tree.left.left.left.right.answer = "You could easily fail the exam";
            tree.left.left.right.left.answer = "You should be able to pass the exam";
            tree.left.left.right.right.answer = "You could easily fail the exam";

            tree.left.right.left.left = new TreeNode();
            tree.left.right.left.right = new TreeNode();
            tree.left.right.right.left = new TreeNode();
            tree.left.right.right.right = new TreeNode();
            tree.left.right.left.left.answer = "You should be able to pass the exam";
            tree.left.right.left.right.answer = "You could easily fail the exam";
            tree.left.right.right.left.answer = "You should be able to pass the exam";
            tree.left.right.right.right.answer = "You could easily fail the exam";

            tree.right.left.left.left = new TreeNode();
            tree.right.left.left.right = new TreeNode();
            tree.right.left.right.left = new TreeNode();
            tree.right.left.right.right = new TreeNode();
            tree.right.left.left.left.answer = "You should be able to pass the exam";
            tree.right.left.left.right.answer = "You could easily fail the exam";
            tree.right.left.right.left.answer = "You could easily fail the exam";
            tree.right.left.right.right.answer = "You could easily fail the exam";

            tree.right.right.left.left = new TreeNode();
            tree.right.right.left.right = new TreeNode();
            tree.right.right.right.left = new TreeNode();
            tree.right.right.right.right = new TreeNode();
            tree.right.right.left.left.answer = "You could easily fail the exam";
            tree.right.right.left.right.answer = "You could easily fail the exam";
            tree.right.right.right.left.answer = "You could easily fail the exam";
            tree.right.right.right.right.answer = "You could easily fail the exam";
        }
    }
}