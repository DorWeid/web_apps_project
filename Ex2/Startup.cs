using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Tweetinvi;

[assembly: OwinStartup(typeof(Ex2.Startup))]

namespace Ex2
{
	public class Startup
	{
		private const string TWITTER_CONSUMER_ID = "LYn500pfaecttQNPal884drI0";
		private const string TWITTER_CONSUMER_SECRET = "rWg2HzMhLku9EizCLbrb5CYWQM9gWAsnSqZgkx8pjuRBLU4s9w";
		private const string TWITTER_ACCESS_TOKEN = "925701208962162688-jr3KSspfMYYY1brKM2uKdVRLeNEwmLN";
		private const string TWITTER_ACCESS_TOKEN_SECRET = "ICckSk7QzWMHOC6062dAO2GNoJP5sHP5rADWLRtCLDV6V";
		
		public void Configuration(IAppBuilder app)
		{
			Auth.SetUserCredentials(TWITTER_CONSUMER_ID,
									TWITTER_CONSUMER_SECRET,
									TWITTER_ACCESS_TOKEN,
									TWITTER_ACCESS_TOKEN_SECRET);
		}
	}
}
