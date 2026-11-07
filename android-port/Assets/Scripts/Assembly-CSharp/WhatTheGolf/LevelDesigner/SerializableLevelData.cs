using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class SerializableLevelData : ISerializationCallbackReceiver
	{
		[SerializeField]
		private string m_SerializedGuid;

		[SerializeField]
		private string m_Name;

		[SerializeField]
		private string m_Description;

		[SerializeField]
		private int m_BallId;

		[SerializeField]
		private byte[] m_SerializedThumbnail;

		[SerializeField]
		private string m_SerializedLevelContentData;

		[SerializeField]
		private bool m_CanPublish;

		[SerializeField]
		private bool m_Published;

		private Guid m_Guid;

		private Texture2D m_Thumbnail;

		private LevelContentData m_LevelContentData;

		public static string levelUrlBase;

		public Guid guid => default;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D thumbnail
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LevelContentData levelContentData => null;

		public int ballID => 0;

		public bool canPublish => false;

		public bool published
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool hasSerializedLevelContentData => false;

		public string url => null;

		public string shortGuid => null;

		public SerializableLevelData(LevelData levelData)
		{
		}

		public void LoadContentData(ElementDatabase elementDatabase)
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}
	}
}
