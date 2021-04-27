﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.MODELOS;
using BackEnd.DAOS;

namespace IngSoft.Interfaces
{
    public partial class Pagos : Form
    {
        int idcliente = 1;
        public Pagos()
        {
            InitializeComponent();
        }
        public Pagos(int idcl)
        {
            InitializeComponent();
            CenterToScreen();
            idcliente = 1;
        }
       

        private void Pagos_Load(object sender, EventArgs e)
        {
            grvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvPagos.DataSource = null;
            grvPagos.DataSource = new DAOPago().getAll(idcliente);
            grvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvPagos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvPagos.ForeColor = Color.Black;
            grvPagos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvPagos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Cliente datos = new DAOCliente().getOne(idcliente);
            txtNombre.Text = datos.Nombre;
            txtDireccion.Text = datos.Direccion;
            txtTelefono.Text = datos.Telefono;
            txtDeudatotal.Text =""+ datos.DeudaTotal;




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                int valorCelda = int.Parse(grvPagos.Rows[grvPagos.CurrentRow.Index].Cells[2].Value.ToString());
                Pago pag = new Pago(valorCelda, Decimal.Parse(txtCantidad.Text));

                if (new DAOPago().registrar(pag))
                {
                    MessageBox.Show("El pago se realizo con exito");
                    txtCantidad.Text = "";
                }
                else
                {
                    MessageBox.Show("No pudo realizarse el pago");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}