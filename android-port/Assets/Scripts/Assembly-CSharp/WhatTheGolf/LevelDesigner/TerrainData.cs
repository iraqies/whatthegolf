using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class TerrainData
	{
		[SerializeField]
		private byte[] m_Values;

		public byte[] values => null;

		public TerrainData(byte[] values)
		{
		}
	}
}
