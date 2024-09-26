using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementWinForms.Data;
using HotelManagementWinForms.Models;

namespace HotelManagementWinForms
{
    public partial class PagosForm : Form
    {
        private ApplicationDbContext _context;

        public PagosForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void PagosForm_Load(object sender, EventArgs e)
        {
            LoadPagos();
        }

        private void LoadPagos()
        {
            dataGridViewPagos.DataSource = _context.Pagos.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var pago = new Pagos
                {
                    Tipo = txtTipo.Text,
                    No_Tarjeta = txtNoTarjeta.Text,
                    Fecha_Exp = DateTime.Parse(txtFechaExp.Text)
                };
                _context.Pagos.Add(pago);
                _context.SaveChanges();
                LoadPagos();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var pago = _context.Pagos.Find(id);
                    if (pago != null)
                    {
                        pago.Tipo = txtTipo.Text;
                        pago.No_Tarjeta = txtNoTarjeta.Text;
                        pago.Fecha_Exp = DateTime.Parse(txtFechaExp.Text);
                        _context.SaveChanges();
                        LoadPagos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el pago con el ID especificado.");
                    }
                }
                else
                {
                    MessageBox.Show("El valor del ID no es un número válido.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                var pago = _context.Pagos.Find(id);
                if (pago != null)
                {
                    _context.Pagos.Remove(pago);
                    _context.SaveChanges();
                    LoadPagos();
                }
                else
                {
                    MessageBox.Show("No se encontró el pago con el ID especificado.");
                }
            }
            else
            {
                MessageBox.Show("El valor del ID no es un número válido.");
            }
        }

        private void dataGridViewPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPagos.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id_Pago"].Value.ToString();
                txtTipo.Text = row.Cells["Tipo"].Value.ToString();
                txtNoTarjeta.Text = row.Cells["No_Tarjeta"].Value.ToString();
                txtFechaExp.Text = row.Cells["Fecha_Exp"].Value.ToString();
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtNoTarjeta.Text) ||
                !DateTime.TryParse(txtFechaExp.Text, out _))
            {
                MessageBox.Show("Por favor, rellena todos los campos correctamente.");
                return false;
            }
            return true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }


    }
}