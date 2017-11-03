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
    public class TwitterController : Controller
    {
		// GET: Twitter/Tweet
		public ActionResult TweetPage()
		{
			return View("~/Views/Admin/Tweet.cshtml");
		}

		// POST Twitter/Tweet
		[HttpPost]
        public ActionResult TweetUpdate(string text)
        {
			try
			{
				var tweetToBe = Tweet.PublishTweet(text);

				if (tweetToBe.IsTweetPublished)
				{
					return Json(new Dictionary<string, object> { { "url", tweetToBe.Url } });
				}
				

			}
			catch (Exception ex)
			{
				return new HttpStatusCodeResult(500, ExceptionHandler.GetLastException().TwitterDescription);
			}
			return new HttpStatusCodeResult(500);
		}
    }
}