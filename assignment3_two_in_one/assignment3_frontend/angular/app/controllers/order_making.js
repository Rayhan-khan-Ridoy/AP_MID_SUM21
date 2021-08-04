app.controller("order_making", function ($scope, $http, ajax, $location) {
  ajax.get("https://localhost:44364/api/product/GetAllProducts", success, error);
  function success(response) {
    $scope.products = response.data;
  }
  function error(error) {
    console.log(error);
  }
  function addSuccess() {
    $location.path("/order_admin");
  }
  $scope.cart = []

  $scope.placeorder = function() {
    $scope.products.forEach(element => {
      if(element.count>0){
        var productOrder = {
          product_id: element.id,
          product_price: element.price,
          product_quantity: element.count
        }
        $scope.cart.push(placeorder);
      }
    });
    console.log($scope.cart);
    ajax.post(
      "https://localhost:44364/api/Order/Place",
      $scope.cart,
      addSuccess,
      error
    );
    $scope.cart = []
  }
});
