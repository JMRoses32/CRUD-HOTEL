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
    public partial class HotelForm : Form
    {
        private ApplicationDbContext _context;

        public HotelForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            LoadHotels();
        }

        private void LoadHotels()
        {
            dataGridViewHotels.DataSource = _context.Hotels.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var hotel = new Hotel
            {
                // Id_Hotel se omite porque la base de datos lo generará automáticamente
                Nombre = txtName.Text,
                Calle = txtAddress.Text,
                Número = int.Parse(txtNumber.Text),
                Ciudad = txtCity.Text,
                Estado = txtState.Text,
                CP = int.Parse(txtPostalCode.Text),
                WWW = txtWebsite.Text,
                Teléfono_Recepción = long.Parse(txtReceptionPhone.Text),
                Teléfono_Reserva = long.Parse(txtReservationPhone.Text),
                Categoría = txtCategory.Text
            };
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
            LoadHotels();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                var hotel = _context.Hotels.Find(id);
                if (hotel != null)
                {
                    hotel.Nombre = txtName.Text;
                    hotel.Calle = txtAddress.Text;
                    hotel.Número = int.Parse(txtNumber.Text);
                    hotel.Ciudad = txtCity.Text;
                    hotel.Estado = txtState.Text;
                    hotel.CP = int.Parse(txtPostalCode.Text);
                    hotel.WWW = txtWebsite.Text;
                    hotel.Teléfono_Recepción = long.Parse(txtReceptionPhone.Text);
                    hotel.Teléfono_Reserva = long.Parse(txtReservationPhone.Text);
                    hotel.Categoría = txtCategory.Text;
                    _context.SaveChanges();
                    LoadHotels();
                }
                else
                {
                    MessageBox.Show("No se encontró el hotel con el ID especificado.");
                }
            }
            else
            {
                MessageBox.Show("El valor del ID no es un número válido.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                var hotel = _context.Hotels.Find(id);
                if (hotel != null)
                {
                    _context.Hotels.Remove(hotel);
                    _context.SaveChanges();
                    LoadHotels();
                }
                else
                {
                    MessageBox.Show("No se encontró el hotel con el ID especificado.");
                }
            }
            else
            {
                MessageBox.Show("El valor del ID no es un número válido.");
            }
        }

        private void dataGridViewHotels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHotels.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id_Hotel"].Value.ToString();
                txtName.Text = row.Cells["Nombre"].Value.ToString();
                txtAddress.Text = row.Cells["Calle"].Value.ToString();
                txtNumber.Text = row.Cells["Número"].Value.ToString();
                txtCity.Text = row.Cells["Ciudad"].Value.ToString();
                txtState.Text = row.Cells["Estado"].Value.ToString();
                txtPostalCode.Text = row.Cells["CP"].Value.ToString();
                txtWebsite.Text = row.Cells["WWW"].Value.ToString();
                txtReceptionPhone.Text = row.Cells["Teléfono_Recepción"].Value.ToString();
                txtReservationPhone.Text = row.Cells["Teléfono_Reserva"].Value.ToString();
                txtCategory.Text = row.Cells["Categoría"].Value.ToString();
            }
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
