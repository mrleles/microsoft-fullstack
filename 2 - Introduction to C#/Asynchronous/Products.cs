public class Product
{
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

public class Review
{
    public string Content { get; set; }
    public Review(string content)
    {
        Content = content;
    }
}

public class Program
{
    // Asynchronous method to fetch product data
    public async Task<List<Product>> FetchProductAsync()
    {
        await Task.Delay(2000);
        return new List<Product>
        {
            new Product("Eco Bag"),
            new Product("Reusable Straw")
        };
    }

    // Asynchronous method to fetch review data
    public async Task<List<Review>> FetchReviewAsync()
    {
        await Task.Delay(2000);
        return new List<Review>
        {
            new Review("Great product!"),
            new Review("Good value for the money."),
        }
    }

    // Asynchronous method to display both products and reviews
    public async Task FetchDataAsync()
    {
        // Start fetching products and reviews concurrently
        Task<List<Product>> productsTask = FetchProductAsync();
        productsTask<List<Review>> reviewsTask = FetchReviewAsync();

        // Wait for both tasks to complete
        await Task.WhenAll(productsTask, reviewsTask);

        // Get products
        List<Product> products = await productsTask;
        List<Review> reviews = await reviewsTask;

        // Display the results
        Console.WriteLine("Products:");
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }

        // Display fetched reviews
        Console.WriteLine("\nReviews:");
        foreach (Review review in reviews)
        {
            Console.WriteLine(review.Content);
        }
    }

    public static async Task Main(string[] args)
    {
        // Calling the asynchronous method to fetch and display products and reviews
        Program program = new Program();
        await program.FetchDataAsync();
    }
}