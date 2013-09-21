using System;
using FellowshipOne.API.Model;
using System.Xml;
using System.Xml.Serialization;

namespace FellowshipOne.API.People.Model {
    [Serializable]
    public partial class AccessRight : ApiModel {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("accessRightGroup")]
        private ParentNamedObject _accessRightGroup = new ParentNamedObject();
        public ParentNamedObject AccessRightGroup {
            get { return _accessRightGroup; }
            set { _accessRightGroup = value; }
        }
    }
}
