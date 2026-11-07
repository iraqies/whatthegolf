using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001297")]
	public class LevelDetailsGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<PlayEvent>
	{
		[Token(Token = "0x2001298")]
		private enum PublishSequenceSource
		{
			[Token(Token = "0x400645C")]
			Main = 0,
			[Token(Token = "0x400645D")]
			HitTheFlagOptions = 1
		}

		[Token(Token = "0x2001299")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x488BC", Offset = "0x488BC")]
		private sealed class _003C_003Ec__DisplayClass95_0
		{
			[Token(Token = "0x400645E")]
			[FieldOffset(Offset = "0x10")]
			public bool isError;

			[Token(Token = "0x6005642")]
			[Address(RVA = "0x17D2C50", Offset = "0x17D2C50", VA = "0x17D2C50")]
			public _003C_003Ec__DisplayClass95_0()
			{
			}

			[Token(Token = "0x6005643")]
			[Address(RVA = "0x17D2C58", Offset = "0x17D2C58", VA = "0x17D2C58")]
			internal void _003CPublishLevelCo_003Eb__0(bool e)
			{
			}
		}

		[Token(Token = "0x200129A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x488CC", Offset = "0x488CC")]
		private sealed class _003CPublishLevelCo_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400645F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006460")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006461")]
			[FieldOffset(Offset = "0x20")]
			public LevelDetailsGUI _003C_003E4__this;

			[Token(Token = "0x4006462")]
			[FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass95_0 _003C_003E8__1;

			[Token(Token = "0x4006463")]
			[FieldOffset(Offset = "0x30")]
			private float _003Cprogress_003E5__2;

			[Token(Token = "0x4006464")]
			[FieldOffset(Offset = "0x34")]
			private float _003CprogressTarget_003E5__3;

			[Token(Token = "0x170009D2")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005647")]
				[Address(RVA = "0x17D3210", Offset = "0x17D3210", VA = "0x17D3210", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009D3")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005649")]
				[Address(RVA = "0x17D3258", Offset = "0x17D3258", VA = "0x17D3258", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005644")]
			[Address(RVA = "0x17D2C60", Offset = "0x17D2C60", VA = "0x17D2C60")]
			[DebuggerHidden]
			public _003CPublishLevelCo_003Ed__95(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005645")]
			[Address(RVA = "0x17D2C8C", Offset = "0x17D2C8C", VA = "0x17D2C8C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005646")]
			[Address(RVA = "0x17D2C90", Offset = "0x17D2C90", VA = "0x17D2C90", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005647")]
			[Address(RVA = "0x17D3210", Offset = "0x17D3210", VA = "0x17D3210", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005648")]
			[Address(RVA = "0x17D3218", Offset = "0x17D3218", VA = "0x17D3218", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005649")]
			[Address(RVA = "0x17D3258", Offset = "0x17D3258", VA = "0x17D3258", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006415")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button closeButton;

		[Token(Token = "0x4006416")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject mainContainer;

		[Token(Token = "0x4006417")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject deleteContainer;

		[Token(Token = "0x4006418")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject publishContainer;

		[Token(Token = "0x4006419")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject shareContainer;

		[Token(Token = "0x400641A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject editTextContainer;

		[Token(Token = "0x400641B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject hitTheFlagContainer;

		[Token(Token = "0x400641C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LevelCoverButtonGUI levelCoverButtonGUI;

		[Token(Token = "0x400641D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button editDetailsButton;

		[Token(Token = "0x400641E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button deleteButton;

		[Token(Token = "0x400641F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button publishButton;

		[Token(Token = "0x4006420")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button shareButton;

		[Token(Token = "0x4006421")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button editButton;

		[Token(Token = "0x4006422")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button backButton;

		[Token(Token = "0x4006423")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TextMeshProUGUI levelName;

		[Token(Token = "0x4006424")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TextMeshProUGUI levelDescription;

		[Token(Token = "0x4006425")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button cancelEditDetailsButton;

		[Token(Token = "0x4006426")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Button confirmEditDetailsButton;

		[Token(Token = "0x4006427")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private LevelCoverButtonGUI editDetailsLevelCover;

		[Token(Token = "0x4006428")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TMP_InputField editTitle;

		[Token(Token = "0x4006429")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private TMP_InputField editDescription;

		[Token(Token = "0x400642A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject publishedLabel;

		[Token(Token = "0x400642B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Button cancelDeleteButton;

		[Token(Token = "0x400642C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Button confirmDeleteButton;

		[Token(Token = "0x400642D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private LevelCoverButtonGUI deleteLevelCover;

		[Token(Token = "0x400642E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Button cancelShareButton;

		[Token(Token = "0x400642F")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Button confirmShareButton;

		[Token(Token = "0x4006430")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TextMeshProUGUI shareTitle;

		[Token(Token = "0x4006431")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private TextMeshProUGUI shareLink;

		[Token(Token = "0x4006432")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private LevelCoverButtonGUI shareLevelCover;

		[Token(Token = "0x4006433")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Button hitFlag_Replay_Button;

		[Token(Token = "0x4006434")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Button hitFlag_Edit_Button;

		[Token(Token = "0x4006435")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Button hitFlag_Publish_Button;

		[Token(Token = "0x4006436")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private LevelCoverButtonGUI hitFlag_LevelCover;

		[Token(Token = "0x4006437")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private LevelCoverButtonGUI publishLevelCover;

		[Token(Token = "0x4006438")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GameObject publishInvalidContainer;

		[Token(Token = "0x4006439")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private LevelCoverButtonGUI publishInvalidCover;

		[Token(Token = "0x400643A")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Button publishInvalidBackButton;

		[Token(Token = "0x400643B")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private RectTransform progressBar;

		[Token(Token = "0x400643C")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private float publishAnimSmoothTime;

		[Token(Token = "0x400643D")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private bool publishDone;

		[Token(Token = "0x400643E")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Graphic publishRenderer;

		[Token(Token = "0x400643F")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Graphic publishSuccessRenderer;

		[Token(Token = "0x4006440")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Graphic publishFailureRenderer;

		[Token(Token = "0x4006441")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GameObject publishInputBlocker;

		[Token(Token = "0x4006442")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private float fadeTime;

		[Token(Token = "0x4006443")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private GameObject publishStartContainer;

		[Token(Token = "0x4006444")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Button publishStart_ButtonBack;

		[Token(Token = "0x4006445")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Button publishStart_ButtonNext;

		[Token(Token = "0x4006446")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private GameObject publishReviewTextContainer;

		[Token(Token = "0x4006447")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Button publishTextReview_ButtonBack;

		[Token(Token = "0x4006448")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private Button publishTextReview_ButtonNext;

		[Token(Token = "0x4006449")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private TMP_InputField hitFlag_LevelName;

		[Token(Token = "0x400644A")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private TMP_InputField hitFlag_LevelDescription;

		[Token(Token = "0x400644B")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private GameObject publishSuccessContainer;

		[Token(Token = "0x400644C")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private TextMeshProUGUI publishSuccess_LevelTitle;

		[Token(Token = "0x400644D")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private TextMeshProUGUI publishSuccess_Link;

		[Token(Token = "0x400644E")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private Button publishSuccess_ButtonCopyLink;

		[Token(Token = "0x400644F")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private Button publishSuccess_ButtonNext;

		[Token(Token = "0x4006450")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private GameObject publishFailureContainer;

		[Token(Token = "0x4006451")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private TextMeshProUGUI publishFailure_LevelTitle;

		[Token(Token = "0x4006452")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private Button publishFailure_ButtonCancel;

		[Token(Token = "0x4006453")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private Button publishFailure_ButtonRetry;

		[Token(Token = "0x4006454")]
		[FieldOffset(Offset = "0x230")]
		private SerializableLevelData serializableLevelData;

		[Token(Token = "0x4006455")]
		[FieldOffset(Offset = "0x238")]
		private PublishSequenceSource publishSequenceSource;

		[Token(Token = "0x4006456")]
		[FieldOffset(Offset = "0x23C")]
		private bool m_IsVisible;

		[Token(Token = "0x4006457")]
		[FieldOffset(Offset = "0x240")]
		private Action continueAction;

		[Token(Token = "0x4006458")]
		[FieldOffset(Offset = "0x248")]
		private Action cancelAction;

		[Token(Token = "0x4006459")]
		private const float minPublishDuration = 1f;

		[Token(Token = "0x400645A")]
		[FieldOffset(Offset = "0x250")]
		private float publishAnimSpeed;

		[Token(Token = "0x170009D1")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x6005614")]
			[Address(RVA = "0x152A920", Offset = "0x152A920", VA = "0x152A920", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005615")]
		[Address(RVA = "0x152A928", Offset = "0x152A928", VA = "0x152A928", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005616")]
		[Address(RVA = "0x152B2CC", Offset = "0x152B2CC", VA = "0x152B2CC")]
		private void CloseButton_OnSelected()
		{
		}

		[Token(Token = "0x6005617")]
		[Address(RVA = "0x152B3A0", Offset = "0x152B3A0", VA = "0x152B3A0")]
		private void RequestPlayLevel(SerializableLevelData sld)
		{
		}

		[Token(Token = "0x6005618")]
		[Address(RVA = "0x152B4AC", Offset = "0x152B4AC", VA = "0x152B4AC")]
		private void PlayLevel(SerializableLevelData sld)
		{
		}

		[Token(Token = "0x6005619")]
		[Address(RVA = "0x152B540", Offset = "0x152B540", VA = "0x152B540")]
		private void PlayLevel()
		{
		}

		[Token(Token = "0x600561A")]
		[Address(RVA = "0x152B548", Offset = "0x152B548", VA = "0x152B548")]
		private void RequestEditLevel()
		{
		}

		[Token(Token = "0x600561B")]
		[Address(RVA = "0x152B654", Offset = "0x152B654", VA = "0x152B654")]
		private void EditLevel()
		{
		}

		[Token(Token = "0x600561C")]
		[Address(RVA = "0x152B6E0", Offset = "0x152B6E0", VA = "0x152B6E0")]
		private void ToggleEditDetails()
		{
		}

		[Token(Token = "0x600561D")]
		[Address(RVA = "0x152B788", Offset = "0x152B788", VA = "0x152B788")]
		private void OpenEditDetails()
		{
		}

		[Token(Token = "0x600561E")]
		[Address(RVA = "0x152B728", Offset = "0x152B728", VA = "0x152B728")]
		private void ConfirmEditDetails()
		{
		}

		[Token(Token = "0x600561F")]
		[Address(RVA = "0x152BD54", Offset = "0x152BD54", VA = "0x152BD54")]
		private void CancelEditDetails()
		{
		}

		[Token(Token = "0x6005620")]
		[Address(RVA = "0x152BD5C", Offset = "0x152BD5C", VA = "0x152BD5C")]
		private void OpenDeleteLevel()
		{
		}

		[Token(Token = "0x6005621")]
		[Address(RVA = "0x152BE00", Offset = "0x152BE00", VA = "0x152BE00")]
		private void ConfirmDeleteLevel()
		{
		}

		[Token(Token = "0x6005622")]
		[Address(RVA = "0x152BE8C", Offset = "0x152BE8C", VA = "0x152BE8C")]
		private void CancelDeleteLevel()
		{
		}

		[Token(Token = "0x6005623")]
		[Address(RVA = "0x152BE94", Offset = "0x152BE94", VA = "0x152BE94")]
		private void PublishFromMain()
		{
		}

		[Token(Token = "0x6005624")]
		[Address(RVA = "0x152C00C", Offset = "0x152C00C", VA = "0x152C00C")]
		private void PublishFromHitTheFlag()
		{
		}

		[Token(Token = "0x6005625")]
		[Address(RVA = "0x152BED0", Offset = "0x152BED0", VA = "0x152BED0")]
		private void ShowPublishStart()
		{
		}

		[Token(Token = "0x6005626")]
		[Address(RVA = "0x152C04C", Offset = "0x152C04C", VA = "0x152C04C")]
		private void ShowInvalidPublish()
		{
		}

		[Token(Token = "0x6005627")]
		[Address(RVA = "0x152C1EC", Offset = "0x152C1EC", VA = "0x152C1EC")]
		private void HandleCancelPublish()
		{
		}

		[Token(Token = "0x6005628")]
		[Address(RVA = "0x152C2E8", Offset = "0x152C2E8", VA = "0x152C2E8")]
		private void PublishInvalidBack()
		{
		}

		[Token(Token = "0x6005629")]
		[Address(RVA = "0x152C2F0", Offset = "0x152C2F0", VA = "0x152C2F0")]
		private void ShowPublishTextReview()
		{
		}

		[Token(Token = "0x600562A")]
		[Address(RVA = "0x152C3A0", Offset = "0x152C3A0", VA = "0x152C3A0")]
		private void PublishLevel()
		{
		}

		[Token(Token = "0x600562B")]
		[Address(RVA = "0x152C41C", Offset = "0x152C41C", VA = "0x152C41C")]
		private IEnumerator PublishLevelCo()
		{
			return null;
		}

		[Token(Token = "0x600562C")]
		[Address(RVA = "0x152C104", Offset = "0x152C104", VA = "0x152C104")]
		private void ResetPublishProgressGroup()
		{
		}

		[Token(Token = "0x600562D")]
		[Address(RVA = "0x152C490", Offset = "0x152C490", VA = "0x152C490")]
		private void ShowPublishFailure()
		{
		}

		[Token(Token = "0x600562E")]
		[Address(RVA = "0x152C4F4", Offset = "0x152C4F4", VA = "0x152C4F4")]
		private void ShowPublishSuccess()
		{
		}

		[Token(Token = "0x600562F")]
		[Address(RVA = "0x152C5AC", Offset = "0x152C5AC", VA = "0x152C5AC")]
		private void PublishSuccessCopyLink()
		{
		}

		[Token(Token = "0x6005630")]
		[Address(RVA = "0x152C62C", Offset = "0x152C62C", VA = "0x152C62C")]
		private void PublishSuccessNext()
		{
		}

		[Token(Token = "0x6005631")]
		[Address(RVA = "0x152C630", Offset = "0x152C630", VA = "0x152C630")]
		private void OpenShareLevel()
		{
		}

		[Token(Token = "0x6005632")]
		[Address(RVA = "0x152C728", Offset = "0x152C728", VA = "0x152C728")]
		private void ConfirmShareLevel()
		{
		}

		[Token(Token = "0x6005633")]
		[Address(RVA = "0x152C7B4", Offset = "0x152C7B4", VA = "0x152C7B4")]
		private void CancelShareLevel()
		{
		}

		[Token(Token = "0x6005634")]
		[Address(RVA = "0x152C7BC", Offset = "0x152C7BC", VA = "0x152C7BC")]
		private void ShowSaveWithDetails(SerializableLevelData sld)
		{
		}

		[Token(Token = "0x6005635")]
		[Address(RVA = "0x152C908", Offset = "0x152C908", VA = "0x152C908")]
		private void CancelSaveWithDetails()
		{
		}

		[Token(Token = "0x6005636")]
		[Address(RVA = "0x152C988", Offset = "0x152C988", VA = "0x152C988")]
		private void ConfirmSaveWithDetails()
		{
		}

		[Token(Token = "0x6005637")]
		[Address(RVA = "0x152C210", Offset = "0x152C210", VA = "0x152C210")]
		private void ShowHitTheFlagOptions(SerializableLevelData sld)
		{
		}

		[Token(Token = "0x6005638")]
		[Address(RVA = "0x152C9FC", Offset = "0x152C9FC", VA = "0x152C9FC")]
		private void HitTheFlagReplay()
		{
		}

		[Token(Token = "0x6005639")]
		[Address(RVA = "0x152CA00", Offset = "0x152CA00", VA = "0x152CA00")]
		private void HitTheFlagEdit()
		{
		}

		[Token(Token = "0x600563A")]
		[Address(RVA = "0x152CA78", Offset = "0x152CA78", VA = "0x152CA78")]
		private void BackAction()
		{
		}

		[Token(Token = "0x600563B")]
		[Address(RVA = "0x152CAB0", Offset = "0x152CAB0", VA = "0x152CAB0", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x600563C")]
		[Address(RVA = "0x152CCE4", Offset = "0x152CCE4", VA = "0x152CCE4", Slot = "8")]
		public void OnEvent(PlayEvent evt)
		{
		}

		[Token(Token = "0x600563D")]
		[Address(RVA = "0x152B964", Offset = "0x152B964", VA = "0x152B964")]
		private void ShowMain(SerializableLevelData sld)
		{
		}

		[Token(Token = "0x600563E")]
		[Address(RVA = "0x152CCA0", Offset = "0x152CCA0", VA = "0x152CCA0")]
		private void ShowMain(CallbackAndGuidArgs callbackAndGuidArgs)
		{
		}

		[Token(Token = "0x600563F")]
		[Address(RVA = "0x152B2D0", Offset = "0x152B2D0", VA = "0x152B2D0")]
		private void Hide()
		{
		}

		[Token(Token = "0x6005640")]
		[Address(RVA = "0x152CDC0", Offset = "0x152CDC0", VA = "0x152CDC0")]
		private void Disable()
		{
		}

		[Token(Token = "0x6005641")]
		[Address(RVA = "0x152CEE8", Offset = "0x152CEE8", VA = "0x152CEE8")]
		public LevelDetailsGUI()
		{
		}
	}
}
