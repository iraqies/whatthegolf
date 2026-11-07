using System;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	[Serializable]
	public struct DiagnosticEvent
	{
		[SerializeField]
		private string m_Graph;

		[SerializeField]
		private int[] m_Dependencies;

		[SerializeField]
		private int m_ObjectId;

		[SerializeField]
		private string m_DisplayName;

		[SerializeField]
		private int m_Stream;

		[SerializeField]
		private int m_Frame;

		[SerializeField]
		private int m_Value;

		public string Graph => null;

		public int ObjectId => 0;

		public string DisplayName => null;

		public int[] Dependencies => null;

		public int Stream => 0;

		public int Frame => 0;

		public int Value => 0;

		public DiagnosticEvent(string graph, string name, int id, int stream, int frame, int value, int[] deps)
		{
			m_Graph = null;
			m_Dependencies = null;
			m_ObjectId = 0;
			m_DisplayName = null;
			m_Stream = 0;
			m_Frame = 0;
			m_Value = 0;
		}

		internal byte[] Serialize()
		{
			return null;
		}

		public static DiagnosticEvent Deserialize(byte[] data)
		{
			return default;
		}
	}
}
