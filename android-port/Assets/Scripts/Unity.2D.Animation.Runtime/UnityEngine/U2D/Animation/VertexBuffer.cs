namespace UnityEngine.U2D.Animation
{
	internal class VertexBuffer
	{
		private readonly int m_Id;

		private bool m_IsActive;

		private int m_DeactivateFrame;

		private NativeByteArray[] m_Buffers;

		private int m_ActiveIndex;

		public int bufferCount => 0;

		public VertexBuffer(int id, int size, bool needDoubleBuffering)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private static int GetCurrentFrame()
		{
			return 0;
		}

		public NativeByteArray GetBuffer(int size)
		{
			return null;
		}

		private void ResizeBuffer(int bufferId, int newSize)
		{
		}

		public void Deactivate()
		{
		}

		public void Dispose()
		{
		}

		public bool IsSafeToDispose()
		{
			return false;
		}
	}
}
