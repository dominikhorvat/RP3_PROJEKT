using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt
{
    public partial class VlasnikInfoControl : UserControl
    {
        public VlasnikInfoControl()
        {
            InitializeComponent();

            labelUputeZaCijenu.Text = "Odgovarajući format cijene za artikl je broj s dvije decimale.\n" +
                "Znak separatora koji se uvažava prilikom unosa je znak zareza.\n" +
                "Također, moguće je unijeti brojeve oblika: \"1\", \"2,1\" i \"3,12\".";

            labelPotrosnjaOdabranog.Text = "U potrošnji kada kliknete na gumb \"Prikaži odabrani\" dobit ćete grafički " +
                "prikaz \nza odabrani artikl u odabranom rasponu ako postoji, te ispis koliko" +
                " je prodano.\nTakođer, bit će navedeni artikl koji je najviše prodan (ukoliko postoji).";

            labelPotrosnja.Text = "U Potrošnji kada kliknete na gumb \"Prikaži prodane\" dobivate ispis \n" +
                "svih prodanih artikala u odabranom rasponu izabranom na odgovarjućim kalendarima.";

            labelPotrosnjaSvih.Text = "U Potrošnji kada kliknete na gumb \"Cjelokupni\" dobivate ispis \n" +
                "za cjelokupno vrijeme i sve artikle prodane tokom cijelog razdoblja rada Caffe bar-a.";
        }
    }
}
