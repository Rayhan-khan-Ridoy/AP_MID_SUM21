app.controller("coach_formationRead",function($scope,$http,ajax){
  ajax.get("https://localhost:44368/api/Formation",success,error);
    function success(response){
      $scope.formation = response.data;
    }
    function error(error){

    }
});
