using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NewsApp
    {
        public NewsList NewsList { get; set; } = new NewsList();

        string[] choices =
        {
            "Add a Message Post",
            "Add a Photo Post",
            "Display All Post",
            "Quit"
        };

        public void Run()
        {
            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1: AddMessage();break;
                case 2: AddPhoto(); break;
                case 4: break;
            }
        }

        private void AddPhoto()
        {
            throw new NotImplementedException();
        }

        private void AddMessage()
        {
            Console.Write(" Please enter your name > ");
            string name = Console.ReadLine();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            NewsList.AddPost(post);
        }
    }
}
