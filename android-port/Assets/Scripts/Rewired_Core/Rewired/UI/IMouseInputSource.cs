using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI
{
	[Token(Token = "0x2000322")]
	public interface IMouseInputSource
	{
		[Token(Token = "0x17000688")]
		int playerId
		{
			[Token(Token = "0x600184B")]
			get;
		}

		[Token(Token = "0x17000689")]
		bool enabled
		{
			[Token(Token = "0x600184C")]
			get;
		}

		[Token(Token = "0x1700068A")]
		bool locked
		{
			[Token(Token = "0x600184D")]
			get;
		}

		[Token(Token = "0x1700068B")]
		int buttonCount
		{
			[Token(Token = "0x600184E")]
			get;
		}

		[Token(Token = "0x1700068C")]
		Vector2 screenPosition
		{
			[Token(Token = "0x6001852")]
			get;
		}

		[Token(Token = "0x1700068D")]
		Vector2 screenPositionDelta
		{
			[Token(Token = "0x6001853")]
			get;
		}

		[Token(Token = "0x1700068E")]
		Vector2 wheelDelta
		{
			[Token(Token = "0x6001854")]
			get;
		}

		[Token(Token = "0x600184F")]
		bool GetButtonDown(int button);

		[Token(Token = "0x6001850")]
		bool GetButtonUp(int button);

		[Token(Token = "0x6001851")]
		bool GetButton(int button);
	}
}
