using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Core.UI;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
	[Token(Token = "0x2001052")]
	public class InGameMenu : MonoBehaviour
	{
		[Token(Token = "0x2001053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47734", Offset = "0x47734")]
		private sealed class _003CShowText_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005619")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400561A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400561B")]
			[FieldOffset(Offset = "0x20")]
			public InGameMenu _003C_003E4__this;

			[Token(Token = "0x400561C")]
			[FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x400561D")]
			[FieldOffset(Offset = "0x30")]
			public float duration;

			[Token(Token = "0x170007BB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600495C")]
				[Address(RVA = "0x17C59F4", Offset = "0x17C59F4", VA = "0x17C59F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007BC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600495E")]
				[Address(RVA = "0x17C5A3C", Offset = "0x17C5A3C", VA = "0x17C5A3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004959")]
			[Address(RVA = "0x17C58A8", Offset = "0x17C58A8", VA = "0x17C58A8")]
			[DebuggerHidden]
			public _003CShowText_003Ed__60(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600495A")]
			[Address(RVA = "0x17C58D4", Offset = "0x17C58D4", VA = "0x17C58D4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600495B")]
			[Address(RVA = "0x17C58D8", Offset = "0x17C58D8", VA = "0x17C58D8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600495C")]
			[Address(RVA = "0x17C59F4", Offset = "0x17C59F4", VA = "0x17C59F4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600495D")]
			[Address(RVA = "0x17C59FC", Offset = "0x17C59FC", VA = "0x17C59FC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600495E")]
			[Address(RVA = "0x17C5A3C", Offset = "0x17C5A3C", VA = "0x17C5A3C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40055FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform strokeCounterContainer;

		[Token(Token = "0x4005600")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StrokeCounter strokeCounter;

		[Token(Token = "0x4005601")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transition transition;

		[Token(Token = "0x4005602")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject menuButton;

		[Token(Token = "0x4005603")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button exitButton;

		[Token(Token = "0x4005604")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button restartButton;

		[Token(Token = "0x4005605")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Canvas menuCanvas;

		[Token(Token = "0x4005606")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI levelName;

		[Token(Token = "0x4005607")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ChallengeCompletedUI ChallengeUI;

		[Token(Token = "0x4005608")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ChallengeCompletedUI ChallengeFailedUI;

		[Token(Token = "0x4005609")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InGameChallengeInfo ChallengeInfo;

		[Token(Token = "0x400560A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InGameChallengeInfo ChallengeInfoTop;

		[Token(Token = "0x400560B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject LookUpText;

		[Token(Token = "0x400560C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SwitchUndockMessage UndockMessage;

		[Token(Token = "0x400560D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InGameFullScreenText fullScreenText;

		[Token(Token = "0x400560E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private IngameInformationText informationText;

		[Token(Token = "0x400560F")]
		[FieldOffset(Offset = "0x98")]
		public DailyChallengePagination DailyChallengePagination;

		[Token(Token = "0x4005610")]
		[FieldOffset(Offset = "0xA0")]
		public Action OnAbandonButtonClicked;

		[Token(Token = "0x4005611")]
		[FieldOffset(Offset = "0xA8")]
		public Action OnRestartButtonClicked;

		[Token(Token = "0x4005612")]
		[FieldOffset(Offset = "0xB0")]
		private RectTransform rectTrans;

		[Token(Token = "0x4005613")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject currentFailScreen;

		[Token(Token = "0x4005614")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject currentTitleScreen;

		[Token(Token = "0x4005615")]
		[FieldOffset(Offset = "0xC8")]
		private GameObject currentWinScreen;

		[Token(Token = "0x4005616")]
		[FieldOffset(Offset = "0xD0")]
		private TextWithShadow currentWinMessage;

		[Token(Token = "0x4005617")]
		[FieldOffset(Offset = "0xD8")]
		private Button[] menuButtons;

		[Token(Token = "0x4005618")]
		[FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI buildText;

		[Token(Token = "0x600492C")]
		[Address(RVA = "0x14EAE20", Offset = "0x14EAE20", VA = "0x14EAE20")]
		private void Awake()
		{
		}

		[Token(Token = "0x600492D")]
		[Address(RVA = "0x14EAEB8", Offset = "0x14EAEB8", VA = "0x14EAEB8")]
		public void Init()
		{
		}

		[Token(Token = "0x600492E")]
		[Address(RVA = "0x14EB004", Offset = "0x14EB004", VA = "0x14EB004")]
		public void DisableCloseButton()
		{
		}

		[Token(Token = "0x600492F")]
		[Address(RVA = "0x14EB024", Offset = "0x14EB024", VA = "0x14EB024")]
		public void ForceScreenChangeHide()
		{
		}

		[Token(Token = "0x6004930")]
		[Address(RVA = "0x14EB068", Offset = "0x14EB068", VA = "0x14EB068")]
		private void Instance_OnLevelWillUnload()
		{
		}

		[Token(Token = "0x6004931")]
		[Address(RVA = "0x14EB2C4", Offset = "0x14EB2C4", VA = "0x14EB2C4")]
		public void Instance_OnLevelLoaded(LevelData level)
		{
		}

		[Token(Token = "0x6004932")]
		[Address(RVA = "0x14EB490", Offset = "0x14EB490", VA = "0x14EB490")]
		public bool ToggleLevelName()
		{
			return default;
		}

		[Token(Token = "0x6004933")]
		[Address(RVA = "0x14EB50C", Offset = "0x14EB50C", VA = "0x14EB50C")]
		public void ShowMenu()
		{
		}

		[Token(Token = "0x6004934")]
		[Address(RVA = "0x14EB52C", Offset = "0x14EB52C", VA = "0x14EB52C")]
		public void HideMenu()
		{
		}

		[Token(Token = "0x6004935")]
		[Address(RVA = "0x14EB54C", Offset = "0x14EB54C", VA = "0x14EB54C")]
		public void DeactivateMenu()
		{
		}

		[Token(Token = "0x6004936")]
		[Address(RVA = "0x14EB5D4", Offset = "0x14EB5D4", VA = "0x14EB5D4")]
		public void ToggleTopButtonTransparency(bool isVisible)
		{
		}

		[Token(Token = "0x6004937")]
		[Address(RVA = "0x14EB650", Offset = "0x14EB650", VA = "0x14EB650")]
		public void ToggleRestartButton(bool state)
		{
		}

		[Token(Token = "0x6004938")]
		[Address(RVA = "0x14EB66C", Offset = "0x14EB66C", VA = "0x14EB66C")]
		public void ToggleExitButton(bool state)
		{
		}

		[Token(Token = "0x6004939")]
		[Address(RVA = "0x14EB688", Offset = "0x14EB688", VA = "0x14EB688")]
		public void ActivateMenu()
		{
		}

		[Token(Token = "0x600493A")]
		[Address(RVA = "0x14EB6CC", Offset = "0x14EB6CC", VA = "0x14EB6CC")]
		public void ToggleLookUp(bool state)
		{
		}

		[Token(Token = "0x600493B")]
		[Address(RVA = "0x14EB6E8", Offset = "0x14EB6E8", VA = "0x14EB6E8")]
		public void SetStrokeCounterSettings(StrokeCounter.CounterTypes counterType, bool useExternalCountActivator)
		{
		}

		[Token(Token = "0x600493C")]
		[Address(RVA = "0x14EB794", Offset = "0x14EB794", VA = "0x14EB794")]
		public StrokeCounter GetStrokeCounter()
		{
			return null;
		}

		[Token(Token = "0x600493D")]
		[Address(RVA = "0x14EB79C", Offset = "0x14EB79C", VA = "0x14EB79C")]
		public void SetStrokeCounterSettings(int initialStrokes, StrokeCounter.CounterTypes counterType, bool useExternalCountActivator, int playerIndex = 0)
		{
		}

		[Token(Token = "0x600493E")]
		[Address(RVA = "0x14EB758", Offset = "0x14EB758", VA = "0x14EB758")]
		public void ToggleStrokeCounter(bool state)
		{
		}

		[Token(Token = "0x600493F")]
		[Address(RVA = "0x14EB81C", Offset = "0x14EB81C", VA = "0x14EB81C")]
		public void CountStroke(GolfBallController shooter, int strokes)
		{
		}

		[Token(Token = "0x6004940")]
		[Address(RVA = "0x14EB844", Offset = "0x14EB844", VA = "0x14EB844")]
		public void CountStroke(int playerIndex, int strokes)
		{
		}

		[Token(Token = "0x6004941")]
		[Address(RVA = "0x14EB860", Offset = "0x14EB860", VA = "0x14EB860")]
		public void CountStroke(int strokes)
		{
		}

		[Token(Token = "0x6004942")]
		[Address(RVA = "0x14EB87C", Offset = "0x14EB87C", VA = "0x14EB87C")]
		public void EnableMenu()
		{
		}

		[Token(Token = "0x6004943")]
		[Address(RVA = "0x14EB8F4", Offset = "0x14EB8F4", VA = "0x14EB8F4")]
		public void DisableMenu()
		{
		}

		[Token(Token = "0x6004944")]
		[Address(RVA = "0x14EB96C", Offset = "0x14EB96C", VA = "0x14EB96C")]
		public void AbandonLevel()
		{
		}

		[Token(Token = "0x6004945")]
		[Address(RVA = "0x14EB980", Offset = "0x14EB980", VA = "0x14EB980")]
		public void RestartLevel()
		{
		}

		[Token(Token = "0x6004946")]
		[Address(RVA = "0x14EB994", Offset = "0x14EB994", VA = "0x14EB994")]
		public void ResetStrokes(int resetToThis = 0)
		{
		}

		[Token(Token = "0x6004947")]
		[Address(RVA = "0x14EB9B0", Offset = "0x14EB9B0", VA = "0x14EB9B0")]
		public void ToggleLeaderCrown(bool state)
		{
		}

		[Token(Token = "0x6004948")]
		[Address(RVA = "0x14EB9CC", Offset = "0x14EB9CC", VA = "0x14EB9CC")]
		public void ResetStrokes(int playerId, int resetToThis = 0)
		{
		}

		[Token(Token = "0x6004949")]
		[Address(RVA = "0x14EB32C", Offset = "0x14EB32C", VA = "0x14EB32C")]
		public void SetOrientation(LevelData.WindowType window)
		{
		}

		[Token(Token = "0x600494A")]
		[Address(RVA = "0x14EB9E8", Offset = "0x14EB9E8", VA = "0x14EB9E8")]
		public void ChallengeCompleted(string title)
		{
		}

		[Token(Token = "0x600494B")]
		[Address(RVA = "0x14EBA08", Offset = "0x14EBA08", VA = "0x14EBA08")]
		public void ChallengeFailed(string title)
		{
		}

		[Token(Token = "0x600494C")]
		[Address(RVA = "0x14EBA28", Offset = "0x14EBA28", VA = "0x14EBA28")]
		public void ShowChallengeInfo(string text)
		{
		}

		[Token(Token = "0x600494D")]
		[Address(RVA = "0x14EBB48", Offset = "0x14EBB48", VA = "0x14EBB48")]
		public void ShowChallengeInfo(string text, Sprite[] icons)
		{
		}

		[Token(Token = "0x600494E")]
		[Address(RVA = "0x14EBBE4", Offset = "0x14EBBE4", VA = "0x14EBBE4")]
		public IEnumerator ShowText(string text, float duration)
		{
			return null;
		}

		[Token(Token = "0x600494F")]
		[Address(RVA = "0x14EBC6C", Offset = "0x14EBC6C", VA = "0x14EBC6C")]
		public void ShowUndockMessage()
		{
		}

		[Token(Token = "0x6004950")]
		[Address(RVA = "0x14EBC70", Offset = "0x14EBC70", VA = "0x14EBC70")]
		public void HideUndockMessage()
		{
		}

		[Token(Token = "0x6004951")]
		[Address(RVA = "0x14EBC74", Offset = "0x14EBC74", VA = "0x14EBC74")]
		public void EnableBuildText()
		{
		}

		[Token(Token = "0x6004952")]
		[Address(RVA = "0x14EBF5C", Offset = "0x14EBF5C", VA = "0x14EBF5C")]
		public void DisableBuildText()
		{
		}

		[Token(Token = "0x6004953")]
		[Address(RVA = "0x14EC050", Offset = "0x14EC050", VA = "0x14EC050")]
		public void SetActiveBuildText(bool enable)
		{
		}

		[Token(Token = "0x6004954")]
		[Address(RVA = "0x14EBD68", Offset = "0x14EBD68", VA = "0x14EBD68")]
		private void FindBuildText()
		{
		}

		[Token(Token = "0x6004955")]
		[Address(RVA = "0x14EC05C", Offset = "0x14EC05C", VA = "0x14EC05C")]
		public void ShowFullScreenText(string text, float duration)
		{
		}

		[Token(Token = "0x6004956")]
		[Address(RVA = "0x14EC0A0", Offset = "0x14EC0A0", VA = "0x14EC0A0")]
		public void ShowInformationText(string text, float duration, bool aboveTransition = false)
		{
		}

		[Token(Token = "0x6004957")]
		[Address(RVA = "0x14EC39C", Offset = "0x14EC39C", VA = "0x14EC39C")]
		public void SetChallengeInfoToShowForMinSeconds(bool show)
		{
		}

		[Token(Token = "0x6004958")]
		[Address(RVA = "0x14EC3C8", Offset = "0x14EC3C8", VA = "0x14EC3C8")]
		public InGameMenu()
		{
		}
	}
}
