using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST {
    public class BSTree {
        public BSTNode Root { get; set; }

        #region Constructors
        public BSTree(int value) {
            if (Root == null) {
                Root = new BSTNode(value);
            }
        }

        public BSTree() {

        }
        #endregion


        /// <summary>
        /// Method- add element to the binary tree, if root == null, create root, else look at the nodes and try to add node
        /// </summary>
        /// <param name="value"></param>
        /// 

        public void Insert(int value){
            if (Root == null){
                Root = new BSTNode(value);
            }
            else{
                Insert(Root,value);
            }
        }

        /// <summary>
        /// Overloaded method. Adding value to the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// 

        private void Insert(BSTNode root, int value){
            if (root != null){
                if (value == root.Value) {
                    return;
                }
                if (root.Value > value) {
                    if (root.LeftNode == null) {
                        root.LeftNode = new BSTNode(value);
                    } else {
                        Insert(root.LeftNode, value);
                    }
                } else {
                    if (root.RightNode == null) {
                        root.RightNode = new BSTNode(value);
                    } else {
                        Insert(root.RightNode, value);
                    }
                }
            }

        }

        public bool Find(int value){
            if (Root != null){
                if (Root.Value == value){
                    return true;
                }
                else{
                   return Find(Root, value);
                }
            }
            else{
                return false;
            }
        }

        private bool Find(BSTNode root, int value){
            if (root != null){
                if (root.Value.CompareTo(value) == 0){
                    return true;
                }
                else{
                    if (root.Value > value){
                        if (root.LeftNode != null){
                            return Find(root.LeftNode, value);
                        }
                    }
                    return Find(root.RightNode, value);
                }

            }
            else{
                return false;
            }
        }


    }
}
