using Mawa.MessageViewer.Services;
using System;

namespace Mawa.MessageViewer
{
    public static class MessageViewerPasser //: IMessageShowerApp
    {
        private static IMessageViewerService _instanceService;
        public static IMessageViewerService InstanceService
        {
            set
            {
                _instanceService = value;
            }
            //get => _instance;
            // as temp for test .?
            get
            {
                if (_instanceService == null)
                    throw new NullReferenceException();
                return _instanceService;
            }
        }



        public static void Show_GeneralMessage_Text(string title, string message)
        {
            InstanceService?.Show_GeneralMessage_Text(title, message);
        }

        public static void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            InstanceService?.Show_GeneralMessage_Text(title, message, icon);
        }

        public static bool Question_GeneralMessage_Text(string title, string message)
        {
            return InstanceService.Question_GeneralMessage_Text(title, message);
        }
        public static bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            return InstanceService.Question_GeneralMessage_Text(title, message, icon);
        }

    }
}
