using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Page
    {
        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo pageInfo { get; set; }
        public User[] users { get; set; }
        public Media[] media { get; set; }
        //public Character[] characters { get; set; }
        public Staff[] staff { get; set; }
        public Studio[] studios { get; set; }
        public MediaList[] mediaList { get; set; }
        public AiringSchedule[] airingSchedules { get; set; }
        //public  notifications(): [NotificationUnion]
        public User[] followers { get; set; }
        public User[] followings { get; set; }
        //public PageInfo activities(): [ActivityUnion]
        public ActivityReply[] activityReplies { get; set; }
        public Thread[] threads { get; set; }
        public ThreadComment[] threadComments { get; set; }
        public Review[] reviews { get; set; }
    }
}
