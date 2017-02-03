using System;

namespace Messenger
{
	public class MessengerSource
	{
		private String _source;

		public MessengerSource ()
		{
			Source = "0x";
		}
			
		public String Source
		{
			get 
			{ 
				return _source; 
			}
			set 
			{
				_source = "";			
			}
		}
	}
}

