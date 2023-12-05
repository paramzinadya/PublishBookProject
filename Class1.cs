//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace WindowsFormsApp2
//{
//    internal class Class1
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
                

//                Book book = new Book("Александр Сергеевич Пушкин", "Золотая рыбка", "Азбука", 2023, "Мягкая обложка", "89628636");
//                book.printBook();

//                Book mybook = new Book();
//                mybook.printBook();

//                mybook.Author = "Лев Николаевич Толстой";
//                mybook.Title = "Война и мир";
//                mybook.Type = "Твердая обложка";
//                mybook.Isbn = "0";
//                mybook.printBook();

//                mybook.AddChapter(new Chapter("Глава 1", 100));//добавление глав
//                mybook.AddChapter(new Chapter("Глава 2", 245));
//                mybook.ChangeChapterPageNumber("Глава 2", 65);//изменение количества страниц 
//                mybook.AddChapter(new Chapter("Пустая глава", 0));
//                if (mybook.IsChapterFilled()) Console.WriteLine("В книге все главы заполнены");//проверка глав на пустоту
//                else Console.WriteLine("В книге есть пустые главы");
//                mybook.RemoveChapter("Пустая глава");
//                if (mybook.IsChapterFilled()) Console.WriteLine("В книге все главы заполнены");//проверка глав на пустоту
//                else Console.WriteLine("В книге есть пустые главы");
//                mybook.PublishBook("Советская Сибирь", 2023, "555555555"); // публикация книги
//                mybook.printBook();
//                Console.WriteLine("Среднее количество страниц в главе: {0}", mybook.MiddleCountPageInChapter());


//                mybook.AddChapter(new Chapter("Глава 3", 300));// изменение опубликованной книги
//                mybook.Author = "Гоголь";
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }

//}
