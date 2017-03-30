using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbosabor1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbosabor2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            lstresumo.Items.Clear();
            txtdesconto.Clear();
            float sabor1 = 0, sabor2 = 0, sabor3 = 0, sabor4 = 0, sabor5 = 0, bebida1 = 0, bebida2 = 0, bebida3 = 0,
                totalpag = 0, totalped = 0, desconto = 0 ;
            int qtd1, qtd2, qtd3, qtd4, qtd5, qtdbeb1, qtdbeb2, qtdbeb3;

            qtd1 = int.Parse(txtqtd1.Text);
            qtd2 = int.Parse(txtqtd2.Text);
            qtd3 = int.Parse(txtqtd3.Text);
            qtd4 = int.Parse(txtqtd4.Text);
            qtd5 = int.Parse(txtqtd5.Text);

            qtdbeb1 = int.Parse(txtqtdbeb1.Text);
            qtdbeb2 = int.Parse(txtqtdbeb2.Text);
            qtdbeb3 = int.Parse(txtqtdbeb3.Text);

            if (cbosabor1.Text == "Mussarela")
                sabor1 = 20.50f;
            
            else if (cbosabor1.Text == "Portuguesa")
                sabor1 = 22.75f;
            
            else if (cbosabor1.Text == "Frango com catupiry")
                sabor1 = 23.45f;
            
            else if (cbosabor1.Text == "Calabresa")
                sabor1 = 21.15f;
            

            if (cbosabor2.Text == "Mussarela")
                sabor2 = 20.50f;
            
            else if (cbosabor2.Text == "Portuguesa")
                sabor2 = 22.75f;
            
            else if (cbosabor2.Text == "Frango com catupiry")
                sabor2 = 23.45f;
            
            else if (cbosabor2.Text == "Calabresa")
                sabor2 = 21.15f;
            

            if (cbosabor3.Text == "Mussarela")
                sabor3 = 20.50f;
            
            else if (cbosabor3.Text == "Portuguesa")
                sabor3 = 22.75f;
            
            else if (cbosabor3.Text == "Frango com catupiry")
                sabor3 = 23.45f;
           
            else if (cbosabor3.Text == "Calabresa")
                sabor3 = 21.15f;


            if (cbosabor4.Text == "Mussarela")
                sabor4 = 20.50f;

            else if (cbosabor4.Text == "Portuguesa")
                sabor4 = 22.75f;

            else if (cbosabor4.Text == "Frango com catupiry")
                sabor4 = 23.45f;

            else if (cbosabor4.Text == "Calabresa")
                sabor4 = 21.15f;


            if (cbosabor5.Text == "Mussarela")
                sabor5 = 20.50f;

            else if (cbosabor5.Text == "Portuguesa")
                sabor5 = 22.75f;

            else if (cbosabor5.Text == "Frango com catupiry")
                sabor5 = 23.45f;

            else if (cbosabor5.Text == "Calabresa")
                sabor5 = 21.15f;

            if (cbobebida1.Text == "Coca-Cola 2L")
                bebida1 = 8.50f;

            else if (cbobebida1.Text == "Fanta 2L")
                bebida1 = 7.75f;

            else if (cbobebida1.Text == "Guarana Antartica 2L")
                bebida1 = 7.45f;

            else if (cbobebida2.Text == "Pepsi")
                bebida1 = 6.15f;

            if (cbobebida2.Text == "Coca-Cola 2L")
                bebida2 = 8.50f;

            else if (cbobebida2.Text == "Fanta 2L")
                bebida2 = 7.75f;

            else if (cbobebida2.Text == "Guarana Antartica 2L")
                bebida2 = 7.45f;

            else if (cbobebida2.Text == "Pepsi")
                bebida2 = 6.15f;

            if (cbobebida3.Text == "Coca-Cola 2L")
                bebida3 = 8.50f;

            else if (cbobebida3.Text == "Fanta 2L")
                bebida3 = 7.75f;

            else if (cbobebida3.Text == "Guarana Antartica 2L")
                bebida3 = 7.45f;

            else if (cbobebida3.Text == "Pepsi")
                bebida3 = 6.15f;

            if (cbosabor1.Text != "")
            {
                totalpag = qtd1 * sabor1;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                txttotalpagar.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Sabor: " + cbosabor1.Text + " Quantidade X " + Convert.ToString(qtd1) + " = " + "R$ " + Convert.ToString(sabor1));
            }

            if (cbosabor2.Text != "")
            {
                totalpag = qtd2 * sabor2;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Sabor: " + cbosabor2.Text + " Quantidade X" + Convert.ToString(qtd2) + " = " + "R$ " + Convert.ToString(sabor2));

            }

            if (cbosabor3.Text != "")
            {
                totalpag = qtd3 * sabor3;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Sabor: " + cbosabor3.Text + " Quantidade X" + Convert.ToString(qtd3) + " = " + "R$ " + Convert.ToString(sabor3));

            }

            if (cbosabor4.Text != "")
            {
                totalpag = qtd4 * sabor4;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Sabor: " + cbosabor4.Text + " Quantidade X" + Convert.ToString(qtd4) + " = " + "R$ " + Convert.ToString(sabor4));

            }

            if (cbosabor5.Text != "")
            {
                totalpag = qtd5 * sabor5;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Sabor: " + cbosabor5.Text + " Quantidade X" + Convert.ToString(qtd5) + " = " + "R$ " + Convert.ToString(sabor5));

            }

            if (cbobebida1.Text != "")
            {
                totalpag = qtdbeb1 * bebida1;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Bebida: " + cbobebida1.Text + " Quantidade X" + Convert.ToString(qtdbeb1) + " = " + "R$ " + Convert.ToString(bebida1*qtdbeb1));


            }

            if (cbobebida2.Text != "")
            {
                totalpag = qtdbeb2 * bebida1;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Bebida: " + cbobebida2.Text + " Quantidade X" + Convert.ToString(qtdbeb2) + " = " + "R$ " + Convert.ToString(bebida2*qtdbeb2));

            }

            if (cbobebida3.Text != "")
            {
                totalpag = qtdbeb3 * bebida1;
                totalped = totalpag + totalped;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Bebida: " + cbobebida3.Text + " Quantidade X" + Convert.ToString(qtdbeb3) + " = " + "R$ " + Convert.ToString(bebida3*qtdbeb3));

            }

            if (chkbordrecheio.Checked == true)
            {
                totalped = totalped + 5;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Borda com recheio = R$5,00");

            }

            if (chkrecheextra.Checked == true)
            {
                totalped = totalped + 9;
                txttotalpedido.Text = Convert.ToString(totalped);
                lstresumo.Items.Add("Recheio extra = R$9,00");
            }

            if(rdbdinheiro.Checked == true)
            {
                desconto = totalped * 0.15f;
                txtdesconto.Text = Convert.ToString(desconto);
                totalped = totalped - (totalped * 0.15f);
                txttotalpagar.Text = Convert.ToString(totalped);
            }

            if (rdbcheque.Checked == true)
            {
                desconto = totalped*0.10f;
                txtdesconto.Text = Convert.ToString(desconto);
                totalped = totalped - (totalped * 0.10f);
                txttotalpagar.Text = Convert.ToString(totalped);
            }

            if (rdbdebito.Checked == true)
            {
                desconto = totalped * 0.05f;
                txtdesconto.Text = Convert.ToString(desconto);
                totalped = totalped - (totalped * 0.05f);
                txttotalpagar.Text = Convert.ToString(totalped);
            }

        }
        private void btnsair_Click(object sender, EventArgs e)
        {

        }

        private void txttotalpagar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtqtd1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            lstresumo.Items.Clear();
            txttotalpedido.Clear();
            txtqtd1.Clear();
            txtqtd2.Clear();
            txtqtd3.Clear();
            txtqtd4.Clear();
            txtqtd5.Clear();

            txtqtd1.Text = Convert.ToString(0);
            txtqtd2.Text = Convert.ToString(0);
            txtqtd3.Text = Convert.ToString(0);
            txtqtd4.Text = Convert.ToString(0);
            txtqtd5.Text = Convert.ToString(0);

            txtqtdbeb1.Clear();
            txtqtdbeb2.Clear();
            txtqtdbeb3.Clear();

            txtqtdbeb1.Text = Convert.ToString(0);
            txtqtdbeb2.Text = Convert.ToString(0);
            txtqtdbeb3.Text = Convert.ToString(0);

            cbosabor1.Items.Clear();
            cbosabor2.Items.Clear();
            cbosabor3.Items.Clear();
            cbosabor4.Items.Clear();
            cbosabor5.Items.Clear();
            cbobebida1.Items.Clear();
            cbobebida2.Items.Clear();
            cbobebida3.Items.Clear();
            cbosabor1.Items.Clear();
            cbosabor1.Items.Add("Mussarela");
            cbosabor1.Items.Add("Portuguesa");
            cbosabor1.Items.Add("Frango com catupiry");
            cbosabor1.Items.Add("Calabresa");

            cbosabor2.Items.Clear();
            cbosabor2.Items.Add("Mussarela");
            cbosabor2.Items.Add("Portuguesa");
            cbosabor2.Items.Add("Frango com catupiry");
            cbosabor2.Items.Add("Calabresa");

            cbosabor3.Items.Clear();
            cbosabor3.Items.Add("Mussarela");
            cbosabor3.Items.Add("Portuguesa");
            cbosabor3.Items.Add("Frango com catupiry");
            cbosabor3.Items.Add("Calabresa");

            cbosabor4.Items.Clear();
            cbosabor4.Items.Add("Mussarela");
            cbosabor4.Items.Add("Portuguesa");
            cbosabor4.Items.Add("Frango com catupiry");
            cbosabor4.Items.Add("Calabresa");

            cbosabor5.Items.Clear();
            cbosabor5.Items.Add("Mussarela");
            cbosabor5.Items.Add("Portuguesa");
            cbosabor5.Items.Add("Frango com catupiry");
            cbosabor5.Items.Add("Calabresa");

            cbobebida1.Items.Clear();
            cbobebida1.Items.Add("Coca-Cola 2L");
            cbobebida1.Items.Add("Fanta 2L");
            cbobebida1.Items.Add("Guarana Antartica 2L");
            cbobebida1.Items.Add("Pepsi 2L");

            cbobebida2.Items.Clear();
            cbobebida2.Items.Add("Coca-Cola 2L");
            cbobebida2.Items.Add("Fanta 2L");
            cbobebida2.Items.Add("Guarana Antartica 2L");
            cbobebida2.Items.Add("Pepsi 2L");

            cbobebida3.Items.Clear();
            cbobebida3.Items.Add("Coca-Cola 2L");
            cbobebida3.Items.Add("Fanta 2L");
            cbobebida3.Items.Add("Guarana Antartica 2L");
            cbobebida3.Items.Add("Pepsi 2L");

            txttotalpagar.Clear();
        }

        private void txtqtd1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbosabor1.Items.Clear();
            cbosabor1.Items.Add("Mussarela");
            cbosabor1.Items.Add("Portuguesa");
            cbosabor1.Items.Add("Frango com catupiry");
            cbosabor1.Items.Add("Calabresa");

            cbosabor2.Items.Clear();
            cbosabor2.Items.Add("Mussarela");
            cbosabor2.Items.Add("Portuguesa");
            cbosabor2.Items.Add("Frango com catupiry");
            cbosabor2.Items.Add("Calabresa");

            cbosabor3.Items.Clear();
            cbosabor3.Items.Add("Mussarela");
            cbosabor3.Items.Add("Portuguesa");
            cbosabor3.Items.Add("Frango com catupiry");
            cbosabor3.Items.Add("Calabresa");

            cbosabor4.Items.Clear();
            cbosabor4.Items.Add("Mussarela");
            cbosabor4.Items.Add("Portuguesa");
            cbosabor4.Items.Add("Frango com catupiry");
            cbosabor4.Items.Add("Calabresa");

            cbosabor5.Items.Clear();
            cbosabor5.Items.Add("Mussarela");
            cbosabor5.Items.Add("Portuguesa");
            cbosabor5.Items.Add("Frango com catupiry");
            cbosabor5.Items.Add("Calabresa");

            cbobebida1.Items.Clear();
            cbobebida1.Items.Add("Coca-Cola 2L");
            cbobebida1.Items.Add("Fanta 2L");
            cbobebida1.Items.Add("Guarana Antartica 2L");
            cbobebida1.Items.Add("Pepsi 2L");

            cbobebida2.Items.Clear();
            cbobebida2.Items.Add("Coca-Cola 2L");
            cbobebida2.Items.Add("Fanta 2L");
            cbobebida2.Items.Add("Guarana Antartica 2L");
            cbobebida2.Items.Add("Pepsi 2L");

            cbobebida3.Items.Clear();
            cbobebida3.Items.Add("Coca-Cola 2L");
            cbobebida3.Items.Add("Fanta 2L");
            cbobebida3.Items.Add("Guarana Antartica 2L");
            cbobebida3.Items.Add("Pepsi 2L");
        }

        private void lstresumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtqtd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtqtd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtqtd3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtqtd4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtqtd5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtqtdbeb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtqtdbeb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtqtdbeb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqtdbeb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
