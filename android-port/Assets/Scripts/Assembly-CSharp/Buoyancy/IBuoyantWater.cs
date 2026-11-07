using Il2CppDummyDll;

namespace Buoyancy
{
	[Token(Token = "0x20011EA")]
	public interface IBuoyantWater
	{
		[Token(Token = "0x170008F6")]
		float Viscosity
		{
			[Token(Token = "0x600522E")]
			get;
		}

		[Token(Token = "0x170008F7")]
		float WaterForceUp
		{
			[Token(Token = "0x600522F")]
			get;
		}

		[Token(Token = "0x170008F8")]
		float SurfacePositionY
		{
			[Token(Token = "0x6005230")]
			get;
		}
	}
}
