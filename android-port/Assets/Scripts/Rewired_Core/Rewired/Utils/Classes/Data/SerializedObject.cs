using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[Token(Token = "0x200037A")]
	[Preserve]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1921E0", Offset = "0x1921E0")]
	internal sealed class SerializedObject : IEnumerable, IEnumerable<SerializedObject.Field>, IAddValue<object>, IAddKeyValue<string, object>, IExportToXml, IExportToJson
	{
		[Token(Token = "0x200037B")]
		public enum ObjectType
		{
			[Token(Token = "0x40011E2")]
			Object = 0,
			[Token(Token = "0x40011E3")]
			List = 1
		}

		[Token(Token = "0x200037C")]
		[Flags]
		public enum FieldOptions
		{
			[Token(Token = "0x40011E5")]
			None = 0,
			[Token(Token = "0x40011E6")]
			ExculdeFromXml = 1
		}

		[Token(Token = "0x200037D")]
		private struct AhoBNMNzWieULmaZjWUIulsNcWuAA
		{
			[Token(Token = "0x40011E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Type gwUdWoefqvdKVvJvsShVNYBtVNpSA;

			[Token(Token = "0x40011E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public object yYOUbwIbBcyPAQvjeAEXVsjzLAln;

			[Token(Token = "0x40011E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldOptions cRTAqROlhrTnVFORtGklgaCffEkmA;

			[Token(Token = "0x6001B29")]
			[Address(RVA = "0x23954BC", Offset = "0x23954BC", VA = "0x23954BC")]
			public AhoBNMNzWieULmaZjWUIulsNcWuAA(Type P_0, object P_1, FieldOptions P_2)
			{
			}

			[Token(Token = "0x6001B2A")]
			[Address(RVA = "0x23954C8", Offset = "0x23954C8", VA = "0x23954C8", Slot = "3")]
			public string RsAkLkYigfQxKWvdxVBUwNqsOGbJ()
			{
				return null;
			}
		}

		[Token(Token = "0x200037E")]
		public struct Field
		{
			[Token(Token = "0x40011EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40011EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public object value;

			[Token(Token = "0x40011EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x40011ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldOptions options;

			[Token(Token = "0x6001B2B")]
			[Address(RVA = "0x23958C8", Offset = "0x23958C8", VA = "0x23958C8")]
			public Field(string P_0, object P_1, Type P_2, FieldOptions P_3)
			{
			}

			[Token(Token = "0x6001B2C")]
			[Address(RVA = "0x23959C0", Offset = "0x23959C0", VA = "0x23959C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x200037F")]
		public class XmlInfo
		{
			[Token(Token = "0x2000380")]
			public abstract class SiNMxfMGMezpRFyWceCPZrsRAdDk
			{
				[Token(Token = "0x6001B30")]
				[Address(RVA = "0x23C0570", Offset = "0x23C0570", VA = "0x23C0570")]
				protected SiNMxfMGMezpRFyWceCPZrsRAdDk()
				{
				}
			}

			[Token(Token = "0x2000381")]
			public class nIytNPQltHNThjHAgjtVciMQQyqsA : SiNMxfMGMezpRFyWceCPZrsRAdDk
			{
				[Token(Token = "0x40011EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string yCwJMdebpVsoAZwRHxyMbDxHYvvT;

				[Token(Token = "0x40011F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string OvVRJOklVDAaDOOGrXwIFuDdpwVJ;

				[Token(Token = "0x40011F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string ZVXfpRlSPjKWRYaEYlEnqADXJiAs;

				[Token(Token = "0x40011F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string yYOUbwIbBcyPAQvjeAEXVsjzLAln;

				[Token(Token = "0x6001B31")]
				[Address(RVA = "0x23C0578", Offset = "0x23C0578", VA = "0x23C0578", Slot = "3")]
				public virtual string RsAkLkYigfQxKWvdxVBUwNqsOGbJ()
				{
					return null;
				}

				[Token(Token = "0x6001B32")]
				[Address(RVA = "0x23C0688", Offset = "0x23C0688", VA = "0x23C0688")]
				public nIytNPQltHNThjHAgjtVciMQQyqsA()
				{
				}
			}

			[Token(Token = "0x40011EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<SiNMxfMGMezpRFyWceCPZrsRAdDk> zsrJURFAvwLPgLtieKeKxdbIWHtj;

			[Token(Token = "0x17000725")]
			public List<SiNMxfMGMezpRFyWceCPZrsRAdDk> attributes
			{
				[Token(Token = "0x6001B2D")]
				[Address(RVA = "0x2395B7C", Offset = "0x2395B7C", VA = "0x2395B7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001B2E")]
			[Address(RVA = "0x2395BF8", Offset = "0x2395BF8", VA = "0x2395BF8")]
			public XmlInfo()
			{
			}

			[Token(Token = "0x6001B2F")]
			[Address(RVA = "0x2395C00", Offset = "0x2395C00", VA = "0x2395C00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000382")]
		public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Field>
		{
			[Token(Token = "0x40011F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IndexedDictionary<string, AhoBNMNzWieULmaZjWUIulsNcWuAA> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			[Token(Token = "0x40011F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Field SgJVPHrjFyHgCSEpxtgUijWhNNop;

			[Token(Token = "0x40011F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IEnumerator<KeyValuePair<string, AhoBNMNzWieULmaZjWUIulsNcWuAA>> rrbOANARHhUTMnvliFmUiAacqgwE;

			[Token(Token = "0x17000726")]
			public Field Current
			{
				[Token(Token = "0x6001B35")]
				[Address(RVA = "0x23958D8", Offset = "0x23958D8", VA = "0x23958D8", Slot = "8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000727")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001B37")]
				[Address(RVA = "0x23958EC", Offset = "0x23958EC", VA = "0x23958EC", Slot = "6")]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x2395668", Offset = "0x2395668", VA = "0x2395668")]
			internal Enumerator(object P_0)
			{
			}

			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x239573C", Offset = "0x239573C", VA = "0x239573C", Slot = "5")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001B36")]
			[Address(RVA = "0x23958E8", Offset = "0x23958E8", VA = "0x23958E8", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001B37")]
			[Address(RVA = "0x23958EC", Offset = "0x23958EC", VA = "0x23958EC", Slot = "6")]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x2395958", Offset = "0x2395958", VA = "0x2395958", Slot = "7")]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000383")]
		private class ramlcMHyWntHHFvjFssuDQDwmkz
		{
			[Token(Token = "0x2000384")]
			public class FgapzGYpoOjcQKkMmHveHfmgHtIBb
			{
				[Token(Token = "0x40011F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public readonly string rCJyseVRiKOjaaVRmjlxeXUUOXNJ;

				[Token(Token = "0x40011F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public readonly FgapzGYpoOjcQKkMmHveHfmgHtIBb xOBFIOiBayOLXbKGUpZvZHJEAmpcb;

				[Token(Token = "0x40011F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string upqsOOpRqmoiLMwZIZCznqWiugNd;

				[Token(Token = "0x40011FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Dictionary<string, string> GHuEcXBqQqvSXkgtoNgPjbsLkPhMA;

				[Token(Token = "0x40011FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public List<FgapzGYpoOjcQKkMmHveHfmgHtIBb> HlKuHkTCoakjdIlyprdQqzFAqAJy;

				[Token(Token = "0x1700072A")]
				public int DsWRCWTDSoPtqczSsmCzHnNlzjgX
				{
					[Token(Token = "0x6001B3E")]
					[Address(RVA = "0x23C0690", Offset = "0x23C0690", VA = "0x23C0690")]
					get
					{
						return XddzIhOVXeeATWORWLUzhYuCZkNJ();
					}
				}

				[Token(Token = "0x1700072B")]
				public int MJEihnAEoPLhRZFXeOAtleAVhOge
				{
					[Token(Token = "0x6001B3F")]
					[Address(RVA = "0x23C06E0", Offset = "0x23C06E0", VA = "0x23C06E0")]
					get
					{
						return TcbvycqxURRVfvZCapWwlCrAzxBc();
					}
				}

				[Token(Token = "0x6001B3E")]
				[Address(RVA = "0x23C0690", Offset = "0x23C0690", VA = "0x23C0690")]
				public int XddzIhOVXeeATWORWLUzhYuCZkNJ()
				{
					return default;
				}

				[Token(Token = "0x6001B3F")]
				[Address(RVA = "0x23C06E0", Offset = "0x23C06E0", VA = "0x23C06E0")]
				public int TcbvycqxURRVfvZCapWwlCrAzxBc()
				{
					return default;
				}

				[Token(Token = "0x6001B40")]
				[Address(RVA = "0x23C073C", Offset = "0x23C073C", VA = "0x23C073C")]
				public FgapzGYpoOjcQKkMmHveHfmgHtIBb(string P_0, FgapzGYpoOjcQKkMmHveHfmgHtIBb P_1)
				{
				}

				[Token(Token = "0x6001B41")]
				[Address(RVA = "0x23C0790", Offset = "0x23C0790", VA = "0x23C0790")]
				public void HViNycCBPIpRZwBqvdCERZJNNopt(FgapzGYpoOjcQKkMmHveHfmgHtIBb P_0)
				{
				}

				[Token(Token = "0x6001B42")]
				[Address(RVA = "0x23C0850", Offset = "0x23C0850", VA = "0x23C0850")]
				public void XnNcFGGuuKGObeItIaZvfUVpEiKNb(string P_0, string P_1)
				{
				}

				[Token(Token = "0x6001B43")]
				[Address(RVA = "0x23C0988", Offset = "0x23C0988", VA = "0x23C0988")]
				public FgapzGYpoOjcQKkMmHveHfmgHtIBb CAUYaNnsovUfMrUBQlFcRiiUddLt(string P_0)
				{
					return null;
				}

				[Token(Token = "0x6001B44")]
				[Address(RVA = "0x23C0A94", Offset = "0x23C0A94", VA = "0x23C0A94")]
				public object sGJIKhhPnzGPxdOnGAPTIOaLhZxHA()
				{
					return null;
				}

				[Token(Token = "0x6001B45")]
				[Address(RVA = "0x23C0BF0", Offset = "0x23C0BF0", VA = "0x23C0BF0", Slot = "3")]
				public virtual string RsAkLkYigfQxKWvdxVBUwNqsOGbJ()
				{
					return null;
				}

				[Token(Token = "0x6001B46")]
				[Address(RVA = "0x23C0C4C", Offset = "0x23C0C4C", VA = "0x23C0C4C")]
				private string RsAkLkYigfQxKWvdxVBUwNqsOGbJ(string P_0, int P_1)
				{
					return null;
				}
			}

			[Token(Token = "0x40011F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly FgapzGYpoOjcQKkMmHveHfmgHtIBb qMKceKGrTQjrybdpYPLUczFhyVaTB;

			[Token(Token = "0x17000728")]
			public FgapzGYpoOjcQKkMmHveHfmgHtIBb EaXiSzEdNuHiaIzWciVCFEZAjJcnC
			{
				[Token(Token = "0x6001B39")]
				[Address(RVA = "0x23963B8", Offset = "0x23963B8", VA = "0x23963B8")]
				get
				{
					return aHQGfWHEgSWMFmErABaDhmqDcnQpb();
				}
			}

			[Token(Token = "0x17000729")]
			public bool HtaXGKSwgRsWaFcEpcKcAcuoUpZnA
			{
				[Token(Token = "0x6001B3A")]
				[Address(RVA = "0x23963C0", Offset = "0x23963C0", VA = "0x23963C0")]
				get
				{
					return uEwmZcyPnvpaRxBhwpPRgteHuYAL();
				}
			}

			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x23963B8", Offset = "0x23963B8", VA = "0x23963B8")]
			public FgapzGYpoOjcQKkMmHveHfmgHtIBb aHQGfWHEgSWMFmErABaDhmqDcnQpb()
			{
				return null;
			}

			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x23963C0", Offset = "0x23963C0", VA = "0x23963C0")]
			public bool uEwmZcyPnvpaRxBhwpPRgteHuYAL()
			{
				return default;
			}

			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x23963D0", Offset = "0x23963D0", VA = "0x23963D0")]
			public ramlcMHyWntHHFvjFssuDQDwmkz(string P_0)
			{
			}

			[Token(Token = "0x6001B3C")]
			[Address(RVA = "0x2396718", Offset = "0x2396718", VA = "0x2396718")]
			private void apUMsstPXQdQaxKIlDLXaUrtgnJbb(XmlReader P_0)
			{
			}

			[Token(Token = "0x6001B3D")]
			[Address(RVA = "0x23969E4", Offset = "0x23969E4", VA = "0x23969E4", Slot = "3")]
			public virtual string RsAkLkYigfQxKWvdxVBUwNqsOGbJ()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000385")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19223C", Offset = "0x19223C")]
		private sealed class nqoRgfQeqAhpyNEzJORfYmTMVCnb
		{
			[Token(Token = "0x40011FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly nqoRgfQeqAhpyNEzJORfYmTMVCnb _003C_003E9;

			[Token(Token = "0x40011FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<FieldInfo, bool> _003C_003E9__63_0;

			[Token(Token = "0x40011FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<FieldInfo, string> _003C_003E9__63_1;

			[Token(Token = "0x40011FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<PropertyInfo, bool> _003C_003E9__63_2;

			[Token(Token = "0x4001200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<PropertyInfo, string> _003C_003E9__63_3;

			[Token(Token = "0x6001B48")]
			[Address(RVA = "0x2395D50", Offset = "0x2395D50", VA = "0x2395D50")]
			public nqoRgfQeqAhpyNEzJORfYmTMVCnb()
			{
			}

			[Token(Token = "0x6001B49")]
			[Address(RVA = "0x2395D58", Offset = "0x2395D58", VA = "0x2395D58")]
			internal bool GfAbSCbkXfgoleyEGfwmUMXFrqKt(FieldInfo P_0)
			{
				return default;
			}

			[Token(Token = "0x6001B4A")]
			[Address(RVA = "0x2395F54", Offset = "0x2395F54", VA = "0x2395F54")]
			internal string WdBTVGnkokkuYvbkHoqBTorjZxbE(FieldInfo P_0)
			{
				return null;
			}

			[Token(Token = "0x6001B4B")]
			[Address(RVA = "0x23960EC", Offset = "0x23960EC", VA = "0x23960EC")]
			internal bool tmXfSFjGQeAmvieceGSoSXapiJLSA(PropertyInfo P_0)
			{
				return default;
			}

			[Token(Token = "0x6001B4C")]
			[Address(RVA = "0x2396220", Offset = "0x2396220", VA = "0x2396220")]
			internal string wzXwJkGHjoECeoSHbXBsgUJavOrp(PropertyInfo P_0)
			{
				return null;
			}
		}

		[Token(Token = "0x40011DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IndexedDictionary<string, AhoBNMNzWieULmaZjWUIulsNcWuAA> HLHkiXAtvIlnILCwVDiPMAWBJRuD;

		[Token(Token = "0x40011DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private XmlInfo VPtUrZujelnPNrtnsCcbMemyJlkR;

		[Token(Token = "0x40011DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Type TIpqQbLCpFnyVWkQInNfNRXErYkK;

		[Token(Token = "0x40011DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ObjectType SfzIlCdbXTnToiRLPgeHvVxRqVmmA;

		[Token(Token = "0x40011DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> PqQfxSEshUquXPWFKNvVbNUQnHFyA;

		[Token(Token = "0x40011E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> dPBmGdUNkJmnAJZMFlvbPJFbfIH;

		[Token(Token = "0x1700071E")]
		private bool allowDuplicateKeys
		{
			[Token(Token = "0x6001B0C")]
			[Address(RVA = "0x240EE18", Offset = "0x240EE18", VA = "0x240EE18")]
			get
			{
				return bXeCCBqLunsahjSBvCUMleZTdCqu();
			}
		}

		[Token(Token = "0x1700071F")]
		public ObjectType objectType
		{
			[Token(Token = "0x6001B0D")]
			[Address(RVA = "0x240ED90", Offset = "0x240ED90", VA = "0x240ED90")]
			set
			{
			}
		}

		[Token(Token = "0x17000720")]
		public Type type
		{
			[Token(Token = "0x6001B0E")]
			[Address(RVA = "0x240EE28", Offset = "0x240EE28", VA = "0x240EE28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000721")]
		public XmlInfo xmlInfo
		{
			[Token(Token = "0x6001B0F")]
			[Address(RVA = "0x240EE30", Offset = "0x240EE30", VA = "0x240EE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B10")]
			[Address(RVA = "0x240EE38", Offset = "0x240EE38", VA = "0x240EE38")]
			set
			{
			}
		}

		[Token(Token = "0x17000722")]
		public int count
		{
			[Token(Token = "0x6001B11")]
			[Address(RVA = "0x240EE40", Offset = "0x240EE40", VA = "0x240EE40")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000723")]
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x240EE94", Offset = "0x240EE94", VA = "0x240EE94")]
		public Field get_Item(int index)
		{
			return default;
		}

		[Token(Token = "0x17000724")]
		private bool Rewired_002EUtils_002EInterfaces_002EIExportToXml_002EwritesOwnElementTag
		{
			[Token(Token = "0x6001B1D")]
			[Address(RVA = "0x240FDB8", Offset = "0x240FDB8", VA = "0x240FDB8", Slot = "8")]
			get
			{
				return hBarglHADXsAagUtTxbKhhcbExHj();
			}
		}

		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x240EB3C", Offset = "0x240EB3C", VA = "0x240EB3C")]
		private SerializedObject()
		{
		}

		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x240EBD0", Offset = "0x240EBD0", VA = "0x240EBD0")]
		private SerializedObject(int P_0)
		{
		}

		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x240EC70", Offset = "0x240EC70", VA = "0x240EC70")]
		public SerializedObject(Type P_0, ObjectType P_1)
		{
		}

		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x240EC78", Offset = "0x240EC78", VA = "0x240EC78")]
		public SerializedObject(Type P_0, ObjectType P_1, int P_2)
		{
		}

		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x240EE18", Offset = "0x240EE18", VA = "0x240EE18")]
		private bool bXeCCBqLunsahjSBvCUMleZTdCqu()
		{
			return default;
		}

		[Token(Token = "0x6001B13")]
		public void Add<T>(string fieldName, T value, FieldOptions options = FieldOptions.None)
		{
		}

		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x240EF68", Offset = "0x240EF68", VA = "0x240EF68")]
		public void Add(Type type, string fieldName, object value, FieldOptions options = FieldOptions.None)
		{
		}

		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x240F1D8", Offset = "0x240F1D8", VA = "0x240F1D8")]
		public void Add(string fieldName, object value)
		{
		}

		[Token(Token = "0x6001B16")]
		public bool TryGetDeserializedValue<T>(string fieldName, out T value)
		{
			return default;
		}

		[Token(Token = "0x6001B17")]
		public bool TryGetDeserializedValue<T>(int index, out T value)
		{
			return default;
		}

		[Token(Token = "0x6001B18")]
		public bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value)
		{
			return default;
		}

		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x240F238", Offset = "0x240F238", VA = "0x240F238")]
		public string ToXmlString(bool writeDocumentTag)
		{
			return null;
		}

		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x240F660", Offset = "0x240F660", VA = "0x240F660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x240F580", Offset = "0x240F580", VA = "0x240F580")]
		private void yXhvfaLRlBwKMqhMlvpomkhFPurm(XmlWriter P_0)
		{
		}

		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x240FA9C", Offset = "0x240FA9C", VA = "0x240FA9C")]
		private void WmPmgythTCkKknxTeQCLppYXlQbs(XmlWriter P_0)
		{
		}

		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x240FDB8", Offset = "0x240FDB8", VA = "0x240FDB8", Slot = "8")]
		private bool hBarglHADXsAagUtTxbKhhcbExHj()
		{
			return default;
		}

		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x240FDC0", Offset = "0x240FDC0", VA = "0x240FDC0", Slot = "9")]
		private void mvSTQcMicmCqSZxGxWxESklqiEsP(XmlWriter P_0)
		{
		}

		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x240FDC4", Offset = "0x240FDC4", VA = "0x240FDC4", Slot = "10")]
		private void yXGIjLLRecTFTawUBjniovMjLQhW(StringBuilder P_0, Action<StringBuilder, object> P_1)
		{
		}

		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x24100B0", Offset = "0x24100B0", VA = "0x24100B0", Slot = "6")]
		private void Rewired_002EUtils_002EInterfaces_002EIAddValue_003CSystem_002EObject_003E_002EAdd(object P_0)
		{
		}

		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x24100FC", Offset = "0x24100FC", VA = "0x24100FC", Slot = "7")]
		private void Rewired_002EUtils_002EInterfaces_002EIAddKeyValue_003CSystem_002EString_002CSystem_002EObject_003E_002EAdd(string P_0, object P_1)
		{
		}

		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x241015C", Offset = "0x241015C", VA = "0x241015C", Slot = "5")]
		private IEnumerator<Field> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EUtils_002EClasses_002EData_002ESerializedObject_002EField_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x24101E8", Offset = "0x24101E8", VA = "0x24101E8", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001B24")]
		private static bool TLxVjSTnEhtSKoelQSmhFqteXmmX<_0001>(object P_0, out _0001 P_1, [Optional][DefaultParameterValue(511)] NumberStyles P_2, [Optional] CultureInfo P_3)
		{
			return default;
		}

		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x2410274", Offset = "0x2410274", VA = "0x2410274")]
		private static bool TLxVjSTnEhtSKoelQSmhFqteXmmX(Type P_0, object P_1, out object P_2, [Optional][DefaultParameterValue(511)] NumberStyles P_3, [Optional] CultureInfo P_4)
		{
			return default;
		}

		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x24175C4", Offset = "0x24175C4", VA = "0x24175C4")]
		private static bool mKVJiXLVvthLShNKPfdobWYLkfyQA(Type P_0, SerializedObject P_1, out object P_2, [Optional][DefaultParameterValue(511)] NumberStyles P_3, [Optional] CultureInfo P_4)
		{
			return default;
		}

		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x24181C0", Offset = "0x24181C0", VA = "0x24181C0")]
		public static SerializedObject FromXml(Type type, string xmlString)
		{
			return null;
		}
	}
}
