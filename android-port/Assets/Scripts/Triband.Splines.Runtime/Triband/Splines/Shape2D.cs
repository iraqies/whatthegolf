using System.Collections;
using System.Collections.Generic;

namespace Triband.Splines
{
	public class Shape2D : IEnumerable<Vertex2D>, IEnumerable
	{
		private readonly List<Vertex2D> vertices = new List<Vertex2D>();

		public int VertexCount => vertices.Count;

		public void AddVertex(Vertex2D vertex) => vertices.Add(vertex);

		public Vertex2D GetVertex(int index) => vertices[index];

		public IEnumerator<Vertex2D> GetEnumerator() => vertices.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => vertices.GetEnumerator();
	}
}
