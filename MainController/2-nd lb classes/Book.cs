﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainController
{
    class Book
    {
        public string Name { get; set; }
        public Book(string Name)
        {
            this.Name = Name;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Book:  {Name}");
            Console.ResetColor();
        }
    }
    class Title : Book
    {
        public Title(string Name) : base(Name)
        {
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Title: {Name}");
            Console.ResetColor();
        }
    }
    class Author : Book
    {
        public Author(string Name) : base(Name)
        {
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Author: {Name}");
            Console.ResetColor();
        }
    }
    class Content : Book
    {
        public Content(string Name) : base(Name)
        {
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Content: {Name}");
            Console.ResetColor();
        }
    }
}
