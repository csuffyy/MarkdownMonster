﻿using System.Collections.Generic;

namespace WebLogAddin.MetaWebLogApi
{
    public interface IMetaWeblogWrapper
    {
        bool DeletePost(int postid);        
        IEnumerable<Category> GetCategories();
        Post GetPost(string postID);
        IEnumerable<Post> GetRecentPosts(int numberOfPosts);
        IEnumerable<UserBlog> GetUserBlogs();
        UserInfo GetUserInfo();
        MediaObjectInfo NewMediaObject(MediaObject mediaObject);
        int NewPost(Post post, bool publish);
        bool EditPost(Post post, bool publish);
    }
}