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
using Taro.Resources;

namespace Taro.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lessons.xaml
    /// </summary>
    public partial class Lessons : Page
    {
        LessonDB lessons;
        public Lessons()
        {
            InitializeComponent();

        }


        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            SPIntro.Visibility = Visibility.Visible;
            SPSA.Visibility = Visibility.Hidden;
            SPMA.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            SPIntro.Visibility = Visibility.Hidden;
            SPSA.Visibility = Visibility.Visible;
            SPMA.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            SPIntro.Visibility = Visibility.Hidden;
            SPSA.Visibility = Visibility.Hidden;
            SPMA.Visibility = Visibility.Visible;
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "Intro");
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void Structure_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "Structure");
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 1);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 2);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 3);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 4);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 5);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 6);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 7);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 8);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 9);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 10);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 11);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 12);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();

        }

        private void SA12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 13);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 14);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 15);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 16);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 17);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 18);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 19);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 20);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 21);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void SA21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "SA" && p.NumberPage == 22);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnBatons_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAB" && p.NumberPage == 1);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnPredBatons_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAB" && p.NumberPage == 6);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnCoupes_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAC" && p.NumberPage == 1);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnPredCoupes_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAC" && p.NumberPage == 6);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnDeniers_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAD" && p.NumberPage == 1);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnEpees_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAE" && p.NumberPage == 1);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnPredEpees_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAE" && p.NumberPage == 6);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }

        private void btnPredDeniers_Click(object sender, RoutedEventArgs e)
        {
            lessons = AppData.db.LessonDB.FirstOrDefault(p => p.Lesson == "MAD" && p.NumberPage == 6);
            Lesson lesson = new Lesson(lessons);
            lesson.Show();
        }
    }
}
