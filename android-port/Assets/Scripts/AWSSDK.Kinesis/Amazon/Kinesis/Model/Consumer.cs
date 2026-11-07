using System;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class Consumer
	{
		private string _consumerARN;

		private DateTime? _consumerCreationTimestamp;

		private string _consumerName;

		private ConsumerStatus _consumerStatus;

		[AWSProperty]
		public string ConsumerARN
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
		public DateTime ConsumerCreationTimestamp
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string ConsumerName
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
		public ConsumerStatus ConsumerStatus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetConsumerARN()
		{
			return false;
		}

		internal bool IsSetConsumerCreationTimestamp()
		{
			return false;
		}

		internal bool IsSetConsumerName()
		{
			return false;
		}

		internal bool IsSetConsumerStatus()
		{
			return false;
		}
	}
}
