app.controller("admin_physioDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;
  //$scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Physio/Delete/"+id, success,error);
    function success(resp){
      $location.path("/admin_physioRead");
    }
    function error(err){

    }

  });
