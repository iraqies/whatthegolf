using System;
using System.Runtime.CompilerServices;

namespace Apple.GameKit
{
	public class GameKitException : Exception
	{
		[CompilerGenerated]
		private int ErrorCode__BackingField;

		public int ErrorCode
		{
			[CompilerGenerated]
			set
			{
				ErrorCode__BackingField = value;
			}
		}

		public GameKitException(int errorCode, string message)
		{
		}
	}
}
