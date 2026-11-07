using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008A0")]
public interface IHitscanTarget
{
	[Token(Token = "0x17000439")]
	Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x60027DC")]
		get;
		[Token(Token = "0x60027DD")]
		set;
	}

	[Token(Token = "0x60027DB")]
	void OnHit(Vector3 point);
}
