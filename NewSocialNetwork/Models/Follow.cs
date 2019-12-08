using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.Models
{
    public class Follow
    {
        public string Id { get; set; }

        public virtual User Follower { get; set; }
        public string FollowerId { get; set; }
        public virtual User Following { get; set; }
        public string FollowingId { get; set; }

        public Follow(User follower, User following)
        {
            Follower = follower;
            FollowerId = follower.Id;
            Following = following;
            FollowingId = following.Id;
        }

        public Follow() { }
    }
}
