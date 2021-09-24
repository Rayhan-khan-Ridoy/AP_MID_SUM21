app.controller("player_f",function($scope,$http,ajax){
  ajax.get("https://localhost:44368//api/Players/All",success,error);
    function success(response){
      $scope.players=response.data;
    }
    function error(error){

    }
});
