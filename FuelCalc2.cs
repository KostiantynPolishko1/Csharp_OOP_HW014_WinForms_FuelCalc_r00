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

            //set position of labels
            int space = 15;
            consumeLabel.Location = new Point((int)(Size.Width - consumeLabel.Width) / 2, space);
            distanceLabel.Location = new Point(consumeLabel.Location.X - distanceLabel.Width - 15, space);
            priceLabel.Location = new Point(consumeLabel.Location.X + consumeLabel.Width + 15, space);

            //set position of textbox
            int space2 = 10;
            distanceTB.Location = new Point(distanceLabel.Location.X + (distanceLabel.Width - distanceTB.Width)/2, distanceLabel.Location.Y + distanceTB.Height + space2);
            consumeTB.Location = new Point(consumeLabel.Location.X + (consumeLabel.Width - consumeTB.Width)/2, consumeLabel.Location.Y + consumeTB.Height + space2);
            priceTB.Location = new Point(priceLabel.Location.X + (priceLabel.Width - priceTB.Width)/2, priceLabel.Location.Y + priceTB.Height + space2);

            //set position of button
            int space3 = 0;
            calcBtn.Location = new Point(distanceLabel.Location.X + (distanceLabel.Width - calcBtn.Width) / 2, distanceTB.Location.Y + calcBtn.Height + space3);
            clearBtn.Location = new Point(consumeLabel.Location.X + (consumeLabel.Width - clearBtn.Width) / 2, consumeTB.Location.Y + clearBtn.Height + space3);
            saveBtn.Location = new Point(priceLabel.Location.X + (priceLabel.Width - saveBtn.Width) / 2, priceTB.Location.Y + saveBtn.Height + space3);
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
