using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Articles> list = new List<Articles>();

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ").ToArray();
                Articles myArticle = new Articles(tokens[0], tokens[1], tokens[2]);
                list.Add(myArticle);
            }

            string sortWord = Console.ReadLine();

            if (sortWord == "title")
            {
                List<Articles> sortedArticle = list.OrderBy(a => a.Title).ToList();
                Console.Write(string.Join("\n", sortedArticle));
            }
            else if (sortWord == "content")
            {
                List<Articles> sortedArticle = list.OrderBy(a => a.Content).ToList();
                Console.Write(string.Join("\n", sortedArticle));
            }
            else
            {
                List<Articles> sortedArticle = list.OrderBy(a => a.Author).ToList();
                Console.Write(string.Join("\n ", sortedArticle));
            }
        }
    }

    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public void Reverse()
        {
        }
    }
}
