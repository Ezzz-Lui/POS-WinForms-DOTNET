using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Punto de Venta";

            // Agregar controles
            InitializePOSControls();

            this.ResumeLayout(false);
        }

        private void InitializePOSControls()
        {
            // Botones de productos
            for (int i = 0; i < 10; i++)
            {
                Button productButton = new Button();
                productButton.Size = new System.Drawing.Size(100, 100);
                productButton.Location = new System.Drawing.Point(10 + (i % 5) * 110, 10 + (i / 5) * 110);
                productButton.Text = "Producto " + (i + 1);
                productButton.Click += ProductButton_Click;
                this.Controls.Add(productButton);
            }

            // Lista de compras
            ListBox listBox = new ListBox();
            listBox.Name = "listBox";
            listBox.Size = new System.Drawing.Size(300, 400);
            listBox.Location = new System.Drawing.Point(550, 10);
            this.Controls.Add(listBox);

            // Total y botón de pago
            Label totalLabel = new Label();
            totalLabel.Name = "totalLabel";
            totalLabel.Text = "Total: $0.00";
            totalLabel.Location = new System.Drawing.Point(550, 420);
            totalLabel.Size = new System.Drawing.Size(300, 30);
            this.Controls.Add(totalLabel);

            Button payButton = new Button();
            payButton.Name = "payButton";
            payButton.Text = "Pagar";
            payButton.Size = new System.Drawing.Size(100, 50);
            payButton.Location = new System.Drawing.Point(550, 460);
            payButton.Click += PayButton_Click;
            this.Controls.Add(payButton);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ListBox listBox = this.Controls["listBox"] as ListBox;
            listBox.Items.Add(button.Text + " - $10.00");

            UpdateTotal();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado con éxito.");
            ListBox listBox = this.Controls["listBox"] as ListBox;
            listBox.Items.Clear();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            ListBox listBox = this.Controls["listBox"] as ListBox;
            decimal total = listBox.Items.Count * 10.00m;
            Label totalLabel = this.Controls["totalLabel"] as Label;
            totalLabel.Text = "Total: $" + total.ToString("0.00");
        }


        #endregion
    }
}

