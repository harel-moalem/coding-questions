namespace Solutions
{
    public static class GenerateTrees
    {
        public static void Test()
        {
            Console.WriteLine(generateTrees(5));
        }

        private class TreeNode
        {
            public int val { get; set; }
            public TreeNode? left { get; set; }
            public TreeNode? right { get; set; }

            public TreeNode(int v)
            {
                this.val = v;
            }

            public bool contains(int a)
            {
                if (this.val == a)
                {
                    return true;
                }
                bool right = this.right is not null && this.right.contains(a);
                bool left = this.left is not null && this.left.contains(a);
                return right || left;
            }
        }

        private static TreeNode[] generateTrees(int a)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            for (int i = 1; i <= a; i++)
            {
                nodes.Add(generateTree(new TreeNode(i), a, new List<int>() { i }));
            }
            return nodes.ToArray();
        }

        private static TreeNode generateTree(TreeNode self, int a, List<int> used)
        {
            for (int i = self.val + 1; i <= a; i++)
            {
                if (!used.Contains(i))
                {
                    used.Add(i);
                    self.left = generateTree(new TreeNode(i), a, used);
                }
            }
            for (int i = 1; i < self.val; i++)
            {
                if (!used.Contains(i))
                {
                    used.Add(i);
                    self.right = generateTree(new TreeNode(i), a, used);
                }
            }
            return self;
        }
    }
}
