
using bank.models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bank.Repository
{
    public class ClientStorage
    {
        private readonly Dictionary<int, client> clients = new();

        public client Create(client Client)
        {
            clients.Add(Client.Id, Client);
            return Client;
        }

        public client Read(int Id)
        {
            return clients[Id];
        }

        public client Update(int Id, client newAuthor)
        {
            clients[Id] = newAuthor;
            return clients[Id];
        }

        public bool Delete(int Id)
        {
            return clients.Remove(Id);
        }
    }
}