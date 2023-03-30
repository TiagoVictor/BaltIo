using Balta.ContentContext;
using Balta.SubscriptionContext;

var articles = new List<Article>();

articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

//foreach (var article in articles)
//{
//    Console.WriteLine(article.Id);
//    Console.WriteLine(article.Title);
//    Console.WriteLine(article.Url);
//}

var courser = new List<Course>();

var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-apsnet");

courser.Add(courseOOP);
courser.Add(courseCsharp);
courser.Add(courseAspNet);

var carreers = new List<Career>();
var careerDotNet = new Career("Especialisita .NET", "especialista-dotnet");

var carrerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
var carrerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
var carrerItem3 = new CareerItem(3, "Aprenda .Net", "", courseAspNet);

careerDotNet.Items.Add(carrerItem2);
careerDotNet.Items.Add(carrerItem);
careerDotNet.Items.Add(carrerItem3);
carreers.Add(careerDotNet);

foreach (var career in carreers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}

var paypalSubscription = new PayPalSubscription();
var student = new Student();

student.CreateSubscription(paypalSubscription);