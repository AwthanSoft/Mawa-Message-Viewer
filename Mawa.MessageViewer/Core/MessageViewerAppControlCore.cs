using Mawa.Lock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mawa.MessageViewer
{
    public abstract class MessageViewerAppControlCore : IMessageViewer, IDisposable
    {
        #region Initail

        public MessageViewerAppControlCore()
        {
            pre_refresh();

            MessageViewerPasser.instance = this;
        }
        private void pre_refresh()
        {
            objectLock = new ObjectLock();
        }

        // For Lock
        #region Lock Base Properties
        private ObjectLock objectLock;

        protected void open_lock()
        {
            objectLock.open_lock();
        }
        protected void close_lock()
        {
            objectLock.close_lock();
        }

        #endregion

        #endregion

        #region Shower
        public virtual void Show_GeneralMessage_Text(string title, string message)
        {
            open_lock();
            _Show_GeneralMessage_Text(title, message);
            close_lock();
        }
        protected abstract void _Show_GeneralMessage_Text(string title, string message);

        public void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            open_lock();
            _Show_GeneralMessage_Text(title, message, icon);
            close_lock();
        }
        protected abstract void _Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon);

        public bool Question_GeneralMessage_Text(string title, string message)
        {
            open_lock();
            var resultt = _Question_GeneralMessage_Text(title, message);
            close_lock();
            return resultt;
        }
        protected abstract bool _Question_GeneralMessage_Text(string title, string message);
        public bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            open_lock();
            var resultt = _Question_GeneralMessage_Text(title, message, icon);
            close_lock();
            return resultt;
        }
        protected abstract bool _Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon);
        #endregion

        #region Shower Async
        //public virtual async void Show_GeneralMessage_TextAsync(string title, string message)
        //{
        //    open_lock();
        //    await _Show_GeneralMessage_TextAsync(title, message);
        //    close_lock();
        //}
        //protected virtual async void _Show_GeneralMessage_TextAsync(string title, string message)
        //{
        //    await Task.Run(() => _Show_GeneralMessage_Text(title, message));
        //}

        //public void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        //{
        //    open_lock();
        //    _Show_GeneralMessage_Text(title, message, icon);
        //    close_lock();
        //}
        //protected abstract void _Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon);

        //public bool Question_GeneralMessage_Text(string title, string message)
        //{
        //    open_lock();
        //    var resultt = _Question_GeneralMessage_Text(title, message);
        //    close_lock();
        //    return resultt;
        //}
        //protected abstract bool _Question_GeneralMessage_Text(string title, string message);
        //public bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        //{
        //    open_lock();
        //    var resultt = _Question_GeneralMessage_Text(title, message, icon);
        //    close_lock();
        //    return resultt;
        //}
        //protected abstract bool _Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon);
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

       

        ~MessageViewerAppControlCore()
        {
            Dispose(false);
        }
       

        #endregion
    }
}
