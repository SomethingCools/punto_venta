﻿namespace bs2punto_venta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto_id,
            this.producto_nombre,
            this.producto_precio,
            this.producto_url});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // producto_id
            // 
            this.producto_id.HeaderText = "producto_id";
            this.producto_id.Name = "producto_id";
            this.producto_id.ReadOnly = true;
            // 
            // producto_nombre
            // 
            this.producto_nombre.HeaderText = "producto_nombre";
            this.producto_nombre.Name = "producto_nombre";
            this.producto_nombre.ReadOnly = true;
            // 
            // producto_precio
            // 
            this.producto_precio.HeaderText = "producto_precio";
            this.producto_precio.Name = "producto_precio";
            this.producto_precio.ReadOnly = true;
            // 
            // producto_url
            // 
            this.producto_url.HeaderText = "producto_url";
            this.producto_url.Name = "producto_url";
            this.producto_url.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_url;
    }
}

