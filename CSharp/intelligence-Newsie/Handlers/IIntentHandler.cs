﻿using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace Newsie.Handlers
{
    public interface IIntentHandler
    {
        Task Respond(IMessageActivity activity, LuisResult result);
    }
}
