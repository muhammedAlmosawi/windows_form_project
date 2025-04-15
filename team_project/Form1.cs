using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
		Boolean software_check = false;
		Boolean security_check = false;
		Boolean network_check = false;
		SqlConnection sql_connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My-Github\windows_form_project\team_project\Database1.mdf;Integrated Security=True");
		private void Form1_Load(object sender, EventArgs e)
		{
			DateTime date = DateTime.Now;
			PrivateFontCollection privateFontCollection = new PrivateFontCollection();
			privateFontCollection.AddFontFile("thuluth.ttf");
			FontFamily ff = privateFontCollection.Families[0];
			label3.Font = new Font(ff, 14);
			label5.Font = new Font(ff, 14);
			textBox2.Text = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();
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
				e.Graphics.DrawLine(pen, 580f, 0f, 880, 0f);
			}
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTime date = DateTime.Now;
			String current_date = date.ToString("dd-MM-YYYY");
			if (comboBox1.SelectedItem.Equals("Software departement"))
			{
				label4.Text = "Software Departement";
				label17.Text = "قسم البرمجيات";
				label15.Text = "ا.م.د.سرى زكي جاسم";
				label16.Text = "رئيس قسم البرمجيات";
				software_check = true;
				sql_connection.Open();
				SqlCommand sqlCommand = new SqlCommand("insert into software values (@Date, ' ', ' ', ' ',' ')", sql_connection);
				sqlCommand.Parameters.AddWithValue("@Date", date);
				sqlCommand.ExecuteNonQuery();
				SqlCommand command = new SqlCommand("select id_soft from software", sql_connection);
				textBox1.Text = command.ExecuteScalar().ToString();
				sql_connection.Close();
			} 
			if (comboBox1.SelectedItem.Equals("Cybersecurity deparetement"))
			{
				label4.Text = "Cybersecurity Departement";
				label17.Text = "قسم الامن السيبراني";
				label15.Text = "أ.م.د.احمد خلفه عبيد";
				label16.Text = "رئيس قسم الامن السيبراني";
				security_check = true;
				sql_connection.Open();
				SqlCommand sqlCommand = new SqlCommand("insert into security values (@Date, ' ', ' ', ' ',' ')", sql_connection);
				sqlCommand.Parameters.AddWithValue("@Date", date);
				sqlCommand.ExecuteNonQuery();
				SqlCommand command = new SqlCommand("select id_sec from security", sql_connection);
				textBox1.Text = command.ExecuteScalar().ToString();
				sql_connection.Close();
			}
			if (comboBox1.SelectedItem.Equals("Networks departement"))
			{
				label4.Text = "Networks Departememnt";
				label17.Text = "قسم الشبكات";
				label15.Text = "أ.م.د.الحارث عبد الكريم عبد الله";
				label16.Text = "رئيس قسم الشبكات";
				network_check = true;
				sql_connection.Open();
				SqlCommand sqlCommand = new SqlCommand("insert into network values (@Date, ' ', ' ', ' ',' ')", sql_connection);
				sqlCommand.Parameters.AddWithValue("@Date", date);
				sqlCommand.ExecuteNonQuery();
				SqlCommand command = new SqlCommand("select id_net from network", sql_connection);
				textBox1.Text = command.ExecuteScalar().ToString();
				sql_connection.Close();
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
			textBox12.Text = textBox2.Text;
			textBox8.Text = textBox2.Text;
			textBox10.Text = textBox2.Text;

			sql_connection.Open();

			if (software_check)
			{
				SqlCommand sql = new SqlCommand("update date set '" + textBox2.Text + "' from software where id_soft like " + int.Parse(textBox1.Text), sql_connection);
				sql.ExecuteNonQuery();
			}
			else if (security_check)
			{
				SqlCommand sql = new SqlCommand("update date set '" + textBox2.Text + "' from security where id_sec like " + int.Parse(textBox1.Text), sql_connection);
				sql.ExecuteNonQuery();
			}
			else if (network_check)
			{
				SqlCommand sql = new SqlCommand("update date set '" + textBox2.Text + "' from network where id_net like " + int.Parse(textBox1.Text), sql_connection);
				sql.ExecuteNonQuery();
			}

			sql_connection.Close();
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox8.Text;
			textBox12.Text = textBox8.Text;
			textBox10.Text = textBox8.Text;
		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox10.Text;
			textBox8.Text = textBox10.Text;
			textBox12.Text = textBox10.Text;
		}

		private void textBox12_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox12.Text;
			textBox8.Text = textBox12.Text;
			textBox10.Text = textBox12.Text;
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			sql_connection.Open();
			if (software_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update software set addressing = '" + textBox3.Text + "' where id_soft like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (security_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update security set addressing = '" + textBox3.Text + "' where id_sec like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (network_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update network set addressing = '" + textBox3.Text + "' where id_net like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			sql_connection.Close();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			sql_connection.Open();
			if (software_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update software set subject = '" + textBox4.Text + "'  where id_soft like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (security_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update security set subject = '" + textBox4.Text + "'  where id_sec like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (network_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update network set subject = '" + textBox4.Text + "'  where id_net like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			sql_connection.Close();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			sql_connection.Open();
			if (software_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update software set context = '" + textBox5.Text + "' where id_soft like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (security_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update security set context = '" + textBox5.Text + "' where id_sec like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (network_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update network set context = '" + textBox5.Text + "' where id_net like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			sql_connection.Close();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			sql_connection.Open();
			if (software_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update software set attachments = '" + textBox6.Text + "' where id_soft like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (security_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update security set attachments = '" + textBox6.Text + "'  where id_sec like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			if (network_check)
			{
				SqlCommand sqlCommand = new SqlCommand("update network set attachments = '" + textBox6.Text + "' where id_net like " + int.Parse(textBox1.Text), sql_connection);
				sqlCommand.ExecuteNonQuery();
			}
			sql_connection.Close();
		}
	}
}
