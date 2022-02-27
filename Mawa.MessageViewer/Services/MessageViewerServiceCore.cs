using Mawa.Lock;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Mawa.MessageViewer.Services
{
    public abstract class MessageViewerServiceCore : IMessageViewerService, IDisposable
    {
        #region Initail
        private readonly ObjectLock objectLock;
        public MessageViewerServiceCore()
        {
            objectLock = new ObjectLock();
            //MessageViewerPasser.instance = this;
        }

        #endregion

        #region Shower
        public void Show_GeneralMessage_Text(string title, string message)
        {
            lock (objectLock.opening_Lock)
            {
                _Show_GeneralMessage_Text(title, message);
            }
        }
        protected abstract void _Show_GeneralMessage_Text(string title, string message);

        public void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            lock (objectLock.opening_Lock)
            {
                _Show_GeneralMessage_Text(title, message, icon);
            }
        }
        protected abstract void _Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon);

        public bool Question_GeneralMessage_Text(string title, string message)
        {
            lock (objectLock.opening_Lock)
            {
                return _Question_GeneralMessage_Text(title, message);
            }
        }
        protected abstract bool _Question_GeneralMessage_Text(string title, string message);
        public bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            lock (objectLock.opening_Lock)
            {
                return _Question_GeneralMessage_Text(title, message, icon);
            }
        }
        protected abstract bool _Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon);
        #endregion

        #region Shower Async

        public async Task Show_GeneralMessage_TextAsync(string title, string message)
        {
            await _Show_GeneralMessage_TextAsync(title, message);
        }
        protected abstract Task _Show_GeneralMessage_TextAsync(string title, string message);

        public async Task Show_GeneralMessage_TextAsync(string title, string message, MessageBoxImage icon)
        {
            await _Show_GeneralMessage_TextAsync(title, message, icon);
        }
        protected abstract Task _Show_GeneralMessage_TextAsync(string title, string message, MessageBoxImage icon);

        public async Task<bool> Question_GeneralMessage_TextAsync(string title, string message)
        {
            return await _Question_GeneralMessage_TextAsync(title, message);
        }
        protected abstract Task<bool> _Question_GeneralMessage_TextAsync(string title, string message);

        public async Task<bool> Question_GeneralMessage_TextAsync(string title, string message, MessageBoxImage icon)
        {
            return await _Question_GeneralMessage_TextAsync(title, message, icon);
        }
        protected abstract Task<bool> _Question_GeneralMessage_TextAsync(string title, string message, MessageBoxImage icon);

        #endregion

        #region Dispose

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                this?.Dispose_FreeManaged();
            }

            // Free any unmanaged objects here.
            this?.Dispose_FreeUnManaged();


            _disposed = true;
        }

        protected abstract void Dispose_FreeManaged();
        protected abstract void Dispose_FreeUnManaged();
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       
        ~MessageViewerServiceCore()
        {
            Dispose(false);
        }


        #endregion
    }
}
