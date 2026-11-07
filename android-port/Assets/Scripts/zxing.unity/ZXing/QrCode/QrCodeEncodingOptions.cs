using System;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace ZXing.QrCode
{
	[Serializable]
	public class QrCodeEncodingOptions : EncodingOptions
	{
		public ErrorCorrectionLevel ErrorCorrection
		{
			set
			{
			}
		}

		public string CharacterSet
		{
			set
			{
			}
		}
	}
}
