using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000029")]
	internal class DelayedActionManager : ComponentSingleton<DelayedActionManager>
	{
		[Token(Token = "0x200002A")]
		private struct DelegateInfo
		{
			[Token(Token = "0x400007E")]
			[FieldOffset(Offset = "0x0")]
			private static int s_Id;

			[Token(Token = "0x400007F")]
			[FieldOffset(Offset = "0x0")]
			private int m_Id;

			[Token(Token = "0x4000080")]
			[FieldOffset(Offset = "0x8")]
			private Delegate m_Delegate;

			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0x10")]
			private object[] m_Target;

			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7DA8", Offset = "0x1B7DA8")]
			private float InvocationTime__BackingField;

			[Token(Token = "0x17000029")]
			public float InvocationTime
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0x2A76BBC", Offset = "0x2A76BBC", VA = "0x2A76BBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8464", Offset = "0x1B8464")]
				get
				{
					return default;
				}
				[Token(Token = "0x600011D")]
				[Address(RVA = "0x2A76BC4", Offset = "0x2A76BC4", VA = "0x2A76BC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8474", Offset = "0x1B8474")]
				private set
				{
				}
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2A64004", Offset = "0x2A64004", VA = "0x2A64004")]
			public DelegateInfo(Delegate d, float invocationTime, params object[] p)
			{
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2A76BCC", Offset = "0x2A76BCC", VA = "0x2A76BCC", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2A645F4", Offset = "0x2A645F4", VA = "0x2A645F4")]
			public void Invoke()
			{
			}
		}

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x18")]
		private List<DelegateInfo>[] m_Actions;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x20")]
		private LinkedList<DelegateInfo> m_DelayedActions;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x28")]
		private Stack<LinkedListNode<DelegateInfo>> m_NodeCache;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x30")]
		private int m_CollectionIndex;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x34")]
		private bool m_DestroyOnCompletion;

		[Token(Token = "0x17000028")]
		public static bool IsActive
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2A6408C", Offset = "0x2A6408C", VA = "0x2A6408C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2A63BCC", Offset = "0x2A63BCC", VA = "0x2A63BCC")]
		private LinkedListNode<DelegateInfo> GetNode(ref DelegateInfo del)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2A63CBC", Offset = "0x2A63CBC", VA = "0x2A63CBC")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2A63D34", Offset = "0x2A63D34", VA = "0x2A63D34")]
		private void DestroyWhenComplete()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2A63D40", Offset = "0x2A63D40", VA = "0x2A63D40")]
		public static void AddAction(Delegate action, float delay = 0f, params object[] parameters)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2A63DB8", Offset = "0x2A63DB8", VA = "0x2A63DB8")]
		private void AddActionInternal(Delegate action, float delay, params object[] parameters)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2A641BC", Offset = "0x2A641BC", VA = "0x2A641BC")]
		public static bool Wait(float timeout = 0f, float timeAdvanceAmount = 0f)
		{
			return default;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2A645CC", Offset = "0x2A645CC", VA = "0x2A645CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2A64300", Offset = "0x2A64300", VA = "0x2A64300")]
		private void InternalLateUpdate(float t)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2A6477C", Offset = "0x2A6477C", VA = "0x2A6477C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2A6483C", Offset = "0x2A6483C", VA = "0x2A6483C")]
		public DelayedActionManager()
		{
		}
	}
}
