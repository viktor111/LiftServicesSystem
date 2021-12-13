using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Settings
{
    public class MessageQueueSettings
    {
        public MessageQueueSettings(
            string host,
            string userName,
            string password)
        {
            this.Host = host;
            this.UserName = userName;
            this.Password = password;
        }

        public string Host { get; }

        public string UserName { get; }

        public string Password { get; }
    }
}
