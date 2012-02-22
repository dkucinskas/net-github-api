using System;
using GithubApi;
using GithubApi.ObjectModel;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class User_Test
	{
		[Test]
		public void Show_ValidUserName_ReturnUser()
		{
			UserApi userApi = new UserApi();
			string result = userApi.GetUser("dkucinskas");
			JObject jobject = JObject.Parse(result);
			
			using (User user = new User())
			{
				user.ReadJson(jobject);
				
				Assert.IsNotNull(user);
				Assert.IsNotNull(user.GravatarID);
				Assert.IsNull(user.Company);
				Assert.AreEqual("Darius Kucinskas", user.Name);
				Assert.Greater(user.CreatedAt, DateTime.MinValue);
				Assert.IsNotNull(user.Location);
				Assert.Greater(user.PublicRepoCount, -1);
				Assert.Greater(user.PublicGistCount, -1);
				Assert.AreEqual("http://blog-of-darius.blogspot.com", user.Blog);
				Assert.Greater(user.FollowingCount, -1);
				Assert.Greater(user.ID, -1);
				Assert.AreEqual("User", user.Type);
				Assert.Greater(user.FollowersCount, -1);
				Assert.AreEqual("dkucinskas", user.Login);
				Assert.AreEqual("d.kucinskas@gmail.com", user.Email);
				Assert.IsNotNull(user.AvatarUrl);
				Assert.IsNotNull(user.Url);
				Assert.AreEqual(false, user.Hireable);
				Assert.IsNull(user.Bio);
				Assert.IsNotNull(user.HtmlUrl);
			}
			
			jobject = null;
			result = null;
		}
	}
}

