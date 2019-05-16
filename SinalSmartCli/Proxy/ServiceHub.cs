using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinalSmartCli.Proxy {
    public class ServiceHub : IServiceHub {

        /// <summary>
        /// Proxy Server Hub
        /// </summary>
        public HubConnection Hub { get; set; }

        /// <summary>
        /// Current DateTime Idented
        /// </summary>
        public string Date { get => DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); }

        /// <summary>
        /// Initialize Hubs
        /// </summary>
        /// <param name="uri"></param>
        public void InitializeHub(string uri) {
            Hub = new HubConnectionBuilder().WithUrl(uri).Build();
            Hub.Closed += async (error) => {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await Hub.StartAsync();
            };
        }

        /// <summary>
        /// Disconnect from Hub
        /// </summary>
        /// <returns></returns>
        public async Task DisconnectHub(TextBox console) {
            await Hub.StopAsync();
            InjectHeader(console, $"----- Desconectado: ----- {Date}");

        }

        /// <summary>
        /// Connect on Hub
        /// </summary>
        /// <param name="console"></param>
        /// <returns></returns>
        public async Task ConnectHub(TextBox console) {
            await Hub.StartAsync();
            InjectHeader(console, $"----- Conectado: ----- {Date}");
        }

        public async Task JoinGroupHub(string id) {
            await Hub.InvokeAsync("JoinGroup", id);
        }

        /// <summary>
        /// Join Method
        /// </summary>
        /// <param name="console"></param>
        /// <param name="method"></param>
        /// <param name="current"></param>
        public void JoinAction(TextBox console, string method, Form current) {
            Hub.On(method, (Action<string>)((result) => {
                current.Invoke((Action)(() => {
                    InjectHeader(console, $"----- Hub: ----- {Date}");
                    var obj = JsonConvert.DeserializeObject(result);
                    console.AppendText(obj.ToJson());
                }));
            }));
        }

        /// <summary>
        /// Info headers on console
        /// </summary>
        /// <param name="console"></param>
        /// <param name="info"></param>
        public void InjectHeader(TextBox console, string info) {
            console.Text = string.Empty;
            console.AppendText(info);
            console.AppendText(Environment.NewLine);
        }

        public void InjectException(TextBox console, Exception ex) {
            console.Text = string.Empty;
            console.AppendText($"----- Erro: ----- {Date}");
            console.AppendText(ex.Message);
        }

    }
}