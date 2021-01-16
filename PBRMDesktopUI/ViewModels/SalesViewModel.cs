using Caliburn.Micro;
using PBDesktopUI.Library.Api;
using PBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<ProductModel> _products;

        private int _itemQuantity;

        private BindingList<ProductModel> _cart;

        IProductEndpoint _productEndpoint;

        public SalesViewModel(IProductEndpoint productEndpoint)
        {
            _productEndpoint = productEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var productList = await _productEndpoint.GetAll();
            Products = new BindingList<ProductModel>(productList);
        }

        public BindingList<ProductModel> Products
        {
            get { return _products; }
            set 
            { 
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            { 
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public BindingList<ProductModel> Cart
        {
            get { return _cart; }
            set 
            { 
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public string Tax
        {
            get 
            { 
                //TODO - Return with a calculated value
                return "£0.00"; 
            }
        }

        public string Total
        {
            get
            {
                //TODO - Return with a calculated value
                return "£0.00";
            }
        }

        public string SubTotal
        {
            get
            {
                //TODO - Return with a calculated value
                return "£0.00";
            }
        }


        public bool CanAddToCart
        {
            get
            {
                bool output = false;
                //Make sure something is selected
                //Make sure quantity is available

                return output;
            }
        }
        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;
                //Make sure something is selected

                return output;
            }
        }
        public void RemoveFromCart()
        {

        }

        public bool CanCheckout
        {
            get
            {
                bool output = false;
                //Make sure there is something in the cart

                return output;
            }
        }
        public void CheckOut()
        {

        }
    }
}
