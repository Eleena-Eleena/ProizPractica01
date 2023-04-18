using Syncfusion.Windows.Shared;
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
    /// Логика взаимодействия для Glossary.xaml
    /// </summary>
    public partial class Glossary : Page
    {
        List<Glossaries> current;
        List<Glossaries> currentEdit;
        List<Glossaries> r;
        bool flag;
        public Glossary()
        {
            InitializeComponent();
            try
            {
                current = AppData.db.Glossaries.ToList();
                LViewOrder.ItemsSource = current;
                flag = true;
                CBUpDown.IsEnabled = true;
                TBSearch.IsEnabled = true;
            }
            catch (Exception ex)
            {
                flag = false;
                CBUpDown.IsEnabled = false;
                TBSearch.IsEnabled = false;
                MessageBox.Show("Ошибка: " + ex);
            }
        }

        public void Update()
        {
            if (flag == false)
            {
                MessageBox.Show("Ошибка");
                CBUpDown.IsEnabled = false;
                TBSearch.IsEnabled = false;
            }
            else
            {
                CBUpDown.IsEnabled = true;
                TBSearch.IsEnabled = true;
                try
                {
                    currentEdit = current;
                    if (CBUpDown.IsChecked.Value)
                    {
                        CBUpDown.Content = "Я -> А";
                        currentEdit = UpdateTB(currentEdit);
                        currentEdit = currentEdit.OrderByDescending(n => n.Definition).ToList();
                    }
                    else
                    {
                        CBUpDown.Content = "А -> Я";
                        currentEdit = UpdateTB(currentEdit);
                        currentEdit = currentEdit.OrderBy(n => n.Definition).ToList();
                    }
                    LViewOrder.ItemsSource = currentEdit.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

        }
        private List<Glossaries> UpdateTB(List<Glossaries> currentEdit)
        {
            if (flag == false)
            {
                MessageBox.Show("Ошибка");
                CBUpDown.IsEnabled = false;
                TBSearch.IsEnabled = false;
            }
            else
            {
                CBUpDown.IsEnabled = true;
                TBSearch.IsEnabled = true;
                if (TBSearch.Text != "" && TBSearch.Text != "Поиск")
                {
                    r = currentEdit.Where(p => p.Definition.ToLower().Trim().Contains(TBSearch.Text.Trim().ToLower())
                    || p.Description.ToLower().Trim().Contains(TBSearch.Text.Trim().ToLower())).ToList();
                }
                else
                {
                    r = currentEdit;
                }
            }
            return r;
        }
        private void CBUpDown_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LViewOrder != null)
                {
                    Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }

        private void CBUpDown_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LViewOrder != null)
                {
                    Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (LViewOrder != null)
                {
                    Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }

        }

        private void TBSearch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
                TBSearch.Text = "";
        }
    }
}
