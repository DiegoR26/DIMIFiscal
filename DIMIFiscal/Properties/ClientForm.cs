using OpenQA.Selenium.DevTools.V111.Network;
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

        public string clientId { get { return txtId.Text; } }
        public string clientName { get { return txtName.Text; } }
        public string clientUser { get { return txtUser.Text; } }
        public string clientPassword { get { return txtPassword.Text; } }
        public string clientSNacional {
            get {
                if (checkSimples.Checked) {
                    return "Sim";
                } else {
                    return "Nao";
                }
            }
        }

        private string saveSituation;


        public DataGridView ClientGrid { get { return clientGrid; } }

        public ClientAcess cAcess;


        public ClientForm() {
            InitializeComponent();


            string fileName = "ClientsDB.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            cAcess = new ClientAcess(path);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cAcess.GetAllClients();

            clientGrid.DataSource = bindingSource;

        }

        public void hideSaveCancelBts() {
            btSave.Visible = false;
            btCancel.Visible = false;
        }

        public void showSaveCancelBts() {
            btSave.Visible = true;
            btCancel.Visible = true;
        }

        public void hideMainBts() {
            btAddClient.Visible = false;
            btEditClient.Visible = false;
            btDelClient.Visible = false;
        }

        public void showMainBts() {
            btAddClient.Visible = true;
            btEditClient.Visible = true;
            btDelClient.Visible = true;
        }


        public void disableFields() {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
            checkSimples.Enabled = false;
        }

        public void enableFields() {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            checkSimples.Enabled = true;
        }


        private void btClientClose_Click(object sender, EventArgs e) {
            Dispose();
            Close();
        }

        private void btAddClient_Click(object sender, EventArgs e) {
            hideMainBts();
            showSaveCancelBts();
            enableFields();

            saveSituation = "add";

            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
            checkSimples.Checked = false;

        }

        private void btEditClient_Click(object sender, EventArgs e) {
            hideMainBts();
            showSaveCancelBts();
            enableFields();

            saveSituation = "edit";

        }

        private void btDelClient_Click(object sender, EventArgs e) {
            hideMainBts();
            showSaveCancelBts();
            enableFields();


        }

        private void btSave_Click(object sender, EventArgs e) {

            if (saveSituation == "edit") {

                if (getClientOnList() != null) {
                    hideSaveCancelBts();
                    showMainBts();

                    if (testEmptyFields()) {
                        cAcess.EditClient(getClientOnList());
                    }

                    saveSituation = null;
                } else {
                    MessageBox.Show("Cliente não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            } else if (saveSituation == "add") {

                if (getClientOnList() == null) {
                    hideSaveCancelBts();
                    showMainBts();
                    disableFields();

                    if (testEmptyFields()) {
                        Client client = new Client(clientId, clientName, clientUser, clientPassword, clientSNacional);
                        cAcess.AddClient(client);
                    }

                    saveSituation = null;
                } else {
                    MessageBox.Show("Cliente já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }

        private void btCancel_Click(object sender, EventArgs e) {
            hideSaveCancelBts();
            showMainBts();
            disableFields();


        }

        private bool testEmptyFields() {

            if (clientId == string.Empty || clientName == string.Empty || clientUser == string.Empty || clientPassword == string.Empty) {
                MessageBox.Show("Existem campos vazios!", "Aviso", MessageBoxButtons.OK);
                return false;
            } else {
                return true;
            }

        }

        private Client getClientOnList() {
            Client client = null;

            List<Client> clientes = cAcess.GetAllClients();

            for (int i = 0; i < clientes.Count; i++) {
                if (clientes[i].Id == txtId.Text) {
                    client = clientes[i];
                    break;
                }
            }

            if (client == null) {
                return null;
            } else {
                return client;
            }
        }
    }
}
