using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class SaveOnExitGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button backButton;

		[SerializeField]
		private Button saveButton;

		[SerializeField]
		private Button dontSaveButton;

		[SerializeField]
		private GameObject warningGroup;

		[SerializeField]
		private GameObject savingGroup;

		[SerializeField]
		private Transform savingProgressBar;

		[SerializeField]
		private float savingDuration;

		private bool isSaving;

		private CallbackArgs callbackArgs;

		public override bool isActiveOnOpen => false;

		public override void Init()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		private IEnumerator SaveCo()
		{
			return null;
		}

		private void HandleBack()
		{
		}

		private void HandleSave()
		{
		}

		private void HandleDontSave()
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void Disable()
		{
		}
	}
}
