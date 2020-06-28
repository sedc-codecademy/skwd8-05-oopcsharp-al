using SEDC.Webinar.DomainModels;
using SEDC.Webinar.PostAPI;
using SEDC.Webinar.PostAPI.ApiExceptionHandlers;
using System;
using System.Collections.Generic;

namespace SEDC.Webinar.ApiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string allPostUrl = "https://api.posts/posts/all";
                string singlePostUrl = "https://api.posts/posts/martin";

                List<Post> allPosts = PostClient.GetAll(allPostUrl);

                Post singlePost = PostClient.Get(singlePostUrl);

                allPosts.ForEach(x =>
                {
                    Console.WriteLine($"Title: {x.Title}");
                    Console.WriteLine($"Content: {x.Content}");
                    Console.WriteLine($"Post by: {x.CreatedBy}");
                    Console.WriteLine("--------------------------------");
                });

                Console.WriteLine("---------------- Single post with id: 1 -------------------");
                Console.WriteLine($"Title: {singlePost.Title}");
                Console.WriteLine($"Content: {singlePost.Content}");
                Console.WriteLine($"Post by: {singlePost.CreatedBy}");
                Console.WriteLine("--------------------------------");

            }
            catch (BadRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Message: {ex.Message} | StatusCode: {ex.StatusCode}");
            }
            catch(NotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Message: {ex.Message} | StatusCode: {ex.StatusCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }


            Console.ReadLine();
        }
    }
}
