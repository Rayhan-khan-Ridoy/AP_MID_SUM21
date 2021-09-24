app.controller("admin_playerWingers",function($scope,$http, ajax){

    ajax.get("https://localhost:44368/api/Player/Wingers",success,error);
    function success(response){
      $scope.player = response.data;

    }

    function error(err){

    }
});
