app.controller("admin_salaryRead",function($scope,$http,ajax){
  ajax.get("https://localhost:44368//api/Salary/Details",success,error);
    function success(response){
      $scope.salary=response.data;
    }
    function error(error){

    }
});
