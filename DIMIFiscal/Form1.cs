using DIMIFiscal.Properties;

namespace DIMIFiscal {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private Form activeWindow = null;
        public void openWindow(Form window) {

            if (activeWindow != null) {
                activeWindow.Close();
            }
            activeWindow = window;

            window.TopLevel = false;
            window.FormBorderStyle = FormBorderStyle.None;
            window.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(window);
            containerPanel.Tag = window;
            window.Show();
        }

        private void btClientes_Click(object sender, EventArgs e) {
            openWindow(new ClientForm());
        }

        private void btNotas_Click(object sender, EventArgs e) {
            openWindow(new NFForm());
        }

        private void btConfig_Click(object sender, EventArgs e) {
            openWindow(new ConfigForm());
        }

        private void btSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente sair?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes) {
                Application.Exit();
            }


        }
    }
}