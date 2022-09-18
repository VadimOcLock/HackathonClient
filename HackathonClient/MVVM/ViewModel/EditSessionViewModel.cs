using HackathonClient.Core;
using SharedLibrary;
using System.Windows;

namespace HackathonClient.MVVM.ViewModel
{
    class EditSessionViewModel : ObservableObject
    {
        private SessionData _sessionData;
        public SessionData SessionData { 
            get => _sessionData;
            set 
            { 
                _sessionData = value;
                OnPropertyChanged();
            } 
        }

        #region Commands
        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                    (_saveCommand = new RelayCommand(obj =>
                    {
                        Window w = obj as Window;
                        if (w != null)
                        {
                            w.DialogResult = true;
                            w.Close();
                        }
                    }));
            }
        }
        #endregion
        public EditSessionViewModel() { }
    }
}