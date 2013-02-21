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
        private List<SubStatus> _subStatuses = new List<SubStatus>();

        [XmlArrayItem(ElementName="subStatus", Type=typeof(SubStatus))]
        public List<SubStatus> SubStatuses {
            get { return _subStatuses; }
            set { _subStatuses = value; }
        }
    }

    [Serializable]
    [XmlRoot("subStatus")]
    public class SubStatus : ParentNamedObject {
    }
}
