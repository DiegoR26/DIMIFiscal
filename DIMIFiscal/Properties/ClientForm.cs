using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIMIFiscal.Properties {
    public partial class ClientForm : Form {

        private ClientAcess clientDataAcess;
        private List<Client> clients;

        public ClientForm() {
            InitializeComponent();

            string fileName = "ClientsDB.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            clientDataAcess = new ClientAcess(path); //FilePath do arquivo txt que vai servir de DB
            clients = clientDataAcess.GetAllClients();

            clientGrid.DataSource = clients;
        }

        private Form activeWindowClient = null;
        public void openWindowClient(Form window) {

            if (activeWindowClient != null) {
                activeWindowClient.Close();
            }
            activeWindowClient = window;

            window.TopLevel = false;
            window.TopMost = true;
            window.FormBorderStyle = FormBorderStyle.None;
            
            Controls.Add(window);
            Tag = window;
            window.BringToFront();
            window.Show();

            window.Location = new Point((this.ClientSize.Width - window.Width) / 2, (this.ClientSize.Height - window.Height) / 2);
        }

        private void btClientClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btAddClient_Click(object sender, EventArgs e) {
            ClientView newClient = new ClientView();
            openWindowClient(newClient);

            if (newClient.DialogResult == DialogResult.OK) {
                string Id = newClient.Id;
                string CName = newClient.CName;
                string User = newClient.User;
                string Password = newClient.Password;
                string SNacional = newClient.SimplesNacional;

                clientDataAcess.AddClient(new Client(Id, CName, User, Password, SNacional));

                clients = clientDataAcess.GetAllClients();
                clientGrid.DataSource = null;
                clientGrid.DataSource = clients;

                newClient.Close();
            }
        }

    }
}
