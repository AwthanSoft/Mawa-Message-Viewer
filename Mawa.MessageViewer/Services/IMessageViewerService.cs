using System.Threading.Tasks;

namespace Mawa.MessageViewer.Services
{
    public interface IMessageViewerService
    {
        void Show_GeneralMessage_Text(string title, string message);
        void Show_GeneralMessage_Text(string title, string message, MessageBoxImage icon);
        bool Question_GeneralMessage_Text(string title, string message);
        bool Question_GeneralMessage_Text(string title, string message, MessageBoxImage icon);

        //Async
        Task Show_GeneralMessage_TextAsync(string title, string message);
        Task Show_GeneralMessage_TextAsync(string title, string message, MessageBoxImage icon);
        Task<bool> Question_GeneralMessage_TextAsync(string title, string message);
        Task<bool> Question_GeneralMessage_TextAsync(string title, string message, MessageBoxImage icon);

    }
}
