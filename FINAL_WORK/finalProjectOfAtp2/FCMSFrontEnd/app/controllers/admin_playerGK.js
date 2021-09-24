app.controller("admin_playerGK",function($scope,$http, ajax){

    ajax.get("https://localhost:44368/api/Player/GK",success,error);
    function success(response){
      $scope.player = response.data;

    }

    function error(err){

    }
});
