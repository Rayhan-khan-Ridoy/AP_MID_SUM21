app.controller("fixtures",function($scope,$http,ajax){
  ajax.get("https://localhost:44368/api/Fixture/All",success,error);
    function success(response){
      $scope.fixture=response.data;
    }
    function error(error){

    }
});
