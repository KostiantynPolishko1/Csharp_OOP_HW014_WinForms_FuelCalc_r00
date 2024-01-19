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
        private void InitializeCustomComponent()
        {
            resultcalc_infoLabel.Text = 
                $"На поездку потребуется {216.00} л топлива. " +
                $"Она обойдётся в {11880.00} грн.";

            setLabelFontBold(distanceLabel, consumeLabel, priceLabel, resultcalcLabel, resultcalc_infoLabel);
            setLabelFontName(distanceLabel, consumeLabel, priceLabel, resultcalcLabel, resultcalc_infoLabel);

            setLabelFontSize(10, distanceLabel, consumeLabel, priceLabel, resultcalc_infoLabel);
            setLabelFontSize(14, resultcalcLabel);

            consumeLabel.Location = new Point((int)(Size.Width - consumeLabel.Width) / 2, consumeLabel.Location.Y);
            distanceLabel.Location = new Point(consumeLabel.Location.X - distanceLabel.Width - 15, distanceLabel.Location.Y);
            priceLabel.Location = new Point(consumeLabel.Location.X + consumeLabel.Width + 15, distanceLabel.Location.Y);
        }

        private void setLabelFontBold(params Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            { 
                label[i].Font = new Font(label[i].Font.Name, label[i].Font.Size, FontStyle.Bold);
            }
        }

        private void setLabelFontName(params Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                label[i].Font = new Font("Calibri", label[i].Font.Size, label[i].Font.Style);
            }
        }

        private void setLabelFontSize(in int size, params Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                label[i].Font = new Font(label[i].Font.Name, size, label[i].Font.Style);
            }
        }
    }
}
