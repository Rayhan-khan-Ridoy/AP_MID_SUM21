app.controller("admin_PerformanceDetails",function($scope,$http,ajax, $routeParams){
  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Performance/Details//"+id,success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }
});
