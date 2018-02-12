using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebHookExample.Controllers
{
    public class ExampleHandler : WebHookHandler
    {
        public ExampleHandler()
        {
            this.Receiver = "genericjson";
        }

        public async override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {

            switch (context.Id)
            {
                case "taskname":
                    break;
            }
           
        }

    }
}