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
using System.IO;
using Lib_11;

namespace Пр_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №1\n Выполнила студентка группы ИСП-31 Кочеткова В\n Задание:Найти произведение n целых случайных чисел X., распределенных в диапазоне от 0 до n. Вывести на экран на одной строке сгенерированные числа, на другой строке результат.", "Доп.Информация", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Расчёт_Click(object sender, RoutedEventArgs e)
        {
            int koll;
            bool f = Int32.TryParse(kol.Text, out koll);
            if (f == true)
            {
                Class1.Proizv(koll, out string str, out string str1);
                chisla.Text = str;
                rez.Text = str1;
            }
            else MessageBox.Show("Ошибка ввода", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error) ;
        }

        private void Очистить_Click(object sender, RoutedEventArgs e)
        {
            kol.Clear();
            rez.Clear();
            chisla.Clear();
        }

        private void kol_TextChanged(object sender, TextChangedEventArgs e)
        {
            rez.Clear();
            chisla.Clear();
        }
    }
}
