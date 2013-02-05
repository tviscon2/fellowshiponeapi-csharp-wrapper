using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipOne.API.Realms {
    public class Giving {
        
        #region Properties
        F1OAuthTicket _ticket { get; set; }
        string _baseUrl { get; set; }

        private FellowshipOne.API.Giving.Sets.Batches _batches;
        public FellowshipOne.API.Giving.Sets.Batches Batches {
            get {
                if (_batches == null) {
                    _batches = new FellowshipOne.API.Giving.Sets.Batches(_ticket, _baseUrl);
                }
                return _batches;
            }
        }

        private FellowshipOne.API.Giving.Sets.RDCBatches _rDCBatches;
        public FellowshipOne.API.Giving.Sets.RDCBatches RDCBatches
        {
            get
            {
                if (_rDCBatches == null)
                {
                    _rDCBatches = new FellowshipOne.API.Giving.Sets.RDCBatches(_ticket, _baseUrl);
                }
                return _rDCBatches;
            }
        }

        private FellowshipOne.API.Giving.Sets.RDCBatchItems _rDCBatchItems;
        public FellowshipOne.API.Giving.Sets.RDCBatchItems RDCBatchItems
        {
            get
            {
                if (_rDCBatchItems == null)
                {
                    _rDCBatchItems = new FellowshipOne.API.Giving.Sets.RDCBatchItems(_ticket, _baseUrl);
                }
                return _rDCBatchItems;
            }
        }
        #endregion Properties

        #region Constructor
        public Giving(F1OAuthTicket ticket, string baseUrl) {
            _ticket = ticket;
            _baseUrl = baseUrl;
        }
        #endregion Constructor
    }
}
