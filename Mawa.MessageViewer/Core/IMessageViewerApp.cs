using System;
using System.Collections.Generic;
using System.Text;


namespace Mawa.MessageViewer
{
    public interface IMessageViewer
    {
        void Show_GeneralMessage_Text(string title, string message);
        void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon);
        bool Question_GeneralMessage_Text(string title, string message);
        bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon);
    }

    
}
