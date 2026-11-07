using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000077")]
	public interface IMeshModifier
	{
		[Token(Token = "0x60004F8")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F8A78", Offset = "0x1F8A78")]
		void ModifyMesh(Mesh mesh);

		[Token(Token = "0x60004F9")]
		void ModifyMesh(VertexHelper verts);
	}
}
