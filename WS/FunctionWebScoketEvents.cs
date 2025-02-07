﻿using System;
using QQChannelFramework.Models;
using QQChannelFramework.Models.MessageModels;
using QQChannelFramework.Models.WsModels;

namespace QQChannelFramework.WS;

partial class FunctionWebSocket
{
    public delegate void GuildDelegate(WsGuild guild);
    public delegate void ChildChannelDelegate(WsChildChannel childChannel);
    public delegate void MemberDelegate(MemberWithGuildID memberWithGuildID);
    public delegate void MessageDelegate(Message message);
    public delegate void MessageReactionDelegate(MessageReaction messageReactionInfo);

    /// <summary>
    /// <para>触发时机: </para>
    /// <para>机器人被加入到某个频道的时候</para>
    /// </summary>
    public event GuildDelegate BotAreAddedToTheGuild;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>频道信息变更</para>
    /// </summary>
    public event GuildDelegate GuildInfoChange;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>频道被解散</para>
    /// <para>机器人被移除</para>
    /// </summary>
    public event GuildDelegate BotBeRemoved;

    /// <summary>
    /// <para>触发时机: </para>
    /// <para>子频道被创建</para>
    /// </summary>
    public event ChildChannelDelegate ChildChannelCreated;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>子频道信息变更</para>
    /// </summary>
    public event ChildChannelDelegate ChildChannelInfoChange;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>子频道被删除</para>
    /// </summary>
    public event ChildChannelDelegate ChildChannelBeRemoved;

    /// <summary>
    /// <para>触发时机: </para>
    /// <para>新成员加入频道</para>
    /// </summary>
    public event MemberDelegate NewMemberJoin;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>成员信息变更</para>
    /// </summary>
    public event MemberDelegate MemberInfoChange;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>成员退出频道</para>
    /// </summary>
    public event MemberDelegate MemberExistGuild;

    /// <summary>
    /// <para>触发时机: </para>
    /// <para>用户发送消息，并且@当前机器人</para>
    /// </summary>
    public event MessageDelegate ReceivedAtMessage;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>用户发送消息时 (仅私域机器人可用)</para>
    /// </summary>
    public event MessageDelegate ReceivedUserMessage;

    /// <summary>
    /// <para>触发时机: </para>
    /// <para>收到事件消息时</para>
    /// </summary>
    public event ReceiveDelegate OnDispatch;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>心跳发送成功时</para>
    /// </summary>
    public event NormalDelegate HeartbeatSendSuccess;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>心跳中断</para>
    /// </summary>
    public event NormalDelegate HeartbeatBreak;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>鉴权失败时</para>
    /// </summary>
    public event NormalDelegate AuthenticationError;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>鉴权成功时</para>
    /// </summary>
    public event NormalDelegate AuthenticationSuccess;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>正在重连</para>
    /// </summary>
    public event NormalDelegate Reconnecting;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>重连事件补发完毕时</para>
    /// </summary>
    [Obsolete("该事件暂时停用",true)]
    public event NormalDelegate Resumed;

    /// <summary>
    /// <para>触发时机: </para>
    /// <para>消息被用户添加表情态</para>
    /// </summary>
    public event MessageReactionDelegate MessageReactionIsAdded;
    /// <summary>
    /// <para>触发时机: </para>
    /// <para>消息表情态被用户取消(移除)</para>
    /// </summary>
    public event MessageReactionDelegate MessageReactionIsRemoved;
}