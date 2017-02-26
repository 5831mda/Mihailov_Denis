using System;

namespace IzdanieModel
{
    /// <summary>
    /// описание интерфейса
    /// </summary>
    public interface  Izdanie
    {
        string Inform { get; }     
        string Surname { get; set; }
        string Initials { get; set; }
        int Year { get; set; }
        int Page { get; set; }
    }
}                                                                                                                                                                                                                                               