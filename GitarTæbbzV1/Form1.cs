using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using System.Diagnostics;
namespace GitarTæbbzV1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int selected = 1;
        string[] a = File.ReadAllLines("tab.txt");
        int posx1;

        int str1Skille1 = 20;

        private void Form1_Load(object sender, EventArgs e)
        {
            posx1 = 234 + 12;
            SelectLabel();
            LoadStrings();
            
        }
        private void LoadStrings()
        {
            label1.Text = a[0].Substring(0, str1Skille1);
            label2.Text = a[0].Substring(str1Skille1, 1);
            label3.Text = a[0].Substring(str1Skille1 + 1);

            label4.Text = a[1].Substring(0, str1Skille1);
            label5.Text = a[1].Substring(str1Skille1, 1);
            label6.Text = a[1].Substring(str1Skille1 + 1);

            label7.Text = a[2].Substring(0, str1Skille1);
            label8.Text = a[2].Substring(str1Skille1, 1);
            label9.Text = a[2].Substring(str1Skille1 + 1);

            label10.Text = a[3].Substring(0, str1Skille1);
            label11.Text = a[3].Substring(str1Skille1, 1);
            label12.Text = a[3].Substring(str1Skille1 + 1);

            label13.Text = a[4].Substring(0, str1Skille1);
            label14.Text = a[4].Substring(str1Skille1, 1);
            label15.Text = a[4].Substring(str1Skille1 + 1);

            label16.Text = a[5].Substring(0, str1Skille1);
            label17.Text = a[5].Substring(str1Skille1, 1);
            label18.Text = a[5].Substring(str1Skille1 + 1);

            label1.Location = new Point(posx1 - 11 * label1.Text.Length, label1.Location.Y);
            label4.Location = new Point(posx1 - 11 * label1.Text.Length, label4.Location.Y);
            label7.Location = new Point(posx1 - 11 * label1.Text.Length, label7.Location.Y);
            label10.Location = new Point(posx1 - 11 * label1.Text.Length, label10.Location.Y);
            label13.Location = new Point(posx1 - 11 * label1.Text.Length, label13.Location.Y);
            label16.Location = new Point(posx1 - 11 * label1.Text.Length, label16.Location.Y);
        }


        private void SelectLabel()
        {
            label17.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            switch (selected)
            {
                case 1:
                    label17.BackColor = Color.DeepSkyBlue;
                    break;
                case 2:
                    label14.BackColor = Color.DeepSkyBlue;
                    break;
                case 3:
                    label11.BackColor = Color.DeepSkyBlue;
                    break;
                case 4:
                    label8.BackColor = Color.DeepSkyBlue;
                    break;
                case 5:
                    label5.BackColor = Color.DeepSkyBlue;
                    break;
                case 6:
                    label2.BackColor = Color.DeepSkyBlue;
                    break;
            }
        }

        private void KnappTrykk(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                if (selected < 6)
                    selected++;
            if (e.KeyCode == Keys.Down)
                if (selected > 1)
                    selected--;
            if (e.KeyCode == Keys.Right)
                str1Skille1++;
            if (e.KeyCode == Keys.Left)
                str1Skille1--;


            LoadStrings();

            SelectLabel();
        }

    }
}
