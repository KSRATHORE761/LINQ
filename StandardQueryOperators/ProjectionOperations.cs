using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQueryOperators
{
    public class ProjectionOperations
    {
        

        //Select Method:
        public void ExecuteSelectUsingQuerySyntax()
        {
            List<string> words = ["an", "apple", "a", "day"];
            var phrasesQuerySyntax = from word in words
                                                     select word.Substring(0, 1);
            foreach(string s in phrasesQuerySyntax)
            {
                Console.WriteLine(s);
            }
        }
        public void ExecuteSelectUsingMethodSyntax()
        {
            List<string> words = ["an", "apple", "a", "day"];
            var phrasesQuerySyntax = words.Select(word=>word.Substring(0, 1));  
            foreach (string s in phrasesQuerySyntax)
            {
                Console.WriteLine(s);
            }
        }
        //Select Many: 
        public void ExecuteSelectManyWithQuerySyntax()
        {
            List<string> phrases = ["an apple a day", "the quick brown fox"];
            var query = from phrase in phrases
                        from word in phrase.Split(' ')
                        select word;
            foreach(string s in query)
            {
                Console.WriteLine(s);
            }
        }
        public void ExecuteSelectManyWithMethodSyntax()
        {
            List<string> phrases = ["an apple a day", "the quick brown fox"];
            var query = phrases.SelectMany(phrase=> phrase.Split(" ")); 
            foreach(string s in query)
            {
                Console.WriteLine(s);
            }
        }

    }
}
