app.controller("admin_playerCF",function($scope,$http, ajax){

    ajax.get("https://localhost:44368/api/Player/CF",success,error);
    function success(response){
      $scope.cf = response.data;

    }

    function error(err){

    }
});
