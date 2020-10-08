using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionApplication
{
    public partial class Form1 : Form
    {

        private ArrayList fruitList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fruitList = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fruitText = textBox1.Text;
            fruitList.Add(fruitText);

            listBox1.Items.Clear();

            foreach (String item in fruitList) {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fruitText = listBox1.SelectedItem.ToString();

            fruitList.Remove(fruitText);

            listBox1.Items.Remove(fruitText);

            }
        }
    }



