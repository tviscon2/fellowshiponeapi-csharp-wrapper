﻿using Restify;

namespace FellowshipOne.API.People.Sets {
    public class People : ApiSet<Model.Person> {
        private const string GET_URL = "/v1/people/{0}";
        private const string SEARCH_URL = "/v1/people/search";
        private const string CHILD_LIST_URL = "/v1/households/{0}/people";
        private const string CREATE_URL = "/v1/people";
        private const string EDIT_URL = "/v1/people/{0}";

        public People(OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }

        protected override string GetUrl { get { return GET_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }
        protected override string GetChildListUrl { get { return CHILD_LIST_URL; } }
        protected override string CreateUrl { get { return CREATE_URL; } }
        protected override string EditUrl { get { return EDIT_URL; } }
    }
}
