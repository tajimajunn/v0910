﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0910
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        const int ChrMax = 100;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        Label[] labels = new Label[100];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < ChrMax; i++)
            {
                vx[i] = rand.Next(-15, 16);
                vy[i] = rand.Next(-15, 16);
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "★";
                Controls.Add(labels[i]);
                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ChrMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]) * 11 / 10;
                }

                if (labels[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]) * 11 / 10;

                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]) * 11 / 10;
                }

                if (labels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]) * 11 / 10;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                if (i == 5)
                {
                    break;
                }

                MessageBox.Show("" + i);
            }
        }
            
        }
    }

