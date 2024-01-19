using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__OOP_HW014_WinForms_FuelCalc_r00
{
    partial class FuelCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.consumeLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.resultcalc_infoLabel = new System.Windows.Forms.Label();
            this.resultcalcLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.topPanel.Controls.Add(this.closeLabel);
            this.topPanel.Controls.Add(this.priceLabel);
            this.topPanel.Controls.Add(this.consumeLabel);
            this.topPanel.Controls.Add(this.distanceLabel);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(801, 164);
            this.topPanel.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(576, 41);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(181, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Стоимость 1л топлива, грн";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consumeLabel
            // 
            this.consumeLabel.AutoSize = true;
            this.consumeLabel.Location = new System.Drawing.Point(250, 41);
            this.consumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.consumeLabel.Name = "consumeLabel";
            this.consumeLabel.Size = new System.Drawing.Size(165, 16);
            this.consumeLabel.TabIndex = 2;
            this.consumeLabel.Text = "Расход толива на 100 км";
            this.consumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.consumeLabel.Click += new System.EventHandler(this.consumeLabel_Click);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(12, 41);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(164, 16);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Расстояние поездки, км";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.bottomPanel.Controls.Add(this.resultcalc_infoLabel);
            this.bottomPanel.Location = new System.Drawing.Point(0, 212);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(801, 53);
            this.bottomPanel.TabIndex = 1;
            // 
            // resultcalc_infoLabel
            // 
            this.resultcalc_infoLabel.AutoSize = true;
            this.resultcalc_infoLabel.Location = new System.Drawing.Point(12, 11);
            this.resultcalc_infoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.resultcalc_infoLabel.Name = "resultcalc_infoLabel";
            this.resultcalc_infoLabel.Size = new System.Drawing.Size(37, 16);
            this.resultcalc_infoLabel.TabIndex = 0;
            this.resultcalc_infoLabel.Text = "label";
            this.resultcalc_infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultcalcLabel
            // 
            this.resultcalcLabel.AutoSize = true;
            this.resultcalcLabel.Location = new System.Drawing.Point(12, 178);
            this.resultcalcLabel.Margin = new System.Windows.Forms.Padding(0);
            this.resultcalcLabel.Name = "resultcalcLabel";
            this.resultcalcLabel.Size = new System.Drawing.Size(143, 16);
            this.resultcalcLabel.TabIndex = 2;
            this.resultcalcLabel.Text = "Результаты расчёта";
            this.resultcalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLabel.BackColor = System.Drawing.Color.Red;
            this.closeLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(757, 0);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(44, 44);
            this.closeLabel.TabIndex = 4;
            this.closeLabel.Text = "X";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click_1);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            this.closeLabel.MouseHover += new System.EventHandler(this.closeLabel_MouseHover);
            // 
            // FuelCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.resultcalcLabel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FuelCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Calculation";
            this.Load += new System.EventHandler(this.FuelCalc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FuelCalc_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FuelCalc_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FuelCalc_MouseMove);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel topPanel;
        private Panel bottomPanel;
        private Label resultcalcLabel;
        private Label priceLabel;
        private Label consumeLabel;
        private Label distanceLabel;
        private Label resultcalc_infoLabel;
        private Label closeLabel;
    }
}

