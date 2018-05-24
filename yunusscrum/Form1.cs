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
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            String metin = txtstory.Text.ToString() + txttask.Text.ToString() + txtDate.Text.ToString();
            liststory.Items.Add(metin);
        }
        private void liststory_DragDrop(object sender, DragEventArgs e)
        {
            liststory.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void liststory_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void liststory_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = liststory.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                liststory.DoDragDrop(liststory.Items[p], DragDropEffects.All);
                liststory.Items.Remove(liststory.SelectedItem);

            }

        }

        private void listnotstarted_DragDrop(object sender, DragEventArgs e)
        {
            listnotstarted.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listnotstarted_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = listnotstarted.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                listnotstarted.DoDragDrop(listnotstarted.Items[p], DragDropEffects.All);
                listnotstarted.Items.Remove(listnotstarted.SelectedItem);

            }
        }

        private void listnotstarted_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listinprogress_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = listinprogress.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                listinprogress.DoDragDrop(listinprogress.Items[p], DragDropEffects.All);
                listinprogress.Items.Remove(listinprogress.SelectedItem);

            }
        }

        private void listinprogress_DragDrop(object sender, DragEventArgs e)
        {
            listinprogress.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listinprogress_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listdone_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listdone_DragDrop(object sender, DragEventArgs e)
        {
            listdone.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listdone_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            int p = listdone.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && p != -1)
            {

                listdone.DoDragDrop(listdone.Items[p], DragDropEffects.All);
                listdone.Items.Remove(listdone.SelectedItem);

            }
        }


    }
}
