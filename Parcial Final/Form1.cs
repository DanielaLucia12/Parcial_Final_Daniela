using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class femeninorbt : Form
    {
        public femeninorbt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime hoy = DateTime.Now;
            Vehiculo v = new Vehiculo();
            Conductor c = new Conductor();
            
            if(sirbt.Checked == true)
            {
                c.Afiliado = Convert.ToString(sirbt.Text);
            }
            else
            {
                c.Afiliado = Convert.ToString(norbt.Text);

            }

            if (masculinorbt.Checked == true)
            {
                c.Sexo = Convert.ToString(masculinorbt.Text);
            }
            else
            {
                c.Sexo = Convert.ToString(femeninrbt.Text);
            }

            if (camionetartb.Checked == true)
            {
                v.Tipo = Convert.ToString(camionetartb.Text);
            }
            else if (microbusrbt.Checked == true)
            {
                v.Tipo = Convert.ToString(microbusrbt.Text);
            }
            else
            {
                v.Tipo = Convert.ToString(automovilrbt.Text);
            }

             if (radioButton1.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton1.Text);
                radioButton1.BackColor = Color.Red;
               
            }
            else if (radioButton2.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton2.Text);
                radioButton2.BackColor = Color.Red;
                
            }
            else if (radioButton3.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton3.Text);
                radioButton3.BackColor = Color.Red;
                
            }
            else if (radioButton4.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton4.Text);
                radioButton4.BackColor = Color.Red;
                
            }
            else if (radioButton5.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton5.Text);
                radioButton5.BackColor = Color.Red;
            }
            else if (radioButton6.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton6.Text);
                radioButton6.BackColor = Color.Red;
                
            }
            else if (radioButton7.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton7.Text);
                radioButton7.BackColor = Color.Red;
                
            }
            else if (radioButton8.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton8.Text);
                radioButton8.BackColor = Color.Red;
                
            }
            else if (radioButton9.Checked == true)
            {
                v.Puesto = Convert.ToString(radioButton9.Text);
                radioButton9.BackColor = Color.Red;
                
            }
            else
            {
                v.Puesto = Convert.ToString(radioButton10.Text);
                radioButton10.BackColor = Color.Red;
                

            }
            DataGridViewRow fila = new DataGridViewRow();

            fechatxt.Text = hoy.ToString("dd/MM/yy");
            horatxt.Text = hoy.ToString("hh:mm:ss:tt");
            c.Id = Idtxt.Text;
            v.Marca = marcatxt.Text;
            v.Placa = placatxt.Text;

            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = fechatxt.Text;
            fila.Cells[1].Value = horatxt.Text;
            fila.Cells[2].Value = c.Sexo;
            fila.Cells[3].Value = c.Id;
            fila.Cells[4].Value = c.Afiliado;
            fila.Cells[5].Value = v.Placa;
            fila.Cells[6].Value = v.Tipo;
            fila.Cells[7].Value = v.Marca;
            fila.Cells[8].Value = v.Puesto;

            dataGridView1.Rows.Add(fila);

            Idtxt.Clear();
            marcatxt.Clear();
            placatxt.Clear();
            fechatxt.Clear();
            horatxt.Clear();
        }

      
    }
}
