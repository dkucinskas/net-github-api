using System;
using System.Net;
using System.IO;

namespace GithubApi
{
	public class Api
	{
		private GithubUrl _githubUrl = null;
		
		public Api()
		{
			_githubUrl = new GithubUrl();
		}
			
		public Api(GithubUrl url)
		{
			_githubUrl = url;
		}
		
		protected string Get(string path)
		{
			string result = null;
			
			GithubUrl url = GithubUrl.Copy(_githubUrl);
			
			url.Path = path;
			
			string fullURL = url.GetURL();
			
			HttpWebRequest request = WebRequest.Create(fullURL) as HttpWebRequest;
			request.Method = "GET";
			request.Proxy = null;
			request.UserAgent = url.UserAgent;
			request.ReadWriteTimeout = url.Timeout;
			
			//JavaScriptSerializer jserializer = new JavaScriptSerializer();
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse) 
			{
				using (StreamReader reader = new StreamReader(response.GetResponseStream())) 
				{
					result = reader.ReadToEnd();
						
					/*UserList userlist = jserializer.Deserialize<UsersList>(str);
						if (userlist != null && userlist.users != null && userlist.users.Count > 0)
						{
							for(int i = 0; i  < userlist.users.Count; i++)
							{
								Console.WriteLine(string.Format("{0}, {1}, {2}, {3}", 
								    userlist.users[i].Id, userlist.users[i].Name, userlist.users[i].FullName, u.Created));
								
							}
						}*/
					//Console.Write (str);
				}
			}
			
			request = null;
			return result;
		}
	}
}

