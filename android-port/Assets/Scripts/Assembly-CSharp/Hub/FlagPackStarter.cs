using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

namespace Hub
{
	public class FlagPackStarter : MonoBehaviour
	{
		[SerializeField]
		private GameObject crown;

		[SerializeField]
		private GameObject completedFlag;

		[SerializeField]
		private GameObject uncompletedFlag;

		[SerializeField]
		private Collider2D circleCollider;

		[SerializeField]
		private Collider2D boxCollider;

		[SerializeField]
		private bool dontDisableOverworld;

		[SerializeField]
		private WhatTheCarPopup carPopup;

		private DayOfWeek lastUpdate;

		[SerializeField]
		public string pack;

		[NonSerialized]
		private ContentPackDef packDef;

		private NotificationConfiguration notifs => null;

		private bool IsImpossiblePack => false;

		private ContentPackDef PackDef => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetState()
		{
		}

		public virtual void OnCollisionEnter2D(Collision2D collision)
		{
		}

		public void StartPack()
		{
		}

		private IEnumerator DisableOverworldWithDelay()
		{
			return null;
		}

		private void DisableInteraction()
		{
		}

		private void EnableInteraction()
		{
		}

		private WTGNotification GetNotification()
		{
			return default;
		}

		private bool IsCompleted()
		{
			return false;
		}

		public static Task<bool> StartFlag(string packId)
		{
			return null;
		}
	}
}
