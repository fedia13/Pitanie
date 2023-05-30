using qwer.Date_Base;
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

namespace qwer.Form
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        user03Entities1 user03Entities { get; set; }
        OrderContains OrderList;
        public Window2(user03Entities1 user03Entities2, OrderContains orderContains)
        {
           
            InitializeComponent();
            user03Entities = user03Entities2;
            OrderList = orderContains;
            Tov.ItemsSource = user03Entities.Pitanie.ToList();
            SumOrderTxb.Text = SumOrder();
            DiscountTxb.Text = DiscountOrder();

        }
        public string SumOrder()
        {
            decimal SumOrder = 0;
            foreach (var item in OrderList.ListProduct)
            {
                var SumDiscount = (Convert.ToInt32(item.Цена) * Convert.ToInt32(item.Размер_скидки)) / 100;
                SumOrder = Convert.ToDecimal(
                    SumOrder + (Convert.ToInt32(item.Цена) - SumDiscount) * item.CountProductOrder);
            }
            return SumOrder.ToString();
        }

        public string DiscountOrder()
        {
            decimal DiscountOrder = 0;
            foreach (var item in OrderList.ListProduct)
            {
                var SumDiscount = (Convert.ToInt32(item.Цена) * Convert.ToInt32(item.Размер_скидки)) / 100;
                DiscountOrder = Convert.ToDecimal(
                    DiscountOrder + SumDiscount * item.CountProductOrder);
            }
            return DiscountOrder.ToString();
        }
        private void Tov_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
