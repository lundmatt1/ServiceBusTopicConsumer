using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DomainModel
{
	public interface RawMessage
	{
		long SequenceNumber { get; }
		byte[] BodyAsBytes { get; }
		string BodyAsString { get; }
	}
}
