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
    }
}
