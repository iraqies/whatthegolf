using System;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	public sealed class RendererParameters : ScriptableObject
	{
		[SerializeField]
		private Material m_Material;

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
