using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using weathernotifier.Models;
using Newtonsoft.Json;
using Discord;
using Discord.Webhook;
using System.IO;
using CSharpDiscordWebhook.NET.Discord;

namespace weathernotifier.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult index(string temp)
        {
            DiscordWebhook hook = new DiscordWebhook();
            hook.Url = "https://discordapp.com/api/webhooks/948481501618655292/JsWWzREh2NFtq30Lhl9Kniz6EoNnSI1AUoE4b42V0OHFuKEncrrzGJtVLk4Yl-Wa3QgU";
            DiscordMessage message = new DiscordMessage();
            message.Content = temp + ", ping";

            DiscordEmbed embed = new DiscordEmbed();
            embed.Title = "Embed title";
            embed.Description = "Embed description";
            embed.Url = "Embed Url";
            embed.Timestamp = DateTime.Now;

            hook.Send(message);

            return View();
        }
    }
}