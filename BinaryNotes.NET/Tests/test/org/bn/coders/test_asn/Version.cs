
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

namespace test.org.bn.coders.test_asn {


    [ASN1PreparedElement]
    [ASN1Sequence ( Name = "Version", IsSet = true  )]
    public class Version : IASN1PreparedElement {
                    
	private Minor minor_ ;
	
        [ASN1Element ( Name = "minor", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public Minor Minor
        {
            get { return minor_; }
            set { minor_ = value;  }
        }
        
                
          
	private Major major_ ;
	
        [ASN1Element ( Name = "major", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public Major Major
        {
            get { return major_; }
            set { major_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Version));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
