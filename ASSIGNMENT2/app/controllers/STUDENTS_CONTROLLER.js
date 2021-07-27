app.controller("STUDENTS_CONTROLLER",function($scope,ajax){
    ajax.get("https://localhost:44385/api/Student/GetAll",success,error);
    function success(response){
      $scope.STUDENTS=response.data;
    }
    function error(error){

    }

});
