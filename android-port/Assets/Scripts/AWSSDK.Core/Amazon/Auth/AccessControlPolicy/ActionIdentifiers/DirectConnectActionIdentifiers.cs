using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000279")]
	public static class DirectConnectActionIdentifiers
	{
		[Token(Token = "0x400097E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllDirectConnectActions;

		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateConnection;

		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CreatePrivateVirtualInterface;

		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CreatePublicVirtualInterface;

		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DeleteConnection;

		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeleteVirtualInterface;

		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DescribeConnectionDetail;

		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier DescribeConnections;

		[Token(Token = "0x4000986")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier DescribeOfferingDetail;

		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier DescribeOfferings;

		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier DescribeVirtualGateways;

		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier DescribeVirtualInterfaces;
	}
}
