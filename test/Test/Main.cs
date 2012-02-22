using System;
using GithubApi;
using GithubApi.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Test
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			UserApi userApi = new UserApi();
			string result = userApi.GetUser("dkucinskas");
			
			JObject jobject = JObject.Parse(result);
			//(JObject)JsonConvert.DeserializeObject(user);
			User user = new User(); 
			user.ReadJson(jobject);
		}
	}
}
