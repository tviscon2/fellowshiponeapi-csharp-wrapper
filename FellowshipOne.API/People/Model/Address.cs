using System;
using FellowshipOne.API.Model;
using System.Xml;
using System.Xml.Serialization;

namespace FellowshipOne.API.People.Model {

    [Serializable]
    [XmlRoot("address")]
    public partial class Address : ApiModel {
        private ParentObject _household = new ParentObject();
        [XmlElement("household")]
        public ParentObject Household {
            get { return _household; }
            set { _household = value; }
        }

        private ParentObject _person = new ParentObject();
        [XmlElement("person")]
        public ParentObject Person {
            get { return _person; }
            set { _person = value; }
        }

        private ParentNamedObject _addressType = new ParentNamedObject();
        [XmlElement("addressType")]
        public ParentNamedObject AddressType {
            get { return _addressType; }
            set { _addressType = value; }
        }

        private string _address1 = string.Empty;
        [XmlElement("address1")]
        public string Address1 {
            get { return _address1; }
            set { _address1 = value; }
        }

        private string _address2 = string.Empty;
        [XmlElement("address2")]
        public string Address2 {
            get { return _address2; }
            set { _address2 = value; }
        }

        private string _address3 = string.Empty;
        [XmlElement("address3")]
        public string Address3 {
            get { return _address3; }
            set { _address3 = value; }
        }

        private string _city = string.Empty;
        [XmlElement("city")]
        public string City {
            get { return _city; }
            set { _city = value; }
        }

        private string _postalCode = string.Empty;
        [XmlElement("postalCode")]
        public string PostalCode {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        private string _county = string.Empty;
        [XmlElement("county")]
        public string County {
            get { return _county; }
            set { _county = value; }
        }

        private string _country = string.Empty;
        [XmlElement("country")]
        public string Country {
            get { return _country; }
            set { _country = value; }
        }

        private string _stProvince = string.Empty;
        [XmlElement("stProvince")]
        public string StProvince {
            get { return _stProvince; }
            set { _stProvince = value; }
        }

        private string _carrierRoute = string.Empty;
        [XmlElement("carrierRoute")]
        public string CarrierRoute {
            get { return _carrierRoute; }
            set { _carrierRoute = value; }
        }

        private string _deliveryPoint = string.Empty;
        [XmlElement("deliveryPoint")]
        public string DeliveryPoint {
            get { return _deliveryPoint; }
            set { _deliveryPoint = value; }
        }

        [XmlElement("addressDate")]
        public DateTime? AddressDate { get; set; }

        private string _addressComment = string.Empty;
        [XmlElement("addressComment")]
        public string AddressComment {
            get { return _addressComment; }
            set { _addressComment = value; }
        }

        [XmlElement("uspsVerified")]
        public bool UspsVerified { get; set; }

        [XmlElement("addressVerifiedDate")]
        public DateTime? AddressVerifiedDate { get; set; }

        [XmlElement("lastVerificationAttemptDate")]
        public DateTime? LastVerificationAttemptDate { get; set; }

        [XmlElement("createdDate")]
        public DateTime? CreatedDate { get; set; }

        [XmlElement("lastUpdatedDate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}