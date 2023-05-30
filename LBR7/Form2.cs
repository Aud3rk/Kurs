using Kurs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBR7
{
    public partial class Form2 : Form
    {
        Dictionary<string, Film> Films = new Dictionary<string, Film>();
        public Form2()
        {
            
        }
        public Form2(Dictionary<string, Film> list)
        {
            Films = list;
            InitializeComponent();
        }

        public void Form2_Loadsome()
        {
            foreach (var item in Films)
            {
                for (int i = 0; i < item.Value.Nomination_.Length; i++)
                {
                    string[] row = {item.Value.NameFilm_,item.Value.NameDirector_,item.Value.Nomination_[i],
                                item.Value.Date_.Day+" мая"};
                    table.Rows.Add(row);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
