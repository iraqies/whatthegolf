using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Buoyancy
{
	[Token(Token = "0x20011E8")]
	public interface IBuoyant
	{
		[Token(Token = "0x170008EB")]
		bool Remove
		{
			[Token(Token = "0x6005213")]
			get;
		}

		[Token(Token = "0x170008EC")]
		Rigidbody Rigid
		{
			[Token(Token = "0x6005214")]
			get;
		}

		[Token(Token = "0x170008ED")]
		Action<Vector3> OnEnterWaterNoSkip
		{
			[Token(Token = "0x6005215")]
			get;
			[Token(Token = "0x6005216")]
			set;
		}

		[Token(Token = "0x170008EE")]
		Action<Vector3> OnPostSkip
		{
			[Token(Token = "0x6005217")]
			get;
			[Token(Token = "0x6005218")]
			set;
		}

		[Token(Token = "0x170008EF")]
		Action OnTargetExitedWater
		{
			[Token(Token = "0x6005219")]
			get;
			[Token(Token = "0x600521A")]
			set;
		}

		[Token(Token = "0x170008F0")]
		bool IsInWater
		{
			[Token(Token = "0x600521B")]
			get;
		}

		[Token(Token = "0x6005210")]
		void HandleFloating(IBuoyantWater water);

		[Token(Token = "0x6005211")]
		void OnEnterWater(IBuoyantWater water);

		[Token(Token = "0x6005212")]
		void OnExitWater(IBuoyantWater water);
	}
}
