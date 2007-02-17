
package org.bn.mq.protocol;
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

import org.bn.*;
import org.bn.annotations.*;
import org.bn.annotations.constraints.*;
import org.bn.coders.*;
import org.bn.types.*;




    @ASN1PreparedElement
    @ASN1Sequence ( name = "LookupRequest", isSet = false )
    public class LookupRequest implements IASN1PreparedElement {
            
    @ASN1String( name = "", 
        stringType =  UniversalTag.PrintableString , isUCS = false )
    @ASN1ValueRangeConstraint ( 
		
		min = 0L, 
		
		max = 255L 
		
	   )
	   
        @ASN1Element ( name = "supplierName", isOptional =  false , hasTag =  false  , hasDefaultValue =  false  )
    
	private String supplierName = null;
                
  
        
        public String getSupplierName () {
            return this.supplierName;
        }

        

        public void setSupplierName (String value) {
            this.supplierName = value;
        }
        
  
                    
        
        public void initWithDefaults() {
            
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(LookupRequest.class);
        public IASN1PreparedElementData getPreparedData() {
            return preparedData;
        }

            
    }
            