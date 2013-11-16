using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    class Node
    {
        public string Name { get; set; }
        public int Level { set; get; }
        public List<Node> Children { set; get; }


        public Node()
        {
            
        }
    }
}
