using System.Security.Cryptography;
using OOPTask9A;
DateTime today = DateTime.Now;

List<Client> clients = new List<Client>()
{
    new Client(1,"Paula",Countries.Finland),
    new Client(2,"Reijo",Countries.Sweden),
    new Client(3,"Matti",Countries.Norway),
    new Client(4,"Minna",Countries.Iceland),
    new Client(5,"Sanna",Countries.Iceland),
    new Client(6,"Joe",Countries.Iceland),
};

List<Product> products = new List<Product>()
{
    new Product(1,"Citrus Press"),
    new Product(2,"Pepper Mill"),
    new Product(3,"Espresso Machine"),
    new Product(4,"Barbecue Grill"),
};

List<PlacedOrder> placedOrders = new List<PlacedOrder>()
{
    new PlacedOrder(1,1),
    new PlacedOrder(2,2),
    new PlacedOrder(3,3),
    new PlacedOrder(4,4),
    new PlacedOrder(5,5),
    new PlacedOrder(6,1),
};

List<ProductOrder> productOrders = new List<ProductOrder>()
{
    //Paula, first
    new ProductOrder(1,1,1,true,today.AddMonths(-1).AddDays(6)),
    //Reijo
    new ProductOrder(2,2,2,true,today.AddMonths(-1).AddDays(5)),
    //Matti
    new ProductOrder(3,3,1,false,today.AddMonths(-1).AddDays(-5)),
    //Minna
    new ProductOrder(4,4,3,true,today.AddMonths(-1).AddDays(4)),
    //Sanna
    new ProductOrder(5,1,1,true,today.AddMonths(-1).AddDays(3)),
    //Paula,Second
    new ProductOrder(6,2,2,true,today.AddMonths(1).AddDays(-6)),
};


//var clientsInIceland = from cli in clients
//                       where cli.Country == Countries.Iceland
//                       select cli;

//foreach (var item in clientsInIceland)
//{
//    Console.WriteLine("Name: " + item.ClientName + ", Country: " + item.Country);
//}

Countries country = Countries.Iceland;

//list client details

//var wanted = from cli in clients where cli.Country == country join plaOrd in placedOrders on cli.Id equals plaOrd.ClientId
//             join proOrd in productOrders on plaOrd.Id equals proOrd.PlacedOrderId
//             join pro in products
//             on proOrd.ProductId equals pro.Id
//             select new
//             {
//                 cli.ClientName,
//                 cli.Country,
//                 pro.ProductName
//             };
//foreach(var item in wanted)
//{
//    Console.WriteLine("Client: "+item.ClientName+",Country: "+item.Country+", product: "+ item.ProductName);
//}

//var wanted = (from cli in clients
//              join plaOrd in placedOrders on cli.Id equals plaOrd.ClientId
//              join proOrd in productOrders on plaOrd.Id equals proOrd.PlacedOrderId
//              join pro in products on proOrd.ProductId equals pro.Id

//              orderby proOrd.DateOfShipping descending

//              select new
//              {
//                  cli.ClientName,
//                  pro.ProductName,
//                  proOrd.DateOfShipping
//              });
//foreach (var item in wanted)
//{
//    Console.WriteLine("Date of Shipping: " + item.DateOfShipping.ToString("D") + ", client: " + item.ClientName + ", product: " + item.ProductName);
//}



//Latest order
//var wanted = (from cli in clients 
//              join plaOrd in placedOrders on cli.Id equals plaOrd.ClientId 
//              join proOrd in productOrders on plaOrd.Id equals proOrd.PlacedOrderId 
//              join pro in products on proOrd.ProductId equals pro.Id

//              orderby proOrd.DateOfShipping descending

//              select new
//                     {
//                                                          cli.ClientName,
//                                                          pro.ProductName,
//                                                          proOrd.DateOfShipping
//                     }).FirstOrDefault();
//if(wanted !=null)
//    Console.WriteLine("Date of Shipping "+wanted.DateOfShipping.ToString("D"));

//Orders which have not been shipped yet? To whom and what?

//var wanted = (from cli in clients
//              join plaOrd in placedOrders 
//              on cli.Id equals plaOrd.ClientId
//              join proOrd in productOrders 
//              on plaOrd.Id equals proOrd.PlacedOrderId

//              where proOrd.DateOfShipping>today
//              join pro in products on proOrd.ProductId equals pro.Id

//              orderby proOrd.DateOfShipping descending

//              select new
//              {
//                  cli.ClientName,
//                  pro.ProductName,
//                  proOrd.DateOfShipping
//              });
//foreach (var item in wanted)
//{
//    Console.WriteLine("Date of Shipping: " + item.DateOfShipping.ToString("D") + ", client: " + item.ClientName + ", product: " + item.ProductName);
//}


//Where do most of the clients comes from(country)?

//var homeCountry = from cli in clients
//                  group cli by cli.Country into gr
//                  let count = gr.Count()
//                  orderby count descending
//                  select new
//                  {
//                      Name = gr.Key,
//                      Count = count,
//                  };

//foreach(var item in homeCountry)
//{
//    Console.WriteLine("Country name: {0}, number of clients: {1}", item.Name, item.Count);
//}

//Most of them :
var homeCountry = (from cli in clients
                  group cli by cli.Country into gr
                  let count = gr.Count()
                  orderby count descending
                  select new
                  {
                      Name = gr.Key,
                      Count = count,
                  }).FirstOrDefault();
if (homeCountry != null)
    Console.WriteLine("Number one: {0}, number of clients {1}", homeCountry.Name, homeCountry.Count);