using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tema3.Models;
using Tema3.Views;

namespace Tema3.ViewModels
{
    public class ProductViewModel:InotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ProductDetails _productDetails;
        public ProductDetails ProductDetails
        {
            get { return _productDetails; }
            set
            {
                _productDetails = value; OnPropertyChanged(nameof(ProductDetails));
            }
        }

    }
}
