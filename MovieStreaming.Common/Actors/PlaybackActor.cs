﻿using System;
using Akka.Actor;

namespace MovieStreaming.Common.Actors
{
    public class PlaybackActor : ReceiveActor
    {     
        public PlaybackActor()
        {           
            Context.ActorOf(Props.Create<UserCoordinatorActor>(), "UserCoordinator");
            Context.ActorOf(Props.Create<PlaybackStatisticsActor>(), "PlaybackStatistics");        
        }




        #region Lifecycle hooks
        protected override void PreStart()
        {
            ColorConsole.WriteLineGreen("PlaybackActor PreStart");
        }

        protected override void PostStop()
        {
            ColorConsole.WriteLineGreen("PlaybackActor PostStop");
        }

        protected override void PreRestart(Exception reason, object message)
        {
            ColorConsole.WriteLineGreen("PlaybackActor PreRestart because: " + reason);

            base.PreRestart(reason, message);
        }

        protected override void PostRestart(Exception reason)
        {
            ColorConsole.WriteLineGreen("PlaybackActor PostRestart because: " + reason);

            base.PostRestart(reason);
        } 
        #endregion
    }
}
