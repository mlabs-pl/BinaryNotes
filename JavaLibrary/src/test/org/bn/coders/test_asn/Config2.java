
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
    @ASN1BoxedType ( name = "Config2" )
    public class Config2 implements IASN1PreparedElement {
                
        

       @ASN1PreparedElement
       @ASN1Sequence ( name = "Config2" , isSet = false )
       public static class Config2SequenceType implements IASN1PreparedElement {
                
        @ASN1Element ( name = "lstVersion", isOptional =  false , hasTag =  false  , hasDefaultValue =  false  )
    
	private LstVersion lstVersion = null;
                
  
        @ASN1Element ( name = "major_config", isOptional =  false , hasTag =  false  , hasDefaultValue =  false  )
    
	private Major major_config = null;
                
  
        
        public LstVersion getLstVersion () {
            return this.lstVersion;
        }

        

        public void setLstVersion (LstVersion value) {
            this.lstVersion = value;
        }
        
  
        
        public Major getMajor_config () {
            return this.major_config;
        }

        

        public void setMajor_config (Major value) {
            this.major_config = value;
        }
        
  
                
                
        public void initWithDefaults() {
            
        }

        public IASN1PreparedElementData getPreparedData() {
            return preparedData_Config2SequenceType;
        }

       private static IASN1PreparedElementData preparedData_Config2SequenceType = CoderFactory.getInstance().newPreparedElementData(Config2SequenceType.class);
                
       }

       
                
        @ASN1Element ( name = "Config2", isOptional =  false , hasTag =  true, tag = 79, 
        tagClass =  TagClass.Application  , hasDefaultValue =  false  )
    
        private Config2SequenceType  value;        

        
        
        public Config2 () {
        }
        
        
        
        public void setValue(Config2SequenceType value) {
            this.value = value;
        }
        
        
        
        public Config2SequenceType getValue() {
            return this.value;
        }            
        

	    public void initWithDefaults() {
	    }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(Config2.class);
        public IASN1PreparedElementData getPreparedData() {
            return preparedData;
        }

            
    }
            