﻿// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Context
{
	using System;
	using System.IO;

	public class InvalidSendContext :
		ISendContext
	{
		public string MessageId
		{
			get { throw CreateException(); }
		}

		public string MessageType
		{
			get { throw CreateException(); }
		}

		public Uri SourceAddress
		{
			get { throw CreateException(); }
		}

		public Uri InputAddress
		{
			get { throw CreateException(); }
		}

		public Uri DestinationAddress
		{
			get { throw CreateException(); }
		}

		public Uri ResponseAddress
		{
			get { throw CreateException(); }
		}

		public Uri FaultAddress
		{
			get { throw CreateException(); }
		}

		public string Network
		{
			get { throw CreateException(); }
		}

		public DateTime? ExpirationTime
		{
			get { throw CreateException(); }
		}

		public int RetryCount
		{
			get { throw CreateException(); }
		}

		public Guid Id
		{
			get { throw CreateException(); }
		}

		public Type DeclaringMessageType
		{
			get { throw CreateException(); }
		}

		public string ContentType
		{
			get { throw CreateException(); }
		}

		public void SerializeTo(Stream stream)
		{
			throw CreateException();
		}

		public bool TryGetContext<T>(out IBusPublishContext<T> context) where T : class
		{
			throw CreateException();
		}

		public void NotifySend(IEndpointAddress address)
		{
			throw CreateException();
		}

		static ContextException CreateException()
		{
			return new ContextException("Send/Publish context is only available when consuming a message");
		}
	}
}