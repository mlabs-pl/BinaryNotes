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

package org.bn.mq.net;

import java.io.IOException;
import java.net.URI;
import java.nio.ByteBuffer;
import org.bn.mq.protocol.MessageEnvelope;

public interface ITransport {
    void send(ByteBuffer buffer) throws IOException;
    void sendAsync(ByteBuffer buffer) throws IOException;
    
    void send(byte[] buffer) throws IOException;
    void sendAsync(byte[] buffer) throws IOException;
    
    void send(MessageEnvelope message) throws Exception;
    void sendAsync(MessageEnvelope message) throws Exception;
    MessageEnvelope call(MessageEnvelope message) throws Exception;
    MessageEnvelope call(MessageEnvelope message, int timeout) throws Exception;
    void callAsync(MessageEnvelope message, ITransportCallListener listener) throws Exception;
    void callAsync(MessageEnvelope message, ITransportCallListener listener, int timeout) throws Exception;
    
    URI getAddr();
    
    void addConnectionListener(ITransportConnectionListener listener);
    void delConnectionListener(ITransportConnectionListener listener);

    void addReader(ITransportReader listener);
    void delReader(ITransportReader listener);
    void setUnhandledMessagesReader(ITransportReader listener);
    
    boolean isAvailable();
    
    void start() throws Exception;
    void close();
}
