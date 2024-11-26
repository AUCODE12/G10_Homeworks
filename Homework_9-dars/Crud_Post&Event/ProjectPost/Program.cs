using ProjectPost.Models;
using ProjectPost.Sevices;


namespace ProjectPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunPostApp();
            //RunEventApp();
        }

        public static void RunPostApp()
        {
            var postService = new PostService();

            while (true)
            {
                Console.WriteLine("1. Add post");
                Console.WriteLine("2. Update post");
                Console.WriteLine("3. Delete post");
                Console.WriteLine("4. Get post");
                Console.WriteLine("5. GetByID post");
                Console.WriteLine("6. Add like post");
                Console.WriteLine("7. Add Comment post");
                Console.WriteLine("8. Add Viewer post");
                Console.WriteLine("9. Get post by comment: ");
                Console.WriteLine("10. Most like to post: ");
                Console.WriteLine("11. Most comment to post: ");
                Console.WriteLine("12. Most viewer to post: ");
                Console.WriteLine();
                Console.Write("Enter Choose: ");
                var option = int.Parse(Console.ReadLine());


                if (option == 1)
                {
                    var post = new Post();
                    Console.Write("Owner Name: ");
                    post.OwnerName = Console.ReadLine();
                    Console.Write("Description: ");
                    post.Description = Console.ReadLine();
                    Console.Write("Type: ");
                    post.Type = Console.ReadLine();
                    post.PostedTime = DateTime.Now;
                    Console.Write("Quantity Likes: ");
                    post.QuantityLikes = int.Parse(Console.ReadLine());
                    Console.Write("Comment: ");
                    var comment = Console.ReadLine();
                    postService.AddCommnetToPost(post.Id, comment);
                    Console.Write("Viewer Names: ");
                    var viewer = Console.ReadLine();
                    postService.AddViewerToPost(post.Id, viewer);

                    postService.AddPost(post);
                }
                else if (option == 2)
                {
                    var updatingPost = new Post();
                    Console.Write("Enter updating to id: ");
                    updatingPost.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Owner Name: ");
                    updatingPost.OwnerName = Console.ReadLine();
                    Console.Write("Description: ");
                    updatingPost.Description = Console.ReadLine();
                    Console.Write("Type: ");
                    updatingPost.Type = Console.ReadLine();
                    updatingPost.PostedTime = DateTime.Now;
                    Console.Write("Quantity Likes: ");
                    updatingPost.QuantityLikes = int.Parse(Console.ReadLine());
                    Console.Write("Comment: ");
                    var commentUpdate = Console.ReadLine();
                    postService.AddCommnetToPost(updatingPost.Id, commentUpdate);
                    Console.Write("Viewer Names: ");
                    var viewerUpdate = Console.ReadLine();
                    postService.AddViewerToPost(updatingPost.Id, viewerUpdate);

                    var requestUpdate = postService.UpdatePost(updatingPost);

                    if (requestUpdate is true)
                    {
                        Console.WriteLine("Updated");
                    }
                    else
                    {
                        Console.WriteLine("Not updated");
                    }
                }
                else if (option == 3)
                {
                    var post = new Post();
                    Console.Write("Enter deleting to id: ");
                    post.Id = Guid.Parse(Console.ReadLine());
                    var requestDelete = postService.DeletePost(post.Id);

                    if (requestDelete is true)
                    {
                        Console.WriteLine("Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Not deleted");
                    }
                }
                else if (option == 4)
                {
                    var posts = postService.GetAllPosts();
                    foreach (var post in posts)
                    {
                        var info = $"Id: {post.Id} \nOwner Name: {post.OwnerName} \nDescription: {post.Description} \nType: {post.Type} \nPosted Time: {post.PostedTime} \nQuantity Likes: {post.QuantityLikes} \nComments: {post.Comments} \nViewer Names: {post.ViewerNames}";
                        Console.WriteLine(info);
                    }
                }
                else if (option == 5)
                {
                    Console.Write("Enter get by id: ");
                    var id = Guid.Parse(Console.ReadLine());
                    var post = postService.GetPostById(id);
                    var info = $"Id: {post.Id} \nOwner Name: {post.OwnerName} \nDescription: {post.Description} \nType: {post.Type} \nPosted Time: {post.PostedTime} \nQuantity Likes: {post.QuantityLikes} \nComments: {post.Comments} \nViewer Names: {post.ViewerNames}";
                    Console.WriteLine(info);
                }
                else if (option == 6)
                {
                    Console.Write("Enter add like by id: ");
                    var id = Guid.Parse(Console.ReadLine());
                    var requestAddLike = postService.AddLike(id);
                    if (requestAddLike is true)
                    {
                        Console.WriteLine("Like bosdingiz");
                    }
                    else
                    {
                        Console.WriteLine("Xatolik yoki bunaqa post yo'q");
                    }
                }
                else if (option == 7)
                {
                    Console.Write("Enter add comment by id: ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter comment: ");
                    var newComment = Console.ReadLine();
                    var requestAddComment = postService.AddCommnetToPost(id, newComment);
                    if (requestAddComment is true)
                    {
                        Console.WriteLine("Comment qo'shildi");
                    }
                    else
                    {
                        Console.WriteLine("Xatolik yoki bunaqa post yo'q");
                    }
                }
                else if (option == 8)
                {
                    Console.Write("Enter add comment by id: ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter comment: ");
                    var viewerName = Console.ReadLine();
                    var requestAddViewer = postService.AddViewerToPost(id, viewerName);
                    if (requestAddViewer is true)
                    {
                        Console.WriteLine("Ko'rganingiz qo'shildi");
                    }
                    else
                    {
                        Console.WriteLine("Xatolik yoki bunaqa post yo'q");
                    }
                }
                else if (option == 9)
                {
                    Console.Write("Comment: ");
                    var comment = Console.ReadLine();
                    var requestPosts = postService.GetPostsByComment(comment);
                    foreach (var post in requestPosts)
                    {
                        var info = $"Id: {post.Id} \nOwner Name: {post.OwnerName} \nDescription: {post.Description} \nType: {post.Type} \nPosted Time: {post.PostedTime} \nQuantity Likes: {post.QuantityLikes} \nComments: {post.Comments} \nViewer Names: {post.ViewerNames}";
                        Console.WriteLine(info);
                    }
                }
                else if (option == 10)
                {
                    //like
                    var post = postService.GetMostLikedPost();
                    var info = $"Id: {post.Id} \nOwner Name: {post.OwnerName} \nDescription: {post.Description} \nType: {post.Type} \nPosted Time: {post.PostedTime} \nQuantity Likes: {post.QuantityLikes} \nComments: {post.Comments} \nViewer Names: {post.ViewerNames}";
                    Console.WriteLine(info);
                }
                else if (option == 11)
                {
                    //comment
                    var post = postService.GetMostCommentedPost();
                    var info = $"Id: {post.Id} \nOwner Name: {post.OwnerName} \nDescription: {post.Description} \nType: {post.Type} \nPosted Time: {post.PostedTime} \nQuantity Likes: {post.QuantityLikes} \nComments: {post.Comments} \nViewer Names: {post.ViewerNames}";
                    Console.WriteLine(info);
                }
                else if (option == 12)
                {
                    //viewer
                    var post = postService.GetMostViewedPost();
                    var info = $"Id: {post.Id} \nOwner Name: {post.OwnerName} \nDescription: {post.Description} \nType: {post.Type} \nPosted Time: {post.PostedTime} \nQuantity Likes: {post.QuantityLikes} \nComments: {post.Comments} \nViewer Names: {post.ViewerNames}";
                    Console.WriteLine(info);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void RunEventApp()
        {
            var eventService = new EventService();

            while (true)
            {
                Console.WriteLine("1. Add Event");
                Console.WriteLine("2. Get All Events");
                Console.WriteLine("3. Get Event By Id");
                Console.WriteLine("4. Get By Location");
                Console.WriteLine("5. Get Popular Event");
                Console.WriteLine("6. Get Max Targetted Event");
                Console.WriteLine("7. Updated Event");
                Console.WriteLine("8. Deleted Event");
                Console.WriteLine("9. Add Person To Event");
                Console.WriteLine("10. Add Tag to Event");
                Console.WriteLine();
                Console.Write("Enter Choose: ");
                var option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (option == 1)
                {
                    var eventAdd = new Event();
                    Console.Write("Title: ");
                    eventAdd.Title = Console.ReadLine();
                    Console.Write("Location: ");
                    eventAdd.Location = Console.ReadLine();
                    Console.Write("Date: ");
                    eventAdd.Date = DateTime.Now;
                    Console.Write("Description: ");
                    eventAdd.Description = Console.ReadLine();
                    Console.Write("Attendees: ");
                    var person = Console.ReadLine();
                    eventService.AddPersonToEvent(eventAdd.Id, person);
                    Console.Write("Tags: ");
                    var tag = Console.ReadLine();
                    eventService.AddTagToEvent(eventAdd.Id, tag);

                    eventService.AddEvent(eventAdd);
                }
                else if (option == 2)
                {
                    var allEvents = eventService.GetAllEvent();
                    foreach (var eventItem in allEvents)
                    {
                        var info = $"Id: {eventItem.Id} \nTitle: {eventItem.Title} \nLocation: {eventItem.Location} \nDate: {eventItem.Date} \nDescription: {eventItem.Description}";
                        Console.WriteLine(info);
                        foreach (var person in eventItem.Attendees)
                        {
                            var infoPerson = $"{person}, ";
                            Console.Write(infoPerson);
                        }
                        foreach (var tag in eventItem.Tags)
                        {
                            var infoTag = $"{tag}, ";
                            Console.Write(infoTag);
                        }
                    }
                }
                else if (option == 3)
                {
                    var id = Guid.NewGuid();
                    var eventItem = eventService.GetEventById(id);
                    var info = $"Id: {eventItem.Id} \nTitle: {eventItem.Title} \nLocation: {eventItem.Location} \nDate: {eventItem.Date} \nDescription: {eventItem.Description} \n";
                    Console.WriteLine(info);
                    foreach (var person in eventItem.Attendees)
                    {
                        var infoPerson = $"{person}, ";
                        Console.Write(infoPerson);
                    }
                    foreach (var tag in eventItem.Tags)
                    {
                        var infoTag = $"{tag}, ";
                        Console.Write(infoTag);
                    }
                }
                else if (option == 4)
                {
                    Console.Write("Location: ");
                    var location = Console.ReadLine();
                    var eventItems = eventService.GetEventsByLocation(location);
                    foreach (var eventItem in eventItems)
                    {
                        var info = $"Id: {eventItem.Id} \nTitle: {eventItem.Title} \nLocation: {eventItem.Location} \nDate: {eventItem.Date} \nDescription: {eventItem.Description}";
                        Console.WriteLine(info);
                        foreach (var person in eventItem.Attendees)
                        {
                            var infoPerson = $"{person}, ";
                            Console.Write(infoPerson);
                        }
                        foreach (var tag in eventItem.Tags)
                        {
                            var infoTag = $"{tag}, ";
                            Console.Write(infoTag);
                        }
                    }
                }
                else if (option == 5)
                {
                    var eventItem = eventService.GetPopularEvent();
                    var info = $"Id: {eventItem.Id} \nTitle: {eventItem.Title} \nLocation: {eventItem.Location} \nDate: {eventItem.Date} \nDescription: {eventItem.Description}";
                    Console.WriteLine(info);
                    foreach (var person in eventItem.Attendees)
                    {
                        var infoPerson = $"{person}, ";
                        Console.Write(infoPerson);
                    }
                    foreach (var tag in eventItem.Tags)
                    {
                        var infoTag = $"{tag}, ";
                        Console.Write(infoTag);
                    }
                }
                else if (option == 6)
                {
                    var eventItem = eventService.GetMaxTaggedEvent();
                    var info = $"Id: {eventItem.Id} \nTitle: {eventItem.Title} \nLocation: {eventItem.Location} \nDate: {eventItem.Date} \nDescription: {eventItem.Description}";
                    Console.WriteLine(info);
                    foreach (var person in eventItem.Attendees)
                    {
                        var infoPerson = $"{person}, ";
                        Console.Write(infoPerson);
                    }
                    foreach (var tag in eventItem.Tags)
                    {
                        var infoTag = $"{tag}, ";
                        Console.Write(infoTag);
                    }
                }
                else if (option == 7)
                {
                    var eventUpdate = new Event();
                    Console.Write("Enter Update In Id: ");
                    eventUpdate.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Title: ");
                    eventUpdate.Title = Console.ReadLine();
                    Console.Write("Location: ");
                    eventUpdate.Location = Console.ReadLine();
                    Console.Write("Date: ");
                    eventUpdate.Date = DateTime.Now;
                    Console.Write("Description: ");
                    eventUpdate.Description = Console.ReadLine();
                    Console.Write("Attendees: ");
                    var person = Console.ReadLine();
                    eventService.AddPersonToEvent(eventUpdate.Id, person);
                    Console.Write("Tags: ");
                    var tag = Console.ReadLine();
                    eventService.AddTagToEvent(eventUpdate.Id, tag);

                    eventService.UpdateEvent(eventUpdate);
                }
                else if (option == 8)
                {
                    Console.Write("Enter Delete In Id: ");
                    var id = Guid.Parse(Console.ReadLine());
                    var requestDelete = eventService.DeleteEvent(id);
                    if (requestDelete is true)
                    {
                        Console.WriteLine("Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Not deleted");
                    }
                }
                else if (option == 9)
                {
                    Console.Write("Enter Id: ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Person:");
                    var person = Console.ReadLine();
                    var requestAddPerson = eventService.AddPersonToEvent(id, person);
                    if (requestAddPerson is true)
                    {
                        Console.WriteLine("Added Person!");
                    }
                    else
                    {
                        Console.WriteLine("Not added person");
                    }
                }
                else if (option == 10)
                {
                    Console.Write("Enter Id: ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Tag:");
                    var tag = Console.ReadLine();
                    var requestAddTag = eventService.AddTagToEvent(id, tag);
                    if (requestAddTag is true)
                    {
                        Console.WriteLine("Added Tag!");
                    }
                    else
                    {
                        Console.WriteLine("Not added tag");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
