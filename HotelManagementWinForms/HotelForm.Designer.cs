using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using HotelManagementWinForms.Data;
using HotelManagementWinForms.Models;

namespace HotelManagementWinForms
{
    partial class HotelForm
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
            this.dataGridViewHotels = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReservationPhone = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtReceptionPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHotels
            // 
            this.dataGridViewHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotels.Location = new System.Drawing.Point(12, 264);
            this.dataGridViewHotels.Name = "dataGridViewHotels";
            this.dataGridViewHotels.RowHeadersWidth = 51;
            this.dataGridViewHotels.RowTemplate.Height = 24;
            this.dataGridViewHotels.Size = new System.Drawing.Size(651, 298);
            this.dataGridViewHotels.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calle";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(133, 156);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(202, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(133, 227);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(202, 22);
            this.txtNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "CP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 33);
            this.label8.TabIndex = 12;
            this.label8.Text = "WWW";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(459, 37);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(201, 22);
            this.txtCity.TabIndex = 13;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(459, 96);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(201, 22);
            this.txtState.TabIndex = 14;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(459, 155);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(201, 22);
            this.txtPostalCode.TabIndex = 15;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(459, 227);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(201, 22);
            this.txtWebsite.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(687, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "TRecepción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(687, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "TReserva";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(687, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 33);
            this.label11.TabIndex = 19;
            this.label11.Text = "Categoría";
            // 
            // txtReservationPhone
            // 
            this.txtReservationPhone.Location = new System.Drawing.Point(839, 98);
            this.txtReservationPhone.Name = "txtReservationPhone";
            this.txtReservationPhone.Size = new System.Drawing.Size(202, 22);
            this.txtReservationPhone.TabIndex = 20;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(839, 166);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(202, 22);
            this.txtCategory.TabIndex = 21;
            // 
            // txtReceptionPhone
            // 
            this.txtReceptionPhone.Location = new System.Drawing.Point(839, 38);
            this.txtReceptionPhone.Name = "txtReceptionPhone";
            this.txtReceptionPhone.Size = new System.Drawing.Size(202, 22);
            this.txtReceptionPhone.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(757, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(757, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(757, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(133, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 22);
            this.txtId.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "IDHotel";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 574);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtReceptionPhone);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtReservationPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridViewHotels);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHotels;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtNumber;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtPostalCode;
        private TextBox txtWebsite;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtReservationPhone;
        private TextBox txtCategory;
        private TextBox txtReceptionPhone;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtId;
        private Label label2;
    }
}