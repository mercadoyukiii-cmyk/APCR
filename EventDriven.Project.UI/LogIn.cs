using EventDriven.Project.Controller;
using EventDriven.Project.Model;
using Microsoft.Win32;

namespace EventDriven.Project.UI
{
    public partial class LogIn : Form
    {

        private UserController userController;
        private int Attempts = 0;
        public LogIn()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Attempts >= 3)
            {
                MessageBox.Show("Too many failed attempts");

            }
            else
            {
                try
                {
                    Attempts++;
                    User matchingUser = userController.ValidateUser(txtboxUsername.Text, txtboxPassword.Text);

                    if (matchingUser != null)
                    {
                        Attempts = 0;
                        MessageBox.Show("Welcome " + matchingUser.Role);
                        this.DialogResult = DialogResult.OK; 
                        switch (matchingUser.Role)
                        {
                            case "Admin":
                                AdminDashBoard adminForm = new AdminDashBoard();
                                adminForm.ShowDialog();
                                break;
                            case "FrontDesk1":
                                FrontDeskDashboard receptionistForm1 = new FrontDeskDashboard();
                                receptionistForm1.ShowDialog();
                                break;
                            case "FrontDesk2":
                                FrontDeskDashboard receptionistForm2 = new FrontDeskDashboard();
                                receptionistForm2.ShowDialog();
                                break;
                        }

                        this.Hide();

                    }
                    else throw new Exception("Invalid Credentials");

                }

                catch (Exception EX)
                {


                    MessageBox.Show(EX.Message);
                }

            }
        }
               
    }
}
