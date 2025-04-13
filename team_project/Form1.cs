using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_project
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		private void Form1_Load(object sender, EventArgs e)
		{
			PrivateFontCollection privateFontCollection = new PrivateFontCollection();
			privateFontCollection.AddFontFile("thuluth.ttf");
			FontFamily ff = privateFontCollection.Families[0];
			label3.Font = new Font(ff, 14);
			label5.Font = new Font(ff, 14);
		}
		private void label2_Click(object sender, EventArgs e)
		{
			
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			using (Pen pen = new Pen(Color.Black, 1))
			{
				e.Graphics.DrawLine(pen, 0.0f, 0.0f, 300.0f, 0.0f);
				e.Graphics.DrawLine(pen, 300.0f, 0.0f, 350.0f, 50f);
				e.Graphics.DrawLine(pen, 350f, 50f, 530f, 50f);
				e.Graphics.DrawLine(pen, 530f, 50f, 580f, 0f);
				e.Graphics.DrawLine(pen, 580f, 0f, 1000, 0f);
			}
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == "Software departement")
			{
				label4.Text = "Software Departement";
				label17.Text = "قسم البرمجيات";
				label15.Text = "ا.م.د.سرى زكي جاسم";
				label16.Text = "رئيس قسم البرمجيات";
			} 
			if (comboBox1.SelectedItem == "Cybersecuirty deparetement")
			{
				label4.Text = "Cybersecurity Departement";
				label17.Text = "قسم الامن السيبراني";
				label15.Text = "أ.م.د.احمد خلفه عبيد";
				label16.Text = "رئيس قسم الامن السيبراني";
			}
			if (comboBox1.SelectedItem == "networks departement")
			{
				label4.Text = "Networks Departememnt";
				label17.Text = "قسم الشبكات";
				label15.Text = "أ.م.د.الحارث عبد الكريم عبد الله";
				label16.Text = "رئيس قسم الشبكات";
			}
		}
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			using (Pen pen = new Pen(Color.Black, 1))
			{
				e.Graphics.DrawLine(pen, 0.0f, 30.0f, 100.0f, 30.0f);
				e.Graphics.DrawLine(pen, 100.0f, 30.0f, 125.0f, 0f);
				e.Graphics.DrawLine(pen, 125f, 0f, 325f, 0f);
				e.Graphics.DrawLine(pen, 325f, 0f, 350f, 30f);
				e.Graphics.DrawLine(pen, 350f, 30f, 450f, 30f);
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			textBox7.Text = textBox2.Text;
			textBox8.Text = textBox2.Text;
			textBox10.Text = textBox2.Text;
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox7.Text;
			textBox8.Text = textBox7.Text;
			textBox10.Text = textBox7.Text;
		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox8.Text;
			textBox7.Text = textBox8.Text;
			textBox10.Text = textBox8.Text;
		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox10.Text;
			textBox7.Text = textBox10.Text;
			textBox8.Text = textBox10.Text;
		}
	}
}
