using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Households : ApiSet<FellowshipOne.API.People.Model.Household> {
        private const string GET_URL = "/v1/households/{0}";
        private const string SEARCH_URL = "/v1/households/search";
        private const string CREATE_URL = "/v1/households";
        private const string EDIT_URL = "/v1/households/{0}";

        public Households(OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }
    }
}
