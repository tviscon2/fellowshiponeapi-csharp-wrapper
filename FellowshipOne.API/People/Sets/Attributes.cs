using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Attributes : ApiSet<FellowshipOne.API.People.Model.Attribute> {
                #region Constructor
        public Attributes(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Properties
        protected override string GetUrl {
            get { throw new NotFiniteNumberException();}
        }

        private string _childGetUrl = "/v1/People/AttributeGroups/{0}/Attributes/{1}";
        protected override string GetChildUrl {
            get { return _childGetUrl; }
            set { _childGetUrl = value; }
        }

        private string _childListUrl = "/v1/People/AttributeGroups/{0}/Attributes";
        protected override string GetChildListUrl {
            get {
                return _childListUrl;
            }
            set {
                _childListUrl = value;
            }
        }

        protected override string ListUrl {
            get {
                throw new NotImplementedException();
            }
        }
        #endregion Properties

        #region Methods
        public List<FellowshipOne.API.People.Model.Attribute> GetAttributesByAttributeGroup(int attributeGroupID) {
            return base.List(attributeGroupID.ToString());
        }
        #endregion Methods
    }
}
