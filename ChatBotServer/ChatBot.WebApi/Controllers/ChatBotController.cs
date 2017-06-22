using ChatBot.Data.Data;
using ChatBot.Data.Entities;
using System.Collections.Generic;
using System.Linq;
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
            List<Problem> problems = chatbotContext.Problems.ToList();


            return Ok(problems);
        }
    }
}
