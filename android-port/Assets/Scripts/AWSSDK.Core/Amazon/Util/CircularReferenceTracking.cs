using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000066")]
	public class CircularReferenceTracking
	{
		[Token(Token = "0x2000067")]
		private class Tracker : IDisposable
		{
			[Token(Token = "0x4000219")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x263E8", Offset = "0x263E8")]
			private object Target__BackingField;

			[Token(Token = "0x400021A")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x263F8", Offset = "0x263F8")]
			private CircularReferenceTracking State__BackingField;

			[Token(Token = "0x400021B")]
			[FieldOffset(Offset = "0x20")]
			private bool disposed;

			[Token(Token = "0x170000BB")]
			public object Target
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x1289104", Offset = "0x1289104", VA = "0x1289104")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2839C", Offset = "0x2839C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600039B")]
				[Address(RVA = "0x128910C", Offset = "0x128910C", VA = "0x128910C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x283AC", Offset = "0x283AC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			private CircularReferenceTracking State
			{
				[Token(Token = "0x600039C")]
				[Address(RVA = "0x1289114", Offset = "0x1289114", VA = "0x1289114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x283BC", Offset = "0x283BC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600039D")]
				[Address(RVA = "0x128911C", Offset = "0x128911C", VA = "0x128911C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x283CC", Offset = "0x283CC")]
				set
				{
				}
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x1289124", Offset = "0x1289124", VA = "0x1289124")]
			public Tracker(CircularReferenceTracking state, object target)
			{
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0x128915C", Offset = "0x128915C", VA = "0x128915C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x12891E8", Offset = "0x12891E8", VA = "0x12891E8", Slot = "5")]
			protected virtual void Dispose(bool disposing)
			{
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x1289230", Offset = "0x1289230", VA = "0x1289230", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x12892B0", Offset = "0x12892B0", VA = "0x12892B0", Slot = "1")]
			~Tracker()
			{
			}
		}

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x10")]
		private object referenceTrackersLock;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x18")]
		private Stack<Tracker> referenceTrackers;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x11DE15C", Offset = "0x11DE15C", VA = "0x11DE15C")]
		public IDisposable Track(object target)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x11DE5B4", Offset = "0x11DE5B4", VA = "0x11DE5B4")]
		private void PopTracker(Tracker tracker)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x11DE404", Offset = "0x11DE404", VA = "0x11DE404")]
		private bool TrackerExists(object target)
		{
			return default;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x11DE750", Offset = "0x11DE750", VA = "0x11DE750")]
		public CircularReferenceTracking()
		{
		}
	}
}
