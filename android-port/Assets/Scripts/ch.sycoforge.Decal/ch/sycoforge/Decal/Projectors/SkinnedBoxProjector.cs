using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	[Token(Token = "0x200003A")]
	internal class SkinnedBoxProjector : BoxProjector
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2C6DA94", Offset = "0x2C6DA94", VA = "0x2C6DA94")]
		internal SkinnedBoxProjector(EasyDecal decal)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2C6DE10", Offset = "0x2C6DE10", VA = "0x2C6DE10", Slot = "12")]
		internal override void Project()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2C6E3C4", Offset = "0x2C6E3C4", VA = "0x2C6E3C4")]
		private void ProjectUsingList()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2C6E1F8", Offset = "0x2C6E1F8", VA = "0x2C6E1F8")]
		private void ProjectUsingEnviroment()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2C6E414", Offset = "0x2C6E414", VA = "0x2C6E414", Slot = "13")]
		protected override void ProcessReceiver(GameObject receiver, int recursiveStepUp, int recursiveStepDown, bool ignoreTerrain = true)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2C6E7F4", Offset = "0x2C6E7F4", VA = "0x2C6E7F4")]
		private void AddMesh(SkinnedMeshRenderer renderer, Transform receiver, Matrix4x4 localToWorld)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2C6E98C", Offset = "0x2C6E98C", VA = "0x2C6E98C")]
		public static Mesh BakeNoScale(SkinnedMeshRenderer skin)
		{
			return null;
		}
	}
}
