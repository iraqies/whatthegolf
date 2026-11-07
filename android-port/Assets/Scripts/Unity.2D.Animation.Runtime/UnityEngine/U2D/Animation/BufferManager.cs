using System.Collections.Generic;

namespace UnityEngine.U2D.Animation
{
	internal class BufferManager : ScriptableObject
	{
		private static BufferManager s_Instance;

		private Dictionary<int, VertexBuffer> m_Buffers;

		private Queue<VertexBuffer> m_BuffersToDispose;

		public int bufferCount => 0;

		public bool needDoubleBuffering { get; set; }

		public static BufferManager instance => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ForceClearBuffers()
		{
		}

		public NativeByteArray GetBuffer(int id, int bufferSize)
		{
			return null;
		}

		private VertexBuffer CreateBuffer(int id, int bufferSize)
		{
			return null;
		}

		public void ReturnBuffer(int id)
		{
		}

		private void Update()
		{
		}
	}
}
