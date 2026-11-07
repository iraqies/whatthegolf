using System;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	public sealed class TerrainLayer
	{
		[SerializeField]
		private bool m_IsEnabled;

		[SerializeField]
		private string m_LayerName;

		[SerializeField]
		private BlendMode m_BlendMode;

		[SerializeField]
		private byte[] m_Values;

		public bool isEnabled => false;

		public BlendMode blendMode => BlendMode.Add;

		public byte[] values
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Init(int pointCount)
		{
		}
	}
}
