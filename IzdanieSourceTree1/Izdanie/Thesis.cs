using System;

/// <summary>
/// Thesis.Position = 123; //set
/// WriteLine("" + Thesis.Position); //get
/// </summary>

namespace IzdanieModel
{
    /// <summary>
    /// Диссертация
    /// </summary>
    [Serializable]
    public class Thesis: Izdanie
    {
        private string _surname;
        private string _initials;
        private string _patronymic;
        private string _position;
        private string _city;
        private int _number;
        private int _year;
        private int _page;
        /// <summary>
        /// диссертация
        /// </summary>
        public Thesis()
        {
        }
        /// <summary>
        /// возвращает на экран информацию в указанном формате
        /// </summary>
        public string Inform
        {
            get
            {
                return String.Format("{0} {2} : {3} / {0} {1} {2} - {4}, {5}. - {6}c.", _surname, _initials, _patronymic, _position, _city, _number, _year, _page);
            }
        }
        /// <summary>
        /// возвращает _surname и присваивает ей значение
        /// </summary>
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }
        /// <summary>
        /// возвращает _position и присваивает ей значение
        /// </summary>
        public string Position
        {
            get { return _position; }
            set { _position = value; }
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
        /// возвращает _number и присваивает ей значение
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { _number = value; }
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
        /// возвращает _year и присваивает ей значение
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        /// <summary>
        /// возвращает _page и присваивает ей значение
        /// </summary>
        public int Page
        {
            get { return _page; }
            set { _page = value; }
        }
    }
}
