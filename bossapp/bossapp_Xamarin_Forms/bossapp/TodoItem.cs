using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace bossapp
{
	public class TodoItem
	{
		string id;
		string name;
		bool done;
        string category;

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value;}
		}

		[JsonProperty(PropertyName = "text")]
		public string Name
		{
			get { return name; }
			set { name = value;}
		}

		[JsonProperty(PropertyName = "complete")]
		public bool Done
		{
			get { return done; }
			set { done = value;}
		}

        [JsonProperty(PropertyName = "category")]
        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        [Version]
        public string Version { get; set; }
	}
}

