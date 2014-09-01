﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ElasticSearchReadModel.Documents;
using ElasticSearchReadModel.Repositories;

namespace UI.Controllers
{
    public class ClientsController : ApiController
    {
        // GET: api/Client
        public IEnumerable<ClientInformation> Get()
        {
            var rep = new ClientInformationRepository();

            return rep.GetClientsBy(null);
        }

        // GET: api/Client/pepe
        public IEnumerable<ClientInformation> Get(string clientName)
        {
            var rep = new ClientInformationRepository();

            return rep.GetClientsBy(clientName);
        }

        // POST: api/Client
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
