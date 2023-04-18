
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
using Taro.Pages;
using Taro.Resources;
using Lessons = Taro.Pages.Lessons;

namespace Taro
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        //private void btnRestore_Click(object sender, RoutedEventArgs e)
        //{
        //    if (IsMaximized)
        //    {
        //        this.WindowState = WindowState.Normal;
        //        this.Height = 900;
        //        this.Width = 1600;
        //        IsMaximized = false;
        //    }
        //    else
        //    {
        //        this.WindowState = WindowState.Maximized;
        //        IsMaximized = true;
        //    }
        //}

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            MW.navframe.NavigationService.Navigate(new FirstWin());
            TBlockMain.Text = "Главное меню";
        }

        private void bntHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            MW.navframe.NavigationService.Navigate(new FirstWin());
            TBlockMain.Text = "Главное меню";
        }

        private void bntGlos_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            MW.navframe.NavigationService.Navigate(new Glossary());
            TBlockMain.Text = "Словарь";
        }

        private void bntLesson_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            MW.navframe.NavigationService.Navigate(new Lessons());
            TBlockMain.Text = "Лекции";
        }

        private void bntTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                MW.navframe.NavigationService.Navigate(new Tests());
                TBlockMain.Text = "Тесты";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
               
            }

        }
    }
}
