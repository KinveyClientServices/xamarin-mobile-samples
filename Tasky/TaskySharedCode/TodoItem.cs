using System;
using Newtonsoft.Json;
using KinveyXamarin;  //*** ADD KINVEY SDK

namespace Tasky.Shared 
{
	/// <summary>
	/// Todo Item business object
	/// </summary>
	[JsonObject(MemberSerialization.OptIn)]
	public class TodoItem 
	{
		public TodoItem ()
		{
		}
		public string _id;
		[JsonProperty("intId")]
        public int ID { get; set; }
		[JsonProperty("action")]
		public string Name { get; set; }
		[JsonProperty("Title")]
		public string Notes { get; set; }
		public bool Done { get; set; }	// TODO: add this field to the user-interface
	}
}