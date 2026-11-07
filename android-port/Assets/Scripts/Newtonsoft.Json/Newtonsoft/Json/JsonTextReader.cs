using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182A7C", Offset = "0x182A7C")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182A7C", Offset = "0x182A7C")]
	public class JsonTextReader : JsonReader
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly TextReader _reader;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185508", Offset = "0x185508")]
		private char[] _chars;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _charsUsed;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _charPos;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _lineStartPos;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _lineNumber;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _isEndOfFile;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private StringBuffer _stringBuffer;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private StringReference _stringReference;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18551C", Offset = "0x18551C")]
		private IArrayPool<char> _arrayPool;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185530", Offset = "0x185530")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185530", Offset = "0x185530")]
		private JsonNameTable PropertyNameTable__BackingField;

		[Token(Token = "0x17000048")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EAD0", Offset = "0x18EAD0")]
		public JsonNameTable PropertyNameTable
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x230AF6C", Offset = "0x230AF6C", VA = "0x230AF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188AE0", Offset = "0x188AE0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188AE0", Offset = "0x188AE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x230AF74", Offset = "0x230AF74", VA = "0x230AF74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188B1C", Offset = "0x188B1C")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188B1C", Offset = "0x188B1C")]
			set
			{
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x230AF7C", Offset = "0x230AF7C", VA = "0x230AF7C")]
		private void EnsureBufferNotEmpty()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x230B000", Offset = "0x230B000", VA = "0x230B000")]
		private void SetNewLine(bool hasNextChar)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x230B064", Offset = "0x230B064", VA = "0x230B064")]
		private void OnNewLine(int pos)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x230B074", Offset = "0x230B074", VA = "0x230B074")]
		private void ParseString(char quote, ReadType readType)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x230B8BC", Offset = "0x230B8BC", VA = "0x230B8BC")]
		private void ParseReadString(char quote, ReadType readType)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x230BC60", Offset = "0x230BC60", VA = "0x230BC60")]
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x230B0C8", Offset = "0x230B0C8", VA = "0x230B0C8")]
		private void ShiftBufferIfNeeded()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x230BC74", Offset = "0x230BC74", VA = "0x230BC74")]
		private int ReadData(bool append)
		{
			return default;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x230BD1C", Offset = "0x230BD1C", VA = "0x230BD1C")]
		private void PrepareBufferForReadData(bool append, int charsRequired)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x230BC7C", Offset = "0x230BC7C", VA = "0x230BC7C")]
		private int ReadData(bool append, int charsRequired)
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x230BEC0", Offset = "0x230BEC0", VA = "0x230BEC0")]
		private bool EnsureChars(int relativePosition, bool append)
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x230BF40", Offset = "0x230BF40", VA = "0x230BF40")]
		private bool ReadChars(int relativePosition, bool append)
		{
			return default;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x230BFB4", Offset = "0x230BFB4", VA = "0x230BFB4", Slot = "10")]
		public override bool Read()
		{
			return default;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x230D35C", Offset = "0x230D35C", VA = "0x230D35C")]
		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x230C29C", Offset = "0x230C29C", VA = "0x230C29C")]
		private void EnsureBuffer()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x230B188", Offset = "0x230B188", VA = "0x230B188")]
		private void ReadStringIntoBuffer(char quote)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x230D5F8", Offset = "0x230D5F8", VA = "0x230D5F8")]
		private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x230D4C0", Offset = "0x230D4C0", VA = "0x230D4C0")]
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x230D840", Offset = "0x230D840", VA = "0x230D840")]
		private char ConvertUnicode(bool enoughChars)
		{
			return default;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x230D43C", Offset = "0x230D43C", VA = "0x230D43C")]
		private char ParseUnicode()
		{
			return default;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x230D9F0", Offset = "0x230D9F0", VA = "0x230D9F0")]
		private void ReadNumberIntoBuffer()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x230DA88", Offset = "0x230DA88", VA = "0x230DA88")]
		private bool ReadNumberCharIntoBuffer(char currentChar, int charPos)
		{
			return default;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x230DC64", Offset = "0x230DC64", VA = "0x230DC64")]
		private void ClearRecentString()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x230CB70", Offset = "0x230CB70", VA = "0x230CB70")]
		private bool ParsePostValue(bool ignoreComments)
		{
			return default;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x230C968", Offset = "0x230C968", VA = "0x230C968")]
		private bool ParseObject()
		{
			return default;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x230DC70", Offset = "0x230DC70", VA = "0x230DC70")]
		private bool ParseProperty()
		{
			return default;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x230DF54", Offset = "0x230DF54", VA = "0x230DF54")]
		private bool ValidIdentifierChar(char value)
		{
			return default;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x230DFD4", Offset = "0x230DFD4", VA = "0x230DFD4")]
		private void ParseUnquotedProperty()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x230E0C8", Offset = "0x230E0C8", VA = "0x230E0C8")]
		private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition)
		{
			return default;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x230C2F8", Offset = "0x230C2F8", VA = "0x230C2F8")]
		private bool ParseValue()
		{
			return default;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x230D5DC", Offset = "0x230D5DC", VA = "0x230D5DC")]
		private void ProcessLineFeed()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x230D50C", Offset = "0x230D50C", VA = "0x230D50C")]
		private void ProcessCarriageReturn(bool append)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x230CEA4", Offset = "0x230CEA4", VA = "0x230CEA4")]
		private void EatWhitespace()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x230E548", Offset = "0x230E548", VA = "0x230E548")]
		private void ParseConstructor()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x230EA44", Offset = "0x230EA44", VA = "0x230EA44")]
		private void ParseNumber(ReadType readType)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x230ECC4", Offset = "0x230ECC4", VA = "0x230ECC4")]
		private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x230FE28", Offset = "0x230FE28", VA = "0x230FE28")]
		private JsonReaderException ThrowReaderError(string message, [Optional][AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B508", Offset = "0x18B508")] Exception ex)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x230FE78", Offset = "0x230FE78", VA = "0x230FE78")]
		private static object BigIntegerParse(string number, CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x230CFE0", Offset = "0x230CFE0", VA = "0x230CFE0")]
		private void ParseComment(bool setToken)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x230FF20", Offset = "0x230FF20", VA = "0x230FF20")]
		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x230FF68", Offset = "0x230FF68", VA = "0x230FF68")]
		private bool MatchValue(string value)
		{
			return default;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2310000", Offset = "0x2310000", VA = "0x2310000")]
		private bool MatchValue(bool enoughChars, string value)
		{
			return default;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x230EB78", Offset = "0x230EB78", VA = "0x230EB78")]
		private bool MatchValueWithTrailingSeparator(string value)
		{
			return default;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x23100E8", Offset = "0x23100E8", VA = "0x23100E8")]
		private bool IsSeparator(char c)
		{
			return default;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x230E29C", Offset = "0x230E29C", VA = "0x230E29C")]
		private void ParseTrue()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x230E488", Offset = "0x230E488", VA = "0x230E488")]
		private void ParseNull()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x230EAB8", Offset = "0x230EAB8", VA = "0x230EAB8")]
		private void ParseUndefined()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x230E394", Offset = "0x230E394", VA = "0x230E394")]
		private void ParseFalse()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x230E9BC", Offset = "0x230E9BC", VA = "0x230E9BC")]
		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2310290", Offset = "0x2310290", VA = "0x2310290")]
		private object ParseNumberNegativeInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x230E934", Offset = "0x230E934", VA = "0x230E934")]
		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x23103E0", Offset = "0x23103E0", VA = "0x23103E0")]
		private object ParseNumberPositiveInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x230E8AC", Offset = "0x230E8AC", VA = "0x230E8AC")]
		private object ParseNumberNaN(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2310530", Offset = "0x2310530", VA = "0x2310530")]
		private object ParseNumberNaN(ReadType readType, bool matched)
		{
			return null;
		}
	}
}
