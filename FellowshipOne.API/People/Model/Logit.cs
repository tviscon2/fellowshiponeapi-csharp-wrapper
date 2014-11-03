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
    [XmlRoot("logit")]
    public class Logit : ParentNamedObject {
        private FellowshipOne.API.Model.ParentObject _person = new ParentObject();
        [XmlElement("person")]
        public FellowshipOne.API.Model.ParentObject Person {
            get { return _person; }
            set { _person = value; }
        }

        private FellowshipOne.API.Model.ParentObject _application = new ParentObject();
        [XmlElement("application")]
        public FellowshipOne.API.Model.ParentObject Application {
            get { return _application; }
            set { _application = value; }
        }

        private FellowshipOne.API.Model.ParentObject _messageDefinition = new ParentObject();
        [XmlElement("messageDefinition")]
        public FellowshipOne.API.Model.ParentObject MessageDefinition {
            get { return _messageDefinition; }
            set { _messageDefinition = value; }
        }

        private FellowshipOne.API.Model.ParentObject _severity = new ParentObject();
        [XmlElement("severity")]
        public FellowshipOne.API.Model.ParentObject Severity {
            get { return _severity; }
            set { _severity = value; }
        }

        private string _machineName = string.Empty;
        [XmlElement("machineName")]
        public string MachineName {
            get { return _machineName; }
            set { _machineName = value; }
        }

        private string _messageText = string.Empty;
        [XmlElement("messageText")]
        public string MessageText {
            get { return _messageText; }
            set { _messageText = value; }
        }

        private string _column1 = string.Empty;
        [XmlElement("column1")]
        public string Column1 {
            get { return _column1; }
            set { _column1 = value; }
        }

        private string _column2 = string.Empty;
        [XmlElement("column2")]
        public string Column2 {
            get { return _column2; }
            set { _column2 = value; }
        }

        private string _column3 = string.Empty;
        [XmlElement("column3")]
        public string Column3 {
            get { return _column3; }
            set { _column3 = value; }
        }

        private string _column4 = string.Empty;
        [XmlElement("column4")]
        public string Column4 {
            get { return _column4; }
            set { _column4 = value; }
        }

        private string _column5 = string.Empty;
        [XmlElement("column5")]
        public string Column5 {
            get { return _column5; }
            set { _column5 = value; }
        }

        private string _column6 = string.Empty;
        [XmlElement("column6")]
        public string Column6 {
            get { return _column6; }
            set { _column6 = value; }
        }

        private string _column7 = string.Empty;
        [XmlElement("column7")]
        public string Column7 {
            get { return _column7; }
            set { _column7 = value; }
        }

        private string _column8 = string.Empty;
        [XmlElement("column8")]
        public string Column8 {
            get { return _column8; }
            set { _column8 = value; }
        }

        private string _column9 = string.Empty;
        [XmlElement("column9")]
        public string Column9 {
            get { return _column9; }
            set { _column9 = value; }
        }
    }
}
