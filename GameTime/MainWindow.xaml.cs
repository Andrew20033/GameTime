using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace GameTime
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private UserData userData;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username
        {
            get { return userData?.Username; }
            set
            {
                if (userData != null)
                {
                    userData.Username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get { return userData?.Password; }
            set
            {
                if (userData != null)
                {
                    userData.Password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            LoadUserData();
            DataContext = this;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadUserData()
        {
            string filePath = "userdata.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        userData = (UserData)formatter.Deserialize(fs);
                    }
                }
                catch
                {
                    userData = new UserData();
                }
            }
            else
            {
                userData = new UserData();
            }
        }

        private void SaveUserData()
        {
            string filePath = "userdata.txt";

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, userData);
                }
            }
            catch
            {
                MessageBox.Show("Failed to save user data.");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(passwordBox.Password))
            {
                userData.Username = usernameTextBox.Text;
                userData.Password = passwordBox.Password;
                SaveUserData();

                MessageBox.Show("Registration successful!");           
                LaunchMainProgram();
            }
            else
            {
                MessageBox.Show("Please enter a username and password.");
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(passwordBox.Password))
            {
                if (userData.Username == usernameTextBox.Text && userData.Password == passwordBox.Password)
                {
                    MessageBox.Show("Login successful!");

                   
                    LaunchMainProgram();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and password.");
            }
        }

        private void LaunchMainProgram()
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();

   
            Close();
        }
    }

    [System.Serializable]
    public class UserData
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}