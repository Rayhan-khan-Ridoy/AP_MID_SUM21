app.controller("admin_salaryDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;
  $scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Salary/Delete/"+id, success,error);
    function success(resp){
      $location.path("/admin_salaryRead");
    }
    function error(err){

    }

  });
