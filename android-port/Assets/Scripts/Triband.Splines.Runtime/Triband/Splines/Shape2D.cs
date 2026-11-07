using System.Collections;
using System.Collections.Generic;

namespace Triband.Splines
{
	public class Shape2D : IEnumerable<Vertex2D>, IEnumerable
	{
		private readonly List<Vertex2D> vertices;

		public int VertexCount => 0;

		public void AddVertex(Vertex2D vertex)
		{
		}

		public Vertex2D GetVertex(int index)
		{
			return default;
		}

		public IEnumerator<Vertex2D> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
