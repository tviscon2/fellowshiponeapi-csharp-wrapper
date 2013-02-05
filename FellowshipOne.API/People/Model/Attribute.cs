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
    [XmlRoot("attribute")]
    public class Attribute : ParentNamedObject {
    }
}
