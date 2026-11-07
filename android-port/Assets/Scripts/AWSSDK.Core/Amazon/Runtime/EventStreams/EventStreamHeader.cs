using System;

namespace Amazon.Runtime.EventStreams
{
	public class EventStreamHeader : IEventStreamHeader
	{
		private static readonly DateTime _unixEpoch;

		private const int _sizeOfByte = 1;

		private const int _sizeOfInt16 = 2;

		private const int _sizeOfInt32 = 4;

		private const int _sizeOfInt64 = 8;

		private const int _sizeOfGuid = 16;

		public string Name { get; }

		public EventStreamHeaderType HeaderType { get; set; }

		private object HeaderValue { get; set; }

		public EventStreamHeader(string name)
		{
		}

		public static EventStreamHeader FromBuffer(byte[] buffer, int offset, ref int newOffset)
		{
			return null;
		}

		public int WriteToBuffer(byte[] buffer, int offset)
		{
			return 0;
		}

		public int GetWireSize()
		{
			return 0;
		}

		public bool AsBool()
		{
			return false;
		}

		public void SetBool(bool value)
		{
		}

		public byte AsByte()
		{
			return 0;
		}

		public void SetByte(byte value)
		{
		}

		public short AsInt16()
		{
			return 0;
		}

		public void SetInt16(short value)
		{
		}

		public int AsInt32()
		{
			return 0;
		}

		public void SetInt32(int value)
		{
		}

		public long AsInt64()
		{
			return 0L;
		}

		public void SetInt64(long value)
		{
		}

		public byte[] AsByteBuf()
		{
			return null;
		}

		public void SetByteBuf(byte[] value)
		{
		}

		public string AsString()
		{
			return null;
		}

		public void SetString(string value)
		{
		}

		public DateTime AsTimestamp()
		{
			return default;
		}

		public void SetTimestamp(DateTime value)
		{
		}

		public Guid AsUUID()
		{
			return default;
		}

		public void SetUUID(Guid value)
		{
		}
	}
}
