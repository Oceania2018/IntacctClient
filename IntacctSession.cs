using System;

namespace Intacct
{
	public class IntacctSession : IIntacctSession
	{
		public string SessionId { get; private set; }
		public Uri EndpointUri { get; private set; }

		internal IntacctSession(string sessionId, Uri endpointUri)
		{
			SessionId = sessionId;
			EndpointUri = endpointUri;
		}
	}
}
