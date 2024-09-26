using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnHotel_Click_1(object sender, EventArgs e)
        {
            var form = new HotelForm();
            form.Show();
        }

        private void btnHabitación_Click(object sender, EventArgs e)
        {
            var form = new HabitaciónForm();
            form.Show();
        }

        private void btnHuésped_Click(object sender, EventArgs e)
        {
            var form = new HuéspedForm();
            form.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            var form = new PagosForm();
            form.Show();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            var form = new ReservaForm();
            form.Show();
        }
    }
}
