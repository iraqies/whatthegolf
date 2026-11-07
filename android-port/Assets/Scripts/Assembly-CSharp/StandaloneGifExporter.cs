using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Moments;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20005D5")]
public class StandaloneGifExporter : MonoBehaviour
{
	[Token(Token = "0x20005D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x408C0", Offset = "0x408C0")]
	private sealed class _003CSavingCheckCR_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001DB4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001DB5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001DB6")]
		[FieldOffset(Offset = "0x20")]
		public StandaloneGifExporter _003C_003E4__this;

		[Token(Token = "0x4001DB7")]
		[FieldOffset(Offset = "0x28")]
		private float _003CpercentDoneLast_003E5__2;

		[Token(Token = "0x170002EA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001A99")]
			[Address(RVA = "0x185A2C4", Offset = "0x185A2C4", VA = "0x185A2C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002EB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001A9B")]
			[Address(RVA = "0x185A30C", Offset = "0x185A30C", VA = "0x185A30C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x185A104", Offset = "0x185A104", VA = "0x185A104")]
		[DebuggerHidden]
		public _003CSavingCheckCR_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x185A130", Offset = "0x185A130", VA = "0x185A130", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x185A134", Offset = "0x185A134", VA = "0x185A134", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x185A2C4", Offset = "0x185A2C4", VA = "0x185A2C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x185A2CC", Offset = "0x185A2CC", VA = "0x185A2CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x185A30C", Offset = "0x185A30C", VA = "0x185A30C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001DAD")]
	[FieldOffset(Offset = "0x18")]
	private Moments.Recorder recorder;

	[Token(Token = "0x4001DAE")]
	[FieldOffset(Offset = "0x20")]
	private GifMoment moment;

	[Token(Token = "0x4001DAF")]
	[FieldOffset(Offset = "0x28")]
	public UnityAction<float> percentDone;

	[Token(Token = "0x4001DB0")]
	[FieldOffset(Offset = "0x30")]
	public UnityAction<bool, string> exportComplete;

	[Token(Token = "0x4001DB1")]
	[FieldOffset(Offset = "0x38")]
	public float currentPercentDone;

	[Token(Token = "0x4001DB2")]
	[FieldOffset(Offset = "0x40")]
	private string exportPath;

	[Token(Token = "0x4001DB3")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine savingCheckCR;

	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x16DA694", Offset = "0x16DA694", VA = "0x16DA694")]
	public void Export(GifMoment moment, UnityAction<float> percentDoneCallback, UnityAction<bool, string> exportCompletedCallback)
	{
	}

	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x16DA9A8", Offset = "0x16DA9A8", VA = "0x16DA9A8")]
	public void SaveGifToFile(string gifName, GifMoment moment)
	{
	}

	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x16DABFC", Offset = "0x16DABFC", VA = "0x16DABFC")]
	private void OnProcessingDone()
	{
	}

	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x16DAC00", Offset = "0x16DAC00", VA = "0x16DAC00")]
	private void OnFileSaveProgress(int id, float percent)
	{
	}

	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x16DAC3C", Offset = "0x16DAC3C", VA = "0x16DAC3C")]
	private void OnFileSaved(int id, string filepath)
	{
	}

	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x16DAB88", Offset = "0x16DAB88", VA = "0x16DAB88")]
	private IEnumerator SavingCheckCR()
	{
		return null;
	}

	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x16DACC4", Offset = "0x16DACC4", VA = "0x16DACC4")]
	public void Cancel()
	{
	}

	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x16DAD90", Offset = "0x16DAD90", VA = "0x16DAD90")]
	public StandaloneGifExporter()
	{
	}
}
