using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIMIFiscal.Properties {
    public partial class ClientView : Form {

        public string Id { get { return txtId.Text; } }
        public string CName { get { return txtName.Text; } }
        public string User { get { return txtUser.Text; } }
        public string Password { get { return txtPassword.Text; } }
        public string SimplesNacional {
            get {
                if (checkSimples.Checked) {
                    return "sim";
                } else {
                    return "no";
                }
            }
        }

        public Button BtClientOk { get { return btClientOk; } }

        public ClientView() {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (txtId.Text == "" || txtName.Text == "" || txtUser.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Faltam dados!", "Aviso");
            } else {
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
