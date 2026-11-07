using Il2CppDummyDll;

namespace Chronos
{
	[Token(Token = "0x2000293")]
	public interface IComponentTimeline
	{
		[Token(Token = "0x600110A")]
		void Initialize();

		[Token(Token = "0x600110B")]
		void OnStartOrReEnable();

		[Token(Token = "0x600110C")]
		void Update();

		[Token(Token = "0x600110D")]
		void FixedUpdate();

		[Token(Token = "0x600110E")]
		void OnDisable();

		[Token(Token = "0x600110F")]
		void AdjustProperties();

		[Token(Token = "0x6001110")]
		void Reset();
	}
}
