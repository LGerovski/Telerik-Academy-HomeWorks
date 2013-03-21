using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace e_library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddBooks());
            Library TelerikLibrary = new Library();
            //string line;
            //using (StreamReader readAuthors = new StreamReader("../../Authors.txt"))
            //{
            //    line = readAuthors.ReadLine();
            //    while (line != null)
            //    {
            //        string[] author = line.Split();
            //        Library.authorsList.Add(new Author(author[0], author[1]));
            //    }
               
            //}

            

            User me = new Administrator("Nikolai", "Aleksiev", "nlaleksiev@gmail.com", "123");
            User newAdmin = new Administrator("Georgi", "Petrov", "georgi@gmail.com", "123");
            User newClient = new Client("Peter", "Georgiev", "me@abv.bg", "123");
            Library.clientsList.Add(newAdmin);
            Library.clientsList.Add(me);
            Library.clientsList.Add(newClient);


            Author stephenKing = new Author("Stephen", "King");
            Author newAuthor = new Author("Thomas", "Grey");
            Library.authorsList.Add(stephenKing);
            Library.authorsList.Add(newAuthor);

            Library.booksList.Add(new Book("The stand", stephenKing, Language.English, new BookSection(Section.SciFi)));


            Application.Run(new LoginMenu());
            


        }
    }
}
