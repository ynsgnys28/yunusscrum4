using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yunusscrum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String metin = textBox1.Text.ToString();
            listBox1.Items.Add(metin);
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = listBox1.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                listBox1.DoDragDrop(listBox1.Items[p], DragDropEffects.All);
                listBox1.Items.Remove(listBox1.SelectedItem);

            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
          
            listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = listBox2.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                listBox2.DoDragDrop(listBox2.Items[p], DragDropEffects.All);
                listBox2.Items.Remove(listBox2.SelectedItem);

            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = listBox3.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                listBox3.DoDragDrop(listBox3.Items[p], DragDropEffects.All);
                listBox3.Items.Remove(listBox3.SelectedItem);

            }
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
           
            listBox3.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox3_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox4_DragOver(object sender, DragEventArgs e)
        {
            
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox4_DragDrop(object sender, DragEventArgs e)
        {
            listBox4.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = listBox4.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                listBox4.DoDragDrop(listBox4.Items[p], DragDropEffects.All);
                listBox4.Items.Remove(listBox4.SelectedItem);

            }
        }

        private void dasd(object sender, EventArgs e)
        {

        }
    }
}
