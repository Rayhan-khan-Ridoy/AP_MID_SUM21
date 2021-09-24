app.controller("physio_fitnessUpdate",function($scope,$http,ajax, $routeParams,$location){

  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Fitness/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateFitness = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/FitnessEdit/"+id,p,
       function(resp){
           $location.path("/physio_fitnessRead");
       },
       function(err){});

     };
});
