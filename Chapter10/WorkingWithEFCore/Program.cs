using Packt.Shared;

// Northwind db = new();
// WriteLine($"Provider: {db.Database.ProviderName}");
// QueryingCategories();
// FilteredIncludes();
// QueryingProducts();
// QueryingWithLike();
// GetRandomProduct();

// var resultAdd = AddProduct(6, "Bob's Burgers", 500M);
//
// if (resultAdd.affected == 1) {
//     WriteLine($"Add product successful with ID: {resultAdd.productId}");
// }
//
// ListProducts(new[] { resultAdd.productId });

// var resultUpdate = IncreaseProductPrice("Bob", 20M);
//
// if (resultUpdate.affected == 1) {
//     WriteLine($"Increase price success for ID: {resultUpdate.productId}");
// }
//
// ListProducts(new[] { resultUpdate.productId });

WriteLine("About to delete all products whose name starts with Bob.");
Write("Press Enter to continue or any other key to exit: ");

if (ReadKey(true).Key == ConsoleKey.Enter) {
    int deleted = DeleteProducts("Bob");
    WriteLine($"{deleted} product(s) were deleted.");
} else {
    WriteLine("Delete was canceled.");
}

