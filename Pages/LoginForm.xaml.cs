using BookApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        private UserService _userService = new UserService();

        private bool _hasCaptchaPassed = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool ValidateCaptcha()
        {
            bool result = Var.f == textBox1.Text;

            return result;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this._hasCaptchaPassed = false;

            String allowchar = " ";

            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";

            allowchar += "1,2,3,4,5,6,7,8,9,0";

            char[] a = { ',' };

            String[] ar = allowchar.Split(a);

            String pwd = "";

            string temp = "";

            Random r = new Random();



            for (int i = 0; i < 6; i++)

            {

                temp = ar[(r.Next(0, ar.Length))];



                pwd += temp;

            }



            Texos.Content = pwd;
            Var.f = pwd;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!this.ValidateCaptcha())
            {
                MessageBox.Show("неправильно, переделывай");
                return;
            }

            if (!this._hasCaptchaPassed)
            {
                MessageBox.Show("Молодец, капча верная");
                this._hasCaptchaPassed = true;
            }

            // Пробуем найти пользователя по логину
            try
            {
                string login = LoginInput.Text;
                string password = PasswordInput.Text;

                if (login.Length == 0 || password.Length == 0)
                {
                    MessageBox.Show("Все поля должны быть заполненными.");
                    return;
                }

                var user = this._userService.GetUser(login, password);

                MessageBox.Show($"Добро пожаловать, {user.UserLogin}");
            }
            catch (Exception ex) // Если не получается найти пользователя, значит данные неверные
            {
                MessageBox.Show("Неверные данные!");
                return;
            }
        }
    }
}
