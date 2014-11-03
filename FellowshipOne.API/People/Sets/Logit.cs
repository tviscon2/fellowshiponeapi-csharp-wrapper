using Restify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FellowshipOne.API.People.Sets {
    public class Logit : ApiSet<Model.Logit> {
        private const string CREATE_URL = "/v1/logit";

        public Logit(OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }

        protected override string CreateUrl { get { return CREATE_URL; } }

        public Model.Logit CreateLogEntry(Model.Logit entity, out string requestXml) {
            var url = CREATE_URL;
            return Create(entity, out requestXml, url);
        }
    }
}
