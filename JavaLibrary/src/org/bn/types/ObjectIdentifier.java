/*
 * Copyright 2007 Abdulla G. Abdurakhmanov (abdulla.abdurakhmanov@gmail.com).
 * 
 * Licensed under the LGPL, Version 2 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.gnu.org/copyleft/lgpl.html
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * With any your questions welcome to my e-mail 
 * or blog at http://abdulla-a.blogspot.com.
 */

package org.bn.types;

/**
 * BitString represents ASN.1 OBJECT IDENTIFIER data types
 */
public class ObjectIdentifier {

    public ObjectIdentifier(String oidAsStr) {
        setValue(oidAsStr);
    }
    
    public ObjectIdentifier(byte[] oidAsBytes) {
         setValue(oidAsBytes);
    }
    
    public byte[] getValue() {
        // TODO
        return null;
    }
    
    public String getValueAsStr() {
        // TODO
        return null;
    }

    public void setValue(byte[] oidAsBytes) {
        // TODO
    }

    public void setValue(String oidAsStr) {
        // TODO
    }
}
