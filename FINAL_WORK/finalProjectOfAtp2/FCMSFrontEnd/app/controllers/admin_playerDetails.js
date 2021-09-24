app.controller("admin_playerDetails",function($scope,$http,ajax, $routeParams){
  var id = $routeParams.id;
  $scope.value = $routeParams.id;
  ajax.get("https://localhost:44368/api/Player/"+id,success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }
});
