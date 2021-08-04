app.controller("order_user", function ($scope, $http, ajax, $routeParams) {
  var id = $routeParams.id;
  ajax
    .get("https://localhost:44364/api/order/" + id, success, error);
  function success(response) {
    $scope.productOrders = response.data.productorders;
    $scope.total = 0;
    $scope.productOrders.forEach((item) => {
      $scope.total += item.product_qty * item.product_price;
    });
    $scope.order = response.data;
  }
  function error(error) {
    console.log(error);
  }
