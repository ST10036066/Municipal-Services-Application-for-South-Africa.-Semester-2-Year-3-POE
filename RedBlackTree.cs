using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application_for_South_Africa
{
    public class RedBlackTree
    {
        private RedBlackNode root;

        public void Insert(int key, ServiceRequest value)
        {
            var newNode = new RedBlackNode(key, value);
            InsertNode(root, newNode);
            FixTreeAfterInsert(newNode);
        }

        public ServiceRequest Search(int key)
        {
            var node = SearchNode(root, key);
            return node?.Value;
        }

        private void InsertNode(RedBlackNode current, RedBlackNode newNode)
        {
            // Standard BST insertion
            if (root == null)
            {
                root = newNode;
                root.IsRed = false; // Root must always be black
                return;
            }

            if (newNode.Key < current.Key)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    newNode.Parent = current;
                }
                else
                {
                    InsertNode(current.Left, newNode);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                    newNode.Parent = current;
                }
                else
                {
                    InsertNode(current.Right, newNode);
                }
            }
        }

        private RedBlackNode SearchNode(RedBlackNode current, int key)
        {
            if (current == null || current.Key == key) return current;
            if (key < current.Key) return SearchNode(current.Left, key);
            return SearchNode(current.Right, key);
        }

        private void FixTreeAfterInsert(RedBlackNode node)
        {
            //the terms grandparent and uncle are used to describe the relative positions of nodes during tree operations like insertion and balancing.
            // These relationships are essential for maintaining the Red - Black Tree's properties.
            // Balancing logic for Red-Black Tree
            while (node != root && node.Parent.IsRed)
            {
                var grandParent = node.Parent.Parent;
                if (node.Parent == grandParent.Left)
                {
                    var uncle = grandParent.Right;
                    if (uncle != null && uncle.IsRed)
                    {
                        // Case 1: Recoloring
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        grandParent.IsRed = true;
                        node = grandParent;
                    }
                    else
                    {
                        if (node == node.Parent.Right)
                        {
                            // Case 2: Left rotation
                            node = node.Parent;
                            RotateLeft(node);
                        }
                        // Case 3: Right rotation
                        node.Parent.IsRed = false;
                        grandParent.IsRed = true;
                        RotateRight(grandParent);
                    }
                }
                else
                {
                    var uncle = grandParent.Left;
                    if (uncle != null && uncle.IsRed)
                    {
                        // Case 1: Recoloring
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        grandParent.IsRed = true;
                        node = grandParent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            // Case 2: Right rotation
                            node = node.Parent;
                            RotateRight(node);
                        }
                        // Case 3: Left rotation
                        node.Parent.IsRed = false;
                        grandParent.IsRed = true;
                        RotateLeft(grandParent);
                    }
                }
            }
            root.IsRed = false; // Ensure root is always black
        }

        private void RotateLeft(RedBlackNode node)
        {
            var temp = node.Right;
            node.Right = temp.Left;
            if (temp.Left != null) temp.Left.Parent = node;
            temp.Parent = node.Parent;

            if (node.Parent == null) root = temp;
            else if (node == node.Parent.Left) node.Parent.Left = temp;
            else node.Parent.Right = temp;

            temp.Left = node;
            node.Parent = temp;
        }

        private void RotateRight(RedBlackNode node)
        {
            var temp = node.Left;
            node.Left = temp.Right;
            if (temp.Right != null) temp.Right.Parent = node;
            temp.Parent = node.Parent;

            if (node.Parent == null) root = temp;
            else if (node == node.Parent.Right) node.Parent.Right = temp;
            else node.Parent.Left = temp;

            temp.Right = node;
            node.Parent = temp;
        }
    }
}
