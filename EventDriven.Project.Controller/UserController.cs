using EventDriven.Project.Model;
using EventDriven.Project.Repository;

namespace EventDriven.Project.Controller
{
    public class UserController
    {
        private UserRepository userRepo;


        public UserController()
        {
            userRepo = new UserRepository();
        }


        public List<User> GetUserList()
        {

            return new List<User> { new User() };
        }


        public User ValidateUser(string Username, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username))
                {
                    throw new Exception("Password/Username cannot be empty.");
                }
                else
                {
                    Console.WriteLine("Login Successful");

                }
            }
            catch (InvalidCastException ex)
            {

                Console.WriteLine(ex.Message);
            }
            return userRepo.ValidateUser(Username, Password);
        }
    }
}





