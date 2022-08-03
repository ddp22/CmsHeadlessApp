
using CmsHeadlessApp.SupportedClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CmsHeadlessApp.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetProperty(ref _isRefreshing, value);
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
       [CallerMemberName] string propertyName = "",
       Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Commands
        public ICommand SelectedContentCommand => new Command<ContentList>(async (contentDetails) =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new ContentDetails(contentDetails));

        });

        public ICommand RefreshCommand => new Command(async () =>{
            IsRefreshing = true;
            await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            IsRefreshing = false;
        }
        )
        ;
        #endregion
    }
}
