﻿using System;
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
                "Također, moguće je unijeti brojeve oblika: \"1\", \"2,1\" i \"3,12\"";

            labelPotrosnjaInfo.Text = "U potrošnji kada potvrdite datum dobit ćete grafički " +
                "prikaz za odabrani artikl \nu odabranom rasponu ako postoji te ispis koliko" +
                " je prodano.\nTakođer, bit će navedeni artikl koji je najviše prodan (ukoliko postoji).";
        }
    }
}
