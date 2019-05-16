using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinalSmartCli.Proxy {
    public interface IServiceHub {

        void InitializeHub(string uri = "");
        void JoinAction(TextBox console, string method, Form current);
        void InjectHeader(TextBox console, string info);
        void InjectException(TextBox console, Exception ex);

        Task DisconnectHub(TextBox console);
        Task ConnectHub(TextBox console);
        Task JoinGroupHub(string id);
    }
}
