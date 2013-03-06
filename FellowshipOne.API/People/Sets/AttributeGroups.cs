using Restify;

namespace FellowshipOne.API.People.Sets {
    public class AttributeGroups : ApiSet<FellowshipOne.API.People.Model.AttributeGroup> {
        private const string GET_URL = "/v1/people/attributegroups/{0}";
        private const string LIST_URL = "/v1/people/attributegroups";

        public AttributeGroups(OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string ListUrl { get { return LIST_URL; } }
    }
}