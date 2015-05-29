using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Timers;

namespace LifeSubsMetro
{
    class MessageHandler
    {
        private Timer timer;
        GroupConversations gcs;
        ApiHandler apiHandler = new ApiHandler();

        public MessageHandler(GroupConversations gc)
        {
            this.gcs = gc;
            //Create a timer with a one second interval
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
        }

        #region timer
        /// <summary>
        /// Elapsed event for Timer timer
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            apiHandler.getMessages(gcs.timeId, gcs);
        }

        public void stopTimer()
        {
            timer.Stop();
        }
        #endregion
    }
}
