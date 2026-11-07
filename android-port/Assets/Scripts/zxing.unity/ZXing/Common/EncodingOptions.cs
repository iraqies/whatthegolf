using System;
using System.Collections.Generic;

namespace ZXing.Common
{
	[Serializable]
	public class EncodingOptions
	{
		public IDictionary<EncodeHintType, object> Hints { get; private set; }

		public int Height
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Margin
		{
			set
			{
			}
		}
	}
}
