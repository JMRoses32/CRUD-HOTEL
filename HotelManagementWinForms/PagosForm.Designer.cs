namespace HotelManagementWinForms
{
    partial class PagosForm
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
            this.dataGridViewPagos = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNoTarjeta = new System.Windows.Forms.TextBox();
            this.txtFechaExp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPagos
            // 
            this.dataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagos.Location = new System.Drawing.Point(13, 232);
            this.dataGridViewPagos.Name = "dataGridViewPagos";
            this.dataGridViewPagos.RowHeadersWidth = 51;
            this.dataGridViewPagos.RowTemplate.Height = 24;
            this.dataGridViewPagos.Size = new System.Drawing.Size(631, 206);
            this.dataGridViewPagos.TabIndex = 0;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(152, 118);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(202, 22);
            this.txtTipo.TabIndex = 1;
            // 
            // txtNoTarjeta
            // 
            this.txtNoTarjeta.Location = new System.Drawing.Point(152, 193);
            this.txtNoTarjeta.Name = "txtNoTarjeta";
            this.txtNoTarjeta.Size = new System.Drawing.Size(202, 22);
            this.txtNoTarjeta.TabIndex = 2;
            // 
            // txtFechaExp
            // 
            this.txtFechaExp.Location = new System.Drawing.Point(498, 46);
            this.txtFechaExp.Name = "txtFechaExp";
            this.txtFechaExp.Size = new System.Drawing.Size(202, 22);
            this.txtFechaExp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "NTarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(152, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 22);
            this.txtId.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 33);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(666, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(666, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 23);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(666, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaExp);
            this.Controls.Add(this.txtNoTarjeta);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.dataGridViewPagos);
            this.Name = "PagosForm";
            this.Text = "PagosForm";
            this.Load += new System.EventHandler(this.PagosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPagos;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNoTarjeta;
        private System.Windows.Forms.TextBox txtFechaExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}