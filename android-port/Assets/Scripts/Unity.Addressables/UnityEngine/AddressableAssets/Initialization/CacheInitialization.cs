using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Serializable]
	[Token(Token = "0x2000056")]
	public class CacheInitialization : IInitializableObject
	{
		[Token(Token = "0x2000057")]
		private class CacheInitOp : AsyncOperationBase<bool>, IUpdateReceiver
		{
			[Token(Token = "0x400011D")]
			[FieldOffset(Offset = "0x98")]
			private Func<bool> m_Callback;

			[Token(Token = "0x400011E")]
			[FieldOffset(Offset = "0xA0")]
			private bool m_UpdateRequired;

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2A3A9E8", Offset = "0x2A3A9E8", VA = "0x2A3A9E8")]
			public void Init(Func<bool> callback)
			{
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2A3A9F0", Offset = "0x2A3A9F0", VA = "0x2A3A9F0", Slot = "33")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x2A3AA90", Offset = "0x2A3AA90", VA = "0x2A3AA90", Slot = "36")]
			public void Update(float unscaledDeltaTime)
			{
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2A3AB50", Offset = "0x2A3AB50", VA = "0x2A3AB50", Slot = "28")]
			protected override void Execute()
			{
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2A3AC04", Offset = "0x2A3AC04", VA = "0x2A3AC04")]
			public CacheInitOp()
			{
			}
		}

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B11FC", Offset = "0x1B11FC")]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0x10")]
			public CacheInitialization _003C_003E4__this;

			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x20")]
			public string data;

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2A3A9BC", Offset = "0x2A3A9BC", VA = "0x2A3A9BC")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2A3A9C4", Offset = "0x2A3A9C4", VA = "0x2A3A9C4")]
			internal bool _003CInitializeAsync_003Eb__0()
			{
				return default;
			}
		}

		[Token(Token = "0x1700005C")]
		public static string RootPath
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x2A28EF4", Offset = "0x2A28EF4", VA = "0x2A28EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2A28C30", Offset = "0x2A28C30", VA = "0x2A28C30", Slot = "4")]
		public bool Initialize(string id, string dataStr)
		{
			return default;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2A28D94", Offset = "0x2A28D94", VA = "0x2A28D94", Slot = "6")]
		public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
		{
			return default;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2A28F84", Offset = "0x2A28F84", VA = "0x2A28F84")]
		public CacheInitialization()
		{
		}
	}
}
