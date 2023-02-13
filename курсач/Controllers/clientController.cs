using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.Extensions.Msal;

using bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bank.models;

namespace bank.Controllers
{
    [ApiController]
    [Route("/client")]
    public class BatchController : ControllerBase
    {
        [HttpPut]
        public client Create(client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet]
        public client Read(int Id)
        {
            return Storage.ClientStorage.Read(Id);
        }

        [HttpPatch]
        public client Update(int Id, client newclient)
        {
            return Storage.ClientStorage.Update(Id, newclient);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.ClientStorage.Delete(Id);
        }
    }

}