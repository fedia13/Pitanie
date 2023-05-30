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
using qwer.Date_Base;



namespace qwer.Form
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        user03Entities1 user03Entities { get; set; }
        OrderContains OrderList;
        public Window1()
        {
            user03Entities = new user03Entities1();
            OrderList = new OrderContains();
            InitializeComponent();
            Tov.ItemsSource = user03Entities.Pitanie.ToList();
            if (OrderList.ListProduct.Count == 0)
            {
                AAA.Visibility = Visibility.Collapsed;
            }
        }
        public void ReadData()
        {
            user03Entities = new user03Entities1();
            Tov.ItemsSource = user03Entities.Pitanie.ToList();
            Title = $"База данных";
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Pitanie CurrentProduct = Tov.SelectedItem as Pitanie; ;
            if (CurrentProduct == null)
            {
                MessageBox.Show("Выберите продукт!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Pitanie FindProduct = OrderList.ListProduct.FirstOrDefault(
                    x => x.ID == CurrentProduct.ID);
                if (FindProduct == null)
                {
                    //Добавление продукта в список продуктов заказа
                    CurrentProduct.CountProductOrder = 1;
                    OrderList.ListProduct.Add(CurrentProduct);
                }
                else
                {
                    //Увеличение на единицу этого товара в списке продуктов 
                    //заказа
                    foreach (var item in OrderList.ListProduct)
                    {
                        if (item.ID == FindProduct.ID)
                            item.CountProductOrder++;
                    }
                }
                AAA.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(user03Entities, OrderList);
            window2.Show();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var input = (sender as TextBox).Text.ToLower();
            if (!(String.IsNullOrEmpty(input)))
            {
                int resultCount = user03Entities.Pitanie.Count(x => x.Наименование_товара.Contains(input));
                Tov.ItemsSource = user03Entities.Pitanie.Where(x => x.Наименование_товара.Contains(input)).ToList();
                Title = $"База данных | Поиск: {input} | Результатов: {resultCount} из {user03Entities.Pitanie.ToList().Count()}";
            }
            else
                ReadData();
            {

            }
        }

        private void Button_Click(object sender, object e)
        {

        }

        private void Tov_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
   
    }

