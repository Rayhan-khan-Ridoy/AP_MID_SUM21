app.controller("products",function($scope,$http,ajax){
    ajax.get("https://localhost:44364/api/product/GetAllProducts",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
