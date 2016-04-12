using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class EventHandlerExtensions
    {
        /// <summary>
        /// 触发事件
        /// </summary>
        public static void RaiseEvent(this EventHandler @this, object sender)
        {
            if (@this != null)
            {
                @this(sender, null);
            }
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        public static void Raise(this EventHandler handler, object sender, EventArgs e)
        {
            if (handler != null)
                handler(sender, e);
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender) where TEventArgs : EventArgs
        {
            if (@this != null)
            {
                @this(sender, Activator.CreateInstance<TEventArgs>());
            }
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender, TEventArgs e) where TEventArgs : EventArgs
        {
            if (@this != null)
            {
                @this(sender, e);
            }
        }
    }
}
