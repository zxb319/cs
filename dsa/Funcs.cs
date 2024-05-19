using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs.dsa {
    internal class Funcs {
        public static void PrintTree(string path,int depth=0) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < depth; i++) {
                sb.Append("--");
            }
            string indent = sb.ToString();
            Console.WriteLine($"{indent}{Path.GetFileName(path)}");
            if (Directory.Exists(path)){
                foreach (var fp in Directory.GetFileSystemEntries(path)) {
                    PrintTree(fp, depth + 1);
                }
            }
        }


    }
}
