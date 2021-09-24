app.controller("admin_playerCB",function($scope,$http, ajax){

    ajax.get("https://localhost:44368/api/Player/CB",success,error);
    function success(response){
      $scope.cb = response.data;

    }

    function error(err){

    }
});
