using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace SausageBOT
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            new CommandHandler();
            // Token
            await _client.LoginAsync(TokenType.Bot, "TOKEN");

            await _client.StartAsync();

            _handler = new CommandHandler();

            await _handler.InitializeAsync(_client);
            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

    }

}
