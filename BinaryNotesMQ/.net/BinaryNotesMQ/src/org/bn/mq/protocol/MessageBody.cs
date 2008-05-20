
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
    [ASN1Choice ( Name = "MessageBody") ]
    public class MessageBody : IASN1PreparedElement {
                    
        
	private MessageUserBody messageUserBody_ ;
        private bool  messageUserBody_selected = false ;
        
                
        
        [ASN1Element ( Name = "messageUserBody", IsOptional =  false , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public MessageUserBody MessageUserBody
        {
            get { return messageUserBody_; }
            set { selectMessageUserBody(value); }
        }
        
                
          
        
	private DeliveryReport deliveryReport_ ;
        private bool  deliveryReport_selected = false ;
        
                
        
        [ASN1Element ( Name = "deliveryReport", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public DeliveryReport DeliveryReport
        {
            get { return deliveryReport_; }
            set { selectDeliveryReport(value); }
        }
        
                
          
        
	private SubscribeRequest subscribeRequest_ ;
        private bool  subscribeRequest_selected = false ;
        
                
        
        [ASN1Element ( Name = "subscribeRequest", IsOptional =  false , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    
        public SubscribeRequest SubscribeRequest
        {
            get { return subscribeRequest_; }
            set { selectSubscribeRequest(value); }
        }
        
                
          
        
	private SubscribeResult subscribeResult_ ;
        private bool  subscribeResult_selected = false ;
        
                
        
        [ASN1Element ( Name = "subscribeResult", IsOptional =  false , HasTag =  true, Tag = 3 , HasDefaultValue =  false )  ]
    
        public SubscribeResult SubscribeResult
        {
            get { return subscribeResult_; }
            set { selectSubscribeResult(value); }
        }
        
                
          
        
	private UnsubscribeRequest unsubscribeRequest_ ;
        private bool  unsubscribeRequest_selected = false ;
        
                
        
        [ASN1Element ( Name = "unsubscribeRequest", IsOptional =  false , HasTag =  true, Tag = 4 , HasDefaultValue =  false )  ]
    
        public UnsubscribeRequest UnsubscribeRequest
        {
            get { return unsubscribeRequest_; }
            set { selectUnsubscribeRequest(value); }
        }
        
                
          
        
	private UnsubscribeResult unsubscribeResult_ ;
        private bool  unsubscribeResult_selected = false ;
        
                
        
        [ASN1Element ( Name = "unsubscribeResult", IsOptional =  false , HasTag =  true, Tag = 5 , HasDefaultValue =  false )  ]
    
        public UnsubscribeResult UnsubscribeResult
        {
            get { return unsubscribeResult_; }
            set { selectUnsubscribeResult(value); }
        }
        
                
          
        
	private LookupRequest lookupRequest_ ;
        private bool  lookupRequest_selected = false ;
        
                
        
        [ASN1Element ( Name = "lookupRequest", IsOptional =  false , HasTag =  true, Tag = 6 , HasDefaultValue =  false )  ]
    
        public LookupRequest LookupRequest
        {
            get { return lookupRequest_; }
            set { selectLookupRequest(value); }
        }
        
                
          
        
	private LookupResult lookupResult_ ;
        private bool  lookupResult_selected = false ;
        
                
        
        [ASN1Element ( Name = "lookupResult", IsOptional =  false , HasTag =  true, Tag = 7 , HasDefaultValue =  false )  ]
    
        public LookupResult LookupResult
        {
            get { return lookupResult_; }
            set { selectLookupResult(value); }
        }
        
                
          
        
	private AliveRequest aliveRequest_ ;
        private bool  aliveRequest_selected = false ;
        
                
        
        [ASN1Element ( Name = "aliveRequest", IsOptional =  false , HasTag =  true, Tag = 8 , HasDefaultValue =  false )  ]
    
        public AliveRequest AliveRequest
        {
            get { return aliveRequest_; }
            set { selectAliveRequest(value); }
        }
        
                
          
        public bool isMessageUserBodySelected () {
            return this.messageUserBody_selected ;
        }

        


        public void selectMessageUserBody (MessageUserBody val) {
            this.messageUserBody_ = val;
            this.messageUserBody_selected = true;
            
            
                    this.deliveryReport_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.lookupResult_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isDeliveryReportSelected () {
            return this.deliveryReport_selected ;
        }

        


        public void selectDeliveryReport (DeliveryReport val) {
            this.deliveryReport_ = val;
            this.deliveryReport_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.lookupResult_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isSubscribeRequestSelected () {
            return this.subscribeRequest_selected ;
        }

        


        public void selectSubscribeRequest (SubscribeRequest val) {
            this.subscribeRequest_ = val;
            this.subscribeRequest_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.deliveryReport_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.lookupResult_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isSubscribeResultSelected () {
            return this.subscribeResult_selected ;
        }

        


        public void selectSubscribeResult (SubscribeResult val) {
            this.subscribeResult_ = val;
            this.subscribeResult_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.deliveryReport_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.lookupResult_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isUnsubscribeRequestSelected () {
            return this.unsubscribeRequest_selected ;
        }

        


        public void selectUnsubscribeRequest (UnsubscribeRequest val) {
            this.unsubscribeRequest_ = val;
            this.unsubscribeRequest_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.deliveryReport_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.lookupResult_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isUnsubscribeResultSelected () {
            return this.unsubscribeResult_selected ;
        }

        


        public void selectUnsubscribeResult (UnsubscribeResult val) {
            this.unsubscribeResult_ = val;
            this.unsubscribeResult_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.deliveryReport_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.lookupResult_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isLookupRequestSelected () {
            return this.lookupRequest_selected ;
        }

        


        public void selectLookupRequest (LookupRequest val) {
            this.lookupRequest_ = val;
            this.lookupRequest_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.deliveryReport_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupResult_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isLookupResultSelected () {
            return this.lookupResult_selected ;
        }

        


        public void selectLookupResult (LookupResult val) {
            this.lookupResult_ = val;
            this.lookupResult_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.deliveryReport_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.aliveRequest_selected = false;
                            
        }
        
          
        public bool isAliveRequestSelected () {
            return this.aliveRequest_selected ;
        }

        


        public void selectAliveRequest (AliveRequest val) {
            this.aliveRequest_ = val;
            this.aliveRequest_selected = true;
            
            
                    this.messageUserBody_selected = false;
                
                    this.deliveryReport_selected = false;
                
                    this.subscribeRequest_selected = false;
                
                    this.subscribeResult_selected = false;
                
                    this.unsubscribeRequest_selected = false;
                
                    this.unsubscribeResult_selected = false;
                
                    this.lookupRequest_selected = false;
                
                    this.lookupResult_selected = false;
                            
        }
        
  

            public void initWithDefaults()
	    {
	    }

            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(MessageBody));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
