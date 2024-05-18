using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace BalancaToledo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Declaração de variáveis globais
        double peso_min, peso_max, peso_produto, tara;
        bool config;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            config = false;
            lblPesoProduto.Visible = false;
            btnPesoProdutoIncrease.Visible = false;
            btnPesoProdutoDecrease.Visible = false;
            lblPesoProdutoValue.Visible = false;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tara >= 0)
            {
                tara -= 0.1;
                lblTaraValue.Text = tara.ToString();
            }
            else 
            {
                lblTaraValue.Text = "0";
            }
                  
        }

        private void btnPesoMinimoIncrease_Click(object sender, EventArgs e)
        {
            peso_min += 1;
            lblPesoMinimoValue.Text = peso_min.ToString();
        }

        private void btnPesoMinimoDecrease_Click(object sender, EventArgs e)
        {
            if (peso_min > 0)
            {
                peso_min -= 1;
                lblPesoMinimoValue.Text = peso_min.ToString();
            }
            else 
            {
                lblPesoMinimoValue.Text = "0";
            }
        }

        private void btnPesoMaximoIncrease_Click(object sender, EventArgs e)
        {
            peso_max += 1;
            lblPesoMaximoValue.Text = peso_max.ToString();
        }

        private void btnPesoMaximoDecrease_Click(object sender, EventArgs e)
        {
            if (peso_max > 0) 
            {
                peso_max -= 1;
                lblPesoMaximoValue.Text = peso_max.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            while (config == false)
            {
                if (peso_min > 0 && peso_max > 0 && tara > 0)
                {
                    if (tara < peso_min && tara < peso_max)
                    {
                        if (peso_max > peso_min)
                        {
                            config = true;
                            
                            if (config == true) 
                            {
                                MessageBox.Show("Pronto, as tolerâncias foram definidas. Agora insira o peso do produto.");
                                lblPesoProduto.Visible = true;
                                btnPesoProdutoIncrease.Visible = true;
                                btnPesoProdutoDecrease.Visible = true;
                                lblPesoProdutoValue.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("OPS! Não faz sentido o valor de peso máximo ser menor que o de peso mínimo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("OPS! O valor da tara não deveria ser maior do que as tolerâncias.");
                    }
                }
                else
                {
                    MessageBox.Show("OPS! Os valores inseridos não são válidos, torne-os maior que 0.");
                }
            }
        }

        private void lblPesoMaximo_Click(object sender, EventArgs e)
        {

        }

        private void lblPesoMaximoValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            if (peso_produto > tara)
            {
                if (peso_min < peso_produto && peso_produto < peso_max)
                {
                    MessageBox.Show("O produto está dentro das tolerâncias definidas, portanto, está aprovado e pode prosseguir.");
                }
                else
                {
                    MessageBox.Show("O produto está fora das tolerâncias definidas, portanto, está reprovado e deve ir para manutenção.");
                }
            }
            else
            {
                MessageBox.Show("A peça inserida não é válida! Tente inserir uma nova peça.");
            }
            peso_produto = 0;
            peso_min = 0;
            peso_max = 0;
            tara = 0;
            lblTaraValue.Text = tara.ToString();
            lblPesoMinimoValue.Text = peso_min.ToString();
            lblPesoMaximoValue.Text = peso_max.ToString();
            lblPesoProdutoValue.Text = peso_produto.ToString();
        }

        private void btnPesoProdutoIncrease_Click(object sender, EventArgs e)
        {
            peso_produto += 1;
            lblPesoProdutoValue.Text = peso_produto.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesoProdutoDecrease_Click(object sender, EventArgs e)
        {
            if (peso_produto > 0)
            {
                peso_produto -= 1;
                lblPesoProdutoValue.Text = peso_produto.ToString();
            }
            else 
            {
                lblPesoProdutoValue.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tara += 0.1;
            lblTaraValue.Text = tara.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
