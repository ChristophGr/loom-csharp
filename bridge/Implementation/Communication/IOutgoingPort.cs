﻿/***
 * Licensed to the Austrian Association for Software Tool Integration (AASTI)
 * under one or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information regarding copyright
 * ownership. The AASTI licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 ***/
using System;

namespace Org.Openengsb.Loom.CSharp.Bridge.Implementation.Communication
{
    /// <summary>
    /// This interfaces specifies the operations for a communication port.
    /// The interface supports sending and receiving text messages over any arbitrary protocol.
    /// </summary>
    public interface IOutgoingPort: IPort
    {
        /// <summary>
        /// Definition to send a message
        /// </summary>
        /// <param name="Text">message to send</param>
        void Send(string Text);
        /// <summary>
        /// Definition to send a message and define ReplyTo
        /// </summary>
        /// <param name="Text">message to send</param>
        /// <param name="ReplyTo">ReplyTo parameter</param>
        void Send(string Text, String ReplyTo);
    }
}
