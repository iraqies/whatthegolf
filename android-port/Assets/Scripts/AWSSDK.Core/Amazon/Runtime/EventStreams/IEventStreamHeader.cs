using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x2000117")]
	public interface IEventStreamHeader
	{
		[Token(Token = "0x1700026A")]
		string Name
		{
			[Token(Token = "0x600090B")]
			get;
		}

		[Token(Token = "0x1700026B")]
		EventStreamHeaderType HeaderType
		{
			[Token(Token = "0x600090C")]
			get;
		}

		[Token(Token = "0x600090D")]
		int GetWireSize();

		[Token(Token = "0x600090E")]
		int WriteToBuffer(byte[] buffer, int offset);

		[Token(Token = "0x600090F")]
		bool AsBool();

		[Token(Token = "0x6000910")]
		void SetBool(bool value);

		[Token(Token = "0x6000911")]
		byte AsByte();

		[Token(Token = "0x6000912")]
		void SetByte(byte value);

		[Token(Token = "0x6000913")]
		short AsInt16();

		[Token(Token = "0x6000914")]
		void SetInt16(short value);

		[Token(Token = "0x6000915")]
		int AsInt32();

		[Token(Token = "0x6000916")]
		void SetInt32(int value);

		[Token(Token = "0x6000917")]
		long AsInt64();

		[Token(Token = "0x6000918")]
		void SetInt64(long value);

		[Token(Token = "0x6000919")]
		byte[] AsByteBuf();

		[Token(Token = "0x600091A")]
		void SetByteBuf(byte[] value);

		[Token(Token = "0x600091B")]
		string AsString();

		[Token(Token = "0x600091C")]
		void SetString(string value);

		[Token(Token = "0x600091D")]
		DateTime AsTimestamp();

		[Token(Token = "0x600091E")]
		void SetTimestamp(DateTime value);

		[Token(Token = "0x600091F")]
		Guid AsUUID();

		[Token(Token = "0x6000920")]
		void SetUUID(Guid value);
	}
}
