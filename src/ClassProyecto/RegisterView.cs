using ClassController;
using ClassController.Abstractions;
using ClassModels;


namespace ClassProyecto
{
    public partial class RegisterView : Form
    {
        private readonly UserHandler _userHandler;
        

        public RegisterView(UserHandler userHandler)
        {
            InitializeComponent();
            _userHandler = userHandler;
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {

        }
    }
}
