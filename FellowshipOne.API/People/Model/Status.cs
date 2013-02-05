using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using FellowshipOne.API.Model;

namespace FellowshipOne.API.People.Model {
    [Serializable]
    [XmlRoot("status")]
    public class Status : ParentNamedObject {
        private string _comment = string.Empty;
        [XmlElement("comment")]
        public string Comment {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _statusDate = string.Empty;
        [XmlElement("date")]
        public string StatusDate {
            get { return _statusDate; }
            set { _statusDate = value; }
        }

        private FellowshipOne.API.Model.ParentNamedObject _subStatus = new FellowshipOne.API.Model.ParentNamedObject();
        [XmlElement("subStatus")]
        public FellowshipOne.API.Model.ParentNamedObject SubStatus {
            get { return _subStatus; }
            set { _subStatus = value; }
        }
    }
}
