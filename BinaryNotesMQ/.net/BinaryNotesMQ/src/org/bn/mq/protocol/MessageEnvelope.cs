
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace org.bn.mq.protocol {


    [ASN1PreparedElement]
    [ASN1Sequence ( Name = "MessageEnvelope", IsSet = false  )]
    public class MessageEnvelope : IASN1PreparedElement {
                    
	private string id_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.PrintableString , IsUCS = false )][ASN1ValueRangeConstraint ( 
		Min = 0L, 
		Max = 255L ) ]
	    
        [ASN1Element ( Name = "id", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public string Id
        {
            get { return id_; }
            set { id_ = value;  }
        }
        
                
          
	private bool deliveryReportReq_ ;
	[ASN1Boolean( Name = "" )]
    
        [ASN1Element ( Name = "deliveryReportReq", IsOptional =  false , HasTag =  false  , HasDefaultValue =  true )  ]
    
        public bool DeliveryReportReq
        {
            get { return deliveryReportReq_; }
            set { deliveryReportReq_ = value;  }
        }
        
                
          
	private MessageBody body_ ;
	
        [ASN1Element ( Name = "body", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public MessageBody Body
        {
            get { return body_; }
            set { body_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
                bool param_DeliveryReportReq =         
            false;
        DeliveryReportReq = param_DeliveryReportReq;
    
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(MessageEnvelope));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
