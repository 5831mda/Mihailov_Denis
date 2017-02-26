using System;
using System.Text.RegularExpressions;

namespace IzdanieModel
{
    /// <summary>
    /// Журнал
    /// </summary>
    [Serializable]
    public class Journal : Izdanie
    {
        private string _surname;
        private string _initials;
        private string _title;
        private string _nameiz;
        private int _year;
        private int _page;
        private int _number;
        /// <summary>
        /// /
        /// </summary>
        public Journal()
        {
        }


        /// <summary>
        /// возвращает на экран информацию в указанном формате
        /// </summary>
        public string Inform
        {
            get
            {

                return String.Format("{0}, {1} {2}/ {1} {0}//{3} - {4}. - №{5} - С.{6}.", _surname, _initials, _title, _nameiz, _year, _page, _number);
            }
        }
    
  
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }     
        }
     
        /// <summary>
        /// возвращается _initials и присваивает ей значение
        /// </summary>
        public string Initials
        {
            get { return _initials; }
            set { _initials = value; }
        }
        /// <summary>
        /// возвращается __title и присваивает ей значение
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        /// <summary>
        /// возвращается _nameiz и присваивает ей значение
        /// </summary>
        public string Nameiz
        {
            get { return _nameiz; }
            set { _nameiz = value; }
        }
        /// <summary>
        /// возвращается _year и присваивает ей значение
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        /// <summary>
        /// возвращается _page и присваивает ей значение
        /// </summary>
        public int Page
        {
            get { return _page; }
            set { _page = value; }
        }
        /// <summary>
        /// возвращается _namber и присваивает ей значение
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}

