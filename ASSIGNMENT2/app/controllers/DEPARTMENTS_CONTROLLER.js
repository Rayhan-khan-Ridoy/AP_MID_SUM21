app.controller("DEPARTMENTS_CONTROLLER",function($scope,ajax){
    ajax.get("https://localhost:44385/api/DEPARTMENT/GetAll",success,error);
    function success(response){
      $scope.DEPARTMENTS=response.data;
    }
    function error(error){

    }

});
