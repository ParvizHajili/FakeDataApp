
using Bogus;
using FakeDataApp;

AppDbContext dbContext = new AppDbContext();

#region User and Adress
//var addressFaker = new Faker<Address>("az")
//    .RuleFor(x => x.Id, x => x.Random.Guid())
//    .RuleFor(x => x.City, x => x.Address.City())
//    .RuleFor(x => x.StreetName, x => x.Address.StreetName())
//    .RuleFor(x => x.ZipCode, x => x.Address.ZipCode());

//var userFaker = new Faker<User>("az")
//    .RuleFor(x => x.Id, x => x.Random.Guid())
//    .RuleFor(x => x.Address, addressFaker)
//    .RuleFor(x => x.Age, x => x.Random.Int(18, 50))
//    .RuleFor(x => x.FirstName, x => x.Person.FirstName)
//    .RuleFor(x => x.LastName, x => x.Person.LastName)
//    .RuleFor(x => x.UserName, (x, y) => x.Internet.UserName(y.FirstName, y.LastName))
//    .RuleFor(x => x.Gender, x => x.PickRandom<Gender>())
//    .RuleFor(x => x.Email, x => x.Person.Email);


//var generatedData = userFaker.Generate(50);


//dbContext.Users.AddRange(generatedData);
//dbContext.SaveChanges();

#endregion

#region Products
var fakeProduct = new Faker<Product>()
    .RuleFor(x => x.Id, x => x.Random.Guid())
    .RuleFor(x => x.Name, x => x.Commerce.Product())
    .RuleFor(x => x.Quantity, x => x.Random.Int(1, 50000));

var generator = fakeProduct.Generate(5);

dbContext.Products.AddRange(generator);
dbContext.SaveChanges();
#endregion
Console.WriteLine("Completed");
