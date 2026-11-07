using Il2CppDummyDll;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x200000A")]
	internal enum SpriteSkinValidationResult
	{
		[Token(Token = "0x4000020")]
		SpriteNotFound = 0,
		[Token(Token = "0x4000021")]
		SpriteHasNoSkinningInformation = 1,
		[Token(Token = "0x4000022")]
		SpriteHasNoWeights = 2,
		[Token(Token = "0x4000023")]
		RootTransformNotFound = 3,
		[Token(Token = "0x4000024")]
		InvalidTransformArray = 4,
		[Token(Token = "0x4000025")]
		InvalidTransformArrayLength = 5,
		[Token(Token = "0x4000026")]
		TransformArrayContainsNull = 6,
		[Token(Token = "0x4000027")]
		RootNotFoundInTransformArray = 7,
		[Token(Token = "0x4000028")]
		Ready = 8
	}
}
