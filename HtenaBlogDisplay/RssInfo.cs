using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HtenaBlogDisplay
{
	public class RssInfo
	{
		[JsonProperty("titleList")]
		public List<string> TitleList =new List<string>();

		[JsonProperty("urlList")]
		public List<string> UrlList =new List<string>();
	}
}
