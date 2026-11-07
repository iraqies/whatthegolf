using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x200000B")]
	public struct ControllerIdentifier
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		private int UceKlChkUHGjQaNwpAzeqaieFMpt;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x4")]
		private ControllerType KHkewZTAeuvHVDDJaWvnQRRxxDiF;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x8")]
		private Guid fMxZVPLmyEupjctdQIaGgbDJdlvHA;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		private string xBrcfixGFlRWLdALITGLqMbVvAXW;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		private Guid guGxXkQdSCnhDedSVaPzhraGphmHA;

		[Token(Token = "0x17000025")]
		public int controllerId
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x235D028", Offset = "0x235D028", VA = "0x235D028")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000026")]
		public ControllerType controllerType
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x235D030", Offset = "0x235D030", VA = "0x235D030")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000027")]
		public Guid hardwareTypeGuid
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x235D038", Offset = "0x235D038", VA = "0x235D038")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000028")]
		public string hardwareIdentifier
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x235D044", Offset = "0x235D044", VA = "0x235D044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public Guid deviceInstanceGuid
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x235D04C", Offset = "0x235D04C", VA = "0x235D04C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2358EC8", Offset = "0x2358EC8", VA = "0x2358EC8")]
		internal ControllerIdentifier(Controller P_0)
		{
		}
	}
}
