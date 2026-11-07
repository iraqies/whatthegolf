using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x2000121")]
	public abstract class EnumerableEventStream<T, TE> : EventStream<T, TE>, IEnumerableEventStream<T, TE>, IEventStream<T, TE>, IDisposable, IEnumerable<T>, IEnumerable where T : IEventStreamEvent where TE : EventStreamException, new()
	{
		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25BE4", Offset = "0x25BE4")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4000453")]
			[FieldOffset(Offset = "0x0")]
			public Queue<T> events;

			[Token(Token = "0x600095A")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600095B")]
			internal void _003CGetEnumerator_003Eb__0(object sender, EventStreamEventReceivedArgs<T> args)
			{
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25BF4", Offset = "0x25BF4")]
		private sealed class _003CGetEnumerator_003Ed__7 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000454")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000455")]
			[FieldOffset(Offset = "0x0")]
			private T _003C_003E2__current;

			[Token(Token = "0x4000456")]
			[FieldOffset(Offset = "0x0")]
			public EnumerableEventStream<T, TE> _003C_003E4__this;

			[Token(Token = "0x4000457")]
			[FieldOffset(Offset = "0x0")]
			private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

			[Token(Token = "0x4000458")]
			[FieldOffset(Offset = "0x0")]
			private byte[] _003Cbuffer_003E5__2;

			[Token(Token = "0x17000275")]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[Token(Token = "0x600095F")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000276")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000961")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600095C")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600095D")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600095E")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600095F")]
			[DebuggerHidden]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
			{
				return (T)null;
			}

			[Token(Token = "0x6000960")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000961")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000451")]
		private const string MutuallyExclusiveExceptionMessage = "Stream has already begun processing. Event-driven and Enumerable traversals of the stream are mutually exclusive. You can either use the event driven or enumerable interface, but not both.";

		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26DF8", Offset = "0x26DF8")]
		private bool IsEnumerated__BackingField;

		[Token(Token = "0x17000274")]
		protected bool IsEnumerated
		{
			[Token(Token = "0x6000953")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2991C", Offset = "0x2991C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2992C", Offset = "0x2992C")]
			set
			{
			}
		}

		[Token(Token = "0x6000955")]
		protected EnumerableEventStream(Stream stream)
		{
		}

		[Token(Token = "0x6000956")]
		protected EnumerableEventStream(Stream stream, IEventStreamDecoder eventStreamDecoder)
		{
		}

		[Token(Token = "0x6000957")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000958")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000959")]
		public override void StartProcessing()
		{
		}
	}
}
