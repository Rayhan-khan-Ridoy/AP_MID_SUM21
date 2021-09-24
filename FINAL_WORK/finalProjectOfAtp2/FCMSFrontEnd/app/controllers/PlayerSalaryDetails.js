app.controller("PlayerSalaryDetails",function($scope,$http,ajax, $routeParams){
  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Salary/"+id,success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }
});
