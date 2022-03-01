using Mawa.MessageViewer.Services;
using System;

namespace Mawa.MessageViewer
{
    public static class MessageViewerPasser //: IMessageShowerApp
    {

        //private static MessageViewerAppControlCore _instance;
        //internal static MessageViewerAppControlCore instance
        //{
        //     set
        //    {
        //        if (_instance == null)
        //            _instance = value;
        //        else
        //            throw new Exception();
        //    }
        //    //get => _instance;
        //    // as temp for test .?
        //    get
        //    {
        //        if (_instance == null)
        //            throw new NullReferenceException();
        //        return _instance;
        //    }
        //}


        private static IMessageViewerService _instanceService;
        internal static IMessageViewerService instanceService
        {
            set
            {
                if (_instanceService == null)
                    _instanceService = value;
                else
                    throw new Exception();
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
            instanceService?.Show_GeneralMessage_Text(title, message);
        }

        public static void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            instanceService?.Show_GeneralMessage_Text(title, message, icon);
        }

        public static bool Question_GeneralMessage_Text(string title, string message)
        {
            return instanceService.Question_GeneralMessage_Text(title, message);
        }
        public static bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
        {
            return instanceService.Question_GeneralMessage_Text(title, message, icon);
        }

    }
}
