using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.Collections
{
	[Serializable]
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x3348C", Offset = "0x3348C")]
	public class ArrayList<T> : FoldOutStruct
	{
		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x334C4", Offset = "0x334C4")]
		private sealed class _003CGetEnumerator_003Ed__15 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000256")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x0")]
			private T _003C_003E2__current;

			[Token(Token = "0x4000258")]
			[FieldOffset(Offset = "0x0")]
			public ArrayList<T> _003C_003E4__this;

			[Token(Token = "0x4000259")]
			[FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000054")]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[Token(Token = "0x60002A4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000055")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60002A6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60002A1")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__15(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60002A2")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60002A3")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60002A4")]
			[DebuggerHidden]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
			{
				return (T)null;
			}

			[Token(Token = "0x60002A5")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60002A6")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> buffer;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x0")]
		private Type type;

		[Token(Token = "0x17000051")]
		[XmlIgnore]
		public int Count
		{
			[Token(Token = "0x600028E")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000052")]
		public List<T> Buffer
		{
			[Token(Token = "0x600028F")]
			get
			{
				return null;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000053")]
		[Token(Token = "0x6000290")]
		public virtual T get_Item(int i)
		{
			return (T)null;
		}

		[Token(Token = "0x6000291")]
		public ArrayList()
		{
		}

		[Token(Token = "0x6000292")]
		public ArrayList(IList<T> p_list)
		{
		}

		[Token(Token = "0x6000293")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000295")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000296")]
		protected void AddWithoutCallEvents(T item)
		{
		}

		[Token(Token = "0x6000297")]
		public bool Contains(T item)
		{
			return default;
		}

		[Token(Token = "0x6000298")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		public void RemoveNulls()
		{
		}

		[Token(Token = "0x600029A")]
		public bool RemoveChecking(T p_object, bool p_removeNulls = true)
		{
			return default;
		}

		[Token(Token = "0x600029B")]
		public bool AddChecking(T p_object)
		{
			return default;
		}

		[Token(Token = "0x600029C")]
		public void MergeList(ArrayList<T> p_otherList)
		{
		}

		[Token(Token = "0x600029D")]
		public void UnmergeList(ArrayList<T> p_otherList)
		{
		}

		[Token(Token = "0x600029E")]
		protected virtual void OnAdd(T p_item)
		{
		}

		[Token(Token = "0x600029F")]
		protected virtual void OnRemove(T p_item)
		{
		}

		[Token(Token = "0x60002A0")]
		private static T[] CloneArray(IList<T> p_buffer)
		{
			return null;
		}
	}
}
