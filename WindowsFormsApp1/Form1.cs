using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int key = 3; // La chiave per la criptazione.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaintext = richTextBox1.Text;
            string ciphertext = Encrypt(plaintext);
            richTextBox2.Text = ciphertext;
            MessageBox.Show("Message Encrypted!");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ciphertext = richTextBox3.Text;
            string plaintext = Decrypt(ciphertext);
            richTextBox4.Text = plaintext;
            MessageBox.Show("Message Decrypted!");
        }

        private string Encrypt(string plaintext)
        {
            string ciphertext = "";
            foreach (char c in plaintext)
            {
                if (c >= 'a' && c <= 'z')
                {
                    ciphertext += (char)('a' + (c - 'a' + key) % 26);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    ciphertext += (char)('A' + (c - 'A' + key) % 26);
                }
                else
                {
                    ciphertext += c;
                }
            }
            return ciphertext;
        }

        private string Decrypt(string ciphertext)
        {
            string plaintext = "";
            foreach (char c in ciphertext)
            {
                if (c >= 'a' && c <= 'z')
                {
                    plaintext += (char)('a' + (c - 'a' - key + 26) % 26);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    plaintext += (char)('A' + (c - 'A' - key + 26) % 26);
                }
                else
                {
                    plaintext += c;
                }
            }
            return plaintext;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}