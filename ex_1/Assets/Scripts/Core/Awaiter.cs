using System;

namespace Core
{
    public class Awaiter
    {
        #region Fields

        private Action _onEndCallback;

        #endregion

        #region Methods

        public void OnEnd(Action endCallback)
        {
            _onEndCallback = endCallback;
        }

        public void TriggerEnd()
        {
            _onEndCallback?.Invoke();
        }

        #endregion
    }
}