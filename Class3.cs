using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Chapter
    {
        private string chapterName;
        private int pageNumber;
        public Chapter(string ChapterName, int PageNumber)
        {
            chapterName = ChapterName;
            pageNumber = PageNumber;
        }

        public string ChapterName
        {
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("Ошибка! Название главы не может быть пустой строкой");
                }
                chapterName = value;
            }
            get => chapterName;
        }
        public int PageNumber
        {

            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка! Номер страницы не может быть отрицательным");
                }
                pageNumber = value;
            }
            get => pageNumber;
        }

        public override string ToString()
        {
            string outputString = ChapterName + ": " + pageNumber.ToString() + " страниц";
            return outputString;
        }
        public void ShowChapterInfo()//вывод информации о главе
        {
            string outputString = ChapterName + ": " + pageNumber.ToString() + " страниц";
            Console.WriteLine(outputString);
        }
    }

}
