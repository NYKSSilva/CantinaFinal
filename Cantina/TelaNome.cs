﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class TelaNome : Form
    {
        public TelaNome()
        {
            InitializeComponent();
        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void TelaNome_Load(object sender, EventArgs e)
        {
         
        }

        public void chamada(string nomeCliente)
        {
            nome.Text = nomeCliente;
        }
    }
}
