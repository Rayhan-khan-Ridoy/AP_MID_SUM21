app.controller("physio_fitnessRead",function($scope,$http,ajax){
  
  ajax.get("https://localhost:44368/api/Fitness/All",success,error);
    function success(response){
      $scope.fitness = response.data;
    }
    function error(error){

    }
});
