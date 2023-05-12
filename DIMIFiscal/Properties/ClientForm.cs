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

        public DataGridView ClientGrid { get { return clientGrid; } }


        public ClientForm() {
            InitializeComponent();

            //string fileName = "ClientsDB.txt";
            //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

        }

        /*private Form activeWindowClient = null;
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
        }*/

        private void btClientClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btAddClient_Click(object sender, EventArgs e) {


        }

    }
}
