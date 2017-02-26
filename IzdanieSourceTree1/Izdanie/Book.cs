using System;

namespace IzdanieModel
{
    /// <summary>
    /// Книга
    /// </summary>
    [Serializable]
    public class Book: Izdanie
    {
        string _surname;
        string _initials;
        string _title;
        string _oblast;
        string _city;
        string _nameiz;
        int _year;
        int _page;
        /// <summary>
        /// 
        /// </summary>
        public Book()
        {
        }
        /// <summary>
        /// возвращает на экран информацию в указанном формате
        /// </summary>
        public string Inform
        {
            get
            {
                return string.Format("{0}, {1} {2} : {3} / {1} {0}. – {4} : {5}, {6}. – {7} с. ", 
                    _surname, _initials, _title, _oblast, _city, _nameiz, _year, _page);
            }
        }
        /// <summary>
        /// возвращает _surname и присваивает ей значение
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        /// <summary>
        /// возвращает _initials и присваивает ей значение
        /// </summary>
        public string Initials
        {
            get { return _initials; }
            set { _initials = value; }
        }
        /// <summary>
        /// возвращает _title и присваивает ей значение
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        /// <summary>
        /// возвращает _oblast и присваивает ей значение
        /// </summary>
        public string Oblast
        {
            get { return _oblast; }
            set { _oblast = value; }
        }
        /// <summary>
        /// возвращает _city и присваивает ей значение
        /// </summary>
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        /// <summary>
        /// возвращает _nameiz и присваивает ей значение
        /// </summary>
        public string Nameiz
        {
            get { return _nameiz; }
            set { _nameiz = value; }
        }
        /// <summary>
        /// возвращает _year и присваивает ей значение
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        /// <summary>
        /// возвращает _surname и присваивает ей значение
        /// </summary>
        public int Page
        {
            get { return _page; }
            set { _page = value; }
        }
    }
}
