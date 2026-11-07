using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Xml;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[Preserve]
	internal sealed class SerializedObject : IEnumerable, IEnumerable<SerializedObject.Field>, IAddValue<object>, IAddKeyValue<string, object>, IExportToXml, IExportToJson
	{
		public enum ObjectType
		{
			Object = 0,
			List = 1
		}

		[Flags]
		public enum FieldOptions
		{
			None = 0,
			ExculdeFromXml = 1
		}

		private struct AhoBNMNzWieULmaZjWUIulsNcWuAA
		{
			public Type gwUdWoefqvdKVvJvsShVNYBtVNpSA;

			public object yYOUbwIbBcyPAQvjeAEXVsjzLAln;

			public FieldOptions cRTAqROlhrTnVFORtGklgaCffEkmA;

			public AhoBNMNzWieULmaZjWUIulsNcWuAA(Type P_0, object P_1, FieldOptions P_2)
			{
				gwUdWoefqvdKVvJvsShVNYBtVNpSA = null;
				yYOUbwIbBcyPAQvjeAEXVsjzLAln = null;
				cRTAqROlhrTnVFORtGklgaCffEkmA = FieldOptions.None;
			}

			public override string ToString()
			{
				return null;
			}
		}

		public struct Field
		{
			public string name;

			public object value;

			public Type type;

			public FieldOptions options;

			public Field(string P_0, object P_1, Type P_2, FieldOptions P_3)
			{
				name = null;
				value = null;
				type = null;
				options = FieldOptions.None;
			}

			public override string ToString()
			{
				return null;
			}
		}

		public class XmlInfo
		{
			public abstract class SiNMxfMGMezpRFyWceCPZrsRAdDk
			{
			}

			public class nIytNPQltHNThjHAgjtVciMQQyqsA : SiNMxfMGMezpRFyWceCPZrsRAdDk
			{
				public string yCwJMdebpVsoAZwRHxyMbDxHYvvT;

				public string OvVRJOklVDAaDOOGrXwIFuDdpwVJ;

				public string ZVXfpRlSPjKWRYaEYlEnqADXJiAs;

				public string yYOUbwIbBcyPAQvjeAEXVsjzLAln;

				public override string ToString()
				{
					return null;
				}
			}

			private List<SiNMxfMGMezpRFyWceCPZrsRAdDk> zsrJURFAvwLPgLtieKeKxdbIWHtj;

			public List<SiNMxfMGMezpRFyWceCPZrsRAdDk> attributes => null;

			public override string ToString()
			{
				return null;
			}
		}

		public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Field>
		{
			private IndexedDictionary<string, AhoBNMNzWieULmaZjWUIulsNcWuAA> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			private Field SgJVPHrjFyHgCSEpxtgUijWhNNop;

			private IEnumerator<KeyValuePair<string, AhoBNMNzWieULmaZjWUIulsNcWuAA>> rrbOANARHhUTMnvliFmUiAacqgwE;

			public Field Current => default;

			object IEnumerator.Current => null;

			internal Enumerator(object P_0)
			{
				gtOwGaSStjjjqPkwkkQpbgQQomCn = null;
				SgJVPHrjFyHgCSEpxtgUijWhNNop = default;
				rrbOANARHhUTMnvliFmUiAacqgwE = null;
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
			}
		}

		private class ramlcMHyWntHHFvjFssuDQDwmkz
		{
			public class FgapzGYpoOjcQKkMmHveHfmgHtIBb
			{
				public readonly string rCJyseVRiKOjaaVRmjlxeXUUOXNJ;

				public readonly FgapzGYpoOjcQKkMmHveHfmgHtIBb xOBFIOiBayOLXbKGUpZvZHJEAmpcb;

				public string upqsOOpRqmoiLMwZIZCznqWiugNd;

				public Dictionary<string, string> GHuEcXBqQqvSXkgtoNgPjbsLkPhMA;

				public List<FgapzGYpoOjcQKkMmHveHfmgHtIBb> HlKuHkTCoakjdIlyprdQqzFAqAJy;

				public int DsWRCWTDSoPtqczSsmCzHnNlzjgX => XddzIhOVXeeATWORWLUzhYuCZkNJ();

				public int MJEihnAEoPLhRZFXeOAtleAVhOge => TcbvycqxURRVfvZCapWwlCrAzxBc();

				public int XddzIhOVXeeATWORWLUzhYuCZkNJ()
				{
					return 0;
				}

				public int TcbvycqxURRVfvZCapWwlCrAzxBc()
				{
					return 0;
				}

				public FgapzGYpoOjcQKkMmHveHfmgHtIBb(string P_0, FgapzGYpoOjcQKkMmHveHfmgHtIBb P_1)
				{
				}

				public void HViNycCBPIpRZwBqvdCERZJNNopt(FgapzGYpoOjcQKkMmHveHfmgHtIBb P_0)
				{
				}

				public void XnNcFGGuuKGObeItIaZvfUVpEiKNb(string P_0, string P_1)
				{
				}

				public FgapzGYpoOjcQKkMmHveHfmgHtIBb CAUYaNnsovUfMrUBQlFcRiiUddLt(string P_0)
				{
					return null;
				}

				public object sGJIKhhPnzGPxdOnGAPTIOaLhZxHA()
				{
					return null;
				}

				public override string ToString()
				{
					return null;
				}

				private string RsAkLkYigfQxKWvdxVBUwNqsOGbJ(string P_0, int P_1)
				{
					return null;
				}
			}

			private readonly FgapzGYpoOjcQKkMmHveHfmgHtIBb qMKceKGrTQjrybdpYPLUczFhyVaTB;

			public FgapzGYpoOjcQKkMmHveHfmgHtIBb EaXiSzEdNuHiaIzWciVCFEZAjJcnC => aHQGfWHEgSWMFmErABaDhmqDcnQpb();

			public bool HtaXGKSwgRsWaFcEpcKcAcuoUpZnA => uEwmZcyPnvpaRxBhwpPRgteHuYAL();

			public FgapzGYpoOjcQKkMmHveHfmgHtIBb aHQGfWHEgSWMFmErABaDhmqDcnQpb()
			{
				return null;
			}

			public bool uEwmZcyPnvpaRxBhwpPRgteHuYAL()
			{
				return false;
			}

			public ramlcMHyWntHHFvjFssuDQDwmkz(string P_0)
			{
			}

			private void apUMsstPXQdQaxKIlDLXaUrtgnJbb(XmlReader P_0)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		private sealed class nqoRgfQeqAhpyNEzJORfYmTMVCnb
		{
			public static readonly nqoRgfQeqAhpyNEzJORfYmTMVCnb _003C_003E9;

			public static Func<FieldInfo, bool> _003C_003E9__63_0;

			public static Func<FieldInfo, string> _003C_003E9__63_1;

			public static Func<PropertyInfo, bool> _003C_003E9__63_2;

			public static Func<PropertyInfo, string> _003C_003E9__63_3;

			internal bool GfAbSCbkXfgoleyEGfwmUMXFrqKt(FieldInfo P_0)
			{
				return false;
			}

			internal string WdBTVGnkokkuYvbkHoqBTorjZxbE(FieldInfo P_0)
			{
				return null;
			}

			internal bool tmXfSFjGQeAmvieceGSoSXapiJLSA(PropertyInfo P_0)
			{
				return false;
			}

			internal string wzXwJkGHjoECeoSHbXBsgUJavOrp(PropertyInfo P_0)
			{
				return null;
			}
		}

		private readonly IndexedDictionary<string, AhoBNMNzWieULmaZjWUIulsNcWuAA> HLHkiXAtvIlnILCwVDiPMAWBJRuD;

		private XmlInfo VPtUrZujelnPNrtnsCcbMemyJlkR;

		private Type TIpqQbLCpFnyVWkQInNfNRXErYkK;

		private ObjectType SfzIlCdbXTnToiRLPgeHvVxRqVmmA;

		private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> PqQfxSEshUquXPWFKNvVbNUQnHFyA;

		private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> dPBmGdUNkJmnAJZMFlvbPJFbfIH;

		private bool allowDuplicateKeys => bXeCCBqLunsahjSBvCUMleZTdCqu();

		public ObjectType objectType
		{
			set
			{
			}
		}

		public Type type => null;

		public XmlInfo xmlInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int count => 0;

		// C# has no syntax for parameterized property 'Item'.
		public Field get_Item(int index)
		{
			return default;
		}

		bool IExportToXml.writesOwnElementTag => hBarglHADXsAagUtTxbKhhcbExHj();

		private SerializedObject()
		{
		}

		private SerializedObject(int P_0)
		{
		}

		public SerializedObject(Type P_0, ObjectType P_1)
		{
		}

		public SerializedObject(Type P_0, ObjectType P_1, int P_2)
		{
		}

		private bool bXeCCBqLunsahjSBvCUMleZTdCqu()
		{
			return false;
		}

		public void Add<T>(string fieldName, T value, FieldOptions options = FieldOptions.None)
		{
		}

		public void Add(Type type, string fieldName, object value, FieldOptions options = FieldOptions.None)
		{
		}

		public void Add(string fieldName, object value)
		{
		}

		public bool TryGetDeserializedValue<T>(string fieldName, out T value)
		{
			value = default;
			return false;
		}

		public bool TryGetDeserializedValue<T>(int index, out T value)
		{
			value = default;
			return false;
		}

		public bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value)
		{
			return false;
		}

		public string ToXmlString(bool writeDocumentTag)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private void yXhvfaLRlBwKMqhMlvpomkhFPurm(XmlWriter P_0)
		{
		}

		private void WmPmgythTCkKknxTeQCLppYXlQbs(XmlWriter P_0)
		{
		}

		private bool hBarglHADXsAagUtTxbKhhcbExHj()
		{
			return false;
		}

		private void mvSTQcMicmCqSZxGxWxESklqiEsP(XmlWriter P_0)
		{
		}

		void IExportToXml.WriteXml(XmlWriter P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in mvSTQcMicmCqSZxGxWxESklqiEsP
			this.mvSTQcMicmCqSZxGxWxESklqiEsP(P_0);
		}

		private void yXGIjLLRecTFTawUBjniovMjLQhW(StringBuilder P_0, Action<StringBuilder, object> P_1)
		{
		}

		void IExportToJson.WriteJson(StringBuilder P_0, Action<StringBuilder, object> P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in yXGIjLLRecTFTawUBjniovMjLQhW
			this.yXGIjLLRecTFTawUBjniovMjLQhW(P_0, P_1);
		}

		void IAddValue<object>.Add(object P_0)
		{
		}

		void IAddKeyValue<string, object>.Add(string P_0, object P_1)
		{
		}

		IEnumerator<Field> IEnumerable<Field>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private static bool TLxVjSTnEhtSKoelQSmhFqteXmmX<_0001>(object P_0, out _0001 P_1, NumberStyles P_2 = NumberStyles.Any, CultureInfo P_3 = null)
		{
			P_1 = default;
			return false;
		}

		private static bool TLxVjSTnEhtSKoelQSmhFqteXmmX(Type P_0, object P_1, out object P_2, NumberStyles P_3 = NumberStyles.Any, CultureInfo P_4 = null)
		{
			P_2 = null;
			return false;
		}

		private static bool mKVJiXLVvthLShNKPfdobWYLkfyQA(Type P_0, SerializedObject P_1, out object P_2, NumberStyles P_3 = NumberStyles.Any, CultureInfo P_4 = null)
		{
			P_2 = null;
			return false;
		}

		public static SerializedObject FromXml(Type type, string xmlString)
		{
			return null;
		}
	}
}
