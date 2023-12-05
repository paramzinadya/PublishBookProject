using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Book book = new Book();
        List<Book> library = new List<Book>();
        public Form1()
        {
            Book book = new Book();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            book.Author = textBox1.Text;
            book.Title = textBox2.Text;
            book.Publisher = textBox3.Text;
            book.Type = textBox10.Text;
            book.Isbn = maskedTextBox1.Text;
            book.Year = Convert.ToInt32(maskedTextBox2.Text);

            if (book.PublishBook(book.Publisher, book.Year, book.Isbn)) library.Add(book);
            label9.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            textBox7.Visible = true;
            label12.Visible = true;
            textBox6.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            button6.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
            textBox8.Visible = true;
            label14.Visible = true;
            textBox9.Visible = true;
            button3.Visible = false;
            button7.Visible = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            richTextBox1.Visible = true;
            foreach (var elem in library) richTextBox1.Text = elem.ToString(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            book.AddChapter(new Chapter(textBox4.Text, Convert.ToInt32(textBox5.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            book.AddChapter(new Chapter(textBox7.Text, Convert.ToInt32(textBox6.Text)));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            book.AddChapter(new Chapter(textBox9.Text, Convert.ToInt32(textBox8.Text)));
        }
    }
}
