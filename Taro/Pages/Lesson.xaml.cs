using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Windows.Xps.Packaging;
using Taro.Resources;
using Path = System.IO.Path;

namespace Taro.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lesson.xaml
    /// </summary>
    public partial class Lesson : System.Windows.Window
    {

        LessonDB lessons;
        LessonDB lesson;
        int maxPage;
        int lessonPage, lessonid;

        public Lesson(LessonDB plessons)
        {
            InitializeComponent();
           
            lessons = plessons;
            try
            {
                switch (lessons.Lesson)
                {
                    case "Intro":
                        lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson);
                        lessonPage = (int)AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).NumberPage;
                        lessonid = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).id;
                        maxPage = 3;
                        break;
                    case "Structure":
                        lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson);
                        lessonPage = (int)AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).NumberPage;
                        lessonid = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).id;
                        maxPage = 6;
                        break;
                    case "SA":
                        lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == lessons.NumberPage && p.Lesson == lessons.Lesson);
                        bntRight.Visibility = Visibility.Collapsed;
                        bntLeft.Visibility = Visibility.Collapsed;
                        break;
                    case "MAB":
                        if (lessons.NumberPage == 6)
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 6 && p.Lesson == lessons.Lesson);
                            bntRight.Visibility = Visibility.Collapsed;
                            bntLeft.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson);
                            lessonPage = (int)AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).NumberPage;
                            lessonid = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).id;
                            maxPage = 5;
                        }
                        break;
                    case "MAC":
                        if (lessons.NumberPage == 6)
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 6 && p.Lesson == lessons.Lesson);
                            bntRight.Visibility = Visibility.Collapsed;
                            bntLeft.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson);
                            lessonPage = (int)AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).NumberPage;
                            lessonid = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).id;
                            maxPage = 5;
                        }
                        break;
                    case "MAD":
                        if (lessons.NumberPage == 6)
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 6 && p.Lesson == lessons.Lesson);
                            bntRight.Visibility = Visibility.Collapsed;
                            bntLeft.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson);
                            lessonPage = (int)AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).NumberPage;
                            lessonid = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).id;
                            maxPage = 5;
                        }
                        break;
                    case "MAE":
                        if (lessons.NumberPage == 6)
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 6 && p.Lesson == lessons.Lesson);
                            bntRight.Visibility = Visibility.Collapsed;
                            bntLeft.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson);
                            lessonPage = (int)AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).NumberPage;
                            lessonid = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == 1 && p.Lesson == lessons.Lesson).id;
                            maxPage = 5;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Lesson MW = Application.Current.Windows.OfType<Lesson>().FirstOrDefault();
                MW.navframe.NavigationService.Navigate(new LessonPage(lesson));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }
        Lesson MW = Application.Current.Windows.OfType<Lesson>().FirstOrDefault();

        private void bntLeft_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lesson == null)
                {
                    return;
                }
                else
                {
                    if (lesson.NumberPage != 1)
                    {
                        lessonPage--;
                        lessonid--;
                        lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == lessonPage && p.Lesson == lessons.Lesson && p.id == lessonid);
                    }
                    else
                    {
                        return;
                    }
                    MW = Application.Current.Windows.OfType<Lesson>().FirstOrDefault();
                    MW.navframe.NavigationService.Navigate(new LessonPage(lesson));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
                this.Close();
            }
        }

        private void bntRight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lesson == null)
                {
                    return;
                }
                else
                {
                    if (lesson.NumberPage < maxPage)
                    {
                        lessonPage++;
                        lessonid++;
                        lesson = AppData.db.LessonDB.FirstOrDefault(p => p.NumberPage == lessonPage && p.Lesson == lessons.Lesson && p.id == lessonid);
                    }
                    else
                    {
                        return;
                    }
                    MW = Application.Current.Windows.OfType<Lesson>().FirstOrDefault();
                    MW.navframe.NavigationService.Navigate(new LessonPage(lesson));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
                this.Close();
            }
        }
    }
}

