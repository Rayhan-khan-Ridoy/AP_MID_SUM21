app.controller("admin_playerDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;
  $scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Player/Delete/"+id, success,error);
    function success(resp){
      $location.path("/player_f2");
    }
    function error(err){

    }

  });
