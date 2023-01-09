using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230109
{
    public partial class UCFirst : UserControl
    {
        public Form1 MainForm { get; set; }

        public bool Success { get; private set; }
        public UCFirst(Form1 mainForm)
        {
            InitializeComponent();
            btnLogIn.Click += OnLogInButtonClick;
            MainForm = mainForm;
        }

        private void OnLogInButtonClick(object? sender, EventArgs e)
        {
            //autentikáció
            //...
            // if sikeres:
            Success = true;

            MainForm.Controls.Remove(MainForm.ucLogIn);
            
            MainForm.Controls.Add(new UCSecond());
        }
    }
}
