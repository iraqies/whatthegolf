using Il2CppDummyDll;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000008")]
	public delegate void DeferredFlagsChangedHandler(DecalBase decal, DeferredFlags lastFlags, DeferredFlags currFlags);
}
