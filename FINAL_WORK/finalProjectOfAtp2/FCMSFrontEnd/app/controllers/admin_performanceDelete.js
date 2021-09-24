app.controller("admin_PerformanceDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;
  //$scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Performance/Delete/"+id, success,error);
    function success(resp){
      $location.path("/PerformanceRead");
    }
    function error(err){

    }

  });
