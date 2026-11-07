using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001252")]
	public sealed class FileSystem : BaseSystem
	{
		[Token(Token = "0x2001253")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48604", Offset = "0x48604")]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x40062B0")]
			[FieldOffset(Offset = "0x10")]
			public bool isError;

			[Token(Token = "0x600547C")]
			[Address(RVA = "0x17A3504", Offset = "0x17A3504", VA = "0x17A3504")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600547D")]
			[Address(RVA = "0x17A350C", Offset = "0x17A350C", VA = "0x17A350C")]
			internal void _003CPublishLevel_003Eb__0(bool e)
			{
			}
		}

		[Token(Token = "0x2001254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48614", Offset = "0x48614")]
		private sealed class _003CPublishLevel_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062B1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062B2")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062B3")]
			[FieldOffset(Offset = "0x20")]
			public Guid levelId;

			[Token(Token = "0x40062B4")]
			[FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

			[Token(Token = "0x40062B5")]
			[FieldOffset(Offset = "0x38")]
			public Action<bool> result;

			[Token(Token = "0x40062B6")]
			[FieldOffset(Offset = "0x40")]
			private SerializableLevelData _003ClevelData_003E5__2;

			[Token(Token = "0x17000982")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005481")]
				[Address(RVA = "0x17A3BE4", Offset = "0x17A3BE4", VA = "0x17A3BE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000983")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005483")]
				[Address(RVA = "0x17A3C2C", Offset = "0x17A3C2C", VA = "0x17A3C2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600547E")]
			[Address(RVA = "0x17A3990", Offset = "0x17A3990", VA = "0x17A3990")]
			[DebuggerHidden]
			public _003CPublishLevel_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600547F")]
			[Address(RVA = "0x17A39BC", Offset = "0x17A39BC", VA = "0x17A39BC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005480")]
			[Address(RVA = "0x17A39C0", Offset = "0x17A39C0", VA = "0x17A39C0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005481")]
			[Address(RVA = "0x17A3BE4", Offset = "0x17A3BE4", VA = "0x17A3BE4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005482")]
			[Address(RVA = "0x17A3BEC", Offset = "0x17A3BEC", VA = "0x17A3BEC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005483")]
			[Address(RVA = "0x17A3C2C", Offset = "0x17A3C2C", VA = "0x17A3C2C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001255")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48624", Offset = "0x48624")]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			[Token(Token = "0x40062B7")]
			[FieldOffset(Offset = "0x10")]
			public bool isError;

			[Token(Token = "0x6005484")]
			[Address(RVA = "0x17A3514", Offset = "0x17A3514", VA = "0x17A3514")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6005485")]
			[Address(RVA = "0x17A351C", Offset = "0x17A351C", VA = "0x17A351C")]
			internal void _003CPopulateCloudLevelsProcess_003Eb__0(bool e, SerializableLevelData[] s)
			{
			}
		}

		[Token(Token = "0x2001256")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48634", Offset = "0x48634")]
		private sealed class _003CPopulateCloudLevelsProcess_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062B8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062B9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062BA")]
			[FieldOffset(Offset = "0x20")]
			public string query;

			[Token(Token = "0x40062BB")]
			[FieldOffset(Offset = "0x28")]
			public Action<bool> result;

			[Token(Token = "0x40062BC")]
			[FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

			[Token(Token = "0x17000984")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005489")]
				[Address(RVA = "0x17A3940", Offset = "0x17A3940", VA = "0x17A3940", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000985")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600548B")]
				[Address(RVA = "0x17A3988", Offset = "0x17A3988", VA = "0x17A3988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005486")]
			[Address(RVA = "0x17A3750", Offset = "0x17A3750", VA = "0x17A3750")]
			[DebuggerHidden]
			public _003CPopulateCloudLevelsProcess_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005487")]
			[Address(RVA = "0x17A377C", Offset = "0x17A377C", VA = "0x17A377C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005488")]
			[Address(RVA = "0x17A3780", Offset = "0x17A3780", VA = "0x17A3780", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005489")]
			[Address(RVA = "0x17A3940", Offset = "0x17A3940", VA = "0x17A3940", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600548A")]
			[Address(RVA = "0x17A3948", Offset = "0x17A3948", VA = "0x17A3948", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600548B")]
			[Address(RVA = "0x17A3988", Offset = "0x17A3988", VA = "0x17A3988", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40062AA")]
		[FieldOffset(Offset = "0x0")]
		private static FileSystem s_Instance;

		[Token(Token = "0x40062AB")]
		[FieldOffset(Offset = "0x8")]
		public static SerializableLevelData[] s_LocalLevels;

		[Token(Token = "0x40062AC")]
		[FieldOffset(Offset = "0x10")]
		public static SerializableLevelData[] s_CloudLevels;

		[Token(Token = "0x40062AD")]
		[FieldOffset(Offset = "0x18")]
		public static SerializableLevelData s_TempLevel;

		[Token(Token = "0x40062AE")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<Guid, SerializableLevelData> s_LocalLevelsMap;

		[Token(Token = "0x40062AF")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<Guid, SerializableLevelData> s_CloudLevelsMap;

		[Token(Token = "0x17000980")]
		public static SerializableLevelData[] LocalLevels
		{
			[Token(Token = "0x600546B")]
			[Address(RVA = "0x14630E0", Offset = "0x14630E0", VA = "0x14630E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000981")]
		public static SerializableLevelData[] CloudLevels
		{
			[Token(Token = "0x600546C")]
			[Address(RVA = "0x146312C", Offset = "0x146312C", VA = "0x146312C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600546D")]
		[Address(RVA = "0x1463178", Offset = "0x1463178", VA = "0x1463178")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x7130C", Offset = "0x7130C")]
		private static void InitOnLoad()
		{
		}

		[Token(Token = "0x600546E")]
		[Address(RVA = "0x14631CC", Offset = "0x14631CC", VA = "0x14631CC", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x600546F")]
		[Address(RVA = "0x1463420", Offset = "0x1463420", VA = "0x1463420", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6005470")]
		[Address(RVA = "0x1463424", Offset = "0x1463424", VA = "0x1463424", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005471")]
		[Address(RVA = "0x1463478", Offset = "0x1463478", VA = "0x1463478")]
		public static SerializableLevelData GetLevel(Guid guid)
		{
			return null;
		}

		[Token(Token = "0x6005472")]
		[Address(RVA = "0x146367C", Offset = "0x146367C", VA = "0x146367C")]
		public static void SaveLevel(Guid levelId)
		{
		}

		[Token(Token = "0x6005473")]
		[Address(RVA = "0x14638F4", Offset = "0x14638F4", VA = "0x14638F4")]
		public static SerializableLevelData GetLevelCopy(Guid levelId)
		{
			return null;
		}

		[Token(Token = "0x6005474")]
		[Address(RVA = "0x1461A08", Offset = "0x1461A08", VA = "0x1461A08")]
		public static void LoadLevel(Guid levelId)
		{
		}

		[Token(Token = "0x6005475")]
		[Address(RVA = "0x1463AC0", Offset = "0x1463AC0", VA = "0x1463AC0")]
		public static void DeleteLevel(Guid levelId)
		{
		}

		[Token(Token = "0x6005476")]
		[Address(RVA = "0x1463B84", Offset = "0x1463B84", VA = "0x1463B84")]
		public static IEnumerator PublishLevel(Guid levelId, Action<bool> result)
		{
			return null;
		}

		[Token(Token = "0x6005477")]
		[Address(RVA = "0x1463C0C", Offset = "0x1463C0C", VA = "0x1463C0C")]
		public static bool IsLevelSaved(Guid levelId)
		{
			return default;
		}

		[Token(Token = "0x6005478")]
		[Address(RVA = "0x1463298", Offset = "0x1463298", VA = "0x1463298")]
		public static void PopulateLocalLevels()
		{
		}

		[Token(Token = "0x6005479")]
		[Address(RVA = "0x1463C90", Offset = "0x1463C90", VA = "0x1463C90")]
		public static void PopulateCloudLevels(string query, Action<bool> result)
		{
		}

		[Token(Token = "0x600547A")]
		[Address(RVA = "0x1463D58", Offset = "0x1463D58", VA = "0x1463D58")]
		private static IEnumerator PopulateCloudLevelsProcess(string query, Action<bool> result)
		{
			return null;
		}

		[Token(Token = "0x600547B")]
		[Address(RVA = "0x1463DD0", Offset = "0x1463DD0", VA = "0x1463DD0")]
		public FileSystem()
		{
		}
	}
}
