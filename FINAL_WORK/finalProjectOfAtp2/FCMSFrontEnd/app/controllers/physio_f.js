app.controller("physio_f",function($scope,$http,ajax){
  ajax.get("https://localhost:44368/api/Physio",success,error);
    function success(response){
      $scope.physio = response.data;
    }
    function error(error){

    }
});
