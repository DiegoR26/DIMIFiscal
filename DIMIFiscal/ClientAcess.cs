using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMIFiscal {
    public class ClientAcess {

        private string FilePath;

        public ClientAcess(string filePath) {
            FilePath = filePath;
        }

        public List<Client> GetAllClients() {
            List<Client> clients = new List<Client>();

            try {
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines) {
                    string[] parts = line.Split(';');
                    Client client = new Client();
                    client.Id = parts[0];
                    client.Name = parts[1];
                    client.User = parts[2];
                    client.Password = parts[3];
                    client.SimplesNacional = parts[4];
                    clients.Add(client);
                }
            } catch (Exception ex) {
                Console.WriteLine("Erro lendo dados: " + ex.Message);
            }

            return clients;
        }

        public void AddClient(Client client) {
            string line = $"{client.Id};{client.Name};{client.User};{client.Password};{client.SimplesNacional}";

            try {
                File.AppendAllText(FilePath, line + Environment.NewLine);
            } catch (Exception ex) {
                Console.WriteLine("Erro ao adicionar cliente: " + ex.Message);
            }
        }

        public void EditClient(Client client) {
            try {
                List<string> lines = File.ReadAllLines(FilePath).ToList();

                for (int i = 0; i < lines.Count; i++) {
                    string[] parts = lines[i].Split(";");
                    if (parts[0] == client.Id) {
                        lines[i] = $"{client.Id};{client.Name};{client.User};{client.Password};{client.SimplesNacional}";
                        break;
                    }
                }

                File.WriteAllLines(FilePath, lines);
            } catch (Exception ex) {
                Console.WriteLine("Erro ao editar cliente: " + ex.Message);
            }
        }

        public void DeleteClient(string id) {
            try {
                List<string> lines = File.ReadAllLines(FilePath).ToList();

                for (int i = 0; i < lines.Count; i++) {
                    string[] parts = lines[i].Split(";");
                    if (parts[0] == id) {
                        lines.RemoveAt(i);
                        break;
                    }
                }

                File.WriteAllLines(FilePath, lines);
            } catch (Exception ex) {
                Console.WriteLine("Erro ao deletar cliente: " + ex.Message);
            }
        }
    }
}