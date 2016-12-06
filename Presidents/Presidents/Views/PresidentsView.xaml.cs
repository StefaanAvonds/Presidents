using Presidents.Managers;
using Presidents.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Presidents.Views
{
    public partial class PresidentsView : ContentPage
    {
        private string _searchText;
        private bool _showGif;
        private ObservableCollection<President> _listPresidents;

        private PresidentManager _presidentManager;

        /// <summary>
        /// The given search text to find a president.
        /// </summary>
        public String SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }

        public Boolean ShowGif
        {
            get { return _showGif; }
            set
            {
                _showGif = value;
                OnPropertyChanged();
                _presidentManager.ShowGif = value;
                ReloadItemsSource();
            }
        }

        /// <summary>
        /// The ItemsSource for all the presidents.
        /// </summary>
        public ObservableCollection<President> ListPresidents
        {
            get { return _listPresidents; }
            set
            {
                _listPresidents = value;
                OnPropertyChanged();
            }
        }

        public PresidentsView()
        {
            InitializeComponent();
            BindingContext = this;

            _presidentManager = new PresidentManager();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ReloadItemsSource();
        }
        
        /// <summary>
        /// Load all presidents on screen.
        /// </summary>
        private void ReloadItemsSource()
        {
            if (String.IsNullOrWhiteSpace(SearchText))
            {
                ListPresidents = _presidentManager.GetAllPresidents();
            }
            else
            {
                ListPresidents = _presidentManager.SearchPresidentBySearchText(SearchText);
            }
        }

        public void OnValueChanged(object sender, TextChangedEventArgs e)
        {
            ReloadItemsSource();
        }
    }
}
