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
		[JsonProperty] public string _id;
		[JsonProperty] public int ID { get; set; }
		[JsonProperty] public string Name { get; set; }
		[JsonProperty] public string Notes { get; set; }
		[JsonProperty] public bool Done { get; set; }	// TODO: add this field to the user-interface
	}
}