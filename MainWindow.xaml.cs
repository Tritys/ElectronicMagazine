using ElectronicMagazine.Admin;
using ElectronicMagazine.Student;
using ElectronicMagazine.Teacher;
using ElectronicMagazine.ApplicationData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectronicMagazine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.modelOdb = new ElectronicMagazineEntities();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                // Вывод ошибки
                MessageBox.Show("Ошибка: отсутствует E-mail");
            }
            else if (string.IsNullOrWhiteSpace(PasswordBox1.Password))
            {
                MessageBox.Show("Ошибка: отсутствует пароль");
            }
            else
            {
                try
                {
                    var userObj = AppConnect.modelOdb.User.FirstOrDefault(x => x.Login == TextBox1.Text && x.Password == PasswordBox1.Password);
                    if (userObj == null)
                    {
                        MessageBox.Show("Такого пользователя нет", "Ошибка при авторизации",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        switch (userObj.Role)
                        {
                            case "АдминистраторАдминистратор":
                                MessageBox.Show("Здравствуйте Администратор" + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
                                AppFrame1.Navigate(new Profile());
                                break;

                            case "Преподаватель":
                                MessageBox.Show("Здравствуйте Флорист" + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigationService AppFrame2 = NavigationService.GetNavigationService(this);
                                AppFrame2.Navigate(new Profile2());
                                break;
                            case "Студент":
                                MessageBox.Show("Здравствуйте Доставщик" + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigationService AppFrame3 = NavigationService.GetNavigationService(this);
                                AppFrame3.Navigate(new Profile3());
                                break;
                            default:
                                MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                                break;
                        }

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ошибка " + Ex.Message.ToString() + "Критическая работа приложения!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
