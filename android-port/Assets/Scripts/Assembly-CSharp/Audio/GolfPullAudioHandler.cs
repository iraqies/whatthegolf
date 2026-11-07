using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200139C")]
	public class GolfPullAudioHandler : MonoBehaviour
	{
		[Token(Token = "0x400694B")]
		[FieldOffset(Offset = "0x18")]
		public bool overrideGlobalSetting;

		[Token(Token = "0x400694C")]
		[FieldOffset(Offset = "0x20")]
		private GolfPullSimple pullSimple;

		[Token(Token = "0x400694D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A660", Offset = "0x5A660")]
		private GolfBallController ball__BackingField;

		[Token(Token = "0x400694E")]
		[FieldOffset(Offset = "0x30")]
		private bool aiming;

		[Token(Token = "0x17000A52")]
		public GolfBallController ball
		{
			[Token(Token = "0x6005B7D")]
			[Address(RVA = "0x14A2D04", Offset = "0x14A2D04", VA = "0x14A2D04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72638", Offset = "0x72638")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B7E")]
			[Address(RVA = "0x14A2D0C", Offset = "0x14A2D0C", VA = "0x14A2D0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72648", Offset = "0x72648")]
			private set
			{
			}
		}

		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0x14A2D14", Offset = "0x14A2D14", VA = "0x14A2D14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B80")]
		[Address(RVA = "0x14A2D70", Offset = "0x14A2D70", VA = "0x14A2D70")]
		public void Initialize(GolfBallController _ball)
		{
		}

		[Token(Token = "0x6005B81")]
		[Address(RVA = "0x14A3000", Offset = "0x14A3000", VA = "0x14A3000")]
		public void Deinitialize()
		{
		}

		[Token(Token = "0x6005B82")]
		[Address(RVA = "0x14A3254", Offset = "0x14A3254", VA = "0x14A3254")]
		public void OnCancel()
		{
		}

		[Token(Token = "0x6005B83")]
		[Address(RVA = "0x14A334C", Offset = "0x14A334C", VA = "0x14A334C")]
		private void OnAimStart()
		{
		}

		[Token(Token = "0x6005B84")]
		[Address(RVA = "0x14A3484", Offset = "0x14A3484", VA = "0x14A3484")]
		private void OnAim(Vector3 boost, bool cancel)
		{
		}

		[Token(Token = "0x6005B85")]
		[Address(RVA = "0x14A327C", Offset = "0x14A327C", VA = "0x14A327C")]
		private void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005B86")]
		[Address(RVA = "0x14A38E8", Offset = "0x14A38E8", VA = "0x14A38E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B87")]
		[Address(RVA = "0x14A3B54", Offset = "0x14A3B54", VA = "0x14A3B54")]
		public GolfPullAudioHandler()
		{
		}
	}
}
