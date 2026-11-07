using System;
using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000172")]
	internal interface IInputManagerJoystickPublic
	{
		[Token(Token = "0x17000361")]
		int rewiredId
		{
			[Token(Token = "0x6000C24")]
			get;
		}

		[Token(Token = "0x17000362")]
		int inputManagerId
		{
			[Token(Token = "0x6000C25")]
			get;
		}

		[Token(Token = "0x17000363")]
		string name
		{
			[Token(Token = "0x6000C26")]
			get;
		}

		[Token(Token = "0x17000364")]
		long? systemId
		{
			[Token(Token = "0x6000C27")]
			get;
		}

		[Token(Token = "0x17000365")]
		int unityId
		{
			[Token(Token = "0x6000C28")]
			get;
		}

		[Token(Token = "0x17000366")]
		Controller.Extension extension
		{
			[Token(Token = "0x6000C29")]
			get;
		}

		[Token(Token = "0x17000367")]
		Guid persistentGuid
		{
			[Token(Token = "0x6000C2A")]
			get;
		}

		[Token(Token = "0x6000C2B")]
		void SetVibration(float amount, int motorIndex);

		[Token(Token = "0x6000C2C")]
		void StopVibration();
	}
}
