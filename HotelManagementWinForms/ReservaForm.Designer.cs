namespace HotelManagementWinForms
{
    partial class ReservaForm
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
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdHuésped = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdHabitación = new System.Windows.Forms.TextBox();
            this.txtFechaEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.txtDías = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIdPago = new System.Windows.Forms.TextBox();
            this.txtEstadoPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(12, 295);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.RowTemplate.Height = 24;
            this.dataGridViewReservas.Size = new System.Drawing.Size(729, 217);
            this.dataGridViewReservas.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 33);
            this.label4.TabIndex = 35;
            this.label4.Text = "IDHuesped";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "IDHabitación";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 22);
            this.txtId.TabIndex = 38;
            // 
            // txtIdHuésped
            // 
            this.txtIdHuésped.Location = new System.Drawing.Point(186, 85);
            this.txtIdHuésped.Name = "txtIdHuésped";
            this.txtIdHuésped.Size = new System.Drawing.Size(202, 22);
            this.txtIdHuésped.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "FechaEntrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "FechaSalida";
            // 
            // txtIdHabitación
            // 
            this.txtIdHabitación.Location = new System.Drawing.Point(186, 151);
            this.txtIdHabitación.Name = "txtIdHabitación";
            this.txtIdHabitación.Size = new System.Drawing.Size(202, 22);
            this.txtIdHabitación.TabIndex = 42;
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Location = new System.Drawing.Point(186, 206);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(202, 22);
            this.txtFechaEntrada.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 33);
            this.label5.TabIndex = 44;
            this.label5.Text = "Dias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 33);
            this.label6.TabIndex = 45;
            this.label6.Text = "Costo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 33);
            this.label7.TabIndex = 46;
            this.label7.Text = "IDPago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(819, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 33);
            this.label8.TabIndex = 47;
            this.label8.Text = "EstadoPago";
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(557, 29);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(202, 22);
            this.txtFechaSalida.TabIndex = 48;
            // 
            // txtDías
            // 
            this.txtDías.Location = new System.Drawing.Point(557, 87);
            this.txtDías.Name = "txtDías";
            this.txtDías.Size = new System.Drawing.Size(202, 22);
            this.txtDías.TabIndex = 49;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(557, 153);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(202, 22);
            this.txtCosto.TabIndex = 50;
            // 
            // txtIdPago
            // 
            this.txtIdPago.Location = new System.Drawing.Point(557, 208);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Size = new System.Drawing.Size(202, 22);
            this.txtIdPago.TabIndex = 51;
            // 
            // txtEstadoPago
            // 
            this.txtEstadoPago.Location = new System.Drawing.Point(795, 85);
            this.txtEstadoPago.Name = "txtEstadoPago";
            this.txtEstadoPago.Size = new System.Drawing.Size(202, 22);
            this.txtEstadoPago.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 33);
            this.label9.TabIndex = 53;
            this.label9.Text = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(774, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 23);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_2);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(774, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 23);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_2);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(774, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 23);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_2);
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 524);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEstadoPago);
            this.Controls.Add(this.txtIdPago);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDías);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.txtIdHabitación);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdHuésped);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewReservas);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdHuésped;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdHabitación;
        private System.Windows.Forms.TextBox txtFechaEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.TextBox txtDías;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIdPago;
        private System.Windows.Forms.TextBox txtEstadoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}