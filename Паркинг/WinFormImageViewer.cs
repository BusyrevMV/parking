﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Паркинг
{
    public partial class WinFormImageViewer : Form
    {
        public WinFormImageViewer(Bitmap img)
        {
            InitializeComponent();
            pictureBox1.Image = img;
        }
    }
}
