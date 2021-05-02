﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngSoft.Interfaces
{
    public partial class R_VentaMes : Form
    {
        public R_VentaMes()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void R_VentaMes_Load(object sender, EventArgs e)
        {
            grvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvVenta.ForeColor = Color.Black;
            grvVenta.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvVenta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ButtonSalir_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonSalir.BackColor = Color.Red;
        }

        private void ButtonSalir_MouseLeave(object sender, EventArgs e)
        {
            ButtonSalir.BackColor = Color.Transparent;

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
