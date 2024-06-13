using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQueryOperators
{
    public class FilterOperator
    {
        string[] words = ["the", "quick", "brown", "fox", "jumps"];
        public void FilterUsingQuerySyntax()
        {
            IEnumerable<string> filterQuerySyntax = from word in words
                                                    where word.Length == 3
                                                    select word;

            Console.WriteLine("Filter Operator using Query Syntax:\n");

            foreach (string str in filterQuerySyntax)
            {
                Console.WriteLine(str);
            }
        }
        public void FilterUsingMethdSyntax()
        {
            Console.WriteLine("\nFilter Operator using Method Syntax:\n");
            IEnumerable<string> filterMethodSyntaxQuery = words.Where(word => word.Length == 3);
            foreach (string str in filterMethodSyntaxQuery)
            {
                Console.WriteLine(str);
            }

        }
    }
}
