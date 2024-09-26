using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HotelManagementWinForms.Data;
using HotelManagementWinForms.Models;

namespace HotelManagementWinForms
{
    public partial class HabitaciónForm : Form
    {
        private ApplicationDbContext _context;

        public HabitaciónForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void HabitaciónForm_Load_1(object sender, EventArgs e)
        {
            LoadHabitacion();
        }

        private void LoadHabitacion()
        {
            dataGridViewHabitacion.DataSource = _context.Habitacion.ToList(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var habitacion = new Habitación
                {
                    //Id_Habitación = int.Parse(txtId.Text), // Ingresado por el usuario
                    Tipo_Habitación = txtTipo.Text,
                    Descripción = txtDescripción.Text,
                    No_Personas = int.Parse(txtCapacidad.Text),
                    Id_Hotel = int.Parse(txtIdHotel.Text),
                    Precio = int.Parse(txtPrecio.Text)
                };
                _context.Habitacion.Add(habitacion);
                _context.SaveChanges();
                LoadHabitacion();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var habitacion = _context.Habitacion.Find(id);
                    if (habitacion != null)
                    {
                        habitacion.Tipo_Habitación = txtTipo.Text;
                        habitacion.Descripción = txtDescripción.Text;
                        habitacion.No_Personas = int.Parse(txtCapacidad.Text);
                        habitacion.Id_Hotel = int.Parse(txtIdHotel.Text);
                        habitacion.Precio = int.Parse(txtPrecio.Text);
                        _context.SaveChanges();
                        LoadHabitacion();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la habitación con el ID especificado.");
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
                var habitacion = _context.Habitacion.Find(id);
                if (habitacion != null)
                {
                    _context.Habitacion.Remove(habitacion);
                    _context.SaveChanges();
                    LoadHabitacion();
                }
                else
                {
                    MessageBox.Show("No se encontró la habitación con el ID especificado.");
                }
            }
            else
            {
                MessageBox.Show("El valor del ID no es un número válido.");
            }
        }

        private void dataGridViewHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHabitacion.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id_Habitación"].Value.ToString();
                txtTipo.Text = row.Cells["Tipo_Habitación"].Value.ToString();
                txtDescripción.Text = row.Cells["Descripción"].Value.ToString();
                txtCapacidad.Text = row.Cells["No_Personas"].Value.ToString();
                txtIdHotel.Text = row.Cells["Id_Hotel"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
            }
        }

        private bool ValidateFields()
        {
            if (!int.TryParse(txtId.Text, out _))
            {
                MessageBox.Show("El valor del ID no es un número válido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripción.Text) ||
                !int.TryParse(txtCapacidad.Text, out _) ||
                !int.TryParse(txtIdHotel.Text, out _) ||
                !int.TryParse(txtPrecio.Text, out _))
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