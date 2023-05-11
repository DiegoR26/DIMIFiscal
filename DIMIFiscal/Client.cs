using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMIFiscal {
    public class Client {

        public string Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string SimplesNacional { get; set; }


        public Client() { 
        }
        public Client(string id, string name, string user, string password, string simplesNacional) {
            Id = id;
            Name = name;
            User = user;
            Password = password;
            SimplesNacional = simplesNacional;
        }
    }
}
