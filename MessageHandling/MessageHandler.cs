using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MessageHandling
{
	public class MessageHandler
	{
		public async Task HandleMessage(CancellationToken cancellationToken, DomainModel.RawMessage rawMessage)
		{
			// TODO - mention timeouts here.  I think the ServiceBus will "give up" on us if we haven't completed the message in a certain
			// amount of time.
			
			

			// From here out we'll use the RawMessage instead of the method inputs.

			// Process the message.
			Console.WriteLine($"Received message: SequenceNumber:{rawMessage.SequenceNumber} Body:{Encoding.UTF8.GetString(rawMessage.BodyAsBytes)}");

			// Important note - completion of the message (ACKing that it was processed successfully) is implicit - if no exception
			// is raised then it'll be completed in the code that calls this method.
		}
	}
}
