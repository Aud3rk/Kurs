using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    [Serializable]
    public class Film
    {
        private string nameFilm;
        private string nameDirector;
        private string country;
        private string[] nomination;
        private int runningTime;
        private DateTime date;

        public string NameFilm_ { get => nameFilm; set => nameFilm = value; }
        public string NameDirector_ { get => nameDirector; set => nameDirector = value; }
        public string Country_ { get => country; set => country = value; }  
        public string[] Nomination_ { get => nomination; set => nomination = value; }
        public int RuningTime_ { get => runningTime; set => runningTime = value; }
        public DateTime Date_ { get => date; set => date = value; }


        // Конструктор с 1 параметром
        public Film(string name)
        {
            this.nameFilm = name;
        }
        public string Get_Nomination()
        {
            string nom = "";
            if (Nomination_.Count() == 0)
                return nom;
            for(int i = 0; i < Nomination_.Length; i++)
                nom += nomination[i] + "\n ";
            return nom;
        }

        public override string ToString()
        {
            return "Название фильма: " + NameFilm_ + "\n" +
                "Имя режиссера: " + NameDirector_ + "\n" +
                "Страна: " + Country_ + "\n" +
                "Номинации: " + Get_Nomination() +
                "Длительность фильма: " + RuningTime_ + "\n" +
                "Дата: " + Date_.Day + "\n";


        }

    }
}
