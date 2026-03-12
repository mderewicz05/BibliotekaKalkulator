using System;
using System.Windows.Forms;
using BibliotekaKalkulator;

namespace KalkulatorG
{
	public partial class Form1 : Form
	{
		Kalkulator k = new Kalkulator();

		public Form1()
		{
			InitializeComponent();
		}

		private bool PobierzLiczby(out double a, out double b)
		{
			bool okA = double.TryParse(textBox1.Text, out a);
			bool okB = double.TryParse(textBox2.Text, out b);

			if (!okA || !okB)
			{
				MessageBox.Show("Wpisz liczby w oba pola.");
				return false;
			}

			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (PobierzLiczby(out double a, out double b))
			{
				textBox3.Text = k.Dodawanie(a, b).ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (PobierzLiczby(out double a, out double b))
			{
				textBox3.Text = k.Odejmowanie(a, b).ToString();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (PobierzLiczby(out double a, out double b))
			{
				textBox3.Text = k.Mnozenie(a, b).ToString();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (PobierzLiczby(out double a, out double b))
			{
				textBox3.Text = k.Dzielenie(a, b).ToString();
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
		}
	}
}