using System;
using System.Collections.Generic;
using System.Text;

namespace MessageConsumerService.Entities
{
	public class RawMessage : DomainModel.RawMessage
	{
		public RawMessage(long sequenceNumber, byte[] bodyAsBytes)
		{
			SequenceNumber = sequenceNumber;
			BodyAsBytes = bodyAsBytes;
		}

		public long SequenceNumber { get; private set; }

		public byte[] BodyAsBytes { get; private set; }

		public string BodyAsString
		{
			get
			{
				if (_bodyAsString == null)
					_bodyAsString = Encoding.UTF8.GetString(BodyAsBytes);

				return _bodyAsString;
			}
		}

		private string _bodyAsString { get; set; } = null;
	}
}
