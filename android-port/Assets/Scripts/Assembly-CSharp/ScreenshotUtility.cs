using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000525")]
public class ScreenshotUtility : MonoBehaviour
{
	[Token(Token = "0x2000526")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40284", Offset = "0x40284")]
	private sealed class _003CWaitAndTakeScreenshot_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A88")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A89")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A8A")]
		[FieldOffset(Offset = "0x20")]
		public LevelData levelData;

		[Token(Token = "0x1700029A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001789")]
			[Address(RVA = "0x183F8CC", Offset = "0x183F8CC", VA = "0x183F8CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700029B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600178B")]
			[Address(RVA = "0x183F914", Offset = "0x183F914", VA = "0x183F914", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001786")]
		[Address(RVA = "0x183F658", Offset = "0x183F658", VA = "0x183F658")]
		[DebuggerHidden]
		public _003CWaitAndTakeScreenshot_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001787")]
		[Address(RVA = "0x183F684", Offset = "0x183F684", VA = "0x183F684", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001788")]
		[Address(RVA = "0x183F688", Offset = "0x183F688", VA = "0x183F688", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001789")]
		[Address(RVA = "0x183F8CC", Offset = "0x183F8CC", VA = "0x183F8CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600178A")]
		[Address(RVA = "0x183F8D4", Offset = "0x183F8D4", VA = "0x183F8D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600178B")]
		[Address(RVA = "0x183F914", Offset = "0x183F914", VA = "0x183F914", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001A84")]
	[FieldOffset(Offset = "0x18")]
	private LevelStarter levelStarter;

	[Token(Token = "0x4001A85")]
	[FieldOffset(Offset = "0x20")]
	private List<LevelData> levelDatas;

	[Token(Token = "0x4001A86")]
	[FieldOffset(Offset = "0x28")]
	private int levelIndex;

	[Token(Token = "0x4001A87")]
	[FieldOffset(Offset = "0x2C")]
	private Scene tempScene;

	[Token(Token = "0x6001781")]
	[Address(RVA = "0x167F1FC", Offset = "0x167F1FC", VA = "0x167F1FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001782")]
	[Address(RVA = "0x167F76C", Offset = "0x167F76C", VA = "0x167F76C")]
	private void Instance_OnLevelLoaded(LevelData levelData)
	{
	}

	[Token(Token = "0x6001783")]
	[Address(RVA = "0x167F3A0", Offset = "0x167F3A0", VA = "0x167F3A0")]
	private void FindAllLevelsInCurrentOverworld()
	{
	}

	[Token(Token = "0x6001784")]
	[Address(RVA = "0x167F7EC", Offset = "0x167F7EC", VA = "0x167F7EC")]
	private IEnumerator WaitAndTakeScreenshot(LevelData levelData)
	{
		return null;
	}

	[Token(Token = "0x6001785")]
	[Address(RVA = "0x167F860", Offset = "0x167F860", VA = "0x167F860")]
	public ScreenshotUtility()
	{
	}
}
