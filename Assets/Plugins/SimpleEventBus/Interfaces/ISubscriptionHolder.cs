﻿using Plugins.SimpleEventBus.Events;

namespace SimpleEventBus
{
    public interface ISubscriptionHolder
    {
        void Invoke(EventBase eventBase);
    }
}