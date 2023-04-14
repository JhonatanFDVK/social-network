using socialnetwork.Entities;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Title: ");
        string postTitle = Console.ReadLine();
        Console.WriteLine("Content:");
        string content = Console.ReadLine();
        Console.Write("Likes: ");
        int likes = int.Parse(Console.ReadLine());

        Post post1 = new Post(DateTime.Now, postTitle, content, likes);

        Comment comment1 = new Comment("Have a nice trip");
        Comment comment2 = new Comment("Wow that's awesome!");

        post1.AddComment(comment1);
        post1.AddComment(comment2);


        Console.Write("Title: ");
        string postTitle2 = Console.ReadLine();
        Console.WriteLine("Content:");
        string content2 = Console.ReadLine();
        Console.Write("Likes: ");
        int likes2 = int.Parse(Console.ReadLine());

        Post post2 = new Post(DateTime.Now, postTitle2, content2, likes2);

        Comment comment3 = new Comment("Have a nice trip");
        Comment comment4 = new Comment("Wow that's awesome!");

        post2.AddComment(comment3);
        post2.AddComment(comment4);

        Console.WriteLine(post1);
        Console.WriteLine(post2);

    }
}