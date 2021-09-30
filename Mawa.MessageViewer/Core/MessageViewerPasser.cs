using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mawa.MessageViewer
{
    public static class MessageViewerPasser //: IMessageShowerApp
    {
        private static MessageViewerAppControlCore _instance;
        internal static MessageViewerAppControlCore instance
        {
             set
            {
                if (_instance == null)
                    _instance = value;
                else
                    throw new Exception();
            }
            //get => _instance;
            // as temp for test .?
            get
            {
                if (_instance == null)
                    throw new Exception();
                return _instance;
            }
        }

        public static void Show_GeneralMessage_Text(string title, string message)
        {
            instance?.Show_GeneralMessage_Text(title, message);
        }

        public static void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            instance?.Show_GeneralMessage_Text(title, message, icon);
        }

        public static bool Question_GeneralMessage_Text(string title, string message)
        {
            return instance.Question_GeneralMessage_Text(title, message);
        }
        public static bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            return instance.Question_GeneralMessage_Text(title, message, icon);
        }

    }
}
