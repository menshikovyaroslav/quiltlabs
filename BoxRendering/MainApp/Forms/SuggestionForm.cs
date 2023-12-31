﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp.Forms
{
    public partial class SuggestionForm : Form
    {
        /// <summary>
        /// Create form using a figure
        /// ToDo: change figure if it needs
        /// </summary>
        /// <param name="inputFigure">Convey figure into the suggestion form</param>
        public SuggestionForm(double inputFigure)
        {
            InitializeComponent();

            figureLabel.Text = inputFigure.ToString();
        }

        #region Window preferences

        private const int WM_MOUSEACTIVATE = 0x0021, MA_NOACTIVATE = 0x0003;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEACTIVATE)
            {
                m.Result = (IntPtr)MA_NOACTIVATE;
                return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        #endregion
    }
}
