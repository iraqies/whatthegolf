using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x200001F")]
	public static class Projection
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2A59234", Offset = "0x2A59234", VA = "0x2A59234")]
		internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2A59760", Offset = "0x2A59760", VA = "0x2A59760")]
		internal static void PlanarProject(ProBuilderMesh mesh, Face face, [Optional] Vector3 projection)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2A59720", Offset = "0x2A59720", VA = "0x2A59720")]
		internal static Vector3 GetTangentToAxis(ProjectionAxis axis)
		{
			return default;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2A59634", Offset = "0x2A59634", VA = "0x2A59634")]
		internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction)
		{
			return default;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2A4B1B4", Offset = "0x2A4B1B4", VA = "0x2A4B1B4")]
		public static Plane FindBestPlane(IList<Vector3> points, [Optional] IList<int> indexes)
		{
			return default;
		}
	}
}
