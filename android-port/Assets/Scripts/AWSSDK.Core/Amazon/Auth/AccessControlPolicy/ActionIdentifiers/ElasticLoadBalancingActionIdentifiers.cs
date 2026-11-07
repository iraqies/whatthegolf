using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x200027E")]
	public static class ElasticLoadBalancingActionIdentifiers
	{
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllElasticLoadBalancingActions;

		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier ApplySecurityGroupsToLoadBalancer;

		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier AttachLoadBalancerToSubnets;

		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier ConfigureHealthCheck;

		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier CreateAppCookieStickinessPolicy;

		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier CreateLBCookieStickinessPolicy;

		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier CreateLoadBalancer;

		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier CreateLoadBalancerListeners;

		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier CreateLoadBalancerPolicy;

		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier DeleteLoadBalancer;

		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier DeleteLoadBalancerListeners;

		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier DeleteLoadBalancerPolicy;

		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier DeregisterInstancesFromLoadBalancer;

		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier DescribeInstanceHealth;

		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier DescribeLoadBalancerAttributes;

		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier DescribeLoadBalancerPolicyTypes;

		[Token(Token = "0x4000A76")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier DescribeLoadBalancerPolicies;

		[Token(Token = "0x4000A77")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier DescribeLoadBalancers;

		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x90")]
		public static readonly ActionIdentifier DetachLoadBalancerFromSubnets;

		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x98")]
		public static readonly ActionIdentifier DisableAvailabilityZonesForLoadBalancer;

		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly ActionIdentifier EnableAvailabilityZonesForLoadBalancer;

		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly ActionIdentifier ModifyLoadBalancerAttributes;

		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly ActionIdentifier RegisterInstancesWithLoadBalancer;

		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly ActionIdentifier SetLoadBalancerListenerSSLCertificate;

		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly ActionIdentifier SetLoadBalancerPoliciesForBackendServer;

		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly ActionIdentifier SetLoadBalancerPoliciesOfListener;
	}
}
