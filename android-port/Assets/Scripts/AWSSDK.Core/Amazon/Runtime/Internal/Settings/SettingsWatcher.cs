using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Settings
{
	[Token(Token = "0x200023E")]
	public class SettingsWatcher : IDisposable
	{
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x10")]
		private string type;

		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C98", Offset = "0x27C98")]
		private bool Enable__BackingField;

		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27CA8", Offset = "0x27CA8")]
		private EventHandler m_SettingsChanged;

		[Token(Token = "0x17000442")]
		public bool Enable
		{
			[Token(Token = "0x6001119")]
			[Address(RVA = "0x1273638", Offset = "0x1273638", VA = "0x1273638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF20", Offset = "0x2BF20")]
			get
			{
				return default;
			}
			[Token(Token = "0x600111A")]
			[Address(RVA = "0x1273640", Offset = "0x1273640", VA = "0x1273640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF30", Offset = "0x2BF30")]
			set
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event EventHandler SettingsChanged
		{
			[Token(Token = "0x600111B")]
			[Address(RVA = "0x1273648", Offset = "0x1273648", VA = "0x1273648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF40", Offset = "0x2BF40")]
			add
			{
			}
			[Token(Token = "0x600111C")]
			[Address(RVA = "0x12736EC", Offset = "0x12736EC", VA = "0x12736EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF50", Offset = "0x2BF50")]
			remove
			{
			}
		}

		[Token(Token = "0x6001116")]
		[Address(RVA = "0x1273424", Offset = "0x1273424", VA = "0x1273424")]
		private SettingsWatcher()
		{
		}

		[Token(Token = "0x6001117")]
		[Address(RVA = "0x127346C", Offset = "0x127346C", VA = "0x127346C")]
		internal SettingsWatcher(string filePath, string type)
		{
		}

		[Token(Token = "0x6001118")]
		[Address(RVA = "0x1273508", Offset = "0x1273508", VA = "0x1273508")]
		public SettingsCollection GetSettings()
		{
			return null;
		}

		[Token(Token = "0x600111D")]
		[Address(RVA = "0x1273790", Offset = "0x1273790", VA = "0x1273790", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600111E")]
		[Address(RVA = "0x1273810", Offset = "0x1273810", VA = "0x1273810", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
