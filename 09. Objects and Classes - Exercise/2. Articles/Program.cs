using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articlesInput = Console.ReadLine().Split(", ").ToArray();
            Article myArticle = new Article(articlesInput[0], articlesInput[1], articlesInput[2]);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] commandTokens = Console.ReadLine().Split(": ").ToArray();

                if (commandTokens[0] == "Edit")
                {
                    myArticle.Edit(commandTokens[1]);
                }

                else if (commandTokens[0] == "ChangeAuthor")
                {
                    myArticle.ChangeAuthor(commandTokens[1]);
                }

                else if (commandTokens[0] == "Rename")
                {
                    myArticle.Rename(commandTokens[1]);
                }
            }
            Console.WriteLine(myArticle.ToString());
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Author = author;
            Content = content;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }

}
