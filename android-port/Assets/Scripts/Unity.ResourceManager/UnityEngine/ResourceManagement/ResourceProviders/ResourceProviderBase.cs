using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x200005A")]
	public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject
	{
		[Token(Token = "0x200005B")]
		private class BaseInitAsyncOp : AsyncOperationBase<bool>
		{
			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x98")]
			private Func<bool> m_CallBack;

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x2A77D60", Offset = "0x2A77D60", VA = "0x2A77D60")]
			public void Init(Func<bool> callback)
			{
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x2A77D68", Offset = "0x2A77D68", VA = "0x2A77D68", Slot = "33")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x2A77DDC", Offset = "0x2A77DDC", VA = "0x2A77DDC", Slot = "28")]
			protected override void Execute()
			{
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0x2A70988", Offset = "0x2A70988", VA = "0x2A70988")]
			public BaseInitAsyncOp()
			{
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7C10", Offset = "0x1B7C10")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x10")]
			public ResourceProviderBase _003C_003E4__this;

			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x20")]
			public string data;

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x2A70980", Offset = "0x2A70980", VA = "0x2A70980")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0x2A77D34", Offset = "0x2A77D34", VA = "0x2A77D34")]
			internal bool _003CInitializeAsync_003Eb__0()
			{
				return default;
			}
		}

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x10")]
		protected string m_ProviderId;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x18")]
		protected ProviderBehaviourFlags m_BehaviourFlags;

		[Token(Token = "0x17000057")]
		public virtual string ProviderId
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x2A70694", Offset = "0x2A70694", VA = "0x2A70694", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private ProviderBehaviourFlags UnityEngine_002EResourceManagement_002EResourceProviders_002EIResourceProvider_002EBehaviourFlags
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x2A709E0", Offset = "0x2A709E0", VA = "0x2A709E0", Slot = "9")]
			get
			{
				return UnityEngine_002EResourceManagement_002EResourceProviders_002EIResourceProvider_002Eget_BehaviourFlags();
			}
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2A706EC", Offset = "0x2A706EC", VA = "0x2A706EC", Slot = "13")]
		public virtual bool Initialize(string id, string data)
		{
			return default;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2A70710", Offset = "0x2A70710", VA = "0x2A70710", Slot = "14")]
		public virtual bool CanProvide(Type t, IResourceLocation location)
		{
			return default;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2A7075C", Offset = "0x2A7075C", VA = "0x2A7075C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2A70768", Offset = "0x2A70768", VA = "0x2A70768", Slot = "15")]
		public virtual void Release(IResourceLocation location, object obj)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2A7076C", Offset = "0x2A7076C", VA = "0x2A7076C", Slot = "16")]
		public virtual Type GetDefaultType(IResourceLocation location)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		public abstract void Provide(ProvideHandle provideHandle);

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2A707F4", Offset = "0x2A707F4", VA = "0x2A707F4", Slot = "18")]
		public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
		{
			return default;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2A709E0", Offset = "0x2A709E0", VA = "0x2A709E0", Slot = "9")]
		private ProviderBehaviourFlags UnityEngine_002EResourceManagement_002EResourceProviders_002EIResourceProvider_002Eget_BehaviourFlags()
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2A5D29C", Offset = "0x2A5D29C", VA = "0x2A5D29C")]
		protected ResourceProviderBase()
		{
		}
	}
}
