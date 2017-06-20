using ChatBot;
using ChatBot.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatBot.WebApi.Controllers
{
    [RoutePrefix("api/chatbot")]
    public class ChatBotController : ApiController
    {
        ChatBotContext chatbotContext { get; set; }

        public ChatBotController()
        {
            chatbotContext = new ChatBotContext();
        }

        [Route("GetAllProblems")]
        public IHttpActionResult GetAllProblemTest()
        {
            
            return Ok(chatbotContext.Problems.ToList());
        }
    }
}
