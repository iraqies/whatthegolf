using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class SerializableTerrainData
	{
		[SerializeField]
		private byte[] m_Values;

		public byte[] values => null;

		public SerializableTerrainData(byte[] values)
		{
		}
	}
}
