using System.Collections.Generic;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Attributes : ApiSet<Model.Attribute> {
        private const string GET_CHILD_URL = "/v1/people/attributegroups/{0}/attributes/{1}";
        private const string CHILD_LIST_URL = "/v1/people/attributegroups/{0}/attributes";

        public Attributes(OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }

        protected override string GetChildUrl { get { return GET_CHILD_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }

        #region Methods
        public List<Model.Attribute> GetAttributesByAttributeGroup(int attributeGroupID) {
            return base.List(attributeGroupID.ToString());
        }
        #endregion Methods
    }
}
