using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001DE")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x132A96C", Offset = "0x132A96C", VA = "0x132A96C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x132A9C8", Offset = "0x132A9C8", VA = "0x132A9C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x132A9FC", Offset = "0x132A9FC", VA = "0x132A9FC")]
		private int GetLODLevel()
		{
			return default;
		}

		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x132AB44", Offset = "0x132AB44", VA = "0x132AB44")]
		public VRIKLODController()
		{
		}
	}
}
