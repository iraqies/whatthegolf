using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000175")]
	public class ParameterCollection : SortedDictionary<string, ParameterValue>
	{
		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D50", Offset = "0x25D50")]
		private sealed class _003CGetParametersEnumerable_003Ed__4 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40005A1")]
			[FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, string> _003C_003E2__current;

			[Token(Token = "0x40005A2")]
			[FieldOffset(Offset = "0x28")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40005A3")]
			[FieldOffset(Offset = "0x30")]
			public ParameterCollection _003C_003E4__this;

			[Token(Token = "0x40005A4")]
			[FieldOffset(Offset = "0x38")]
			private Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x40005A5")]
			[FieldOffset(Offset = "0x68")]
			private string _003Cname_003E5__3;

			[Token(Token = "0x40005A6")]
			[FieldOffset(Offset = "0x70")]
			private List<string>.Enumerator _003C_003E7__wrap3;

			[Token(Token = "0x17000319")]
			private KeyValuePair<string, string> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002ECurrent
			{
				[Token(Token = "0x6000BBC")]
				[Address(RVA = "0x1290414", Offset = "0x1290414", VA = "0x1290414", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700031A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000BBE")]
				[Address(RVA = "0x1290460", Offset = "0x1290460", VA = "0x1290460", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x128FCF4", Offset = "0x128FCF4", VA = "0x128FCF4")]
			[DebuggerHidden]
			public _003CGetParametersEnumerable_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x128FD2C", Offset = "0x128FD2C", VA = "0x128FD2C", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x128FEE4", Offset = "0x128FEE4", VA = "0x128FEE4", Slot = "8")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x128FE88", Offset = "0x128FE88", VA = "0x128FE88")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x128FE2C", Offset = "0x128FE2C", VA = "0x128FE2C")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x1290414", Offset = "0x1290414", VA = "0x1290414", Slot = "6")]
			[DebuggerHidden]
			private KeyValuePair<string, string> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x1290420", Offset = "0x1290420", VA = "0x1290420", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x1290460", Offset = "0x1290460", VA = "0x1290460", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x12904C8", Offset = "0x12904C8", VA = "0x12904C8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, string>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x1290570", Offset = "0x1290570", VA = "0x1290570", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x1246624", Offset = "0x1246624", VA = "0x1246624")]
		public ParameterCollection()
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x12466E8", Offset = "0x12466E8", VA = "0x12466E8")]
		public void Add(string key, string value)
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x1246780", Offset = "0x1246780", VA = "0x1246780")]
		public void Add(string key, List<string> values)
		{
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x1246818", Offset = "0x1246818", VA = "0x1246818")]
		public List<KeyValuePair<string, string>> GetSortedParametersList()
		{
			return null;
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x12468B8", Offset = "0x12468B8", VA = "0x12468B8")]
		private IEnumerable<KeyValuePair<string, string>> GetParametersEnumerable()
		{
			return null;
		}
	}
}
