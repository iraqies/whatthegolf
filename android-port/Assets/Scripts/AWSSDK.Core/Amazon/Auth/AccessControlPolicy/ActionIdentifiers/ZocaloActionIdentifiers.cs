using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000295")]
	public static class ZocaloActionIdentifiers
	{
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllZocaloActions;

		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier ActivateUser;

		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier AddUserToGroup;

		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CheckAlias;

		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier CreateInstance;

		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DeactivateUser;

		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DeleteInstance;

		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier DeregisterDirectory;

		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier DescribeAvailableDirectories;

		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier DescribeInstances;

		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier RegisterDirectory;

		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier RemoveUserFromGroup;

		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier UpdateInstanceAlias;
	}
}
