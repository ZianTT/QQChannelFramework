﻿using System;
using QQChannelFramework.Api.Types;

namespace QQChannelFramework.Api.Raws
{
    /// <summary>
    /// 源Api信息 - 创建子频道
    /// </summary>
    public struct RawCreateChildChannelApi : Base.IRawApiInfo
    {
        public string Version => "1.0";

        public bool NeedParam => true;

        public string Url => "/guilds/{guild_id}/channels";

        public MethodType Method => MethodType.POST;
    }
}

