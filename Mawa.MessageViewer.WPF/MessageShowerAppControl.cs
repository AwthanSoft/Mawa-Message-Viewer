//using Mawa.TypeEnumCtrls;
//using Mawa.MessageViewer;
//using System;

//namespace MDM.ManagementApp.MessageShowerApp
//{
//    class MessageShowerAppControl : MessageViewerAppControlCore
//    {
//        private static TypeEnumCtrlCore<System.Windows.MessageBoxImage> MessageBoxImageEnumCtrl = new TypeEnumCtrlCore<System.Windows.MessageBoxImage>();
//        #region initial 
//        public MessageShowerAppControl()
//        {

//        }
//        #endregion

//        protected override void _Show_GeneralMessage_Text(string title, string message)
//        {
//            System.Windows.MessageBox.Show(message, title);
//        }

//        protected override void _Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
//        {
//            System.Windows.MessageBox.Show(message, title, System.Windows.MessageBoxButton.OK, MessageBoxImageEnumCtrl.str_to_enum(icon.ToString()));
//        }

//        //Q
//        protected override bool _Question_GeneralMessage_Text(string title, string message)
//        {
//            bool resultt = false;
//            var resulttBtn = System.Windows.MessageBox.Show(
//                message,
//                title,
//                System.Windows.MessageBoxButton.YesNo,
//                System.Windows.MessageBoxImage.Question);
//            switch (resulttBtn)
//            {
//                case System.Windows.MessageBoxResult.Yes:
//                    {
//                        resultt = true;
//                        break;
//                    }
//                case System.Windows.MessageBoxResult.No:
//                    {
//                        resultt = false;
//                        break;
//                    }
//                default:
//                    {
//                        resultt = false;
//                        throw new Exception();
//                    }
//            }

//            return resultt;
//        }
//        protected override bool _Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon)
//        {
//            bool resultt = false;
//            var resulttBtn = System.Windows.MessageBox.Show(
//                message,
//                title,
//                System.Windows.MessageBoxButton.YesNo,
//                MessageBoxImageEnumCtrl.str_to_enum(icon.ToString()));
//            switch (resulttBtn)
//            {
//                case System.Windows.MessageBoxResult.Yes:
//                    {
//                        resultt = true;
//                        break;
//                    }
//                case System.Windows.MessageBoxResult.No:
//                    {
//                        resultt = false;
//                        break;
//                    }
//                default:
//                    {
//                        resultt = false;
//                        throw new Exception();
//                    }
//            }

//            return resultt;
//        }
//        #region Dispose

//        protected override void Dispose_FreeManaged()
//        {
//            //throw new NotImplementedException();
//        }

//        protected override void Dispose_FreeUnManaged()
//        {
//            //throw new NotImplementedException();
//        }

//        #endregion
//    }
//}
