using HackathonClient.Core;

namespace HackathonClient.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public SessionsViewModel SessionsVM { get; set; }

        #region Commands
        private RelayCommand _sessionsViewCommand;
        public RelayCommand SessionsViewCommand
        {
            get
            {
                return _sessionsViewCommand ??
                    (_sessionsViewCommand = new RelayCommand(obj =>
                    {
                        CurrentView = SessionsVM;
                    }));
            }
        }
        #endregion

        public MainViewModel()
        {
            SessionsVM = new SessionsViewModel();

            CurrentView = SessionsVM;
        }
    }
}