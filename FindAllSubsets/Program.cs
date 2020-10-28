using System;
using System.Collections.Generic;

namespace FindAllSubsets
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] a = { 1, 2, 3 };
            var res = GetSubsets(a);
            foreach(var list in res)
            {
                Console.WriteLine(string.Join("," , list));
            }
            Console.ReadLine();
        }
        public static IList<IList<int>> GetSubsets(int[] a)
        {
            var res = new List<IList<int>>();
            DFS(0, a, new List<int>(), res);
            return res;
        }
        public static void DFS(int index,int[] a, IList<int> current, IList<IList<int>> res  )
        {
            res.Add(new List<int>(current));
            for(int i= index; i<a.Length;i++)
            {
                current.Add(a[i]);
                DFS(i + 1, a, current, res);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
