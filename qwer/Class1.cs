using qwer.Date_Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwer
{
    public class OrderContains
    {
        public ObservableCollection<Pitanie> ListProduct;

        public OrderContains()
        {
            ListProduct = new ObservableCollection<Pitanie>();
        }
    }
}
