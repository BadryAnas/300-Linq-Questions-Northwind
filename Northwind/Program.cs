using static Northwind.DataLists;
namespace Northwind
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Easy
            #region 1.  Retrieve all products with a unit price greater than $50.

            //var products = Products.Where(product => product.UnitPrice > 50);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            //var result01 = Products.Where(product => product.UnitPrice > 50);

            //foreach (var product in result01)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 2. List the names of all customers from London.


            //var customers = Customers.Where(customer => customer.City == "London").Select(customer => customer.ContactName);

            //foreach (var customer in customers)
            //{
            //     Console.WriteLine(customer);
            //}



            //var result02 = Customers.Where(customer => customer.City == "London").Select(customer => customer.ContactName);
            //foreach (var customer in result02)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 3. Find all orders shipped by "Speedy Express".

            //int companyId = Shippers.Where(company => company.CompanyName == "Speedy Express").Select(company => company.ShipperID).FirstOrDefault();

            //var orders = Orders.Where(order => order.ShipVia == companyId);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}


            //var companyID = Shippers.Where(shipper => shipper.CompanyName == "Speedy Express").Select(Shipper => Shipper.ShipperID).FirstOrDefault();
            //var result03 = Orders.Where(order => order.ShipVia == companyID);
            //foreach (var order in result03)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 4. Get the total number of orders placed by customer "ALFKI".
            /// 1.
            /// var NumberOforders = Orders.GroupBy(order => order.CustomerID).Select(customer => new { Name = customer.Key, NumberOforders = customer.Count() }).Where(customer => customer.Name == "ALFKI").FirstOrDefault();
            /// Console.WriteLine(NumberOforders);

            /// 2.
            /// int NumberOfOrders = Orders.Where(order => order.CustomerID == "ALFKI").Count();
            /// Console.WriteLine(NumberOfOrders);

            /// 3.
            /// var result04 = Orders.Where(order => order.CustomerID == $"ALFKI");
            /// foreach (var order in result04)
            /// {
            ///     Console.WriteLine(order);
            /// }
            #endregion

            #region 5. List all employees who are managers.

            //var employees = Employees.Where(employee => employee.Title.Contains("Manager"));

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}







            //var result05 = Employees.Where(emp => emp.Title.Contains("Manager"));

            //foreach (var emp in result05)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 6.  Find products that are discontinued.


            //var products = Products.Where(product => product.Discontinued);

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}






            //var result06 = Products.Where(product => product.Discontinued == true);
            //foreach (var product in result06)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 7. Retrieve the names and phone numbers of all suppliers.



            //var supplires = Suppliers.Select(supplier => new { Name = supplier.ContactName, Phone = supplier.Phone });
            //foreach (var supplier in supplires)
            //{
            //    Console.WriteLine(supplier);
            //}





            //var result07 = Suppliers.Select(Supplier => new
            //{
            //    Supplier.ContactName,
            //    Supplier.Phone,
            //});

            //foreach (var item in result07)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8. Get all orders placed in the year 1996.


            //var orders = Orders.Where(order => order.OrderDate.Year == 1996);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}








            //var result08 = Orders.Where(order => order.OrderDate.Year == 1996);
            //foreach (var order in result08)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 9. Find all customers in the "USA".

            //var customers = Customers.Where(customer => customer.Country == "USA");
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}




            //var result09 = Customers.Where(customer => customer.Country == "USA");
            //foreach (var customer in result09)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 10. List products that belong to category "Beverages".
            //int categoryId = Categories.Where(category => category.CategoryName == "Beverages").Select(category => category.CategoryID).FirstOrDefault();

            //var products = Products.Where(product => product.CategoryID == categoryId);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}







            //var CategoryID = Categories.Where(category => category.CategoryName == "Beverages").Select(category => category.CategoryID).FirstOrDefault();
            //var result10 = Products.Where(product => product.CategoryID == CategoryID);
            //foreach (var product in result10)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 11. Retrieve orders with a freight cost less than $10.

            //var orders = Orders.Where(order => order.Freight < 10);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}




            //var result11 = Orders.Where(order => order.Freight < 10);
            //foreach (var order in result11)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 12. Get the names and titles of all employees.
            //var employees  = Employees.Select(employee => new 
            //{ 
            //    Name = $"{employee.FirstName } {employee.LastName}" ,
            //    Titles = employee.Title 
            //} );

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}





            //var result12 = Employees.Select(emp => new
            //{
            //    Name = $"{emp.FirstName} {emp.LastName}",
            //    emp.Title,
            //});

            //foreach (var emp in result12)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 13. Find suppliers from "Germany".

            //var supplires = Suppliers.Where(supplire => supplire.Country == "Germany");
            //foreach (var supplire in supplires)
            //{
            //    Console.WriteLine(supplire);
            //}





            //var result13 = Suppliers.Where(supplier => supplier.Country == "Germany");
            //foreach (var supplier in result13)
            //{
            //    Console.WriteLine(supplier);
            //};
            #endregion

            #region 14. List all products with quantities between 10 and 50.


            //var products = Products.Where(product => product.UnitsInStock >= 10 && product.UnitsInStock <= 50);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}





            //var result14 = Products.Where(product => product.UnitsInStock >= 10 && product.UnitsInStock <= 50);
            //foreach (var product in result14)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 15. Retrieve orders that were shipped but not yet delivered.

            //var orders = Orders.Where(order => order.ShippedDate != null && order.RequiredDate > DateTime.Now);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}








            //var result15 = Orders.Where(order => order.ShippedDate != null && order.RequiredDate > DateTime.Now);
            //foreach (var order in result15)
            //{
            //    Console.WriteLine(order.ShippedDate);

            //    Console.WriteLine(order.RequiredDate);
            //}
            #endregion

            #region 16. Get the total number of products in each category.

            //var NumberOfProducts = Products.GroupBy(product => product.CategoryID)
            //    .Select(category => new
            //    {
            //        CategoryNumber = category.Key,
            //        NumberOfProduct = category.Count()
            //    });

            //foreach (var product in NumberOfProducts)
            //{
            //    Console.WriteLine(product);
            //}







            //var result16 = Products.GroupBy(product => product.CategoryID).Select(group => new
            //{
            //    CatID = group.Key,
            //    ProductCount = group.Count(),
            //});
            //foreach (var item in result16)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 17.  List all orders placed by employee with ID 5.
            //var orders = Orders.Where(order => order.EmployeeID == 5);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}




            //var result17 = Orders.Where(order => order.EmployeeID == 5);
            //foreach (var order in result17)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 18. Find the name of the supplier with the highest ID.
            //string name = Suppliers.OrderByDescending(supplier => supplier.SupplierID).Select(supplier => supplier.ContactName).First();
            //Console.WriteLine(name);




            //var result18 = Suppliers.OrderByDescending(supplier => supplier.SupplierID).FirstOrDefault();
            //Console.WriteLine(result18.ContactName);

            #endregion

            #region 19. Retrieve products that have "Box" in their quantity per unit description.
            //var products = Products.Where(product => product.QuantityPerUnit.Contains("box"));
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}





            //var result19 = Products.Where(product => product.QuantityPerUnit.Contains("box"));
            //foreach (var product in result19)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 20. List all customers from "Germany".

            //var customers = Customers.Where(customer => customer.Country == "Germany");
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}




            //var result20 = Customers.Where(Customer => Customer.Country == "Germany");
            //foreach (var supplier in result20)
            //{
            //    Console.WriteLine(supplier);
            //};
            #endregion

            #region 21. Find all products that have never been ordered.

            //var products = Products.Where(product => product.ReorderLevel == 0);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}





            //var result21 = Products.Where(product => product.ReorderLevel == 0);
            //foreach (var product in result21)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 22. Get all orders with a freight cost greater than $50.

            //var orders = Orders.Where(order => order.Freight > 50);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}






            //var result22 = Orders.Where(order => order.Freight > 50);
            //foreach (var order in result22)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 23. Retrieve names of all categories.


            //var naemOfCates = Categories.Select(category => new { Name = category.CategoryName }).Distinct();
            //foreach (var category in naemOfCates)
            //{
            //    Console.WriteLine(category);
            //}



            //var result23 = Categories.Select(category => category.CategoryName).Distinct();
            //foreach (var category in result23)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 24. List all orders where the ship city is "Seattle".

            //var orders = Orders.Where(order => order.ShipCity == "Seattle");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}





            //var result24 = Orders.Where(order => order.ShipCity == "Seattle");
            //foreach (var order in result24)
            //{
            //    Console.WriteLine(order.ShipCity);
            //}
            #endregion

            #region 25. Find the employees who have "Sales" in their title

            //var employees = Employees.Where(employee => employee.Title.Contains("Sales"));
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}



            //var result25 = Employees.Where(emp => emp.Title.Contains("Sales"));
            //foreach (var emp in result25)
            //{
            //    Console.WriteLine(emp.Title);
            //}
            #endregion

            #region 26. Retrieve orders that were placed in the month of June.

            //var orders = Orders.Where(order => order.OrderDate.Month == 6);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}




            //var result26 = Orders.Where(order => order.OrderDate.Month == 6);
            //foreach (var order in result26)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 27. Get the names and phone numbers of suppliers from "Italy".

            //var suppliers = Suppliers.Where(supplier => supplier.Country == "Italy")
            //    .Select(supplier => new
            //    {
            //        Name = supplier.ContactName,
            //        Phone = supplier.Phone
            //    });

            //foreach (var supplier in suppliers)
            //{
            //    Console.WriteLine(supplier);
            //}




            //var result27 = Suppliers.Where(supplier => supplier.Country == "Italy").Select(supplier => new
            //{
            //    supplier.ContactName,
            //    supplier.Phone,
            //});

            //foreach (var supplier in result27)
            //{
            //    Console.WriteLine(supplier);
            //}
            #endregion

            #region 28. List all products with unit prices less than $20.

            //var products = Products.Where(product => product.UnitPrice < 20);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}




            //var result28 = Products.Where(product => product.UnitPrice < 20);
            //foreach (var product in result28)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 29. Find orders that were shipped in 1997.
            //var orders = Orders.Where(order => order.ShippedDate?.Year == 1997);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}





            //var result29 = Orders.Where(order => order.ShippedDate?.Year == 1997);
            //foreach (var order in result29)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 30. Retrieve the names of all customers who have placed more than 5 orders.


            //var orders = Orders.GroupBy(order => order.CustomerID)          
            //    .Where(orders => orders.Count() > 5)
            //    .Join(Customers , 
            //    group => group.Key,
            //    customer => customer.CustomerID,
            //    (group, customer) => customer.ContactName
            //    ).Distinct();
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}






            //var result30 = Orders.GroupBy(order => order.CustomerID)
            //                    .Where(group => group.Count() > 5)
            //                    .Join(Customers,
            //                          group => group.Key,
            //                          customer => customer.CustomerID,
            //                          (group, customer) => customer.ContactName)
            //                    .Distinct();

            //foreach (var item in result30)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 31. List products with no quantity on order.

            //var products = Products.Where(product => product.UnitsOnOrder == 0);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}




            //var result31 = Products.Where(product => product.UnitsOnOrder == 0);
            //foreach (var product in result31)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 32. Get all categories with more than 10 products

            //var categories = Products.GroupBy(product => product.CategoryID)
            //.Select(group => new
            //{
            //    Name = group.Key,
            //    Count = group.Count(),
            //}).Where(category => category.Count > 10)
            //.Join(Categories, group => group.Name, category => category.CategoryID, (group, category) => group);

            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category);
            //}



            //var result32 = Products.GroupBy(product => product.CategoryID)
            //                       .Where(group => group.Count() > 10)
            //                       .Select(group => group.Key)
            //                       .Join(Categories, group => group, Category => Category.CategoryID, (group, Category) => Category);

            //foreach (var item in result32)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 33. Find the customer with the most recent order.

            //var customer = Orders.OrderByDescending(order => order.OrderDate)
            //    .Join(Customers , order => order.CustomerID , customer => customer.CustomerID , (group , customer) => customer).FirstOrDefault();
            //Console.WriteLine(customer);




            //var RecentOrder = Orders.MaxBy(order => order.OrderDate);
            //var result33 = Customers.Where(customer => customer.CustomerID == RecentOrder.CustomerID);
            //foreach (var customer01 in result33)
            //{
            //    Console.WriteLine(customer01);
            //}
            #endregion

            #region 34. Retrieve employees who work in "Sales".


            //var employees = Employees.Where(emp => emp.Title.Contains("Sales"));
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}











            //var result25 = Employees.Where(emp => emp.Title.Contains("Sales"));
            //foreach (var emp in result25)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 35. List all products with a reorder level less than 10.

            //var products = Products.Where(product => product.ReorderLevel < 10);
            //foreach(var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            //var result35 = Products.Where(product => product.ReorderLevel < 10);
            //foreach (var product in result35)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 36. Find orders with a ship country of "USA" and a freight cost less than $20.
            //var orders = Orders.Where(order => order.ShipCountry == "USA" && order.Freight < 20);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}










            //var result36 = Orders.Where(order => order.ShipCountry == "USA" && order.Freight < 20);
            //foreach (var order in result36)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 37. Get the names of suppliers who have a fax number.
            //var suppliers = Suppliers.Where(Supplier => Supplier.Fax != null).Select(Supplier => Supplier.ContactName);
            //foreach (var supplier in suppliers)
            //{
            //    Console.WriteLine(supplier);
            //}






            //var result38 = Suppliers.Where(Supplier => Supplier.Fax != null).Select(Supplier => Supplier.ContactName);
            //foreach (var supplier in result38)
            //{
            //    Console.WriteLine(supplier);
            //}
            #endregion

            #region 38. List all orders placed in the first quarter of 1996.
            //var orders = Orders.Where(order => order.OrderDate.Year == 1996 && order.OrderDate.Month < 4);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}














            //var result38 = Orders.Where(order => order.OrderDate.Year == 1996 && (order.OrderDate.Month == 1 || order.OrderDate.Month == 2 || order.OrderDate.Month == 3 || order.OrderDate.Month == 4));
            //foreach (var order in result38)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region 39. Retrieve products that have a unit price between $20 and $50.
            //var products = Products.Where(product => product.UnitPrice >= 20 && product.UnitPrice <= 50);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}








            //var result39 = Products.Where(product => product.UnitPrice >= 20 && product.UnitPrice <= 50);
            //foreach (var product in result39)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 40. Find customers who have a postal code starting with "9".

            //var customers = Customers.Where(customer => customer.PostalCode[0] == '9');
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}











            //var result40 = Customers.Where(customer => customer.PostalCode.StartsWith("9"));
            //foreach (var customer in result40)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 41. List all employees with their address details.
            //var employees = Employees.Select(emp => new
            //{
            //    Name = emp.FirstName,
            //    Address = emp.Address
            //});

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}









            //var result41 = Employees.Select(emp => new
            //{
            //    emp.FirstName,
            //    emp.Address,
            //});
            //foreach (var emp in result41)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 42. Get all orders where the ship region is "CA".

            //var orders = Orders.Where(order => order.ShipRegion == "CA");
            //foreach
            //    (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}









            //var result42 = Orders.Where(order => order.ShipRegion == "CA");
            //foreach (var order in result42)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 43. Find all categories with at least one product in stock.

            //var categories = Products.Where(product => product.UnitsInStock > 0)
            //    .Join(Categories, product => product.CategoryID, category => category.CategoryID, (group, category) => category).Distinct();
            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category);
            //}

            //Console.WriteLine("===========");

            //var result44 = Products.Where(product => product.UnitsInStock != 0)
            //                       .GroupBy(product => product.CategoryID)
            //                       .Select(group => group.Key)
            //                       .Join(Categories, group => group, category => category.CategoryID, (group, Category) => Category);

            //foreach (var group in result44)
            //{
            //    Console.WriteLine(group);
            //}
            #endregion

            #region 44. Retrieve the names and cities of customers who live in "USA
            //var customers = Customers.Where(customer => customer.Country == "USA")
            //    .Select(customer => new
            //    {
            //        Name = customer.ContactName,
            //        City = customer.City,
            //    });

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}


            #endregion

            #region 45. List products supplied by supplier with ID 10.

            //var products = Products.Where(product => product.SupplierID == 10);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}









            //var result45 = Products.Where(product => product.SupplierID == 10);
            //foreach (var product in result45)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 46. Find all orders where the ship name contains "Express".

            //var orders = Orders.Where(order => order.ShipName.Contains("Express"));
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}





            //var result46 = Orders.Where(order => order.ShipName.Contains("Express"));

            //foreach (var order in result46)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 47. Get the details of products with more than 20 units in stock.

            //var products = Products.Where(product => product.UnitsInStock > 20);
            //foreach
            //    (var product in products)
            //{
            //    Console.WriteLine(product);
            //}






            //var result47 = Products.Where(product => product.UnitsInStock > 20);
            //foreach (var product in result47)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 48. Retrieve all orders where the order date is in 1995.

            //var orders = Orders.Where(order => order.OrderDate.Year == 1995);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}




            //var result48 = Orders.Where(order => order.OrderDate.Year == 1995);
            //foreach (var order in result48)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 49. List all suppliers from "Canada" who have a phone number starting with "416".


            //var suppliers = Suppliers.Where(supplier => supplier.Country == "Canada" && supplier.Phone.StartsWith("416"));
            //foreach (var supplier in suppliers)
            //{
            //    Console.WriteLine(supplier);
            //}






            //var result49 = Suppliers.Where(Supplier => Supplier.Country == "Canada" && Supplier.Phone.StartsWith("416"));
            //foreach (var item in result49) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 50. Find products that have been ordered more than 50 times.

            //var products = OrderDetails.GroupBy(order => order.ProductID)
            //    .Where(order => order.Count() > 50)
            //    .Select(order => order.Key);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            //var result50 = Orders.Join(OrderDetails, 
            //                                         order => order.OrderID,
            //                                         orderDetails => orderDetails.OrderID,
            //                                         (order, orderDetails) => orderDetails.ProductID)

            //                      .GroupBy(productId => productId)
            //                      .Where(group => group.Count() > 50)
            //                      .Join(Products, group => group.Key, product => product.ProductID, (group, product) => product);

            //foreach (var item in result50)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 51. Get the names of all employees who are not managers.

            //var employees = Employees.Where(employee => !employee.Title.Contains("Manager"));
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}





            //var result51 = Employees.Where(emp => !emp.Title.Contains("Manager"));
            //foreach (var emp in result51)
            //{
            //    Console.WriteLine(emp.Title);
            //}
            #endregion

            #region 52. List orders where the ship country is "Mexico".
            //var orders = Orders.Where(order => order.ShipCountry == "Mexico");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}










            //var result52 = Orders.Where(order => order.ShipCountry == "Mexico");
            //foreach (var order in result52)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 53. Retrieve all products with a quantity per unit description containing "bottle".
            //var products = Products.Where(product => product.QuantityPerUnit.Contains("bottle"));
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}







            //var result53 = Products.Where(product => product.QuantityPerUnit.Contains("bottle"));
            //foreach (var product in result53)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region 54. Find the top 5 products with the highest unit price.
            //var products = Products.OrderByDescending(order => order.UnitPrice).Take(5);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}





            //var result54 = Products.OrderByDescending(product => product.UnitPrice).Take(5);
            //foreach (var item in result54)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 55. Get all customers who have a contact title of "Owner".
            //var customers = Customers.Where(customer => customer.ContactTitle == "Owner");
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}






            //var result55 = Customers.Where(Customer => Customer.ContactTitle == "Owner");
            //foreach (var customer in result55)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 56. List all employees who have their last name starting with "S".
            //var employees = Employees.Where(emp => emp.LastName[0] == 'S');
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}







            //var result56 = Employees.Where(emp => emp.LastName.StartsWith("S"));
            //foreach (var emp in result56)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 57. Retrieve orders placed in the month of December.

            //var orders = Orders.Where(order => order.OrderDate.Month == 12);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}









            //var result57 = Orders.Where(order => order.OrderDate.Month == 12);
            //foreach (var order in result57)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 58. Find products that are neither discontinued nor have a reorder level of 0.


            //var products = Products.Where(product => !product.Discontinued && product.ReorderLevel != 0);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}






            //var result58 = Products.Where(Product => Product.Discontinued == false && Product.ReorderLevel != 0);
            //foreach (var product in result58)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 59. Get the names of suppliers who have their country listed as "UK".

            //var suppliers = Suppliers.Where(supplier => supplier.Country == "UK");
            //foreach (var supplier in suppliers)
            //{
            //    Console.WriteLine(supplier);
            //}






            //var result59 = Suppliers.Where(supplier => supplier.Country == "UK");
            //foreach (var item in result59)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 60. List all orders with a ship city of "London" and a freight cost greater than $30.

            //var orders = Orders.Where(order => order.ShipCity == "London");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}






            //var result60 = Orders.Where(order => order.ShipCity == "London");
            //foreach (var order in result60)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 61. Retrieve all employees who were hired in 1997.

            //var employees = Employees.Where(emp => emp.HireDate.StartsWith("1997"));
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}



            //var result61 = Employees.Where(emp => emp.HireDate.Contains("1997"));
            //foreach (var emp in result61)
            //{
            //    Console.WriteLine(emp.HireDate);
            //}
            #endregion

            #region 62. Find products that have been ordered by more than 10 different customers.

            //var products = OrderDetails.Join(Orders, orderDetail => orderDetail.OrderID, order => order.OrderID, (details, order) => new
            //{
            //    Product = details.ProductID,
            //    Customer = order.CustomerID
            //}).GroupBy(group => group.Product)
            //    .Where(group => group.Select(x => x.Customer).Distinct().Count() >= 10 /*2 for test*/)
            //    .Select(group => new
            //    {
            //        ProductId = group.Key,
            //        CustpmerCount = group.Count()
            //    });




            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            #endregion

            #region 63. Get all categories that do not have any discontinued products.

            //var categories = Categories.Join(Products, category => category.CategoryID, product => product.CategoryID,
            //    (category, product) => new
            //    {
            //        Category = category.CategoryID,
            //        discontinued = product.Discontinued
            //    }).GroupBy(x => x.Category).Where(x => x.All(has => has.discontinued))
            //    .Select(x => x.Key)
            //    .Join(Categories , cat => cat , cat => cat.CategoryID , (cat01 , cat02) => cat02.CategoryName);

            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category);
            //}



            //var result63 = Products.GroupBy(product => product.CategoryID)
            //                        .Where(group => group.All(product => product.Discontinued == false))
            //                        .Select(group => group.Key)
            //                        .Join(Categories, CategoryID => CategoryID, Categories => Categories.CategoryID, (CategoryID, Categories) => Categories);

            //foreach (var item in result63)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 64. List all customers who have a region specified.
            //var customers = Customers.Where(custmoer => !String.IsNullOrEmpty(custmoer.Region));

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.Region);
            //}



            //var result64 = Customers.Where(customer => customer.Region != "");


            //foreach (var customer in result64)
            //{
            //    Console.WriteLine(customer.Region);
            //}
            #endregion

            #region 65. Retrieve products where the unit price is greater than the average unit price.


            //var products = Products.Where(product => product.UnitPrice > Products.Average(product => product.UnitPrice));
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            //var result65 = Products.Where(product => product.UnitPrice > Products.Average(product => product.UnitPrice));
            //foreach (var product in result65)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 66. Find the supplier with the most products.

            //var supplier = Products.GroupBy(product => product.SupplierID).OrderByDescending(group => group.Count()).Take(1)
            //    .Select(group => group.Key).FirstOrDefault();

            //Console.WriteLine(supplier);


            //var SupplierId = Products.GroupBy(Product => Product.SupplierID).OrderByDescending(group => group.Count()).Select(group => group.Key).FirstOrDefault();
            //var result66 = Suppliers.Where(supplier => supplier.SupplierID == SupplierId);
            //foreach (var supplier in result66)
            //{
            //    Console.WriteLine(supplier);
            //}
            #endregion

            #region 67. Get all orders where the order date is after January 1, 1996.

            //var orders = Orders.Where(order => order.OrderDate > new DateTime(1 / 1 / 1996));
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}





            //var result67 = Orders.Where(order => order.OrderDate > new DateTime(1 / 1 / 1996));
            //foreach (var order in result67)
            //{
            //    Console.WriteLine(order.OrderDate);
            //}
            #endregion

            #region 68. List products with a unit price that is a multiple of 5.

            //var products = Products.Where(product => product.UnitPrice % 5 == 0);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}




            //var result68 = Products.Where(product => product.UnitPrice % 5 == 0);
            //foreach (var product in result68)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 69. Retrieve the names of customers who have placed at least 3 orders.
            //var customers = Orders.GroupBy(order => order.CustomerID)
            //                      .Where(group => group.Count() >= 3)
            //                      .Join(Customers, group => group.Key, customers => customers.CustomerID, (group, custom) => custom.ContactName);
            //foreach (var custom in customers)
            //{
            //    Console.WriteLine(custom);
            //}




            //var result69 = Orders.GroupBy(order => order.CustomerID)
            //                     .Where(group => group.Count() >= 3)
            //                     .Select(group => group.Key)
            //                     .Join(Customers, customerId => customerId, Customers => Customers.CustomerID, (customerId, Customers) => Customers.ContactName);

            //foreach (var customer in result69)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 70. Find all orders shipped by "United Package".
            //int shipperId = Shippers.Where(shipper => shipper.CompanyName == "United Package").Select(shipper => shipper.ShipperID).FirstOrDefault();
            //var orders = Orders.Where(order => order.ShipVia == shipperId);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}





            //var shipperID = Shippers.Where(Shipper => Shipper.CompanyName == "United Package").Select(Shipper => Shipper.ShipperID).FirstOrDefault();
            //var result70 = Orders.Where(order => order.ShipVia == shipperID);
            //foreach (var order in result70)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 71. Get the details of orders that were shipped in "Paris".

            //var orders = Orders.Where(order => order.ShipCity == "Paris").Select(order => new
            //{
            //    Id = order.OrderID
            //})
            //    .Join(OrderDetails, order => order.Id, OD => OD.OrderID, (order, details) => details);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}





            //var result71 = Orders.Where(order => order.ShipCity == "Paris")
            //                                      .Select(order => order.OrderID)
            //                                      .Join(OrderDetails
            //                                            , orderId => orderId
            //                                            , OrderDetails => OrderDetails.OrderID
            //                                            , (orderId, OrderDetails) => OrderDetails);

            //var result071 = from order in Orders
            //               where order.ShipCity == "Paris"
            //               join orderDetail in OrderDetails
            //               on order.OrderID equals orderDetail.OrderID into orderDetailGroup
            //               from orderDetail in orderDetailGroup.DefaultIfEmpty()
            //               select new
            //               {
            //                   order.OrderID,
            //                   order.ShipCity,
            //                   order.ShipCountry,
            //               };


            //foreach (var order in result71)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region 72. List products that have been discontinued and have a unit price greater than $30.
            //var products = Products.Where(product => product.UnitPrice > 30 && product.Discontinued);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}







            //var result72 = Products.Where(product => product.UnitPrice > 30 && product.Discontinued ==true );
            //foreach (var product in result72)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 73. Retrieve employees who have not shipped any orders.


            //var employeeWithOrders = Orders.Select(order => order.EmployeeID);

            //var employeesWithoutOrders = Employees.Select(emp => !employeeWithOrders.Contains(emp.EmployeeID));
            //foreach (var employee in employeesWithoutOrders)
            //{
            //    Console.WriteLine(employee);
            //}





            //var EmpWithOrders = Orders.Select(order => order.EmployeeID);
            //var result73 = Employees.Where(Employee => !EmpWithOrders.Contains(Employee.EmployeeID));
            //foreach (var emp in result73)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion

            #region 74. Find customers who have orders with a discount applied.

            //var ordersWihtDiscount = OrderDetails.Where(order => order.Discount != 0).Select(order => order.OrderID);
            //var customers = Orders.Where(order => ordersWihtDiscount.Contains(order.OrderID)).Select(o => o.CustomerID).Distinct();

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}





            //var OrdersWithDiscountId = OrderDetails.Where(order => order.Discount != 0).Select(order => order.OrderID);
            //var customersId = Orders.Where(order => OrdersWithDiscountId.Contains(order.OrderID)).Select(order => order.CustomerID);
            //var result74 = Customers.Where(customer => customersId.Contains(customer.CustomerID));
            //foreach (var customer in result74)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 75. Get the top 3 most expensive products.

            //var products = Products.OrderByDescending(product => product.UnitPrice).Take(3);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}




            //var result75 = Products.OrderByDescending(product =>product.UnitPrice).Take(3);
            //foreach (var product in result75)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 76. List all suppliers with a home page.
            //var suppliers = Suppliers.Where(supp =>!string.IsNullOrEmpty(supp.HomePage) );
            //Console.WriteLine( suppliers.Count());


            //foreach (var supplier in suppliers)
            //{
            //    Console.WriteLine(supplier);
            //}





            //var result76 = Suppliers.Where(Supplier => Supplier.HomePage != "" && Supplier.HomePage != null);
            //foreach (var item in result76)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(result76.Count());

            #endregion

            #region 77. Retrieve orders where the freight cost is between $10 and $50.

            //var orders  = Orders.Where(order => order.Freight >= 10 && order.Freight <= 50);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}





            //var result77 = Orders.Where(order => order.Freight >=10 && order.Freight <=50);
            //foreach (var order in result77)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region 78. Find products supplied by a supplier with the name "Exotic Liquids".
            //var supplier = Suppliers.FirstOrDefault(supp => supp.CompanyName == "Exotic Liquids");

            //var products = Products.Where(product => product.SupplierID == supplier.SupplierID);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}






            //var result78 = Suppliers.Where(supplier => supplier.CompanyName == "Exotic Liquids")
            //                        .Select(Supplier => Supplier.SupplierID)
            //                        .Join(Products, SupplierID => SupplierID, product => product.SupplierID, (SupplierID, Products) => Products);

            //foreach (var item in result78)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 79. Get all orders that were required before the order date.

            //var orders = Orders.Where(order => order.RequiredDate < order.OrderDate);
            //foreach
            //    (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}



            //var result79 = Orders.Where(order => order.RequiredDate < order.OrderDate);
            //foreach (var order in result79)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 80. List products that have been ordered at least once in each year of the 1990s.






            #endregion

            #region 81. Retrieve all orders where the ship city is "Seattle" or "Portland".
            //var orders = Orders.Where(order => order.ShipCity == "Seattle" || order.ShipCity == "Portland");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}




            //var result81 = Orders.Where(order => order.ShipCity == "Seattle" || order.ShipCity == "Portland");
            //foreach (var order in result81)
            //{
            //    Console.WriteLine(order.ShipCity);
            //}
            #endregion

            #region 82. Find employees who have more than one phone number listed.

            #endregion

            #region 83. Get the details of orders placed by the customer "ANATR".

            //var orders = Orders.Where(order => order.CustomerID == "ANATR")
            //    .Join(OrderDetails, o => o.OrderID, od => od.OrderID, (o, od) => od);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}



            //var result83 = Orders.Where(order => order.CustomerID == "ANATR")
            //.Join(OrderDetails, order => order.OrderID, orderDetails => orderDetails.OrderID, (orders, OrderDetails) => OrderDetails);


            //foreach (var order in result83)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 84. List products with a quantity per unit description that includes "can".
            //var products = Products.Where(product => product.QuantityPerUnit.Contains("can"));
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}




            //var result84 = Products.Where(product => product.QuantityPerUnit.Contains("Can"));
            //foreach (var product in Products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 85. Retrieve the names of all customers who have their contact name starting with "A".


            //var customers = Customers.Where(customer => customer.ContactName.StartsWith('A')).Select(customer => customer.ContactName);
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}



            //var result85 = Customers.Where(customer => customer.ContactName.StartsWith("A")).Select(customer =>customer.ContactName);
            //foreach (var customer in result85)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 86. Find all products with a unit price between $15 and $25.

            //var products = Products.Where(product => product.UnitPrice >= 15 && product.UnitPrice <= 25);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            //var result86 = Products.Where(product => product.UnitPrice >= 15 && product.UnitPrice <= 25);
            //foreach (var product in result86)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 87. Get all orders that were shipped in the year 1997 but required before 1996.

            //var orders = Orders.Where(order => order.ShippedDate?.Year == 1997 && order.RequiredDate.Year <  1996);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}



            //var result87 = Orders.Where(order => order.ShippedDate?.Year == 1997 && order.RequiredDate.Year < 1996);
            //foreach (var order in result87)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 88. List all categories with at least one product that is not discontinued.
            //var categories = Products.Where(product => !product.Discontinued).Join(Categories, product => product.CategoryID,
            //    cat => cat.CategoryID, (pro, cat) => cat.CategoryName).Distinct();

            //foreach (var categorie in categories)
            //{
            //    Console.WriteLine(categorie);
            //}

            //Console.WriteLine("==============");

            //var CategoriesID = Products.GroupBy(product => product.CategoryID).Where(group => group.Any(product => product.Discontinued == false)).Select(group => group.Key);
            //var result88 = Categories.Where(cat => CategoriesID.Contains(cat.CategoryID));
            //foreach (var cat in result88)
            //{
            //    Console.WriteLine(cat);
            //}
            #endregion

            #region 89. Retrieve the names of suppliers who do not have a fax number.


            //var suppliers = Suppliers.Where(supp => supp.Fax == "").Select(supp => supp.ContactName);
            //foreach (var supplier in suppliers)
            //{
            //    Console.WriteLine(supplier);
            //}



            //var result89 = Suppliers.Where(supplier => supplier.Fax == "").Select(supplier =>supplier.ContactName);
            //foreach (var item in result89)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 90. Find customers who live in cities starting with "S".


            //var customers = Customers.Where(customers => customers.City.StartsWith('S'));
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}



            //var result90 = Customers.Where(customer => customer.City.StartsWith("S"));
            //foreach (var customer in result90)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 91. Get the total number of products for each supplier.

            //var numbersOfSupp = Products.GroupBy(product => product.SupplierID).Select(g => new
            //{
            //    supp = g.Key,
            //    NumberOfProducts = g.Count(),

            //});

            //foreach (var product in numbersOfSupp)
            //{
            //    Console.WriteLine(product);
            //}


            //Console.WriteLine("============================");


            //var result91 = Products.GroupBy(product => product.SupplierID).Select(group => new
            //{
            //    SupplierId = group.Key,
            //    NoOfProducts = group.Count()
            //});

            //foreach (var item in result91)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 92. List all orders where the freight cost is exactly $15.

            //var orders = Orders.Where(order => order.Freight == 15);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}




            //var result92 = Orders.Where(order => order.Freight == 15);
            //foreach (var order in result92)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 93. Retrieve employees who have a title containing "Manager".

            //var employees = Employees.Where(emp => emp.Title.Contains("Manager"));
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}





            //var result93 = Employees.Where(emp => emp.Title.Contains("Manager"));
            //foreach (var emp in result93)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 94. Find products with a unit price that is not an integer.


            //var products = Products.Where(pro => pro.UnitPrice - (int)pro.UnitPrice > 0);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}


            //var result94 = Products.Where(product => product.UnitPrice - (int)product.UnitPrice !=0);

            //foreach (var product in result94)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 95. Get the names of all employees whose last name is "Davies".


            //var employees = Employees.Where(emp => emp.LastName == "Davies").Select(emp => emp.FirstName);
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}






            //var result95 = Employees.Where(emp =>emp.LastName == "Davies").Select(emp =>emp.FirstName);
            //foreach (var emp in result95)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion

            #region 96. List all orders shipped by "Federal Shipping".

            //int shipperId = Shippers.Where(Shippers => Shippers.CompanyName == "Federal Shipping").Select(s => s.ShipperID).FirstOrDefault();
            //var orders = Orders.Where(order => order.ShipVia == shipperId);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}




            //var shipperIds = Shippers.Where(s => s.CompanyName == "Federal Shipping").Select(s => s.ShipperID);
            //var result96 = Orders.Where(o => shipperIds.Contains(o.ShipVia));
            //foreach (var shipper in result96)
            //{
            //    Console.WriteLine(shipper);
            //}
            #endregion

            #region 97. Retrieve products with a unit price less than $25 and greater than $10.

            //var products = Products.Where(product => product.UnitPrice < 25 && product.UnitPrice > 10);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            //var result97 = Products.Where(product => product.UnitPrice > 10 && product.UnitPrice < 25);
            //foreach (var product in result97)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region 98. Find all customers with the same city as "Berlin".


            //var customers = Customers.Where(customer => customer.City == "Berlin");
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}



            //var result98 = Customers.Where(customer => customer.City == "Berlin");
            //foreach (var customer in result98)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region 99. Get the details of orders where the required date is within a week of the order date.

            //var orders = Orders.Where(order => (order.RequiredDate - order.OrderDate).Days == 7).Select(order => order.OrderID);
            //var orderDetails = OrderDetails.Where(order => orders.Contains(order.OrderID));
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}






            //var orderIds = Orders.Where(order => (order.RequiredDate - order.OrderDate).Days == 7).Select(order =>order.OrderID);
            //var result99 = OrderDetails.Where(order => orderIds.Contains(order.OrderID));

            //foreach (var order in result99)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 100. List all products that have been ordered but have a quantity per unit of "6 boxes".
            //var productsOrdered = OrderDetails.Select(od => od.ProductID).Distinct();
            //var products = Products.Where(product => product.QuantityPerUnit.Contains("6 boxes") && productsOrdered.Contains(product.ProductID));
            //foreach (var product in productsOrdered)
            //{
            //    Console.WriteLine(product);
            //}




            //var productsOrdered = OrderDetails.Select(OrderDetails => OrderDetails.ProductID).Distinct();
            //var result100 = Products.Where(product => productsOrdered.Contains(product.ProductID) && product.QuantityPerUnit == "6 boxes");

            //foreach (var product in result100)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #endregion Easy


            #region Medium
            // List all products whose unit price is higher than the average unit price of all products.

            // Retrieve the top 5 customers who have placed the highest number of orders.

            // Find all employees who have processed orders in more than 3 different countries.

            // Get the total number of orders shipped by each shipper.

            // List all products that have been ordered more than the average quantity ordered per product.

            // Retrieve the names of all customers who have ordered products from more than 5 different categories.

            // Find suppliers that have provided products in more than 3 different categories.

            // Get the details of the order with the maximum freight cost.

            // List all employees who have shipped orders to more than 10 different cities.

            // Retrieve all orders that were placed by customers from the same country as the employee who processed them.

            // Find the products that have the highest average discount applied.

            // Get the total number of products supplied by each supplier.

            // List all orders where the total freight cost exceeds the average freight cost of all orders.

            // Retrieve the names and addresses of all customers who have not placed any orders.

            // Find the employee with the most recent hire date.

            // Get all orders that were shipped on the same date they were ordered.

            // List all products with a unit price that is greater than the median unit price.

            // Retrieve the average freight cost for each shipper.

            // Find suppliers that have their contact title starting with "Sales".

            // Get the names of all customers who have ordered products with a unit price greater than $100.

            // List products that have a reorder level higher than the average reorder level of all products.

            // Retrieve the top 3 cities with the most customers.

            // Find orders that have a freight cost below the average freight cost for the year 1997.

            // Get the details of the orders shipped by "Speedy Express" in 1996.

            // List all products with a quantity per unit that contains the word "Pack".

            // Retrieve the names of employees who have processed orders in more than 2 different regions.

            // Find the supplier with the most products that have been ordered more than 50 times.

            // Get the total sales amount for each customer.

            // List all customers who have their postal code starting with "9" and have ordered products from more than 3 different categories.

            // Retrieve the average unit price of products in the "Beverages" category.

            // Find the product with the highest unit price and list its supplier details.

            // Get all orders that were placed by customers who have the same contact name as the employee who processed them.

            // List the names of customers and the number of orders they have placed in the year 1996.

            // Retrieve all products with a unit price greater than $30 and with quantities in stock less than the average.

            // Find all employees who have processed orders with a total freight cost above $100.

            // Get the total number of products in each category and list them in descending order.

            // List all orders where the total freight cost is above the average freight cost for orders shipped by "United Package".

            // Retrieve the names of suppliers who have provided products in the "Seafood" category.

            // Find all products that have been ordered in the last 6 months.

            // Get the names of customers who have ordered products supplied by more than 5 different suppliers.

            // List the total number of orders placed by each customer and sort by descending order count.

            // Retrieve employees who have shipped orders to cities in more than 3 different countries.

            // Find the products that are in stock but have never been ordered.

            // Get the total freight cost for each shipper and list them in ascending order.

            // List all categories that have at least one product with a unit price above the average for its category.

            // Retrieve the names and addresses of suppliers who have shipped products to "Paris".

            // Find the customers with the highest average order amount.

            // Get all products that have a unit price less than the average unit price and have never been discontinued.

            // List all orders where the shipping address is in a country that has more than 3 suppliers.

            // Retrieve the names of employees who have processed orders for products in the "Snacks" category.

            // Find the suppliers that have their company name containing the word "Deluxe".

            // Get the details of orders that were shipped to "Tokyo" and have a freight cost above the average.

            // List the products with the highest quantity ordered for each category.

            // Retrieve the names of customers who have not ordered any products from the "Seafood" category.

            // Find all employees who have shipped orders with a total freight cost of less than $20.

            // Get the total number of orders placed by each customer and filter for those with more than 10 orders.

            // List all products that are supplied by suppliers with the highest ID.

            // Retrieve the names and addresses of customers who have ordered products from more than 3 different categories.

            // Find the product with the lowest unit price and list its supplier details.

            // Get all orders where the order date is before the ship date.

            // List all suppliers who have provided products with a unit price above $50.

            // Retrieve the total freight cost for each order and list in descending order.

            // Find customers who have placed orders in every month of the year 1996.

            // Get the names of employees who have not shipped orders to "New York".

            // List all products with a quantity per unit containing the word "Bottle" or "Can".

            // Retrieve the names of suppliers who have a contact name containing "James".

            // Find all orders that were shipped with a freight cost above the average for orders shipped by "Federal Shipping".

            // Get the total number of products in stock for each category and sort in ascending order.

            // List all products that have a unit price higher than the average for their respective categories.

            // Retrieve the names of employees who have shipped orders to customers with a postal code starting with "9".

            // Find suppliers that have provided products with a unit price less than $25 and more than $50.

            // Get all orders that were placed in the month of July and shipped by "United Package".

            // List the top 5 cities with the highest number of shipped orders.

            // Retrieve the names and contact details of suppliers who have provided products in the "Confections" category.

            // Find all products that are currently out of stock but have been ordered in the past year.

            // Get the total number of products supplied by each supplier and list in descending order.

            // List all customers with a contact title of "Sales Representative" and who have ordered more than 3 products.

            // Retrieve the names of employees who have processed orders for the highest number of products.

            // Find the suppliers that have the same contact title as the employee with the most orders.

            // Get all orders that were shipped with a discount applied.

            // List the products with the highest quantity per unit and their respective suppliers.

            // Retrieve the names and addresses of customers who live in cities where the average order amount is above $200.

            // Find all products that have been ordered more than the average quantity ordered per product in the "Condiments" category.

            // Get the details of the orders that were shipped to "Berlin" and have a freight cost above $50.

            // List all categories with at least 10 products and sort by the total quantity of products in stock.

            // Retrieve the names of suppliers who have the highest number of products in the "Dairy Products" category.

            // Find all orders where the order date is within the first quarter of 1996 and the freight cost is less than $30.

            // Get the total sales amount for each employee and list them in descending order.

            // List all products with a unit price greater than the average price in their category and with a reorder level above 10.

            // Retrieve the names of customers who have placed orders in every month of 1997.

            // Find the products that have the highest quantity ordered and were supplied by suppliers from "Italy".

            // Get all orders where the ship city is "Seattle" and the order amount is greater than $100.

            // List all employees who have shipped products with a quantity greater than the average quantity ordered.

            // Retrieve the names of suppliers who have provided products with a unit price between $20 and $40.

            // Find the top 10 products with the highest total quantity ordered.

            // Get all orders where the required date is before the order date and the freight cost is below $25.

            // List the names and contact titles of suppliers who have shipped products in the "Seafood" category.

            // Retrieve the names of employees who have processed orders for more than 5 different categories.

            // Find all products that have been ordered by customers with a postal code starting with "1" and are in stock.

            // Get the total number of orders placed by customers from each city and list them in descending order.

            #endregion Medium

            #region Hard
            // Retrieve the top 5 customers who have the highest total order amount and list their order count.

            // Find the average discount applied to orders for each product category.

            // Get the names of employees who have shipped orders with a freight cost above the median freight cost of all orders.

            // List all products that are supplied by the supplier with the most products and have been ordered more than the average quantity.

            // Retrieve the top 3 categories with the highest average product unit price.

            // Find the customers who have ordered products from every category at least once.

            // Get the details of the order with the longest time between order date and required date.

            // List all suppliers who have not supplied products to any orders in the year 1996.

            // Retrieve the total number of products ordered for each product and compare it to the total stock quantity.

            // Find all products that have a reorder level equal to the maximum reorder level for their category.

            // Get the names of all customers who have ordered products from suppliers with more than 5 products.

            // List the employees who have processed orders for customers in more than 4 different countries.

            // Retrieve the names of categories where the average unit price of products is greater than the overall average unit price.

            // Find the suppliers who have provided products with a quantity per unit description that includes both "Box" and "Pack".

            // Get all orders where the total order amount is greater than the average order amount for the year 1997.

            // List products that have been ordered in every month of 1996 and have a unit price above $20.

            // Retrieve the names of customers who have placed orders in every year from 1995 to 1997.

            // Find all orders with a freight cost greater than the average freight cost of orders shipped by "Federal Shipping" and "United Package".

            // Get the total number of orders placed by customers who live in cities with more than 3 suppliers.

            // List all products that have been ordered by customers from more than 5 different regions.

            // Retrieve the names of employees who have shipped orders with the maximum discount applied.

            // Find the top 10 products that have been ordered the most in the last 6 months.

            // Get the details of orders where the ship country is the same as the supplier's country.

            // List all categories with products that have never been discontinued and have been ordered more than 10 times.

            // Retrieve the average quantity ordered for each product and compare it to the average stock quantity.

            // Find the customers who have ordered products from suppliers in at least 3 different countries.

            // Get all products that have a unit price within the range of the top 5 % most expensive products in their category.

            // List employees who have processed orders for products in every category.

            // Retrieve the total number of products ordered for each category and sort by descending total quantity.

            // Find the orders that have a ship city different from the customer’s city.

            // Get the details of the top 5 most recent orders and the names of the employees who processed them.

            // List all products with a unit price higher than the average unit price for their supplier.

            // Retrieve the names of suppliers who have a contact title of "Owner" and have provided products in the "Beverages" category.

            // Find the top 5 customers with the highest average order value and the number of orders they have placed.

            // Get all products that have been ordered in the last year and have a reorder level greater than the average reorder level.

            // List the employees who have processed orders for customers with a postal code starting with "9" and "8".

            // Retrieve the total order amount for each category and list them in descending order.

            // Find the suppliers who have not supplied products to any customers with orders in 1997.

            // Get the names of customers who have placed orders with products that have a unit price higher than the average unit price of products in their category.

            // List all products that have been ordered by customers from cities with the top 3 highest order counts.

            // Retrieve the names and contact titles of suppliers who have shipped products to "Paris" and "London".

            // Find all orders with a freight cost that is above the median freight cost and was shipped by "Speedy Express".

            // Get the top 5 products with the highest average discount applied and list their total quantity ordered.

            // List all employees who have shipped orders with a total freight cost above the average for the year 1996.

            // Retrieve the total number of products in stock for each category where the average unit price is above $30.

            // Find the customers who have placed orders with a discount applied and have ordered products from at least 4 different suppliers.

            // Get all products that have a unit price greater than the average for their supplier and have been ordered more than 10 times.

            // List all categories with products that have a reorder level equal to the average reorder level of products in their category.

            // Retrieve the names of suppliers who have provided products in the "Seafood" category and have a fax number.

            // Find the top 5 cities with the highest total order amount and list the number of customers in each city.

            // Get the details of orders where the ship name contains "Express" and the freight cost is above $40.

            // List the top 3 most expensive products in each category and retrieve their supplier details.

            // Retrieve the total number of orders placed by customers with a postal code starting with "1" and "2".

            // Find the products that have a quantity per unit description containing "Can" or "Pack" and have been ordered more than the median quantity.

            // Get the names of customers who have placed orders with products that have the highest total quantity ordered.

            // List all orders where the ship city is different from the customer’s city and the order amount is above the average.

            // Retrieve the names of employees who have shipped orders with a total quantity of products ordered above the average.

            // Find the top 10 products with the highest unit price that have been ordered in the last year.

            // Get the details of orders where the ship country is the same as the supplier’s country and the freight cost is above the average.

            // List all products that have been ordered by customers in cities with a total order amount greater than $1000.

            // Retrieve the names of suppliers who have provided products with a unit price less than $20 and more than $50.

            // Find the categories with products that have never been discontinued and have been ordered in every month of the last year.

            // Get the total number of orders for each category where the average order amount is greater than $200.

            // List all customers who have placed orders in every month of the last year and have a postal code starting with "1".

            // Retrieve the names of employees who have processed orders for the highest number of products and their total order amount.

            // Find the suppliers who have the highest number of products in categories where the average unit price is above $30.

            // Get all products that have a unit price higher than the median unit price in their category and have been ordered more than 20 times.

            // List all orders where the freight cost is above the average for the year 1997 and the order date is before the ship date.

            // Retrieve the top 5 customers with the highest average discount applied and their total order amount.

            // Find the products that have been ordered more than the average quantity ordered for their category and have a unit price above $25.

            // Get the names of suppliers who have provided products with a quantity per unit description containing "Bottle" and "Can".

            // List all employees who have shipped orders with a freight cost above the average and have processed orders for customers in more than 3 different countries.

            // Retrieve the total number of products in stock for each category where the reorder level is above the average for products in their category.

            // Find the customers who have placed orders for products in categories where the average quantity ordered is above 50.

            // Get all orders where the ship city is the same as the customer’s city and the order amount is above the median order amount.

            // List all categories with products that have a reorder level less than the average reorder level for their category and have been ordered more than 5 times.

            // Retrieve the names of suppliers who have provided products with a unit price within the range of the top 5 % most expensive products.

            // Find the top 10 cities with the most customers and list the total order amount for each city.

            // Get the details of orders where the ship country is "USA" and the order amount is greater than the average order amount for the year 1996.

            // List all products with a unit price greater than the average unit price in their category and have been ordered in the last 6 months.

            // Retrieve the names of employees who have shipped orders to customers with postal codes starting with "9" and "8" and have processed more than 20 orders.

            // Find the top 5 suppliers with the highest total quantity of products supplied and list their contact details.

            // Get all orders where the total order amount is greater than the average for orders shipped by "Speedy Express" and "United Package".

            // List all products that have been ordered in every year from 1995 to 1997 and have a reorder level higher than the average for their category.

            // Retrieve the names of suppliers who have provided products with a quantity per unit description containing "Pack" and "Box" and have a contact title starting with "Sales".

            // Find the customers who have placed orders with a discount applied and have ordered products from more than 5 different categories.

            // Get the total number of orders placed by customers who have ordered products in every month of the year 1997.

            // List all products with a unit price that is within the range of the average unit price plus one standard deviation for their category.

            // Retrieve the names of employees who have processed orders with the maximum number of products ordered and their total freight cost.

            // Find the top 3 categories with the highest total quantity of products ordered and list their average unit price.

            // Get all orders where the order amount is above the average for orders shipped by "Federal Shipping" and "Speedy Express".

            // List all suppliers who have shipped products to "London" and "Paris" and have provided products in the "Beverages" category.

            // Retrieve the names of customers who have ordered products from suppliers in more than 5 different countries.

            // Find the products that have been ordered more than the median quantity ordered and have a unit price above $30.

            // Get the total order amount for each employee and list them in descending order of the total amount.

            // List all categories with products that have a unit price higher than the median unit price for their category and have been ordered more than 10 times.

            // Retrieve the names of suppliers who have provided products with a quantity per unit description containing "Bottle" or "Pack" and have a fax number.

            // Find the top 5 products with the highest quantity ordered in the last year and their total order amount.

            // Get all orders where the ship country is "USA" and the order date is within the first quarter of 1997.

            // List all products that have a unit price within the range of the top 10 % most expensive products and have been ordered in every month of the last year.


            #endregion Hard
        }
    }
}