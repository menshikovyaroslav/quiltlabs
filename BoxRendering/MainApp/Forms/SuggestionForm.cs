using System;
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
        public SuggestionForm(double inputFigure)
        {
            InitializeComponent();

            figureLabel.Text = inputFigure.ToString();
        }
    }
}
