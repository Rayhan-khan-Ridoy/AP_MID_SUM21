app.controller("admin_fixtureRead1",function($scope,$http,ajax){
  ajax.get("https://localhost:44368/api/Fixture/All",success,error);
    function success(response){
      $scope.fixture=response.data;
    }
    function error(error){

    }
});
