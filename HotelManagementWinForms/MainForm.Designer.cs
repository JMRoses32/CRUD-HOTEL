namespace HotelManagementWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnHabitación = new System.Windows.Forms.Button();
            this.btnHuésped = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Principal";
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(171, 120);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(171, 23);
            this.btnHotel.TabIndex = 4;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click_1);
            // 
            // btnHabitación
            // 
            this.btnHabitación.Location = new System.Drawing.Point(171, 167);
            this.btnHabitación.Name = "btnHabitación";
            this.btnHabitación.Size = new System.Drawing.Size(171, 23);
            this.btnHabitación.TabIndex = 5;
            this.btnHabitación.Text = "Habitacion";
            this.btnHabitación.UseVisualStyleBackColor = true;
            this.btnHabitación.Click += new System.EventHandler(this.btnHabitación_Click);
            // 
            // btnHuésped
            // 
            this.btnHuésped.Location = new System.Drawing.Point(171, 214);
            this.btnHuésped.Name = "btnHuésped";
            this.btnHuésped.Size = new System.Drawing.Size(171, 23);
            this.btnHuésped.TabIndex = 6;
            this.btnHuésped.Text = "Huésped";
            this.btnHuésped.UseVisualStyleBackColor = true;
            this.btnHuésped.Click += new System.EventHandler(this.btnHuésped_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(171, 261);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(171, 23);
            this.btnPagos.TabIndex = 7;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(171, 317);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(171, 23);
            this.btnReserva.TabIndex = 8;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 491);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnHuésped);
            this.Controls.Add(this.btnHabitación);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnHabitación;
        private System.Windows.Forms.Button btnHuésped;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnReserva;
    }
}