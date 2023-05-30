using LBR7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kurs
{
    public partial class Form1 : Form
    {
        List<string> nomination = new List<string>();
        Dictionary<string, Film> Films = new Dictionary<string, Film>();
        string[] nom = { "Лучший фильм", "Лучшая режиссура", "Лучшая мужская роль", 
                            "Лучшая женская роль", "Лучший оригинальный сценарий", "Лучшие визуальные эффекты",
                            "Лучший звук", "Лучший дизайн", "Лучший дизайн костюмов", "Лучшая оригинальная песня",
                            "Лучший саундтрек","Лучший монтаж", "Лучшая операторская работа", 
                            "Лучший короткометражный мультфильм"};
        BinaryFormatter formatter = new BinaryFormatter();
        int MaxCountInDay = 4;

        public Form1()
        {
            InitializeComponent();
            
        }

        public Film Film
        {
            get => default;
            set
            {
            }
        }

        public Form2 Form2
        {
            get => default;
            set
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            foreach (string s in nom)
                NominationBox.Items.Add(s);

        }
        private bool CheckName()
        {
            if (BoxNameFilm.Text.Length == 0)
            {
                MessageBox.Show("Введите название фильма!");
                return false;
            }
            if (BoxNameDirector.Text.Length == 0)
            {
                MessageBox.Show("Введите имя режиссера!");
                return false;
            }
            if (CountryBox.Text.Length == 0)
            {
                MessageBox.Show("Введите страну производства фильма!");
                return false;
            }
            if (nomination.Count()==0)
            {
                MessageBox.Show("Добавьте номинацию!");
                return false;
            }

            if (Films.ContainsKey(BoxNameFilm.Text))
            {
                MessageBox.Show("Фильм с таким названием уже существует!");
                return false;
            }
            if(Films.Where(value => 
                             value.Value.Date_.Day==
                             Convert.ToDateTime(DayBox.Value).Day).Count() == MaxCountInDay)
            {
                MessageBox.Show("В этот день нет места для нового фильма!");
                return false;
            }
            
            return true;
        }

        private void addObject_Click(object sender, EventArgs e)
        {
            if (!CheckName())
            {
                return;
            }
            Film newFilm = new Film(Convert.ToString(BoxNameFilm.Text));
            newFilm.NameDirector_ = Convert.ToString(BoxNameDirector.Text);
            newFilm.Country_ = Convert.ToString(CountryBox.Text);
            newFilm.Nomination_ = nomination.ToArray();
            newFilm.RuningTime_ = Convert.ToInt32(RunningTimeBox.Text);
            newFilm.Date_ = Convert.ToDateTime(DayBox.Value);

            Films.Add(newFilm.NameFilm_, newFilm);
            nomination.Clear();
            if (Convert.ToDateTime(dateTimePicker1.Value).Day == newFilm.Date_.Day)
            {

                FilmsList.Items.Add(newFilm.NameFilm_);
                outInfo.Text = Convert.ToString(newFilm);
                FilmsList.SelectedItem = FilmsList.Items[0];
            }
        }

        private void deleteObject_Click(object sender, EventArgs e)
        {
            string Name = Convert.ToString(FilmsList.SelectedItem);
            Films.Remove(Name);
            FilmsList.Items.Remove(Name);
            outInfo.Text = "Информация о фильме отсутствует";
        }


        private void Film_SelectedIndexChanged(object sender, EventArgs e)
        {
            outInfo.Text = Convert.ToString(Films[FilmsList.SelectedItem.ToString()]);
        }
        
        /// <summary>
        /// Запись в файл колллекции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WriteToFileButton_Click(object sender, EventArgs e)
        {
            
            using (FileStream fs = new FileStream("Films.dat", FileMode.OpenOrCreate))
            formatter.Serialize(fs, Films);
            MessageBox.Show("Запись в файл Films.dat успешно осуществлена!", "Система");
        }

        /// <summary>
        /// открытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile_Click(object sender, EventArgs e)
        {

            using (FileStream fs = new FileStream("Films.dat", FileMode.OpenOrCreate))
            {
                var newPerson = (Dictionary<string, Film>)formatter.Deserialize(fs);
                Films = newPerson;
                Form2 frm2 = new Form2(Films);
                frm2.Show();
                frm2.Form2_Loadsome();
                
                if(Films.Count > 0)
                {
                    FilmsList.Items.Clear();
                    foreach (var film in Films)
                    {
                        if (film.Value.Date_.Day == Convert.ToDateTime(dateTimePicker1.Value).Day)
                            FilmsList.Items.Add(film.Value.NameFilm_);
                    }
                    if (FilmsList.Items.Count > 0)
                    {
                        FilmsList.SelectedItem = FilmsList.Items[0];
                        outInfo.Text = Convert.ToString(Films[FilmsList.SelectedItem.ToString()]);
                    }
                }
            }
            
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*int some =Films.Where(value =>
            value.Value.Date_.Day ==
                             Convert.ToDateTime(DayBox.Value).Day).Count();*/
            if (FilmsList.Items.Count > 0)
            {
                FilmsList.Items.Clear();
                outInfo.Text = "Информация о фильме отсутствует";
            }
            if (Films != null)
            {
                foreach (var film in Films)
                {
                    if (film.Value.Date_.Day == Convert.ToDateTime(dateTimePicker1.Value).Day)
                        FilmsList.Items.Add(film.Value.NameFilm_);
                }
                if (FilmsList.Items.Count > 0)
                {
                    FilmsList.SelectedItem = FilmsList.Items[0];
                    outInfo.Text = Convert.ToString(Films[FilmsList.SelectedItem.ToString()]);
                }
            }

        }

        private void Add_Nomination(object sender, EventArgs e)
        {
            if (!nomination.Contains(Convert.ToString(NominationBox.Text))&&!(Convert.ToString(NominationBox.Text).Equals("")))
                nomination.Add(Convert.ToString(NominationBox.Text));
            else
                MessageBox.Show("Выберете другую номинацию");
        }
    }
}
