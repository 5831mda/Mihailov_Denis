using System;

namespace IzdanieModel
{  
    class Program
    {
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.RunProgram();                
        }
      /// <summary>
      /// запуск программы
      /// </summary>
        public void RunProgram()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите: 1 - книга; 2 - журнал; 3 - диссертация.");
                    var g = Console.ReadLine();
                    var enteredValue = Convert.ToInt32(g);
                    Izdanie iz;
                    switch (enteredValue)
                    {
                        case 1:
			                iz = EnterBook();
                            break;
                        case 2:
			                iz = EnterJournal();
			                break;
                        case 3:
			                iz = EnterThesis();
                            break;
                        default : throw new Exception();         
		            }
                    Console.WriteLine(iz.Inform);
		            Console.Read(); 
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Неправильная опция, повторите");
                }
            }
        }

        private void EnterGeneralFields(Izdanie izdanie)
        {
            izdanie.Surname = WriteLetterField("фамилию");
            izdanie.Initials = WriteInitials();
            izdanie.Year = WriteNumber("год издания");
            izdanie.Page = WriteNumber("количество страниц");
            
        }

        /// <summary>
        /// Ввести книгу
        /// </summary>
        /// <returns></returns>
        private Izdanie EnterBook()
        {
            Book book = new Book();
            EnterGeneralFields(book); // Присвоение типа, может быть небезопасно, но тут точно знаем что объект вернётся наш

            book.Title = WriteLetterField("название издания");
            book.Oblast = WriteLetterField("предметную область издания");
            book.City = WriteLetterField("город");
            book.Nameiz = WriteLetterField("название издательства");

            return book;
        }
        /// <summary>
        /// Ввод буквенного поля
        /// </summary>
        /// <returns></returns>
        public string WriteLetterField(string fieldName)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите " + fieldName + ":");
                    var field = Console.ReadLine();
                    var regex = new System.Text.RegularExpressions.Regex("^[ A-ZА-Я]+$");

                    if (!regex.IsMatch(field.ToUpper()))
                    {
                        throw new Exception();
                    }
                    return field;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вводить можно только символы, повторите");
                }
            }
        }
        
        /// <summary>
        /// Ввод инициалов
        /// </summary>
        /// <returns></returns>
        private string WriteInitials()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите инициалы имени и отчества через точку: ");
                    var _name = Console.ReadLine();
                    var regex = new System.Text.RegularExpressions.Regex("^[A-ZА-Я][.][A-ZА-Я][.]$");

                    if (!regex.IsMatch(_name.ToUpper()))
                    {
                        throw new Exception();
                    }
                    return _name;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вводить можно только символы через точку, повторите");
                }
            }
        }

        private int WriteNumber(string fieldName)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите " + fieldName + ":");
                    return Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вводить можно только цифры, повторите");
                }
            }
        }

        /// <summary>
        /// Ввести журнал
        /// </summary>
        /// <returns></returns>
        private Izdanie EnterJournal()
        {       
            Journal journal = new Journal();
            EnterGeneralFields(journal);

            journal.Title = WriteLetterField("название издания");
            journal.Nameiz = WriteLetterField("название издательства");
            journal.Number = WriteNumber("номер журнала");

            return journal;
        }
        /// <summary>
        /// Ввести дессертацию
        /// </summary>
        /// <returns></returns>
        private Izdanie EnterThesis()
        {
            Thesis thesis = new Thesis();
            EnterGeneralFields(thesis);

            thesis.Patronymic = WriteLetterField("отчество");
            thesis.Position = WriteLetterField("научную степень");
            thesis.City = WriteLetterField("город");
            thesis.Number = WriteNumber("номер работы");

            return thesis;
        }
    }
}


