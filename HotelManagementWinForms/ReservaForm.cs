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
    public partial class ReservaForm : Form
    {
        private ApplicationDbContext _context;

        public ReservaForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void ReservaForm_Load(object sender, EventArgs e)
        {
            LoadReservas();
        }

        private void LoadReservas()
        {
            dataGridViewReservas.DataSource = _context.Reservas.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var reserva = new Reserva
                {
                    //Id_Reserva = int.Parse(txtId.Text),
                    Id_Huésped = int.Parse(txtIdHuésped.Text),
                    Id_Habitación = int.Parse(txtIdHabitación.Text),
                    Fecha_Entrada = DateTime.Parse(txtFechaEntrada.Text),
                    Fecha_Salida = DateTime.Parse(txtFechaSalida.Text),
                    Días = int.Parse(txtDías.Text),
                    Costo = decimal.Parse(txtCosto.Text),
                    Id_Pago = int.Parse(txtIdPago.Text),
                    Estado_Pago = txtEstadoPago.Text
                };
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
                LoadReservas();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var reserva = _context.Reservas.Find(id);
                    if (reserva != null)
                    {
                        reserva.Id_Huésped = int.Parse(txtIdHuésped.Text);
                        reserva.Id_Habitación = int.Parse(txtIdHabitación.Text);
                        reserva.Fecha_Entrada = DateTime.Parse(txtFechaEntrada.Text);
                        reserva.Fecha_Salida = DateTime.Parse(txtFechaSalida.Text);
                        reserva.Días = int.Parse(txtDías.Text);
                        reserva.Costo = decimal.Parse(txtCosto.Text);
                        reserva.Id_Pago = int.Parse(txtIdPago.Text);
                        reserva.Estado_Pago = txtEstadoPago.Text;
                        _context.SaveChanges();
                        LoadReservas();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la reserva con el ID especificado.");
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
                var reserva = _context.Reservas.Find(id);
                if (reserva != null)
                {
                    _context.Reservas.Remove(reserva);
                    _context.SaveChanges();
                    LoadReservas();
                }
                else
                {
                    MessageBox.Show("No se encontró la reserva con el ID especificado.");
                }
            }
            else
            {
                MessageBox.Show("El valor del ID no es un número válido.");
            }
        }

        private void dataGridViewReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservas.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id_Reserva"].Value.ToString();
                txtIdHuésped.Text = row.Cells["Id_Huésped"].Value.ToString();
                txtIdHabitación.Text = row.Cells["Id_Habitación"].Value.ToString();
                txtFechaEntrada.Text = row.Cells["Fecha_Entrada"].Value.ToString();
                txtFechaSalida.Text = row.Cells["Fecha_Salida"].Value.ToString();
                txtDías.Text = row.Cells["Días"].Value.ToString();
                txtCosto.Text = row.Cells["Costo"].Value.ToString();
                txtIdPago.Text = row.Cells["Id_Pago"].Value.ToString();
                txtEstadoPago.Text = row.Cells["Estado_Pago"].Value.ToString();
            }
        }

        private bool ValidateFields()
        {
            if (!int.TryParse(txtIdHuésped.Text, out _) ||
                !int.TryParse(txtIdHabitación.Text, out _) ||
                !DateTime.TryParse(txtFechaEntrada.Text, out _) ||
                !DateTime.TryParse(txtFechaSalida.Text, out _) ||
                !int.TryParse(txtDías.Text, out _) ||
                !decimal.TryParse(txtCosto.Text, out _) ||
                !int.TryParse(txtIdPago.Text, out _) ||
                string.IsNullOrWhiteSpace(txtEstadoPago.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos correctamente.");
                return false;
            }
            return true;
        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void btnDelete_Click_2(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }


    }
}