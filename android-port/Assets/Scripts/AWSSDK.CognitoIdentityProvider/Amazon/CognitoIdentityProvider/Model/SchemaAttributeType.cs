using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SchemaAttributeType
	{
		private AttributeDataType _attributeDataType;

		private bool? _developerOnlyAttribute;

		private bool? _mutable;

		private string _name;

		private NumberAttributeConstraintsType _numberAttributeConstraints;

		private bool? _required;

		private StringAttributeConstraintsType _stringAttributeConstraints;

		public AttributeDataType AttributeDataType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool DeveloperOnlyAttribute
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Mutable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NumberAttributeConstraintsType NumberAttributeConstraints
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Required
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public StringAttributeConstraintsType StringAttributeConstraints
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAttributeDataType()
		{
			return false;
		}

		internal bool IsSetDeveloperOnlyAttribute()
		{
			return false;
		}

		internal bool IsSetMutable()
		{
			return false;
		}

		internal bool IsSetName()
		{
			return false;
		}

		internal bool IsSetNumberAttributeConstraints()
		{
			return false;
		}

		internal bool IsSetRequired()
		{
			return false;
		}

		internal bool IsSetStringAttributeConstraints()
		{
			return false;
		}
	}
}
