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
        
        string[] a = File.ReadAllLines("tab.txt");
        int posx1;
        int selectedY = 1;
        int selectedX = 20;
        List<string[]> backup = new List<string[]>();

        private void Form1_Load(object sender, EventArgs e)
        {
            posx1 = 234 + 12;
            SelectLabel();
            LoadStrings();
            this.Focus();
        }
        private void LoadStrings()
        {
            label1.Text = a[0].Substring(0, selectedX);
            label2.Text = a[0].Substring(selectedX, 1);
            label3.Text = a[0].Substring(selectedX + 1);

            label4.Text = a[1].Substring(0, selectedX);
            label5.Text = a[1].Substring(selectedX, 1);
            label6.Text = a[1].Substring(selectedX + 1);

            label7.Text = a[2].Substring(0, selectedX);
            label8.Text = a[2].Substring(selectedX, 1);
            label9.Text = a[2].Substring(selectedX + 1);

            label10.Text = a[3].Substring(0, selectedX);
            label11.Text = a[3].Substring(selectedX, 1);
            label12.Text = a[3].Substring(selectedX + 1);

            label13.Text = a[4].Substring(0, selectedX);
            label14.Text = a[4].Substring(selectedX, 1);
            label15.Text = a[4].Substring(selectedX + 1);

            label16.Text = a[5].Substring(0, selectedX);
            label17.Text = a[5].Substring(selectedX, 1);
            label18.Text = a[5].Substring(selectedX + 1);

            label1.Location = new Point(posx1 - 11 * label1.Text.Length, label1.Location.Y);
            label4.Location = new Point(posx1 - 11 * label1.Text.Length, label4.Location.Y);
            label7.Location = new Point(posx1 - 11 * label1.Text.Length, label7.Location.Y);
            label10.Location = new Point(posx1 - 11 * label1.Text.Length, label10.Location.Y);
            label13.Location = new Point(posx1 - 11 * label1.Text.Length, label13.Location.Y);
            label16.Location = new Point(posx1 - 11 * label1.Text.Length, label16.Location.Y);
            TempSave();
                }

        private void SelectLabel()
        {
            label17.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            switch (selectedY)
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
            string temp = a[1];
            if (e.KeyCode == Keys.Up)
                if (selectedY< 6)
                    selectedY++;
            if (e.KeyCode == Keys.Down)
                if (selectedY> 1)
                    selectedY--;
            if ((e.KeyCode == Keys.Right)&&(selectedX < a[0].Length-2))
            {
                selectedX++;
                if (temp[selectedX] == '|')
                {
                    selectedX++;
                }
            }
            
            else if ((e.KeyCode == Keys.Left)&&(selectedX > 0))
            {
                selectedX--;
                if (temp[selectedX] == '|')
                {
                    selectedX--;
                }
            }
            LoadStrings();

            SelectLabel();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            a[6-selectedY] = a[6-selectedY].Remove(selectedX, 1);
            a[6-selectedY] = a[6-selectedY].Insert(selectedX, c.ToString());
            LoadStrings();
        }

        private void TempSave()
        {
            int count = 0;
            backup.Add(a);
            if (backup.Count > 1)
            {
                for (int i = 0; i < length; i++)
                {

                }
                    File.WriteAllLines("backup.txt", backup[backup.Count - 2]);
            }
            
            
        }

        private void Label19_Click(object sender, EventArgs e)
        {
            a = backup[backup.Count - 2];
            LoadStrings();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
