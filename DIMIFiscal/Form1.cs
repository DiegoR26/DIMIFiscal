using DIMIFiscal.Properties;

namespace DIMIFiscal {
    public partial class Form1 : Form {

        public ClientForm ClientBase;
        public NFForm NFBase;
        public ConfigForm Config;

        public ClientAcess CAcess;

        public List<Client> clientList = new List<Client> ();

        private Form activeWindow = null;

        public Form1() {
            InitializeComponent();

            string fileName = "ClientsDB.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            CAcess = new ClientAcess(path);

            clientList = CAcess.GetAllClients();

        }

        public void openWindow(Form window) {

            if (activeWindow != null) {
                activeWindow.Dispose();
                activeWindow.Close();
            }

            activeWindow = window;

            window.TopLevel = false;
            window.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(window);
            containerPanel.Tag = window;
            window.Show();
        }

        private void btClientes_Click(object sender, EventArgs e) {
            ClientBase = new ClientForm();
            openWindow(ClientBase);

            ClientBase.hideSaveCancelBts();
            ClientBase.disableFields();

        }

        private void btNotas_Click(object sender, EventArgs e) {
            NFBase = new NFForm();
            openWindow(NFBase);

            NFBase.setClientList(clientList);
            
        }

        private void btConfig_Click(object sender, EventArgs e) {
            Config = new ConfigForm();
            openWindow(Config);
        }

        private void btSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente sair?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes) {
                Application.Exit();
            }


        }
    }
}