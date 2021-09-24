app.controller("physio_fitnessDelete",function($scope,ajax, $routeParams,$location){
  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Fitness/Delete/"+id, success,error);
    function success(resp){
      $location.path("/physio_fitnessRead");
    }
    function error(err){

    }

  });
