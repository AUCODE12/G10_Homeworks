using ProjectPost.Sevices;

namespace ProjectPost
{
    internal class Program
    {
        static void Main(string[] args)
        {  
        }
        
        public static void RunApp()
        {
            var postServce = new PostService();

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
                Console.WriteLine();
                Console.Write("Enter Choose: ");
                var option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                }

            }
        }
    }
}
