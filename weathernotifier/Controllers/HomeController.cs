using System;
using Microsoft.AspNetCore.Mvc;
//using System.Net;
//using System.Collections.Generic;
//using System.Diagnostics;
//using weathernotifier.Models;
//using Newtonsoft.Json;
//using Discord;
//using Discord.Webhook;
//using System.IO;
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
        public ActionResult index(string temperature)
        {
            DiscordWebhook hook = new DiscordWebhook();
            hook.Url = "https://discordapp.com/api/webhooks/948481501618655292/JsWWzREh2NFtq30Lhl9Kniz6EoNnSI1AUoE4b42V0OHFuKEncrrzGJtVLk4Yl-Wa3QgU";
            DiscordMessage message = new DiscordMessage();
            message.Content = "Temperature : " + temperature + "c" ;

            DiscordEmbed embed = new DiscordEmbed(); 
            embed.Fields = new List<EmbedField>();

            DateTime today = DateTime.Today;
            var Today = today.DayOfWeek.ToString();

            if (Today == "Monday")
            {
                embed.Fields.Add(new EmbedField() { Name = "Temperature : ", Value = temperature + "c", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "1 - Riverside", Value = "Room - 004, Time - 12PM - 02PM", InLine = false });
            }
            else if (Today == "Tuesday")
            {
                embed.Fields.Add(new EmbedField() { Name = "Temperature : ", Value = temperature + "c", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "333 - Riverside", Value = "Room - 205, Time - 11AM - 12PM", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "333 - Riverside", Value = "Room - 212, Time - 12PM - 2PM", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "333 - Riverside", Value = "Room - 206, Time - 04PM - 06PM", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "1 - Riverside", Value = "Room - 008, Time - 06PM - 08PM", InLine = false });

            }
            else if (Today == "Wednesday")
            {
                embed.Fields.Add(new EmbedField() { Name = "Temperature : ", Value = temperature + "c", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "333 - Riverside", Value = "Room - 008, Time - 04PM - 07PM", InLine = false });

            }
            else if (Today == "Thursday")
            {
                embed.Fields.Add(new EmbedField() { Name = "Temperature : ", Value = temperature + "c", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "333 - Riverside", Value = "Room - 206, Time - 11AM - 02PM", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "1 - Riverside", Value = "Room - 007, Time - 02PM - 04PM", InLine = false });

            }
            else
            {
                embed.Fields.Add(new EmbedField() { Name = "Temperature : ", Value = temperature + "c", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "zeklaman", Value = "Room-5, Time - 04PM - 06PM", InLine = false });
                embed.Fields.Add(new EmbedField() { Name = "zeklaman", Value = "Room-5, Time - 06PM - 08PM", InLine = false });
                //embed.Fields.Add(new EmbedField() { Name = "Field Name 2", Value = "Field Value 2", InLine = true });
            }


            message.Embeds = new List<DiscordEmbed>();
            message.Embeds.Add(embed);
            //DiscordEmbed embed = new DiscordEmbed();
            //embed.Title = "Embed title";
            //embed.Description = "Embed description";
            //embed.Url = "Embed Url";
            //embed.Timestamp = DateTime.Now;

            hook.Send(message);

            return View();
        }
    }

 
}