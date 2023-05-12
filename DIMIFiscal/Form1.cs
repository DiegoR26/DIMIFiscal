using DIMIFiscal.Properties;

namespace DIMIFiscal {
    public partial class Form1 : Form {

        public Form ClientBase = new ClientForm();
        public Form NFBase = new NFForm();
        public Form Config = new ConfigForm();
        public Form ClientData = new ClientView();

        private Form activeWindow = null;

        public Form1() {
            InitializeComponent();

        }

        public void openWindow(Form window) {

            if (activeWindow != null) {
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
            openWindow(ClientBase);

        }

        private void btNotas_Click(object sender, EventArgs e) {
            openWindow(NFBase);

        }

        private void btConfig_Click(object sender, EventArgs e) {
            openWindow(Config);

        }

        private void btSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente sair?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes) {
                Application.Exit();
            }


        }
    }
}