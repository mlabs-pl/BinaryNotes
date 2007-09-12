
package test.org.bn.coders.test_asn;
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
    @ASN1BoxedType ( name = "ITUType3" )
    public class ITUType3 implements IASN1PreparedElement {
                
        
        @ASN1Element ( name = "ITUType3", isOptional =  false , hasTag =  true, tag = 2 , hasDefaultValue =  false  )
    
        private ITUType2  value;        

        
        
        public ITUType3 () {
        }
        
        
        
        public void setValue(ITUType2 value) {
            this.value = value;
        }
        
        
        
        public ITUType2 getValue() {
            return this.value;
        }            
        

	    public void initWithDefaults() {
	    }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(ITUType3.class);
        public IASN1PreparedElementData getPreparedData() {
            return preparedData;
        }

            
    }
            