angular.module('directivesApp', []).controller('productController', function 
($scope) {
    $scope.products = [
        { category: "Dairy", name: "Milk", price: 1.99, qty: 0 },
        { category: "Dairy", name: "Cheese", price: 2.99, qty: 0 },
        { category: "Dairy", name: "Yogurt", price: 3.99, qty: 0 },
        { category: "Dairy", name: "Butter", price: 2.99, qty: 0 },
        { category: "Dairy", name: "Cream", price: 1.75, qty: 0 },
        { category: "Dairy", name: "Ice Cream", price: 5.99, qty: 0 },
        { category: "Dairy", name: "Custard", price: 1.25, qty: 0 },
        { category: "Meat", name: "Mutton", price: 4.99, qty: 0 },
        { category: "Meat", name: "Chicken Breasts", price: 3.99, qty: 0 },
        { category: "Meat", name: "Steak", price: 3.99, qty: 0 },
        { category: "Meat", name: "Sausages", price: 3.99, qty: 0 },
        { category: "Meat", name: "Lamb Shanks", price: 3.99, qty: 0 },
        { category: "Produce", name: "Tomato", price: 0.99, qty: 0 },
        { category: "Produce", name: "Lettuce", price: 0.75, qty: 0 },
        { category: "Produce", name: "Eggplant", price: 0.75, qty: 0 },
        { category: "Produce", name: "Carrots", price: 0.99, qty: 0 },
        { category: "Fruit", name: "Lychee", price: 0.99, qty: 0 },
        { category: "Fruit", name: "Passion Fruit", price: 5.99, qty: 0 },
        { category: "Fruit", name: "Pineapple", price: 5.99, qty: 0 },
        { category: "Fruit", name: "Dragonfruit", price: 6.99, qty: 0 }
    ];
    $scope.stores = ["Safeway", "Albertsons", "Fred Meyers", "QFC", "Saars", "Whole
Foods"];
});