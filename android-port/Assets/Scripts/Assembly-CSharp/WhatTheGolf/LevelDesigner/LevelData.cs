using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public sealed class LevelData : ScriptableObject
	{
		[SerializeField]
		private string m_LevelName;

		[SerializeField]
		private string m_Description;

		[SerializeField]
		private Texture2D m_Thumbnail;

		[SerializeField]
		private LevelContentData m_ContentData;

		[SerializeField]
		private bool m_CanPublish;

		[SerializeField]
		private bool m_Published;

		private Guid m_Guid;

		private bool m_Completed;

		public string levelName
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

		public LevelContentData contentData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool canPublish
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public Guid guid
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public bool completed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool hasUnsavedChanges { get; set; }
	}
}
