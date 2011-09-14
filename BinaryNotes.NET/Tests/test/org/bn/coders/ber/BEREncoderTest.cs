/*
 Copyright 2006-2011 Abdulla Abdurakhmanov (abdulla@latestbit.com)
 Original sources are available at www.latestbit.com

 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at

 http://www.apache.org/licenses/LICENSE-2.0

 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.
 */
using System;
using org.bn;
using org.bn.coders;
using csUnit;
using test.org.bn.coders.test_asn;

namespace test.org.bn.coders.ber
{
	
	public class BEREncoderTest:EncoderTest
	{
		protected CoderFactory coderFactory = new CoderFactory();
		
		public BEREncoderTest(System.String sTestName):base(sTestName, new BERCoderTestUtils())
		{			
		}

        public BEREncoderTest(System.String sTestName, CoderTestUtilities coderTestUtils)
            : base(sTestName, coderTestUtils)
        {
        }

        protected override IEncoder newEncoder()
        {
            return coderFactory.newEncoder("BER");
        }
	}
}