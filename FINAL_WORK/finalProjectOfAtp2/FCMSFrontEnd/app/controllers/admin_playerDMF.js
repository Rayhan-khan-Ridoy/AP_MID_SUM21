app.controller("admin_playerDMF",function($scope,$http, ajax){

    ajax.get("https://localhost:44368/api/Player/DMF",success,error);
    function success(response){
      $scope.dmf = response.data;

    }

    function error(err){

    }
});
