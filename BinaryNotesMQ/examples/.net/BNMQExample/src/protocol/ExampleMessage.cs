
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

namespace org.bn.mq.examples.protocol {


    [ASN1PreparedElement]
    [ASN1Sequence ( Name = "ExampleMessage", IsSet = false  )]
    public class ExampleMessage : IASN1PreparedElement {
                    
	private string field1_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.PrintableString , IsUCS = false )]
        [ASN1Element ( Name = "field1", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public string Field1
        {
            get { return field1_; }
            set { field1_ = value;  }
        }
        
                
          
	private long field2_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "field2", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public long Field2
        {
            get { return field2_; }
            set { field2_ = value;  }
        }
        
                
          
	private byte[] field3_ ;
	
        private bool  field3_present = false ;
	[ASN1OctetString( Name = "" )]
    
        [ASN1Element ( Name = "field3", IsOptional =  true , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public byte[] Field3
        {
            get { return field3_; }
            set { field3_ = value; field3_present = true;  }
        }
        
                
          
	private string field4_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.UTF8String , IsUCS = false )]
        [ASN1Element ( Name = "field4", IsOptional =  false , HasTag =  false  , HasDefaultValue =  true )  ]
    
        public string Field4
        {
            get { return field4_; }
            set { field4_ = value;  }
        }
        
                
  
        public bool isField3Present () {
            return this.field3_present == true;
        }
        

            public void initWithDefaults() {
                string param_Field4 =         
            "Hello";
        Field4 = param_Field4;
    
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ExampleMessage));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
