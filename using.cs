using System.Net.Http;

using (HttpClient client = new HttpClient())
{
	string apiUrl = @"URL: https://v2.jokeapi.dev/joke/Any?blacklistFlags=religious,political,racist,explicit";

	string response = await Client.GetStringAsync(apiUrl);
	}
}
