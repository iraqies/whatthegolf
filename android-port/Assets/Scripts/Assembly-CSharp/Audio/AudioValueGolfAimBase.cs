using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013C9")]
	public abstract class AudioValueGolfAimBase : BaseAudioValue
	{
		[Token(Token = "0x4006A60")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected GolfBallController controller;

		[Token(Token = "0x4006A61")]
		[FieldOffset(Offset = "0x40")]
		protected Vector3 boost;

		[Token(Token = "0x4006A62")]
		[FieldOffset(Offset = "0x4C")]
		protected Vector3 lastBoost;

		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x150F244", Offset = "0x150F244", VA = "0x150F244")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005C50")]
		[Address(RVA = "0x150F468", Offset = "0x150F468", VA = "0x150F468")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005C51")]
		[Address(RVA = "0x150F68C", Offset = "0x150F68C", VA = "0x150F68C")]
		private void OnAimStart()
		{
		}

		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x150F690", Offset = "0x150F690", VA = "0x150F690")]
		private void OnAimUpdate(Vector3 boost, bool arg2)
		{
		}

		[Token(Token = "0x6005C53")]
		[Address(RVA = "0x150F6E4", Offset = "0x150F6E4", VA = "0x150F6E4")]
		private void OnAimShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005C54")]
		[Address(RVA = "0x150F6E8", Offset = "0x150F6E8", VA = "0x150F6E8")]
		private void OnAimCancel()
		{
		}

		[Token(Token = "0x6005C55")]
		[Address(RVA = "0x150F234", Offset = "0x150F234", VA = "0x150F234")]
		protected AudioValueGolfAimBase()
		{
		}
	}
}
