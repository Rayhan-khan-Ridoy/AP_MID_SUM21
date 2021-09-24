app.controller("admin_performanceRead",function($scope,$http,ajax){
  ajax.get("https://localhost:44368/api/Performance/Details",success,error);
    function success(response){
      $scope.performance=response.data;
    }
    function error(error){

    }
});
