using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x200003A")]
	public interface ILayoutElement
	{
		[Token(Token = "0x170000B2")]
		float minWidth
		{
			[Token(Token = "0x600027F")]
			get;
		}

		[Token(Token = "0x170000B3")]
		float preferredWidth
		{
			[Token(Token = "0x6000280")]
			get;
		}

		[Token(Token = "0x170000B4")]
		float flexibleWidth
		{
			[Token(Token = "0x6000281")]
			get;
		}

		[Token(Token = "0x170000B5")]
		float minHeight
		{
			[Token(Token = "0x6000282")]
			get;
		}

		[Token(Token = "0x170000B6")]
		float preferredHeight
		{
			[Token(Token = "0x6000283")]
			get;
		}

		[Token(Token = "0x170000B7")]
		float flexibleHeight
		{
			[Token(Token = "0x6000284")]
			get;
		}

		[Token(Token = "0x170000B8")]
		int layoutPriority
		{
			[Token(Token = "0x6000285")]
			get;
		}

		[Token(Token = "0x600027D")]
		void CalculateLayoutInputHorizontal();

		[Token(Token = "0x600027E")]
		void CalculateLayoutInputVertical();
	}
}
