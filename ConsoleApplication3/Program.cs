using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                string appID = "65b69925-ee55-42d1-99fb-68845ef55d86";
                string appPW = "OcB5EDRhBonY0rRpdLG3V9o";
                ChannelAccount botAccount = new ChannelAccount(name: "Tim_Boot_Test", id: "1022754904501872");
                ChannelAccount userAccount = new ChannelAccount(name: "摰�孕 �㷍", id: "1203227929772025");

                var connector = new ConnectorClient(new Uri("https://facebook.botframework.com"), appID, appPW);
                var conversationId = await connector.Conversations.CreateDirectConversationAsync(botAccount, userAccount);
                var msg = new Activity()
                {
                    Type = ActivityTypes.Message,
                    From = botAccount,
                    ChannelId = "facebook",
                    Recipient = userAccount,
                    Text = "push1",
                    Conversation = new ConversationAccount(id: conversationId.Id)
                };

                await connector.Conversations.SendToConversationAsync(msg);
            }).Wait();
        }
    }
}
