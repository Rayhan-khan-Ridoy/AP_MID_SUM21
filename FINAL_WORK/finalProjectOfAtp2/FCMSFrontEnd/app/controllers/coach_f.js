app.controller("coach_f",function($scope,$http,ajax){
  ajax.get("https://localhost:44368/api/Coach/Details",success,error);
    function success(response){
      $scope.coach = response.data;
    }
    function error(error){

    }
});
