using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
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
using Taro.Resources;

namespace Taro
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        LessonDB lessons;
        byte[] image_bytes;
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lessons = AppData.db.LessonDB.FirstOrDefault(p => p.id == 55 && p.NumberPage == 24);
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image files (*.BMP, *.JPG, *.PNG)|*.bmp;*.jpg; *.png";
                if (fileDialog.ShowDialog() == true)
                {
                    string fileName = fileDialog.FileName;
                    imagePath.Text = fileName;
                    imageAva.Source = new BitmapImage(new Uri(fileName));
                    image_bytes = File.ReadAllBytes(fileDialog.FileName);

                }
                lessons.Image = image_bytes;
                AppData.db.LessonDB.AddOrUpdate(lessons) ;
                AppData.db.SaveChanges();

                MessageBox.Show("Фото успешно добавлено", "Уведомление");
                Environment.Exit(0);
            }
            catch
            {
                MessageBox.Show("Фото неизменено", "Уведомление");
            }

        }
    }
}
