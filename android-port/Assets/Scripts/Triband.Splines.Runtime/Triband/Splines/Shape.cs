using System.Collections.Generic;

namespace Triband.Splines
{
	public class Shape
	{
		private readonly List<Vertex> vertices = new List<Vertex>();
		private readonly List<int> triangles = new List<int>();

		public List<Vertex> Vertices => vertices;
		public List<int> Triangles => triangles;
	}
}
