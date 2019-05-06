﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Uno.AzureDevOps.Client
{
	public class ProfileAvatarData
	{
		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("timeStamp")]
		public DateTime TimeStamp { get; set; }

		[JsonProperty("size")]
		public string Size { get; set; }

		[JsonProperty("isAutoGenerated")]
		public bool IsAutoGenerated { get; set; }
	}
}
