using System.Collections.Generic;
using UnityEngine;

namespace Triband.Core.GeometryUtils
{
	public static class TriangulationUtil
	{
		public static int[] TriangulateSimple(Vector2[] points)
		{
			if (points == null || points.Length < 3) return new int[0];
			List<int> indices = new List<int>();
			int n = points.Length;
			List<int> V = new List<int>(n);
			if (Area(points) > 0f)
			{
				for (int v = 0; v < n; v++) V.Add(v);
			}
			else
			{
				for (int v = 0; v < n; v++) V.Add((n - 1) - v);
			}
			int nv = n;
			int count = 2 * nv;
			for (int v = nv - 1; nv > 2;)
			{
				if ((count--) <= 0) break;
				int u = v; if (nv <= u) u = 0;
				v = u + 1; if (nv <= v) v = 0;
				int w = v + 1; if (nv <= w) w = 0;
				if (Snip(points, u, v, w, nv, V))
				{
					indices.Add(V[u]);
					indices.Add(V[v]);
					indices.Add(V[w]);
					V.RemoveAt(v);
					nv--;
					count = 2 * nv;
				}
			}
			indices.Reverse();
			return indices.ToArray();
		}

		private static float Area(Vector2[] points)
		{
			int n = points.Length;
			float A = 0f;
			for (int p = n - 1, q = 0; q < n; p = q++)
				A += points[p].x * points[q].y - points[q].x * points[p].y;
			return A * 0.5f;
		}

		private static bool Snip(Vector2[] points, int u, int v, int w, int n, List<int> V)
		{
			Vector2 A = points[V[u]];
			Vector2 B = points[V[v]];
			Vector2 C = points[V[w]];
			if (Mathf.Epsilon > (((B.x - A.x) * (C.y - A.y)) - ((B.y - A.y) * (C.x - A.x))))
				return false;
			for (int p = 0; p < n; p++)
			{
				if (p == u || p == v || p == w) continue;
				Vector2 P = points[V[p]];
				if (InsideTriangle(A, B, C, P)) return false;
			}
			return true;
		}

		private static bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			float ax = C.x - B.x, ay = C.y - B.y;
			float bx = A.x - C.x, by = A.y - C.y;
			float cx = B.x - A.x, cy = B.y - A.y;
			float apx = P.x - A.x, apy = P.y - A.y;
			float bpx = P.x - B.x, bpy = P.y - B.y;
			float cpx = P.x - C.x, cpy = P.y - C.y;
			return (ax * bpy - ay * bpx >= 0f) && (bx * cpy - by * cpx >= 0f) && (cx * apy - cy * apx >= 0f);
		}
	}
}
