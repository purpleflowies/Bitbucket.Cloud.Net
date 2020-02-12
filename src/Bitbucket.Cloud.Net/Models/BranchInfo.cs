﻿using Newtonsoft.Json;

namespace Bitbucket.Cloud.Net.Models
{
	public class BranchInfo : BranchName
	{
		public Branch Branch { get; set; }
		[JsonProperty("use_mainbranch")]
		public bool UseMainbranch { get; set; }
		[JsonProperty("is_valid")]
		public bool? IsValid { get; set; }
		public bool? Enabled { get; set; }

	}
}