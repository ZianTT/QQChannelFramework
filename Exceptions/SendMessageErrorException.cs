﻿using System;
namespace QQChannelFramework.Exceptions
{
    public class SendMessageErrorException : Exception
    {
        public SendMessageErrorException() : base("发送消息出现错误")
        {
        }
    }
}

