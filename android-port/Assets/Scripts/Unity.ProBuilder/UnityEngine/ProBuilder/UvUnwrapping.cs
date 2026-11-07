using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	internal static class UvUnwrapping
	{
		private static Vector2 s_TempVector2;

		private static readonly List<int> s_IndexBuffer;

		internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection = default(Vector3))
		{
		}

		internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings)
		{
		}

		private static void ApplyUVSettings(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings uvSettings)
		{
		}

		private static void StretchUVs(Vector2[] uvs, IList<int> indexes)
		{
		}

		private static void FitUVs(Vector2[] uvs, IList<int> indexes)
		{
		}

		private static void ApplyUVAnchor(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings.Anchor anchor)
		{
		}
	}
}
