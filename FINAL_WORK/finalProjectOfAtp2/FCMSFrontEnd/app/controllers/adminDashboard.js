app.controller("adminDashboard",function($scope,$http,ajax){
  ajax.get("https://localhost:44368//api/Player/Number",success,error);

    function success(response){
      $scope.totalPlayer=response.data;
    }
    function error(error){

    }
});
