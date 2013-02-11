using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.Giving.Sets {
    public class RDCBatchItems : ApiSet<FellowshipOne.API.Giving.Model.RDCBatchItem> {
        public RDCBatchItems(F1OAuthTicket ticket, string baseUrl)
            : base(ticket, baseUrl) {
        }

        private string _getUrl = "/giving/v1/rdcbatcheitems/{0}";
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

        private string _searchUrl = "/v1/rdcbatcheitems/Search";
        protected override string SearchUrl {
            get {
                return _searchUrl;
            }
            set {
                _searchUrl = value;
            }
        }

        private string _createUrl = "/giving/v1/rdcbatcheitems";
        protected override string CreateUrl {
            get { return this._createUrl; }
            set { this._createUrl = value; }
        }

        protected override string EditUrl {
            get {
                return "/giving/v1/rdcbatcheitems/{0}/Edit";
            }
            set {
                base.EditUrl = value;
            }
        }

        public override bool Create(byte[] stream) {
            CreateUrl = "/giving/v1/rdcbatcheitems/{0}/referenceimages";
            return base.Create(stream);
            CreateUrl = "/giving/v1/rdcbatcheitems";
        }        
    }
}
