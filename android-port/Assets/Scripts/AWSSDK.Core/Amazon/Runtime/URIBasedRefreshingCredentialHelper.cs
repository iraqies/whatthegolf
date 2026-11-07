using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000BD")]
	public class URIBasedRefreshingCredentialHelper : RefreshingAWSCredentials
	{
		[Token(Token = "0x20000BE")]
		protected class SecurityBase
		{
			[Token(Token = "0x4000334")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26978", Offset = "0x26978")]
			private string Code__BackingField;

			[Token(Token = "0x4000335")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26988", Offset = "0x26988")]
			private string Message__BackingField;

			[Token(Token = "0x4000336")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26998", Offset = "0x26998")]
			private DateTime LastUpdated__BackingField;

			[Token(Token = "0x170001BA")]
			public string Code
			{
				[Token(Token = "0x60006FE")]
				[Address(RVA = "0x1297FC0", Offset = "0x1297FC0", VA = "0x1297FC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28FEC", Offset = "0x28FEC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0x1297FC8", Offset = "0x1297FC8", VA = "0x1297FC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28FFC", Offset = "0x28FFC")]
				set
				{
				}
			}

			[Token(Token = "0x170001BB")]
			public string Message
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x1297FD0", Offset = "0x1297FD0", VA = "0x1297FD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2900C", Offset = "0x2900C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x1297FD8", Offset = "0x1297FD8", VA = "0x1297FD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2901C", Offset = "0x2901C")]
				set
				{
				}
			}

			[Token(Token = "0x170001BC")]
			public DateTime LastUpdated
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x1297FE0", Offset = "0x1297FE0", VA = "0x1297FE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2902C", Offset = "0x2902C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x1297FE8", Offset = "0x1297FE8", VA = "0x1297FE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2903C", Offset = "0x2903C")]
				set
				{
				}
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1297FF0", Offset = "0x1297FF0", VA = "0x1297FF0")]
			public SecurityBase()
			{
			}
		}

		[Token(Token = "0x20000BF")]
		protected class SecurityInfo : SecurityBase
		{
			[Token(Token = "0x4000337")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x269A8", Offset = "0x269A8")]
			private string InstanceProfileArn__BackingField;

			[Token(Token = "0x4000338")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x269B8", Offset = "0x269B8")]
			private string InstanceProfileId__BackingField;

			[Token(Token = "0x170001BD")]
			public string InstanceProfileArn
			{
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x1298060", Offset = "0x1298060", VA = "0x1298060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2904C", Offset = "0x2904C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000706")]
				[Address(RVA = "0x1298068", Offset = "0x1298068", VA = "0x1298068")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2905C", Offset = "0x2905C")]
				set
				{
				}
			}

			[Token(Token = "0x170001BE")]
			public string InstanceProfileId
			{
				[Token(Token = "0x6000707")]
				[Address(RVA = "0x1298070", Offset = "0x1298070", VA = "0x1298070")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2906C", Offset = "0x2906C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x1298078", Offset = "0x1298078", VA = "0x1298078")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2907C", Offset = "0x2907C")]
				set
				{
				}
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1298080", Offset = "0x1298080", VA = "0x1298080")]
			public SecurityInfo()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		protected class SecurityCredentials : SecurityBase
		{
			[Token(Token = "0x4000339")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x269C8", Offset = "0x269C8")]
			private string Type__BackingField;

			[Token(Token = "0x400033A")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x269D8", Offset = "0x269D8")]
			private string AccessKeyId__BackingField;

			[Token(Token = "0x400033B")]
			[FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x269E8", Offset = "0x269E8")]
			private string SecretAccessKey__BackingField;

			[Token(Token = "0x400033C")]
			[FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x269F8", Offset = "0x269F8")]
			private string Token__BackingField;

			[Token(Token = "0x400033D")]
			[FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A08", Offset = "0x26A08")]
			private DateTime Expiration__BackingField;

			[Token(Token = "0x400033E")]
			[FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A18", Offset = "0x26A18")]
			private string RoleArn__BackingField;

			[Token(Token = "0x170001BF")]
			public string Type
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x1297FF8", Offset = "0x1297FF8", VA = "0x1297FF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2908C", Offset = "0x2908C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x1298000", Offset = "0x1298000", VA = "0x1298000")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2909C", Offset = "0x2909C")]
				set
				{
				}
			}

			[Token(Token = "0x170001C0")]
			public string AccessKeyId
			{
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x1298008", Offset = "0x1298008", VA = "0x1298008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x290AC", Offset = "0x290AC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x1298010", Offset = "0x1298010", VA = "0x1298010")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x290BC", Offset = "0x290BC")]
				set
				{
				}
			}

			[Token(Token = "0x170001C1")]
			public string SecretAccessKey
			{
				[Token(Token = "0x600070E")]
				[Address(RVA = "0x1298018", Offset = "0x1298018", VA = "0x1298018")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x290CC", Offset = "0x290CC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600070F")]
				[Address(RVA = "0x1298020", Offset = "0x1298020", VA = "0x1298020")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x290DC", Offset = "0x290DC")]
				set
				{
				}
			}

			[Token(Token = "0x170001C2")]
			public string Token
			{
				[Token(Token = "0x6000710")]
				[Address(RVA = "0x1298028", Offset = "0x1298028", VA = "0x1298028")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x290EC", Offset = "0x290EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x1298030", Offset = "0x1298030", VA = "0x1298030")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x290FC", Offset = "0x290FC")]
				set
				{
				}
			}

			[Token(Token = "0x170001C3")]
			public DateTime Expiration
			{
				[Token(Token = "0x6000712")]
				[Address(RVA = "0x1298038", Offset = "0x1298038", VA = "0x1298038")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2910C", Offset = "0x2910C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000713")]
				[Address(RVA = "0x1298040", Offset = "0x1298040", VA = "0x1298040")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2911C", Offset = "0x2911C")]
				set
				{
				}
			}

			[Token(Token = "0x170001C4")]
			public string RoleArn
			{
				[Token(Token = "0x6000714")]
				[Address(RVA = "0x1298048", Offset = "0x1298048", VA = "0x1298048")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2912C", Offset = "0x2912C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000715")]
				[Address(RVA = "0x1298050", Offset = "0x1298050", VA = "0x1298050")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2913C", Offset = "0x2913C")]
				set
				{
				}
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1298058", Offset = "0x1298058", VA = "0x1298058")]
			public SecurityCredentials()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x0")]
		private static string SuccessCode;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x127E864", Offset = "0x127E864", VA = "0x127E864")]
		protected static string GetContents(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x127E90C", Offset = "0x127E90C", VA = "0x127E90C")]
		protected static string GetContents(Uri uri, IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x127E998", Offset = "0x127E998", VA = "0x127E998")]
		protected static string GetContents(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x60006F8")]
		protected static T GetObjectFromResponse<T>(Uri uri)
		{
			return (T)null;
		}

		[Token(Token = "0x60006F9")]
		protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy)
		{
			return (T)null;
		}

		[Token(Token = "0x60006FA")]
		protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
		{
			return (T)null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x127EB40", Offset = "0x127EB40", VA = "0x127EB40")]
		protected static void ValidateResponse(SecurityBase response)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x127EC94", Offset = "0x127EC94", VA = "0x127EC94")]
		public URIBasedRefreshingCredentialHelper()
		{
		}
	}
}
