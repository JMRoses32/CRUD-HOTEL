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
    public partial class HuéspedForm : Form
    {
        private ApplicationDbContext _context;

        public HuéspedForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void HuéspedForm_Load(object sender, EventArgs e)
        {
            LoadHuésped();
        }

        private void LoadHuésped()
        {
            dataGridViewHuésped.DataSource = _context.Huéspedes.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var huésped = new Huésped
                {
                    //Id_Huésped = int.Parse(txtId.Text), // Ingresado por el usuario
                    Nombre = txtNombre.Text,
                    Apellido_P = txtApellidoP.Text,
                    Apellido_M = txtApellidoM.Text,
                    Tel_Cel = long.Parse(txtTelCel.Text),
                    Tel_Fijo = long.Parse(txtTelFijo.Text),
                    Calle = txtCalle.Text,
                    Número = txtNúmero.Text,
                    Colonia = txtColonia.Text,
                    Ciudad = txtCiudad.Text,
                    Estado = txtEstado.Text,
                    CP = int.Parse(txtCP.Text)
                };
                _context.Huéspedes.Add(huésped);
                _context.SaveChanges();
                LoadHuésped();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var huésped = _context.Huéspedes.Find(id);
                    if (huésped != null)
                    {
                        huésped.Nombre = txtNombre.Text;
                        huésped.Apellido_P = txtApellidoP.Text;
                        huésped.Apellido_M = txtApellidoM.Text;
                        huésped.Tel_Cel = long.Parse(txtTelCel.Text);
                        huésped.Tel_Fijo = long.Parse(txtTelFijo.Text);
                        huésped.Calle = txtCalle.Text;
                        huésped.Número = txtNúmero.Text;
                        huésped.Colonia = txtColonia.Text;
                        huésped.Ciudad = txtCiudad.Text;
                        huésped.Estado = txtEstado.Text;
                        huésped.CP = int.Parse(txtCP.Text);
                        _context.SaveChanges();
                        LoadHuésped();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el huésped con el ID especificado.");
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
                var huésped = _context.Huéspedes.Find(id);
                if (huésped != null)
                {
                    _context.Huéspedes.Remove(huésped);
                    _context.SaveChanges();
                    LoadHuésped();
                }
                else
                {
                    MessageBox.Show("No se encontró el huésped con el ID especificado.");
                }
            }
            else
            {
                MessageBox.Show("El valor del ID no es un número válido.");
            }
        }

        private void dataGridViewHuésped_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHuésped.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id_Huésped"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoP.Text = row.Cells["Apellido_P"].Value.ToString();
                txtApellidoM.Text = row.Cells["Apellido_M"].Value.ToString();
                txtTelCel.Text = row.Cells["Tel_Cel"].Value.ToString();
                txtTelFijo.Text = row.Cells["Tel_Fijo"].Value.ToString();
                txtCalle.Text = row.Cells["Calle"].Value.ToString();
                txtColonia.Text = row.Cells["Número"].Value.ToString();
                txtColonia.Text = row.Cells["Colonia"].Value.ToString();
                txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();
                txtEstado.Text = row.Cells["Estado"].Value.ToString();
                txtCP.Text = row.Cells["CP"].Value.ToString();
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoP.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoM.Text) ||
                !long.TryParse(txtTelCel.Text, out _) ||
                !long.TryParse(txtTelFijo.Text, out _) ||
                string.IsNullOrWhiteSpace(txtCalle.Text) ||
                string.IsNullOrWhiteSpace(txtColonia.Text) ||
                string.IsNullOrWhiteSpace(txtColonia.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtEstado.Text) ||
                !int.TryParse(txtCP.Text, out _))
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