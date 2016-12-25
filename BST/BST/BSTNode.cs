using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST {
    public class BSTNode {
        public int Value { get; set; }
        public BSTNode LeftNode { get; set; }
        public BSTNode RightNode { get; set; }

        public BSTNode(int value){
            Value = value;
            LeftNode = null;
            RightNode = null;
        }

        public void Insert(BSTNode root, int value){
            if (root != null){
                if (root.Value != value){
                    if (root.Value > value){
                        if (root.LeftNode != null){
                            Insert(root.LeftNode, value);
                        }
                        else{
                            root.LeftNode = new BSTNode(value);
                        }
                    }
                    else{
                        if (root.RightNode != null){
                            Insert(root.RightNode,value);
                        }
                    }
                }
            }
        }
    }
}
