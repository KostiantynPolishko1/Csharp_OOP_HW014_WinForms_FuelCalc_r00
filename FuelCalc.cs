using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__OOP_HW014_WinForms_FuelCalc_r00
{
    public partial class FuelCalc : Form
    {
        private Point lastMousePosition;
        public FuelCalc()
        {
            InitializeComponent();

            topPanel.Dock = DockStyle.Top;
            topPanel.Height = (int)(Size.Height) / 2 + 20;

            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = (int)(Size.Height) / 6;

            InitializeCustomComponent();
        }

        private void FuelCalc_Load(object sender, EventArgs e)
        {

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FuelCalc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastMousePosition.X;
                Top += e.Y - lastMousePosition.Y;
            }
        }

        private void FuelCalc_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePosition = new Point(e.X, e.Y);
        }

        private void FuelCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void closeLabel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.DarkRed;
        }

        private void consumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
