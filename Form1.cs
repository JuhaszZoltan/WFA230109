namespace WFA230109
{
    public partial class Form1 : Form
    {
        public UCFirst ucLogIn { get; set; }
        public Form1()
        {
            InitializeComponent();
            ucLogIn = new UCFirst(this);
            Controls.Add(ucLogIn);
        }
    }
}