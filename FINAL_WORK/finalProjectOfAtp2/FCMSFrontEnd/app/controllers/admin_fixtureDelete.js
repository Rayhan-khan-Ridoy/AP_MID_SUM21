app.controller("admin_fixtureDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;
  //$scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Fixture/Delete/"+id, success,error);
    function success(resp){
      $location.path("/admin_fixtureRead1");
    }
    function error(err){

    }

  });
