using System;
using System.Collections.Generic;

using KinveyXamarin;
using KinveyXamariniOS;
using UIKit;
using System.Threading.Tasks;

namespace Tasky.Shared 
{
	/// <summary>
	/// Manager classes are an abstraction on the data access layers
	/// </summary>
	public class TodoItemManager 
	{
		// add kinveyClient object
		public static Client kinveyClient { get; set; }
		public static AsyncAppData<TodoItem> kinveyStore;

		static TodoItemManager ()
		{
			kinveyClient = ((AppDelegate)UIApplication.SharedApplication.Delegate).kinveyClient;
			kinveyStore = kinveyClient.AppData<TodoItem> ("todo", typeof(TodoItem));
		}
		
		public static TodoItem GetTask(int id)
		{
			return TodoItemRepositoryADO.GetTask(id);
			//return kinveyClient
		}

		// OLD CLASS TO GET TASKS
		public static IList<TodoItem> GetTasks ()
		{
			return new List<TodoItem>(TodoItemRepositoryADO.GetTasks());
		}

		// NEW KINVEY METHOD TO GET TASKS
		public async static Task<IList<TodoItem>> GetKTasks ()
		{
			return new List<TodoItem>(await kinveyStore.GetAsync());
		}		

		public static int SaveTask (TodoItem item)
		{
			return TodoItemRepositoryADO.SaveTask(item);
		}
		
		public static int DeleteTask(int id)
		{
			return TodoItemRepositoryADO.DeleteTask(id);
		}
	}
}