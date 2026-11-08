#!/usr/bin/env python3
"""Fix all remaining C# decompilation quirks in third-party/package assemblies
(UnityEngine.UI, Unity.ResourceManager, Unity.TextMeshPro, Unity.ProBuilder,
zxing.unity, AWSSDK.Core, Newtonsoft.Json, Rewired_Core) in both android-port/Assets
and ExportedProject/Assets.
"""
import os
import re

ROOTS = [
    "/home/ubuntu/work/WhatTheGolf/android-port/Assets",
    "/home/ubuntu/c113work/ar_out/ExportedProject/Assets",
]


def patch_file(rel_path: str, fn) -> None:
    for r in ROOTS:
        p = os.path.join(r, rel_path)
        if os.path.exists(p):
            old = open(p, encoding="utf-8", errors="ignore").read()
            new = fn(old)
            if new != old:
                with open(p, "w", encoding="utf-8") as f:
                    f.write(new)


def main() -> None:
    # 1. IndexedSet.cs
    patch_file(
        "Scripts/UnityEngine.UI/UnityEngine/UI/Collections/IndexedSet.cs",
        lambda t: t.replace(
            "\t\t// C# has no syntax for parameterized property 'Item'.\n\t\tpublic T get_Item(int index)\n\t\t{\n\t\t\treturn default;\n\t\t}\n\n\t\tpublic void set_Item(int index, T value)\n\t\t{\n\t\t}",
            "\t\tpublic T this[int index]\n\t\t{\n\t\t\tget => m_List != null && index >= 0 && index < m_List.Count ? m_List[index] : default;\n\t\t\tset { if (m_List != null && index >= 0 && index < m_List.Count) m_List[index] = value; }\n\t\t}\n\n\t\tpublic T get_Item(int index) => this[index];\n\t\tpublic void set_Item(int index, T value) { this[index] = value; }"
        )
    )

    # 2. ListWithEvents.cs
    patch_file(
        "Scripts/Unity.ResourceManager/ListWithEvents.cs",
        lambda t: t.replace(
            "\t// C# has no syntax for parameterized property 'Item'.\n\tpublic T get_Item(int index)\n\t{\n\t\treturn default;\n\t}\n\n\tpublic void set_Item(int index, T value)\n\t{\n\t}",
            "\tpublic T this[int index]\n\t{\n\t\tget => m_List != null && index >= 0 && index < m_List.Count ? m_List[index] : default;\n\t\tset { if (m_List != null && index >= 0 && index < m_List.Count) m_List[index] = value; }\n\t}\n\n\tpublic T get_Item(int index) => this[index];\n\tpublic void set_Item(int index, T value) { this[index] = value; }"
        )
    )

    # 3. TMP_Offset.cs
    patch_file(
        "Scripts/Unity.TextMeshPro/TMPro/TMP_Offset.cs",
        lambda t: t if "operator !=" in t else t.replace(
            "\t\tpublic static bool operator ==(TMP_Offset lhs, TMP_Offset rhs)\n\t\t{\n\t\t\treturn false;\n\t\t}",
            "\t\tpublic static bool operator ==(TMP_Offset lhs, TMP_Offset rhs)\n\t\t{\n\t\t\treturn false;\n\t\t}\n\n\t\tpublic static bool operator !=(TMP_Offset lhs, TMP_Offset rhs)\n\t\t{\n\t\t\treturn !(lhs == rhs);\n\t\t}"
        )
    )

    # 4. Vertex.cs
    patch_file(
        "Scripts/Unity.ProBuilder/UnityEngine/ProBuilder/Vertex.cs",
        lambda t: t if "operator !=" in t else t.replace(
            "\t\tpublic static bool operator ==(Vertex a, Vertex b)\n\t\t{\n\t\t\treturn false;\n\t\t}",
            "\t\tpublic static bool operator ==(Vertex a, Vertex b)\n\t\t{\n\t\t\treturn false;\n\t\t}\n\n\t\tpublic static bool operator !=(Vertex a, Vertex b)\n\t\t{\n\t\t\treturn !(a == b);\n\t\t}"
        )
    )

    # 5. BigInteger.cs
    patch_file(
        "Scripts/zxing.unity/BigIntegerLibrary/BigInteger.cs",
        lambda t: t if "operator >(" in t else t.replace(
            "\t\tpublic static bool operator <(BigInteger a, BigInteger b)\n\t\t{\n\t\t\treturn false;\n\t\t}",
            "\t\tpublic static bool operator <(BigInteger a, BigInteger b)\n\t\t{\n\t\t\treturn false;\n\t\t}\n\n\t\tpublic static bool operator >(BigInteger a, BigInteger b)\n\t\t{\n\t\t\treturn false;\n\t\t}"
        )
    )

    # 6. ParametersDictionaryFacade.cs
    patch_file(
        "Scripts/AWSSDK.Core/Amazon/Runtime/Internal/ParametersDictionaryFacade.cs",
        lambda t: t.replace(
            "\t\t// C# has no syntax for parameterized property 'Item'.\n\t\tpublic string get_Item(string key)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tpublic void set_Item(string key, string value)\n\t\t{\n\t\t}",
            "\t\tpublic string this[string key]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}\n\n\t\tpublic string get_Item(string key) => null;\n\t\tpublic void set_Item(string key, string value) { }"
        )
    )

    # 7. JsonData.cs
    def fix_jsondata(t: str) -> str:
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.\n\t\tobject IDictionary.get_Item(object key)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IDictionary.set_Item(object key, object value)\n\t\t{\n\t\t}",
            "\t\tobject IDictionary.this[object key]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.Specialized.IOrderedDictionary.Item'.\n\t\tobject IOrderedDictionary.get_Item(int idx)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IOrderedDictionary.set_Item(int idx, object value)\n\t\t{\n\t\t}",
            "\t\tobject IOrderedDictionary.this[int idx]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.IList.Item'.\n\t\tobject IList.get_Item(int index)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IList.set_Item(int index, object value)\n\t\t{\n\t\t}",
            "\t\tobject IList.this[int index]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        return t
    patch_file("Scripts/AWSSDK.Core/ThirdParty/Json/LitJson/JsonData.cs", fix_jsondata)

    # 8. JsonFormatterConverter.cs
    patch_file(
        "Scripts/Newtonsoft.Json/Newtonsoft/Json/Serialization/JsonFormatterConverter.cs",
        lambda t: t if "ToByte(" in t else t.replace(
            "\t\tpublic object Convert(object value, Type type)\n\t\t{\n\t\t\treturn null;\n\t\t}",
            "\t\tpublic object Convert(object value, Type type)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tpublic object Convert(object value, TypeCode typeCode) => null;\n\t\tpublic byte ToByte(object value) => 0;\n\t\tpublic char ToChar(object value) => '\\0';\n\t\tpublic DateTime ToDateTime(object value) => default;\n\t\tpublic decimal ToDecimal(object value) => 0m;\n\t\tpublic double ToDouble(object value) => 0.0;\n\t\tpublic short ToInt16(object value) => 0;\n\t\tpublic sbyte ToSByte(object value) => 0;\n\t\tpublic ushort ToUInt16(object value) => 0;\n\t\tpublic uint ToUInt32(object value) => 0u;\n\t\tpublic ulong ToUInt64(object value) => 0uL;"
        )
    )

    # 9. JArray.cs, JContainer.cs, JObject.cs, JProperty.cs
    patch_file(
        "Scripts/Newtonsoft.Json/Newtonsoft/Json/Linq/JArray.cs",
        lambda t: t.replace(
            "\t\t// C# has no syntax for parameterized property 'Item'.\n\t\tpublic JToken get_Item(int index)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tpublic void set_Item(int index, JToken value)\n\t\t{\n\t\t}",
            "\t\tpublic JToken this[int index]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}\n\n\t\tpublic JToken get_Item(int index) => null;\n\t\tpublic void set_Item(int index, JToken value) { }"
        )
    )
    def fix_jcontainer(t: str) -> str:
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item'.\n\t\tJToken IList<JToken>.get_Item(int index)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IList<JToken>.set_Item(int index, JToken value)\n\t\t{\n\t\t}",
            "\t\tJToken IList<JToken>.this[int index]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.IList.Item'.\n\t\tobject IList.get_Item(int index)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IList.set_Item(int index, object value)\n\t\t{\n\t\t}",
            "\t\tobject IList.this[int index]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        return t
    patch_file("Scripts/Newtonsoft.Json/Newtonsoft/Json/Linq/JContainer.cs", fix_jcontainer)
    patch_file(
        "Scripts/Newtonsoft.Json/Newtonsoft/Json/Linq/JObject.cs",
        lambda t: t.replace(
            "\t\t// C# has no syntax for parameterized property 'Item'.\n\t\tpublic JToken get_Item(string propertyName)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tpublic void set_Item(string propertyName, JToken value)\n\t\t{\n\t\t}",
            "\t\tpublic JToken this[string propertyName]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}\n\n\t\tpublic JToken get_Item(string propertyName) => null;\n\t\tpublic void set_Item(string propertyName, JToken value) { }"
        )
    )
    patch_file(
        "Scripts/Newtonsoft.Json/Newtonsoft/Json/Linq/JProperty.cs",
        lambda t: t.replace(
            "\t\t\t// C# has no syntax for parameterized property 'Item'.\n\t\t\tpublic JToken get_Item(int index)\n\t\t\t{\n\t\t\t\treturn null;\n\t\t\t}\n\n\t\t\tpublic void set_Item(int index, JToken value)\n\t\t\t{\n\t\t\t}",
            "\t\t\tpublic JToken this[int index]\n\t\t\t{\n\t\t\t\tget => null;\n\t\t\t\tset { }\n\t\t\t}\n\n\t\t\tpublic JToken get_Item(int index) => null;\n\t\t\tpublic void set_Item(int index, JToken value) { }"
        )
    )

    # 10. UnityTools.cs
    patch_file(
        "Scripts/Rewired_Core/Rewired/Utils/UnityTools.cs",
        lambda t: t if "operator <=" in t else t.replace(
            "\t\t\tpublic static bool operator >=(UnityVersionClass a, UnityVersionClass b)\n\t\t\t{\n\t\t\t\treturn false;\n\t\t\t}",
            "\t\t\tpublic static bool operator >=(UnityVersionClass a, UnityVersionClass b)\n\t\t\t{\n\t\t\t\treturn false;\n\t\t\t}\n\n\t\t\tpublic static bool operator <=(UnityVersionClass a, UnityVersionClass b)\n\t\t\t{\n\t\t\t\treturn false;\n\t\t\t}"
        )
    )

    # 11. ControllerMapEnabler.cs & ControllerMapLayoutManager.cs
    patch_file(
        "Scripts/Rewired_Core/Rewired/ControllerMapEnabler.cs",
        lambda t: t.replace(
            "\t\t\t// C# has no syntax for parameterized property 'Item'.\n\t\t\tpublic Rule get_Item(int index)\n\t\t\t{\n\t\t\t\treturn null;\n\t\t\t}\n\n\t\t\tpublic void set_Item(int index, Rule value)\n\t\t\t{\n\t\t\t}",
            "\t\t\tpublic Rule this[int index]\n\t\t\t{\n\t\t\t\tget => null;\n\t\t\t\tset { }\n\t\t\t}\n\n\t\t\tpublic Rule get_Item(int index) => null;\n\t\t\tpublic void set_Item(int index, Rule value) { }"
        )
    )
    patch_file(
        "Scripts/Rewired_Core/Rewired/ControllerMapLayoutManager.cs",
        lambda t: t.replace(
            "\t\t\t// C# has no syntax for parameterized property 'Item'.\n\t\t\tpublic Rule get_Item(int index)\n\t\t\t{\n\t\t\t\treturn null;\n\t\t\t}\n\n\t\t\tpublic void set_Item(int index, Rule value)\n\t\t\t{\n\t\t\t}",
            "\t\t\tpublic Rule this[int index]\n\t\t\t{\n\t\t\t\tget => null;\n\t\t\t\tset { }\n\t\t\t}\n\n\t\t\tpublic Rule get_Item(int index) => null;\n\t\t\tpublic void set_Item(int index, Rule value) { }"
        )
    )

    # 12. AList.cs, ADictionary.cs, IndexedDictionary.cs
    def fix_alist(t: str) -> str:
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'Item'.\n\t\tpublic T get_Item(int index)\n\t\t{\n\t\t\treturn default;\n\t\t}\n\n\t\tpublic void set_Item(int index, T value)\n\t\t{\n\t\t}",
            "\t\tpublic T this[int index]\n\t\t{\n\t\t\tget => default;\n\t\t\tset { }\n\t\t}\n\n\t\tpublic T get_Item(int index) => default;\n\t\tpublic void set_Item(int index, T value) { }"
        )
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.IList.Item'.\n\t\tobject IList.get_Item(int index)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IList.set_Item(int index, object value)\n\t\t{\n\t\t}",
            "\t\tobject IList.this[int index]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        return t
    patch_file("Scripts/Rewired_Core/Rewired/Utils/Classes/Data/AList.cs", fix_alist)

    def fix_adict(t: str) -> str:
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'Item'.\n\t\tpublic TValue get_Item(TKey key)\n\t\t{\n\t\t\treturn default;\n\t\t}\n\n\t\tpublic void set_Item(TKey key, TValue value)\n\t\t{\n\t\t}",
            "\t\tpublic TValue this[TKey key]\n\t\t{\n\t\t\tget => default;\n\t\t\tset { }\n\t\t}\n\n\t\tpublic TValue get_Item(TKey key) => default;\n\t\tpublic void set_Item(TKey key, TValue value) { }"
        )
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.\n\t\tobject IDictionary.get_Item(object key)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IDictionary.set_Item(object key, object value)\n\t\t{\n\t\t}",
            "\t\tobject IDictionary.this[object key]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        return t
    patch_file("Scripts/Rewired_Core/Rewired/Utils/Classes/Data/ADictionary.cs", fix_adict)

    def fix_idxdict(t: str) -> str:
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.Generic.IDictionary<TKey,TValue>.Item'.\n\t\tTValue IDictionary<TKey, TValue>.get_Item(TKey P_0)\n\t\t{\n\t\t\treturn default;\n\t\t}\n\n\t\tvoid IDictionary<TKey, TValue>.set_Item(TKey P_0, TValue P_1)\n\t\t{\n\t\t}",
            "\t\tTValue IDictionary<TKey, TValue>.this[TKey P_0]\n\t\t{\n\t\t\tget => default;\n\t\t\tset { }\n\t\t}"
        )
        t = t.replace(
            "\t\t// C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.\n\t\tobject IDictionary.get_Item(object key)\n\t\t{\n\t\t\treturn null;\n\t\t}\n\n\t\tvoid IDictionary.set_Item(object key, object value)\n\t\t{\n\t\t}",
            "\t\tobject IDictionary.this[object key]\n\t\t{\n\t\t\tget => null;\n\t\t\tset { }\n\t\t}"
        )
        return t
    patch_file("Scripts/Rewired_Core/Rewired/Utils/Classes/Data/IndexedDictionary.cs", fix_idxdict)

    # 13. CustomCalculation_*.cs
    for cc in [
        "CustomCalculation_Accelerometer.cs",
        "CustomCalculation_CompareElementValues.cs",
        "CustomCalculation_FirstNonZero.cs",
        "CustomCalculation_LogitechGRacingWheelPedals.cs",
    ]:
        patch_file(
            f"Scripts/Rewired_Core/Rewired/Data/Mapping/{cc}",
            lambda t: t.replace(
                "internal override TypeWrapper.DataType msPGkahjUeDsvWeBnAwyduNCSsdO => get_ResultType();",
                "internal override TypeWrapper.DataType ResultType => get_ResultType();"
            )
        )

    # 14. tmPBYsdGCEOnbogabbGMuUDuHrHj.cs
    def fix_tmpby(t: str) -> str:
        t = t.replace(
            "\t// C# has no syntax for parameterized property 'DnOVsxyYplvCxlGqDJhQTdITXUim.dvPsYKgTmQEzpmDbxLcTJoNaDxtw'.\n\tControllerMap DnOVsxyYplvCxlGqDJhQTdITXUim.get_dvPsYKgTmQEzpmDbxLcTJoNaDxtw(int P_0)\n\t{\n\t\treturn tNrdumShOleCoQpkZDYIKhozLDUu(P_0);\n\t}\n\n\tIList<ControllerMap> IYAZWDOxptdEIZqQulstZlWFDrWQ => vHnkNxDCkZkLEycTguoDvbSiQQbL();",
            "\tControllerMap DnOVsxyYplvCxlGqDJhQTdITXUim.get_xKHWVyyMFvFkZzVdcahSgmCfFoFGb(int P_0) => tNrdumShOleCoQpkZDYIKhozLDUu(P_0);\n\tControllerMap DnOVsxyYplvCxlGqDJhQTdITXUim.dvPsYKgTmQEzpmDbxLcTJoNaDxtw(int P_0) => tNrdumShOleCoQpkZDYIKhozLDUu(P_0);\n\tIList<ControllerMap> DnOVsxyYplvCxlGqDJhQTdITXUim.kIfmjNGuuXrTJuvNLfqyicMBRuPS => vHnkNxDCkZkLEycTguoDvbSiQQbL();\n\tIList<ControllerMap> DnOVsxyYplvCxlGqDJhQTdITXUim.IYAZWDOxptdEIZqQulstZlWFDrWQ() => vHnkNxDCkZkLEycTguoDvbSiQQbL();"
        )
        return t
    patch_file("Scripts/Rewired_Core/tmPBYsdGCEOnbogabbGMuUDuHrHj.cs", fix_tmpby)

    # 15. Player.cs
    def fix_player(t: str) -> str:
        old_uh = """\t\t\t\t\tController ErQenHIYsTkFUbnkMAtWziiYAMGtA => ZCMIkJsulsGqqdpafCqkRjTDvFkf();

\t\t\t\t\tDnOVsxyYplvCxlGqDJhQTdITXUim pxlGvvmmBMZIJiyXisYPNdMoyvDn => lUkNvaAscjtjJezlRrCYZEJFfbgv();

\t\t\t\t\tdouble tvUAAraGvYJRpabzmoHBQhaNlppCb => BEpaoGIhhnIzuWXfczQKkUpEMSxdb();"""
        new_uh = """\t\t\t\t\tDnOVsxyYplvCxlGqDJhQTdITXUim UnNPkxDfGWJQVABSUufpxfnajIgHA.ONWZvZGbSQUjcMvUiPoePNFmWXVD => lUkNvaAscjtjJezlRrCYZEJFfbgv();
\t\t\t\t\tController UnNPkxDfGWJQVABSUufpxfnajIgHA.MHuXHKLCPsUIeLOovImpnHVJaYufA => ZCMIkJsulsGqqdpafCqkRjTDvFkf();
\t\t\t\t\tdouble UnNPkxDfGWJQVABSUufpxfnajIgHA.tEDFaJjOLaplFpvDzbLxFyLzHDrab => BEpaoGIhhnIzuWXfczQKkUpEMSxdb();
\t\t\t\t\tDnOVsxyYplvCxlGqDJhQTdITXUim UnNPkxDfGWJQVABSUufpxfnajIgHA.pxlGvvmmBMZIJiyXisYPNdMoyvDn() => lUkNvaAscjtjJezlRrCYZEJFfbgv();
\t\t\t\t\tController UnNPkxDfGWJQVABSUufpxfnajIgHA.ErQenHIYsTkFUbnkMAtWziiYAMGtA() => ZCMIkJsulsGqqdpafCqkRjTDvFkf();
\t\t\t\t\tdouble UnNPkxDfGWJQVABSUufpxfnajIgHA.tvUAAraGvYJRpabzmoHBQhaNlppCb() => BEpaoGIhhnIzuWXfczQKkUpEMSxdb();"""
        t = t.replace(old_uh, new_uh)
        old_hfr = """\t\t\t\t// C# has no syntax for parameterized property 'Rewired.Player.ControllerHelper.HfrONhohtqJsXuOJcrerFhDFBfdP.dvPsYKgTmQEzpmDbxLcTJoNaDxtw'.
\t\t\t\tUnNPkxDfGWJQVABSUufpxfnajIgHA HfrONhohtqJsXuOJcrerFhDFBfdP.get_dvPsYKgTmQEzpmDbxLcTJoNaDxtw(int P_0)
\t\t\t\t{
\t\t\t\t\treturn ZfzbacfrUazhyIUVQWszgBueKSeU(P_0);
\t\t\t\t}"""
        new_hfr = """\t\t\t\tUnNPkxDfGWJQVABSUufpxfnajIgHA HfrONhohtqJsXuOJcrerFhDFBfdP.get_xKHWVyyMFvFkZzVdcahSgmCfFoFGb(int P_0) => ZfzbacfrUazhyIUVQWszgBueKSeU(P_0);
\t\t\t\tUnNPkxDfGWJQVABSUufpxfnajIgHA HfrONhohtqJsXuOJcrerFhDFBfdP.dvPsYKgTmQEzpmDbxLcTJoNaDxtw(int P_0) => ZfzbacfrUazhyIUVQWszgBueKSeU(P_0);"""
        t = t.replace(old_hfr, new_hfr)
        return t
    patch_file("Scripts/Rewired_Core/Rewired/Player.cs", fix_player)

    # 16. ControllerTemplate.cs
    def fix_ct(t: str) -> str:
        t = t.replace(
            "public override bool PhpaujTLOdqAPpftaxjzKpWeuveq => get_exists();",
            "public override bool exists => get_exists();"
        )
        t = t.replace(
            "public override IControllerTemplateElementSource rmMLNGpqXVBSkkjZadentyrvdrgtA => get_source();",
            "public override IControllerTemplateElementSource source => get_source();"
        )
        return t
    patch_file("Scripts/Rewired_Core/Rewired/ControllerTemplate.cs", fix_ct)

    print("Fixed all 25 third-party files.")


if __name__ == "__main__":
    main()
