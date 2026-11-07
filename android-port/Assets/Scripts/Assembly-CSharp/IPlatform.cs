using System;
using Il2CppDummyDll;

[Token(Token = "0x2000B3B")]
public interface IPlatform
{
	[Token(Token = "0x17000572")]
	bool Initialized
	{
		[Token(Token = "0x6003577")]
		get;
	}

	[Token(Token = "0x6003576")]
	void RunAfterInitialization(Action act);

	[Token(Token = "0x6003578")]
	void ShowTrophies(Action<bool> callback);
}
