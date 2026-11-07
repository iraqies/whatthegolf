using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000CB")]
	public class InstanceProfileAWSCredentials : URIBasedRefreshingCredentialHelper
	{
		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25A4C", Offset = "0x25A4C")]
		private sealed class _003CGetAvailableRoles_003Ed__14 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x18")]
			private string _003C_003E2__current;

			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x28")]
			private IWebProxy proxy;

			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x30")]
			public IWebProxy _003C_003E3__proxy;

			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x38")]
			private string[] _003C_003E7__wrap1;

			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x40")]
			private int _003C_003E7__wrap2;

			[Token(Token = "0x170001DF")]
			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
			{
				[Token(Token = "0x6000778")]
				[Address(RVA = "0x128D9F0", Offset = "0x128D9F0", VA = "0x128D9F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001E0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600077A")]
				[Address(RVA = "0x128DA38", Offset = "0x128DA38", VA = "0x128DA38", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x128D5BC", Offset = "0x128D5BC", VA = "0x128D5BC")]
			[DebuggerHidden]
			public _003CGetAvailableRoles_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x128D5F4", Offset = "0x128D5F4", VA = "0x128D5F4", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x128D5F8", Offset = "0x128D5F8", VA = "0x128D5F8", Slot = "8")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x128D9F0", Offset = "0x128D9F0", VA = "0x128D9F0", Slot = "6")]
			[DebuggerHidden]
			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x128D9F8", Offset = "0x128D9F8", VA = "0x128D9F8", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x128DA38", Offset = "0x128DA38", VA = "0x128DA38", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x128DA40", Offset = "0x128DA40", VA = "0x128DA40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x128DAEC", Offset = "0x128DAEC", VA = "0x128DAEC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x0")]
		private static TimeSpan _preemptExpiryTime;

		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x8")]
		private static TimeSpan _refreshAttemptPeriod;

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x38")]
		private CredentialsRefreshState _currentRefreshState;

		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x40")]
		private IWebProxy _proxy;

		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B18", Offset = "0x26B18")]
		private string Role__BackingField;

		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x10")]
		private static string[] AliasSeparators;

		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x18")]
		private static string Server;

		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x20")]
		private static string RolesPath;

		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x28")]
		private static string InfoPath;

		[Token(Token = "0x170001DB")]
		public string Role
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1217DAC", Offset = "0x1217DAC", VA = "0x1217DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x292BC", Offset = "0x292BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1217DB4", Offset = "0x1217DB4", VA = "0x1217DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x292CC", Offset = "0x292CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		private static Uri RolesUri
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1218E44", Offset = "0x1218E44", VA = "0x1218E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DD")]
		private Uri CurrentRoleUri
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x1218EE4", Offset = "0x1218EE4", VA = "0x1218EE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DE")]
		private static Uri InfoUri
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1218F94", Offset = "0x1218F94", VA = "0x1218F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1217DBC", Offset = "0x1217DBC", VA = "0x1217DBC", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x12186C0", Offset = "0x12186C0", VA = "0x12186C0")]
		public InstanceProfileAWSCredentials(string role)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x12186C8", Offset = "0x12186C8", VA = "0x12186C8")]
		public InstanceProfileAWSCredentials(string role, IWebProxy proxy)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1218880", Offset = "0x1218880", VA = "0x1218880")]
		public InstanceProfileAWSCredentials()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x12188F8", Offset = "0x12188F8", VA = "0x12188F8")]
		public InstanceProfileAWSCredentials(IWebProxy proxy)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1218D28", Offset = "0x1218D28", VA = "0x1218D28")]
		public static IEnumerable<string> GetAvailableRoles()
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1218DD0", Offset = "0x1218DD0", VA = "0x1218DD0")]
		public static IEnumerable<string> GetAvailableRoles(IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x12184F8", Offset = "0x12184F8", VA = "0x12184F8")]
		private CredentialsRefreshState GetEarlyRefreshState(CredentialsRefreshState state)
		{
			return null;
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1218324", Offset = "0x1218324", VA = "0x1218324")]
		private CredentialsRefreshState GetRefreshState(string token)
		{
			return null;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1219038", Offset = "0x1219038", VA = "0x1219038")]
		private static SecurityInfo GetServiceInfo(IWebProxy proxy, string token)
		{
			return null;
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1219110", Offset = "0x1219110", VA = "0x1219110")]
		private SecurityCredentials GetRoleCredentials(string token)
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x12191F0", Offset = "0x12191F0", VA = "0x12191F0")]
		private static void CheckIsIMDSEnabled()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x12193D8", Offset = "0x12193D8", VA = "0x12193D8")]
		private static string GetFirstRole()
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1218974", Offset = "0x1218974", VA = "0x1218974")]
		private static string GetFirstRole(IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1218844", Offset = "0x1218844", VA = "0x1218844")]
		private static bool IsNullOrWhiteSpace(string s)
		{
			return default;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1219308", Offset = "0x1219308", VA = "0x1219308")]
		private static Dictionary<string, string> CreateMetadataTokenHeaders(string token)
		{
			return null;
		}
	}
}
