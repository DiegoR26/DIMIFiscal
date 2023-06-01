using OpenQA.Selenium.DevTools.V113.FedCm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIMIFiscal.Properties {
    public partial class NFForm : Form {

        private List<string> checkedClientsString;
        private List<Client> checkedClients;

        ClientAcess cAcess;
        AcessoPOA APOA;

        public NFForm() {
            InitializeComponent();

            string fileName = "ClientsDB.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            cAcess = new ClientAcess(path);
        }

        public string getEmissor() {
            if (radioPres.Checked) { 
                return "prestados"; 
            } else {
                return "tomados";
            }
            
        }

        public string getDtCompIni() {
            return dtCompIni.Value.ToString("ddMMyyyy");
        }

        public string getDtCompFin() {
            return dtCompFin.Value.ToString("ddMMyyyy");
        }

        public string getDtEmitIni() {
            return dtEmitIni.Value.ToString("ddMMyyyy");
        }

        public string getDtEmitFin() {
            return dtEmitFin.Value.ToString("ddMMyyyy");
        }

        public string getCheckXML() {
            if (checkXML.Checked) { 
                return "XMLSim"; 
            } else {
                return "XMLNao";
            }
            
        }

        public string getCheckPDF() {
            if (checkPDF.Checked) { 
                return "PDFSim"; 
            } else {
                return "PDFNao";
            }
            
        }

        public void setClientList(List<Client> clientList) {

            clientList.ForEach(client => {
                checkedClientList.Items.Add(client.Name);
            });
        }

        public List<string> listCheckedClients() {
            checkedClientsString = new List<string>();

            for (int i = 0; i < checkedClientList.CheckedItems.Count; i++) {
                string checkedClient = checkedClientList.CheckedItems[i].ToString();
                checkedClientsString.Add(checkedClient);
            }

            return checkedClientsString;
        }


        private void btNFClose_Click(object sender, EventArgs e) {
            Dispose();
            Close();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void btBaixarNF_Click(object sender, EventArgs e) {

            checkedClientsString = listCheckedClients();
            List<Client> allClients = cAcess.GetAllClients();
            checkedClients = new List<Client>();

            for (int i = 0; i < checkedClientsString.Count; i++) {
                if (allClients.Any(client => client.Name == checkedClientsString[i])) {
                    Client matchedClient = allClients.First(client => client.Name == checkedClientsString[i]);
                    checkedClients.Add(matchedClient);
                }
            }

            for (int i = 0; i < checkedClients.Count; i++) {
                APOA = new AcessoPOA(checkedClients[i], getEmissor(), getDtCompIni(), getDtCompFin(), getDtEmitIni(), getDtEmitFin(), getCheckXML(), getCheckPDF());
                APOA.validarAcessoPOA();
                    
            }

            MessageBox.Show("Processo concluído!", "Belezinha", MessageBoxButtons.OK,MessageBoxIcon.None);

        }

        
    }
}
