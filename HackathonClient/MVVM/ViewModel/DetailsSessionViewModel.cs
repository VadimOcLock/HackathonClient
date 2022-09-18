using HackathonClient.Core;
using SharedLibrary;

namespace HackathonClient.MVVM.ViewModel
{
    class DetailsSessionViewModel : ObservableObject
    {
        private SessionData _sessionData;
        public SessionData SessionData
        {
            get => _sessionData;
            set
            {
                _sessionData = value;
                OnPropertyChanged();
            }
        }
        public DetailsSessionViewModel() { }
    }
}