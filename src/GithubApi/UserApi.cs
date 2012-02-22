using System;
using System.Web;

namespace GithubApi
{
	public class UserApi : Api
	{
		public UserApi()
			: base()
		{
		}
		
		public UserApi(GithubUrl url)
			:base(url)
		{	
		}
		
		public string GetUser(string username)
		{
			return Get("users/" + HttpUtility.UrlEncode(username));
		}
		
		/*
		public string Search(string username)
		{
			return Get("user/search/" + HttpUtility.UrlEncode(username));
		}
		
		public string GetFollowing(string username)
		{
			
        	return Get("user/show/" + HttpUtility.UrlEncode(username) + "/following");
		}
		
		public string GetFollowers(string username)
		{
			return Get("user/show/" + HttpUtility.UrlEncode(username) + "/followers");
		}
		
		public string GetWatchedRepos(string username)
		{
			return Get("repos/watched/" + HttpUtility.UrlEncode(username));
		}*/
		
		//TODO: missing the following methods
		// update, follow, unFollow, getKeys, addKey, removeKey, getEmails, addEmail, removeEmail
		//:~

	}
}

