using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x200006E")]
	internal class ReflectionMethodsCache
	{
		[Token(Token = "0x200006F")]
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i);

		[Token(Token = "0x2000070")]
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i);

		[Token(Token = "0x2000071")]
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i);

		[Token(Token = "0x2000072")]
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i);

		[Token(Token = "0x2000073")]
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i);

		[Token(Token = "0x2000074")]
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i);

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x10")]
		public Raycast3DCallback raycast3D;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x18")]
		public RaycastAllCallback raycast3DAll;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x20")]
		public GetRaycastNonAllocCallback getRaycastNonAlloc;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x28")]
		public Raycast2DCallback raycast2D;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x30")]
		public GetRayIntersectionAllCallback getRayIntersectionAll;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x38")]
		public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x0")]
		private static ReflectionMethodsCache s_ReflectionMethodsCache;

		[Token(Token = "0x1700014E")]
		public static ReflectionMethodsCache Singleton
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x2C31378", Offset = "0x2C31378", VA = "0x2C31378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2C306D8", Offset = "0x2C306D8", VA = "0x2C306D8")]
		public ReflectionMethodsCache()
		{
		}
	}
}
