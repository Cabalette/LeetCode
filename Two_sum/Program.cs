using System.Reflection;
using System;
using System.Xml.Linq;
using System.Collections;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Two_sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WordPattern("abba", "dog cat cat dog");
        }
        static public char WordPattern(string s, string t)
        {
            Dictionary<char, int> dict = new();
            foreach (char c in s)
            {
                if (!dict.TryAdd(c, 1))
                    dict[c]++;
            }
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c) || (dict.TryGetValue(c, out int val) && val == 0))
                    return c;
                dict[c]--;
            }
            return 's';
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
