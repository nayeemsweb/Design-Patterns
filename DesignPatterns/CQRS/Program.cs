using CQRS;

var repo = new Repository();

var customer = new CustomerCommand();
customer.FirstName = "Nayeem";

repo.Save(customer);

List<CustomerQuery> customers = repo.Read();