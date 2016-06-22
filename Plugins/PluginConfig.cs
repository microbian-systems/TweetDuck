﻿using System;
using System.Collections.Generic;

namespace TweetDck.Plugins{
    [Serializable]
    class PluginConfig{
        [field:NonSerialized]
        public event EventHandler<PluginChangedStateEventArgs> PluginChangedState;

        private readonly HashSet<string> Disabled = new HashSet<string>();

        public void SetEnabled(Plugin plugin, bool enabled){
            if ((enabled && Disabled.Remove(plugin.Identifier)) || (!enabled && Disabled.Add(plugin.Identifier))){
                if (PluginChangedState != null){
                    PluginChangedState(this,new PluginChangedStateEventArgs(plugin,enabled));
                }
            }
        }

        public bool IsEnabled(Plugin plugin){
            return !Disabled.Contains(plugin.Identifier);
        }
    }
}