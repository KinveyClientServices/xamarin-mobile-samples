using System;
using System.Collections.Generic;
using UIKit;
using System.Threading.Tasks;

//using KinveyXamarin;
//using KinveyXamariniOS;

namespace Tasky.Shared 
{
	/// <summary>
	/// Manager classes are an abstraction on the data access layers
	/// </summary>
	public class TodoItemManager 
	{
		// ******************
		// add kinveyClient object
/*		public static Client kinveyClient { get; set; }
		public static AsyncAppData<TodoItem> kinveyStore;
*/		// ******************

		static TodoItemManager ()
		{
			// **********************************
			// initialize data store links
/*			kinveyClient = ((AppDelegate)UIApplication.SharedApplication.Delegate).kinveyClient;
			kinveyStore = kinveyClient.AppData<TodoItem> ("todo", typeof(TodoItem));
*/			// **********************************
		}
		
		public async static Task<TodoItem> GetTask(int id)
		{
			return TodoItemRepositoryADO.GetTask(id);
			//return await kinveyStore.GetEntityAsync(id.ToString());
		}

		public async static Task<IList<TodoItem>> GetTasks ()
		{
			return new List<TodoItem>(TodoItemRepositoryADO.GetTasks());
			//return new List<TodoItem>(await kinveyStore.GetAsync());
		}

		public async static Task<int> SaveTask (TodoItem item)
		{
			return TodoItemRepositoryADO.SaveTask(item);
			//return (await kinveyStore.SaveAsync(item)).ID;
		}

		public async static Task<int> DeleteTask(int id)
		{
			return TodoItemRepositoryADO.DeleteTask(id);
			//await kinveyStore.DeleteAsync(id.ToString());
			//return 0;
		}


	}
}