﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQ.Framework.Packets.Receive.Message;
using QQ.Framework.Sockets;

namespace QQ.Framework.Domains.Commands.ReceiveCommands.Login
{
    /// <summary>
    /// 收到QQ好友消息
    /// </summary>
    [ReceivePacketCommand(QQCommand.Message0x00CE)]
    public class ReceiveQQFriendMessagesCommand : ReceiveCommand<Receive_0x00CE>
    {
        /// <summary>
        /// 收到QQ好友消息
        /// </summary>
        public ReceiveQQFriendMessagesCommand(byte[] data, QQClient client) : base(data, client)
        {
            _packet = new Receive_0x00CE(data, client.QQUser);
            _event_args = new QQEventArgs<Receive_0x00CE>(client, _packet);
        }

        public override void Process()
        {
            _client.OnReceive_0x00CE(_event_args);
            
        }
    }
}
