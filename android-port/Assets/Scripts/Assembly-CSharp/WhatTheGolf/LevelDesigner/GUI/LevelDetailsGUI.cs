using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class LevelDetailsGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<PlayEvent>
	{
		private enum PublishSequenceSource
		{
			Main = 0,
			HitTheFlagOptions = 1
		}

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private GameObject mainContainer;

		[SerializeField]
		private GameObject deleteContainer;

		[SerializeField]
		private GameObject publishContainer;

		[SerializeField]
		private GameObject shareContainer;

		[SerializeField]
		private GameObject editTextContainer;

		[SerializeField]
		private GameObject hitTheFlagContainer;

		[SerializeField]
		private LevelCoverButtonGUI levelCoverButtonGUI;

		[SerializeField]
		private Button editDetailsButton;

		[SerializeField]
		private Button deleteButton;

		[SerializeField]
		private Button publishButton;

		[SerializeField]
		private Button shareButton;

		[SerializeField]
		private Button editButton;

		[SerializeField]
		private Button backButton;

		[SerializeField]
		private TextMeshProUGUI levelName;

		[SerializeField]
		private TextMeshProUGUI levelDescription;

		[SerializeField]
		private Button cancelEditDetailsButton;

		[SerializeField]
		private Button confirmEditDetailsButton;

		[SerializeField]
		private LevelCoverButtonGUI editDetailsLevelCover;

		[SerializeField]
		private TMP_InputField editTitle;

		[SerializeField]
		private TMP_InputField editDescription;

		[SerializeField]
		private GameObject publishedLabel;

		[SerializeField]
		private Button cancelDeleteButton;

		[SerializeField]
		private Button confirmDeleteButton;

		[SerializeField]
		private LevelCoverButtonGUI deleteLevelCover;

		[SerializeField]
		private Button cancelShareButton;

		[SerializeField]
		private Button confirmShareButton;

		[SerializeField]
		private TextMeshProUGUI shareTitle;

		[SerializeField]
		private TextMeshProUGUI shareLink;

		[SerializeField]
		private LevelCoverButtonGUI shareLevelCover;

		[SerializeField]
		private Button hitFlag_Replay_Button;

		[SerializeField]
		private Button hitFlag_Edit_Button;

		[SerializeField]
		private Button hitFlag_Publish_Button;

		[SerializeField]
		private LevelCoverButtonGUI hitFlag_LevelCover;

		[SerializeField]
		private LevelCoverButtonGUI publishLevelCover;

		[SerializeField]
		private GameObject publishInvalidContainer;

		[SerializeField]
		private LevelCoverButtonGUI publishInvalidCover;

		[SerializeField]
		private Button publishInvalidBackButton;

		[SerializeField]
		private RectTransform progressBar;

		[SerializeField]
		private float publishAnimSmoothTime;

		[SerializeField]
		private bool publishDone;

		[SerializeField]
		private Graphic publishRenderer;

		[SerializeField]
		private Graphic publishSuccessRenderer;

		[SerializeField]
		private Graphic publishFailureRenderer;

		[SerializeField]
		private GameObject publishInputBlocker;

		[SerializeField]
		private float fadeTime;

		[SerializeField]
		private GameObject publishStartContainer;

		[SerializeField]
		private Button publishStart_ButtonBack;

		[SerializeField]
		private Button publishStart_ButtonNext;

		[SerializeField]
		private GameObject publishReviewTextContainer;

		[SerializeField]
		private Button publishTextReview_ButtonBack;

		[SerializeField]
		private Button publishTextReview_ButtonNext;

		[SerializeField]
		private TMP_InputField hitFlag_LevelName;

		[SerializeField]
		private TMP_InputField hitFlag_LevelDescription;

		[SerializeField]
		private GameObject publishSuccessContainer;

		[SerializeField]
		private TextMeshProUGUI publishSuccess_LevelTitle;

		[SerializeField]
		private TextMeshProUGUI publishSuccess_Link;

		[SerializeField]
		private Button publishSuccess_ButtonCopyLink;

		[SerializeField]
		private Button publishSuccess_ButtonNext;

		[SerializeField]
		private GameObject publishFailureContainer;

		[SerializeField]
		private TextMeshProUGUI publishFailure_LevelTitle;

		[SerializeField]
		private Button publishFailure_ButtonCancel;

		[SerializeField]
		private Button publishFailure_ButtonRetry;

		private SerializableLevelData serializableLevelData;

		private PublishSequenceSource publishSequenceSource;

		private bool m_IsVisible;

		private Action continueAction;

		private Action cancelAction;

		private const float minPublishDuration = 1f;

		private float publishAnimSpeed;

		public override bool isActiveOnOpen => false;

		public override void Init()
		{
		}

		private void CloseButton_OnSelected()
		{
		}

		private void RequestPlayLevel(SerializableLevelData sld)
		{
		}

		private void PlayLevel(SerializableLevelData sld)
		{
		}

		private void PlayLevel()
		{
		}

		private void RequestEditLevel()
		{
		}

		private void EditLevel()
		{
		}

		private void ToggleEditDetails()
		{
		}

		private void OpenEditDetails()
		{
		}

		private void ConfirmEditDetails()
		{
		}

		private void CancelEditDetails()
		{
		}

		private void OpenDeleteLevel()
		{
		}

		private void ConfirmDeleteLevel()
		{
		}

		private void CancelDeleteLevel()
		{
		}

		private void PublishFromMain()
		{
		}

		private void PublishFromHitTheFlag()
		{
		}

		private void ShowPublishStart()
		{
		}

		private void ShowInvalidPublish()
		{
		}

		private void HandleCancelPublish()
		{
		}

		private void PublishInvalidBack()
		{
		}

		private void ShowPublishTextReview()
		{
		}

		private void PublishLevel()
		{
		}

		private IEnumerator PublishLevelCo()
		{
			return null;
		}

		private void ResetPublishProgressGroup()
		{
		}

		private void ShowPublishFailure()
		{
		}

		private void ShowPublishSuccess()
		{
		}

		private void PublishSuccessCopyLink()
		{
		}

		private void PublishSuccessNext()
		{
		}

		private void OpenShareLevel()
		{
		}

		private void ConfirmShareLevel()
		{
		}

		private void CancelShareLevel()
		{
		}

		private void ShowSaveWithDetails(SerializableLevelData sld)
		{
		}

		private void CancelSaveWithDetails()
		{
		}

		private void ConfirmSaveWithDetails()
		{
		}

		private void ShowHitTheFlagOptions(SerializableLevelData sld)
		{
		}

		private void HitTheFlagReplay()
		{
		}

		private void HitTheFlagEdit()
		{
		}

		private void BackAction()
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		public void OnEvent(PlayEvent evt)
		{
		}

		private void ShowMain(SerializableLevelData sld)
		{
		}

		private void ShowMain(CallbackAndGuidArgs callbackAndGuidArgs)
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
