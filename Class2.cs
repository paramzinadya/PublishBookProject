using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
        public class Book
        {
            private string author, title, publisher, type, isbn;
            private int year;


            private Dictionary<string, Chapter> chapterList;
           
            private bool isBookPublished;

            private void Check(string Author, string Title, string Publisher, int Year, string Type, string Isbn) // проверка на корректность
            {
                author = (Author.Replace(" ", "").All(Char.IsLetter)) ? Author : throw new Exception("В имени автора не могут содержаться цифры и символы");
                title = (Title.Replace(" ", "").All(Char.IsLetter)) ? Title : throw new Exception("В названии книги не могут содержаться цифры и символы");
                publisher = (Publisher.Replace(" ", "").All(Char.IsLetter)) ? Publisher : throw new Exception("В названии издательства не могут содержаться цифры и символы");
                year = (Year >= 0 && Year <= 2023) ? Year : throw new Exception("Год не может быть отрицательным и больше 2023");
                type = (Type.Replace(" ", "").All(Char.IsLetter)) ? Type : throw new Exception("В типе обложки не могут содержаться цифры и символы");
                isbn = (Isbn.All(char.IsDigit)) ? Isbn : throw new Exception("ISBN не может содержать буквы");
            }


            public Book()
            {
                Check("Unknown", "Unknown", "Unknown", 0, "Unknown", "0");
                chapterList = new Dictionary<string, Chapter>();
                isBookPublished = false;

            }
            public void printBook()
            {
                Console.WriteLine("\nИнформация о книге:\n");
                if (author != "Unknown")
                {
                    Console.WriteLine("Автор: {0} ", author);
                }
                else
                {
                    Console.WriteLine("Автор: - ");
                }

                if (title != "Unknown")
                {
                    Console.WriteLine("Название книги: {0}", title);
                }
                else
                {
                    Console.WriteLine("Название  книги: - ");
                }

                if (publisher != "Unknown")
                {
                    Console.WriteLine("Издательство: {0}", publisher);
                }
                else
                {
                    Console.WriteLine("Издательство: - ");
                }

                if (year > 0)
                {
                    Console.WriteLine("Год издания: {0}", year);
                }
                else
                {
                    Console.WriteLine("Год издания: - ");
                }
                if (type != "Unknown")
                {
                    Console.WriteLine("Тип обложки: {0}", type);
                }
                else
                {
                    Console.WriteLine("Тип обложки: - ");
                }

                if (isbn != "0")
                {
                    Console.WriteLine("ISBN: {0}", isbn);
                }
                else
                {
                    Console.WriteLine("ISBN: - ");
                }
                Console.WriteLine("\nСодержание:\n");
                var cnt = chapterList.Count;
                if (cnt == 0) Console.WriteLine("Книга пуста, глав нет");
                else
                {
                    foreach (KeyValuePair<string, Chapter> elem in chapterList)
                    {
                        Console.WriteLine("{0}", elem.Value);
                    }
                }
                Console.WriteLine("\n");
            }


            public Book(string Author = "Unknown", string Title = "Unknown", string Publisher = "Unknown",
                int Year = 0, string Type = "Unknown", string Isbn = "0", Dictionary<string, Chapter> ChapterList = null, bool IsBookPublished = false)
            {
                Check(Author, Title, Publisher, Year, Type, Isbn);
                chapterList = ChapterList ?? new Dictionary<string, Chapter>();
                isBookPublished = IsBookPublished;
            }
            public Book(string Author = "Unknown", string Title = "Unknown", string Type = "Unknown", Dictionary<string, Chapter> ChapterList = null)
            {
                Check(Author, Title, "Unknown", 0, Type, "0");
                chapterList = ChapterList ?? new Dictionary<string, Chapter>();
            }
            public string Author
            {
                set
                {
                    if (value == String.Empty)
                    {
                        throw new Exception("Ошибка! Имя автора не должно быть пустой строкой");
                    }
                    if (isBookPublished)
                    {
                        throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                    }
                    author = value;
                }
                get => author;
            }

            public string Title
            {
                set
                {
                    if (value == String.Empty)
                    {
                        throw new Exception("Ошибка! Название книги не должно быть пустой строкой");
                    }
                    if (isBookPublished)
                    {
                        throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                    }
                    title = value;

                }
                get => title;
            }

            public string Publisher
            {
                set
                {
                    if (value == String.Empty)
                    {
                        throw new Exception("Ошибка! Название издательства не должно быть пустой строкой");
                    }

                    if (isBookPublished)
                    {
                        throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                    }
                    publisher = value;
                }
                get => publisher;
            }
            public int Year
            {
                set
                {
                    if (value < 0 && value > System.DateTime.Now.Year)
                    {
                        throw new Exception("Ошибка! Год не может быть меньше нуля и превышать 2023");
                    }
                    if (isBookPublished)
                    {
                        throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                    }
                    year = value;
                }
                get => year;
            }

            public string Type
            {
                get => type;
                set => type = value;
            }

            public string Isbn
            {
                set
                {
                    if (value == String.Empty && value.All(char.IsDigit))
                    {
                        throw new Exception("Ошибка! ISBN может содержать только цифры и не должно быть пустой строкой");
                    }
                    if (isBookPublished)
                    {
                        throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                    }
                    isbn = value;
                }
                get => isbn;
            }

            public void AddChapter(Chapter chapter) //добавление главы
            {
                if (chapterList.ContainsKey(chapter.ChapterName))
                {
                    throw new Exception("Ошибка! Глава с таким именем уже существует.");
                }
                if (isBookPublished)
                {
                    throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                }
                else chapterList[chapter.ChapterName] = chapter;
            }
            public bool RemoveChapter(Chapter chapter) //удаление главы
            {
                return chapterList.Remove(chapter.ChapterName);
            }

            public bool RemoveChapter(string chapterName) //удаление главы
            {
                return chapterList.Remove(chapterName);
            }

            public Dictionary<string, Chapter> GetChapterList() // получение списка глав
            {
                return this.chapterList;
            }

            public void ChangeChapterName(string oldName, string newName)//изменение названия главы
            {
                if (isBookPublished)
                {
                    throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                }
                if (chapterList.ContainsKey(oldName))
                {
                    var chapter = chapterList[oldName];
                    chapter.ChapterName = newName;
                    AddChapter(chapter);
                    RemoveChapter(oldName);
                }
                else throw new Exception("Глава с таким названием не найдена");
            }

            public void ChangeChapterPageNumber(string ChapterName, int newPageNumber) //изменение количества страниц в главе
            {
                if (newPageNumber <= 0) { throw new Exception("Ошибка! Количество страниц не может быть отрицательным или равным нулю"); }
                else
                {
                    if (isBookPublished)
                    {
                        throw new Exception("Ошибка! Книга уже издана, нельзя менять ее характеристики");
                    }
                    if (chapterList.ContainsKey(ChapterName))
                    {
                        chapterList[ChapterName].PageNumber = newPageNumber;
                    }
                    else throw new Exception("Глава с таким названием не найдена");
                }
            }

            public void ChapterInfo(string ChapterName) // информация о главе
            {
                if (chapterList.ContainsKey(ChapterName))
                {
                    chapterList[ChapterName].ShowChapterInfo();
                }
                else throw new Exception("Глава с таким названием не найдена");
            }

            public bool PublishBook(string Publisher, int Year, string Isbn)// публикация книги
            {
                if (isBookPublished) throw new Exception("Ошибка! Книга уже издана.");
                if (!IsBookNotEmpty())
                {
                    throw new Exception("Ошибка! Нельзя издать книгу без глав");
                }
                else if (!IsChapterFilled())
                {
                    throw new Exception("Ошибка! Не все главы заполнены");
                }
                else
                {
                    isBookPublished = true;
                    publisher = Publisher;
                    year = Year;
                    isbn = Isbn;
                }
            return isBookPublished;
            }
            public bool IsChapterFilled() //проверка на пустые главы
            {
                foreach (var chapter in chapterList.Values)
                {
                    if (chapter.PageNumber == 0) return false;
                }
                return true;
            }

            public bool IsBookNotEmpty()//проверка на пустую книгу
            {
                return chapterList.Count > 0;
            }
            public int MiddleCountPageInChapter()
            {
                int summPage = 0;
                if (chapterList.Count == 0) { return 0; }
                else
                {
                    foreach (var chapter in chapterList.Values)
                    {
                        summPage += chapter.PageNumber;
                    }
                    return summPage / chapterList.Count;
                }
            }
            public override string ToString()
            {
                string chapterinf = "\nГлавы: \n";
                foreach (KeyValuePair<string, Chapter> elem in chapterList)
                {
                    chapterinf += "   -   ";
                    chapterinf += elem.Value.ToString();
                    chapterinf += "\n";
                }
                string outputString = "Название книги: " + Title + "\nАвтор: "+Author+"\nИздательство: "+Publisher+"\nГод издания: "+Year.ToString()+"\nТип обложки: "+Type;
                return outputString + chapterinf;
            }

    }
}
