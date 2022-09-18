using System;

namespace HackathonClient.Core
{
    public class RelayCommand : Command
    {
        private Action<object> _Execute;
        private Func<object, bool> _CanExecute;

        public RelayCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override void Execute(object? parameter) => _Execute(parameter);
        public override bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;
    }
}