using Builder.Business;

ProductDirector director = new ProductDirector();
var builder = new NewCustomerBuilder();
director.GenerateProduct(builder);
var model = builder.GetProduct();
Console.WriteLine(model.Name);   