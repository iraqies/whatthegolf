using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000007")]
	public interface ICanvasElement
	{
		[Token(Token = "0x17000009")]
		Transform transform
		{
			[Token(Token = "0x6000016")]
			get;
		}

		[Token(Token = "0x6000015")]
		void Rebuild(CanvasUpdate executing);

		[Token(Token = "0x6000017")]
		void LayoutComplete();

		[Token(Token = "0x6000018")]
		void GraphicUpdateComplete();

		[Token(Token = "0x6000019")]
		bool IsDestroyed();
	}
}
