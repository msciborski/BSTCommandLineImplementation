using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST {
    class Program {
        static void Main(string[] args) {
            BSTree tree = new BSTree();
            tree.Insert(3);
            tree.Insert(45);
            tree.Insert(40);
            tree.Insert(32);
            tree.Insert(2);
            tree.Insert(12);
            tree.Insert(22);
            tree.Insert(111);

            if (tree.Find(2)){
                Console.WriteLine("Dziala, znalzlo.");
            }
            else{
                Console.WriteLine("Nie znalazlo.");
            }
            Console.WriteLine(tree.MinValue());
            Console.WriteLine(tree.MaxValue());
        }
    }
}
