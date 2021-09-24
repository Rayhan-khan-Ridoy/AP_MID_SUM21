app.controller("coach_formationDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;
  $scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Formation/Delete/"+id, success,error);
    function success(resp){
      $location.path("/coach_formationRead");
    }
    function error(err){

    }

  });
