using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200001D")]
	public delegate EasyDecal InstantiationDelegate(GameObject decalPrefab, GameObject parent, Vector3 position, Quaternion rotation);
}
