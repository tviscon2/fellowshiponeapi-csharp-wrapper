using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;
using FellowshipOne.API.Giving.Model;

namespace FellowshipOne.API.Giving.Sets {
    public class Batches : ApiSet<FellowshipOne.API.Giving.Model.Batch> {
        public Batches(F1OAuthTicket ticket, string baseUrl)
            : base(ticket, baseUrl) {
        }

        private string _getUrl = "/giving/v1/batches/{0}";
        protected override string GetUrl {
            get {
                return _getUrl;
            }
            set {
                _getUrl = value;
            }
        }

        protected override string ListUrl {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        private string _searchUrl = "/giving/v1/Batches/Search";
        protected override string SearchUrl {
            get {
                return _searchUrl;
            }
            set {
                _searchUrl = value;
            }
        }

        private string _createUrl = "/giving/v1/Batches";
        protected override string CreateUrl
        {
            get { return this._createUrl; }
            set { this._createUrl = value; }
        }

        protected override string EditUrl {
            get {
                return "/giving/v1/batches/{0}";
            }
            set {
                base.EditUrl = value;
            }
        }
                                                           
        private string _autoMatch = "/giving/v1/batches/{0}/System_Automatch";
        public string CreateAutoMatchURL {
            get {
                return _autoMatch;
            }
            set {
                _autoMatch = value;
            }
        }

        public void GetSystemAutoMatch(Batch batch, string id) {
            GetUrl = String.Format("/giving/v1/batches/{0}/System_Automatch", id);
            base.Get(id);
            GetUrl = "/giving/v1/batches/{0}";
        }
    }
}
