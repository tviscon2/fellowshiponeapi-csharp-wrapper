using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Addresses : ApiSet<Model.Address> {
        private const string GET_URL = "/v1/addresses/{0}";
        private const string GET_CHILD_URL = "/v1/people/{0}/addresses{1}";
        private const string CHILD_LIST_URL = "/v1/people/{0}/addresses";
        private const string CREATE_URL = "/v1/addresses";
        private const string EDIT_URL = "/v1/addresses/{0}";

        public Addresses(OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string GetChildUrl { get { return GET_CHILD_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }
        
        public Model.Address CreateForPerson(int personID, Model.Address entity) {
            var url = string.Format("/v1/People/{0}/Addresses", personID);
            return Create(entity, url);
        }

        public Model.Address CreateForPerson(int personID, Model.Address entity, out string requestXml) {
            var url = string.Format("/v1/People/{0}/Addresses", personID);
            return Create(entity, out requestXml, url);
        }

        public Model.Address CreateForHousehold(int householdID, Model.Address entity) {
            var url = string.Format("/v1/Households/{0}/Addresses", householdID);
            return Create(entity, url);
        }

        public Model.Address CreateForHousehold(int householdID, Model.Address entity, out string requestXml) {
            var url = string.Format("/v1/Households/{0}/Addresses", householdID);
            return Create(entity, out requestXml, url);
        }
    }
}
