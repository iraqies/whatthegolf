using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class RoleMapping
	{
		private AmbiguousRoleResolutionType _ambiguousRoleResolution;

		private RulesConfigurationType _rulesConfiguration;

		private RoleMappingType _type;

		public AmbiguousRoleResolutionType AmbiguousRoleResolution
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RulesConfigurationType RulesConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public RoleMappingType Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAmbiguousRoleResolution()
		{
			return false;
		}

		internal bool IsSetRulesConfiguration()
		{
			return false;
		}

		internal bool IsSetType()
		{
			return false;
		}
	}
}
