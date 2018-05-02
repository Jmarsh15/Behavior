using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Behavior
{
    public partial class Form2 : Form
    {
        Form1 ths;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ths = frm;
        }
    }
}
