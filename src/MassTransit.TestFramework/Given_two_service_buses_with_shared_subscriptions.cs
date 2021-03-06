// Copyright 2007-2008 The Apache Software Foundation.
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
namespace MassTransit.TestFramework
{
	using System;
	using Fixtures;
	using Magnum.TestFramework;
	using MassTransit.Transports;
	using MassTransit.Transports.Loopback;

	[Scenario]
	public class Given_two_service_buses_with_shared_subscriptions :
		LocalAndRemoteTestFixture<LoopbackTransportFactory>
	{
		protected Given_two_service_buses_with_shared_subscriptions()
		{
			LocalUri = new Uri("loopback://localhost/mt_client");
			RemoteUri = new Uri("loopback://localhost/mt_server");
		}
	}
}