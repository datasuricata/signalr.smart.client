using SinalSmartCli.Proxy;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinalSmartCli {
    public partial class SignalForm : Form {

        private readonly IServiceHub Hub;

        private bool resize { get; set; }

        public SignalForm(IServiceHub Hub) {
            this.Hub = Hub;
            InitializeComponent();
        }

        private void OpenTool_Click(object sender, EventArgs e) {
            if (resize) {
                ActiveForm.Size = new Size(320, 251);
                resize = false;
                OpenTool.Text = "⤵";
            } else {
                ActiveForm.Size = new Size(320, 684);
                resize = true;
                OpenTool.Text = "⤴";
            }
        }

        private void Clipboard_Click(object sender, EventArgs e) {
            System.Windows.Forms.Clipboard.SetText(MessageConsole.Text);
        }

        private async void Disconnect_Click(object sender, EventArgs e) {
            try {
                await Hub.DisconnectHub(MessageConsole);
            } catch (Exception ex) {
                Hub.InjectException(MessageConsole, ex);
            }
        }

        private async void JoinGroup_Click(object sender, EventArgs e) {
            try {
                await Hub.JoinGroupHub(txtGroup.Text);
            } catch (Exception ex) {
                Hub.InjectException(MessageConsole, ex);
            }
        }

        private async void JoinMethods_Click(object sender, EventArgs e) {
            try {

                Hub.InitializeHub(txtHost.Text);
                Hub.JoinAction(MessageConsole, txtMethods.Text, this);

                await Hub.ConnectHub(MessageConsole);

            } catch (Exception ex) {
                Hub.InjectException(MessageConsole, ex);
            }
        }
    }
}
