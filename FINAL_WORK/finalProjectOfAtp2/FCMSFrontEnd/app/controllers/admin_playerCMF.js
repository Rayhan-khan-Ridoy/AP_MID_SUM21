app.controller("admin_playerCMF",function($scope,$http, ajax){

    ajax.get("https://localhost:44368/api/Player/CMF",success,error);
    function success(response){
      $scope.cmf = response.data;

    }

    function error(err){

    }
});
