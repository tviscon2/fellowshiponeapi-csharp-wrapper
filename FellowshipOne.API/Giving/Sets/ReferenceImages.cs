using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FellowshipOne.API.Giving.Sets {
    public class ReferenceImages : ApiSet<FellowshipOne.API.Giving.Model.ReferenceImage> { {
        public ReferenceImages(F1OAuthTicket ticket, string baseUrl)
            : base(ticket, baseUrl) {
        }

        private string _getUrl = "/giving/v1/referenceimages/{0}";
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

        private string _searchUrl = "/giving/v1/referenceimages/Search";
        protected override string SearchUrl {
            get {
                return _searchUrl;
            }
            set {
                _searchUrl = value;
            }
        }

        private string _createUrl = "/giving/v1/referenceimages";
        protected override string CreateUrl
        {
            get { return this._createUrl; }
            set { this._createUrl = value; }
        }

        protected override string EditUrl {
            get {
                return "/giving/v1/referenceimages/{0}";
            }
            set {
                base.EditUrl = value;
            }
        }
    }
    }
}
