using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace BinaryTree
{
    class Tree   
    {
        public Tree(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }
        public void Add(int value)
        {
            if(value < this.Value)
            {
                if(Left == null)
                {
                    Left = new Tree(value);
                }
                else
                {
                    Left.Add(value);
                }
            }
            if(value >= this.Value)
            {
                if(Right == null)
                {
                    Right = new Tree(value);
                }
                else
                {
                    Right.Add(value);
                }
            }
        }
        public int GetMin()
        {
            var result = this;
            while(result.Left != null)
            {
                result = result.Left;
            }
            return result.Value;
        }
        public int GetMax()
        {
            var result = this;
            while(result.Right != null)
            {
                result = result.Right;
            }
            return result.Value;
        }
        public void Print()
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 5, 9, 8, 6 };
            Tree tree = new Tree(7);
            for (int i = 0; i < arr.Length; i++)
            {
                tree.Add(arr[i]);
            }
            Console.WriteLine(tree.GetMin());
            Console.WriteLine(tree.GetMax());
        }
    }

}
