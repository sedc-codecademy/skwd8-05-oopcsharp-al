using SEDC.Webinar.DataAccess;
using SEDC.Webinar.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Webinar.PostAPI
{
    public class PostClient
    {
        // URL: https://api.posts/posts/all
        public static List<Post> GetAll(string url)
        {
            try
            {
                if (url == "https://api.posts/posts/all")
                {
                    List<Post> allPost = Db.Posts();
                    return allPost;
                }
                else
                {
                    //Throw new bad request exception
                    throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                //Handle the exception thrown
                throw new NotImplementedException();
            }
        }

        public static Post Get(string url)
        {
            //URL: https://api.posts/posts/1

            try
            {
                int id = Convert.ToInt32(url.Split('/').ToList().TakeLast(1).FirstOrDefault());
                Post post = Db.Posts().Where(x => x.Id == id).SingleOrDefault();

                if(post != null)
                {
                    return post;
                }
                else
                {
                    //Throw new NotFound exception with status code 404
                    throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
