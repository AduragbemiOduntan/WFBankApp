using WFBankApp.Core.Abstraction;

namespace WFBankAppPresentation
{
    public partial class Form1 : Form
    {
        BindingSource _bindingAccounts;
        IServiceManager _serviceManager;

        public Form1(IServiceManager serviceManager)
        {
            _bindingAccounts = new BindingSource();
            _serviceManager = serviceManager;
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void recieverAcctNumText_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startHereButton_Click(object sender, EventArgs e)
        {
            registerLoginPanel.Show();
        }
    }
}