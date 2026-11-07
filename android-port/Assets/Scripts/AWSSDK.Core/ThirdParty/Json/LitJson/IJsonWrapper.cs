using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x2000017")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		[Token(Token = "0x17000015")]
		bool IsArray
		{
			[Token(Token = "0x6000091")]
			get;
		}

		[Token(Token = "0x17000016")]
		bool IsBoolean
		{
			[Token(Token = "0x6000092")]
			get;
		}

		[Token(Token = "0x17000017")]
		bool IsDouble
		{
			[Token(Token = "0x6000093")]
			get;
		}

		[Token(Token = "0x17000018")]
		bool IsInt
		{
			[Token(Token = "0x6000094")]
			get;
		}

		[Token(Token = "0x17000019")]
		bool IsUInt
		{
			[Token(Token = "0x6000095")]
			get;
		}

		[Token(Token = "0x1700001A")]
		bool IsLong
		{
			[Token(Token = "0x6000096")]
			get;
		}

		[Token(Token = "0x1700001B")]
		bool IsULong
		{
			[Token(Token = "0x6000097")]
			get;
		}

		[Token(Token = "0x1700001C")]
		bool IsObject
		{
			[Token(Token = "0x6000098")]
			get;
		}

		[Token(Token = "0x1700001D")]
		bool IsString
		{
			[Token(Token = "0x6000099")]
			get;
		}

		[Token(Token = "0x600009A")]
		bool GetBoolean();

		[Token(Token = "0x600009B")]
		double GetDouble();

		[Token(Token = "0x600009C")]
		int GetInt();

		[Token(Token = "0x600009D")]
		uint GetUInt();

		[Token(Token = "0x600009E")]
		JsonType GetJsonType();

		[Token(Token = "0x600009F")]
		long GetLong();

		[Token(Token = "0x60000A0")]
		ulong GetULong();

		[Token(Token = "0x60000A1")]
		string GetString();

		[Token(Token = "0x60000A2")]
		void SetBoolean(bool val);

		[Token(Token = "0x60000A3")]
		void SetDouble(double val);

		[Token(Token = "0x60000A4")]
		void SetInt(int val);

		[Token(Token = "0x60000A5")]
		void SetUInt(uint val);

		[Token(Token = "0x60000A6")]
		void SetJsonType(JsonType type);

		[Token(Token = "0x60000A7")]
		void SetLong(long val);

		[Token(Token = "0x60000A8")]
		void SetULong(ulong val);

		[Token(Token = "0x60000A9")]
		void SetString(string val);

		[Token(Token = "0x60000AA")]
		string ToJson();

		[Token(Token = "0x60000AB")]
		void ToJson(JsonWriter writer);
	}
}
