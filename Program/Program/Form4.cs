﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class PostojecaDomacica : Form
    {
        public PostojecaDomacica()
        {
            InitializeComponent();
        }

        private void btKorisnik_Click(object sender, EventArgs e)
        {
            ListaKorisnika lk = new ListaKorisnika();
            lk.Show();
        }
    }
}
