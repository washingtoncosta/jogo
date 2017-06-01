using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {

        bool x = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button11.Click += new EventHandler(buttonClick);
            button12.Click += new EventHandler(buttonClick);
            button13.Click += new EventHandler(buttonClick);
            button21.Click += new EventHandler(buttonClick);
            button22.Click += new EventHandler(buttonClick);
            button23.Click += new EventHandler(buttonClick);
            button31.Click += new EventHandler(buttonClick);
            button32.Click += new EventHandler(buttonClick);
            button33.Click += new EventHandler(buttonClick);

            foreach (Control item in this.Controls)
            {

                if (item is Button)
                {

                    item.TabStop = false;
                }
            }


        }

        private void buttonClick(object sender, EventArgs e)
        {

            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void Ganhador()
        {
            if (

                    button11.Text != String.Empty && button11.Text == button12.Text && button12.Text == button13.Text ||
                    button21.Text != String.Empty && button21.Text == button22.Text && button22.Text == button23.Text ||
                    button31.Text != String.Empty && button31.Text == button32.Text && button32.Text == button33.Text ||

                    button11.Text != String.Empty && button11.Text == button21.Text && button21.Text == button31.Text ||
                    button12.Text != String.Empty && button12.Text == button22.Text && button22.Text == button32.Text ||
                    button13.Text != String.Empty && button13.Text == button23.Text && button23.Text == button33.Text ||

                    button11.Text != String.Empty && button11.Text == button22.Text && button22.Text == button33.Text ||
                    button13.Text != String.Empty && button13.Text == button22.Text && button22.Text == button31.Text
                )
            {
                MessageBox.Show(String.Format("Ganhador é o [{0}]", x ? "x" : "O"), " Parabens ao Ganhador", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Recomecar();

            }
            else
            {
                Empate();
            }


        }

        private void Recomecar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {

                    item.Enabled = true;
                    item.Text = String.Empty;
                }
            }

        }

        private void Empate()
        {
            bool desabilitados = true;

            foreach (Control item in this.Controls)
            {

                if (item is Button && item.Enabled)
                {
                    desabilitados = false;
                    break;
                }
            }
            if (desabilitados)
            {
                MessageBox.Show(String.Format("Empate"), "Empate", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Recomecar();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;

            Ganhador();

            x = !x;

            lb1.Text = String.Format("{0}, sua vez", this.x ? "x" : "O");
        }
    }


}