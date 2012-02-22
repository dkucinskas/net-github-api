using System;
using GithubApi.ObjectModel;
using Newtonsoft.Json.Linq;

namespace GithubApi.ObjectModel
{
	public class User : GithubObject
	{
		private string _gravatarID = null;
		private string _company = null;
		private string _name = null;
		private DateTime _createdAt = DateTime.MinValue;
		private string _location = null;
		private int _publicRepos = -1;
		private int _publicGists = -1;
		private string _blog = null;
		private int _following = -1;
		private int _ID = -1;
		private string _type = null;
		private int _followers = -1;
		private string _login = null;
		private string _email = null;
		//TODO: added
		private string _avatarUrl = null;
		private string _url = null;
		private bool _hireable = false;
		private string _bio = null;
		private string _htmlUrl = null;
		
		public User()
			:base()
		{
		}

		public string GravatarID
		{
			get { return this._gravatarID; }
			set { _gravatarID = value; }
		}

		public string Company
		{
			get { return this._company; }
			set { _company = value; }
		}
		
		public string Name
		{
			get { return this._name; }
			set { _name = value; }
		}

		public DateTime CreatedAt
		{
			get { return this._createdAt; }
			set { _createdAt = value; }
		}

		public string Location
		{
			get { return this._location; }
			set { _location = value; }
		}

		public int PublicRepoCount
		{
			get { return this._publicRepos; }
			set { _publicRepos = value; }
		}

		public int PublicGistCount
		{
			get { return this._publicGists; }
			set { _publicGists = value; }
		}

		public string Blog
		{
			get { return this._blog; }
			set { _blog = value; }
		}	

		public int FollowingCount
		{
			get { return this._following; }
			set { _following = value; }
		}

		public int ID
		{
			get { return this._ID; }
			set { _ID = value; }
		}	

		public string Type
		{
			get { return this._type; }
			set { _type = value; }
		}

		public int FollowersCount
		{
			get { return this._followers; }
			set { _followers = value; }
		}

		public string Login
		{
			get { return this._login; }
			set { _login = value; }
		}

		public string Email
		{
			get { return this._email; }
			set { _email = value; }
		}

		public string AvatarUrl
		{
			get { return this._avatarUrl; }
			set { _avatarUrl = value; }
		}

		public string Bio
		{
			get { return this._bio; }
			set { _bio = value; }
		}

		public bool Hireable
		{
			get { return this._hireable; }
			set { _hireable = value; }
		}

		public string HtmlUrl
		{
			get { return this._htmlUrl; }
			set { _htmlUrl = value; }
		}

		public string Url
		{
			get { return this._url; }
			set { _url = value; }
		}		
		public override void ReadJson(JObject obj)
		{
			base.ReadJson(obj);
			
			GravatarID = obj["gravatar_id"].Value<string>();
			Company = obj["company"].Value<string>();
			Name = obj["name"].Value<string>();
			CreatedAt = obj["created_at"].Value<DateTime>();
			Location = obj["location"].Value<string>();
			PublicRepoCount = obj["public_repos"].Value<int>();
			PublicGistCount = obj["public_gists"].Value<int>();
			Blog = obj["blog"].Value<string>();
			FollowingCount = obj["following"].Value<int>();
			ID = obj["id"].Value<int>();
			Type = obj["type"].Value<string>();
			FollowersCount = obj["followers"].Value<int>();
			Login = obj["login"].Value<string>();
			Email = obj["email"].Value<string>();
			AvatarUrl = obj["avatar_url"].Value<string>();
			Url = obj["url"].Value<string>();
			Hireable = obj["hireable"].Value<bool>();
			Bio = obj["bio"].Value<string>();
			HtmlUrl = obj["html_url"].Value<string>();
		}

		protected override void Dispose(bool disposing)
		{
			if (!IsDisposed) 
			{
				if (disposing) 
				{
					_company = null;
					_gravatarID = null;
					_name = null;
					_location = null;
					_blog = null;
					_type = null;
					_login = null;
					_email = null;
					_avatarUrl = null;
					_url = null;
					_bio = null;
					_htmlUrl = null;
				}
			}

			base.Dispose (disposing);
		}
	}
}



