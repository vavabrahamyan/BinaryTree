using System;

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
        }
    }
}
