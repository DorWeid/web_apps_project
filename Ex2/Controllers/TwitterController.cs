using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ex2.Models;
using Tweetinvi;

namespace Ex2.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TwitterController : Controller
    {
        // POST api/Twitter/Tweet
        [HttpPost]
        public async Task<ActionResult> Tweet(TweetToBe tweet)
        {
            var tweetToBe = await TweetAsync.PublishTweet(tweet.Text);

            if (tweetToBe.IsTweetPublished)
            {
                return Json(new Dictionary<string, object> { { "url", tweetToBe.Url } });
            }

            return new HttpStatusCodeResult(500);

        }
    }
}