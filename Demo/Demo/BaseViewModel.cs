using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private readonly string _realTimeData = "https://fir-41151-default-rtdb.firebaseio.com/";
        private readonly string _auth = "AIzaSyCRUWPFzRdtGsNhh4TMsJsgJSB5PUMPv_c";
        private readonly string _storage = "schoolmission-7f9fe.appspot.com";
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected readonly FirebaseClient _firebaseDatabase;
        //protected readonly FirebaseAuthProvider _firebaseAuthProvider;
        //protected readonly FirebaseStorage _firebaseStorage;
        //protected static UserModel _userModel;
        //protected static string _firebaseToken;

        string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(); }
        }

        bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }

        public BaseViewModel(string title)
        {
            Title = title;
            _firebaseDatabase = new FirebaseClient(_realTimeData);
            //_firebaseStorage = new FirebaseStorage(_storage);
            //_firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(_auth));
        }

        //public virtual Task LoadAsync(NavigationParameters navigationData) => Task.FromResult(false);

        //public virtual Task OnNavigate(NavigationParameters navigationData) => Task.FromResult(false);

        //public virtual Task ResumeASync() => Task.FromResult(false);

        //public virtual void AppLinkRequestReceive(Uri uri) => Task.FromResult(false);
    }
}
