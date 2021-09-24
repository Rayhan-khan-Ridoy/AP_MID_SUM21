app.controller("admin_coachDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;
  //$scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Coach/Delete/"+id, success,error);
    function success(resp){
      $location.path("/coach_f1");
    }
    function error(err){

    }

  });
