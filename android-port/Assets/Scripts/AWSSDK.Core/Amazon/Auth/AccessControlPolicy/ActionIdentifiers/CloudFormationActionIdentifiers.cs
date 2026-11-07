using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000271")]
	public static class CloudFormationActionIdentifiers
	{
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllCloudFormationActions;

		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CreateStack;

		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier DeleteStack;

		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier DescribeStackEvents;

		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier DescribeStackResource;

		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier DescribeStackResources;

		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier DescribeStacks;

		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier EstimateTemplateCost;

		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier GetTemplate;

		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier ListStacks;

		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier ListStackResources;

		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier UpdateStack;

		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier ValidateTemplate;
	}
}
