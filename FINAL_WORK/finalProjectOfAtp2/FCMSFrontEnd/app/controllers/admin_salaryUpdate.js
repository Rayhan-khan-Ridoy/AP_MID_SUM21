app.controller("admin_salaryUpdate",function($scope,$http,ajax, $routeParams,$location){

  var id = $routeParams.id;
  $scope.p = {};

  ajax.get("https://localhost:44368/api/Salary/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateSalary = function(p){
       //$scope.Name
       var amountError = false;
       if(p.Amount == undefined)
       {
         amountError = true;
         $scope.amountError = "Please Add amount";
       }
       var salaryGradeError = false;
       if(p.Grade == "")
       {
         salaryGradeError = true;
         $scope.salaryGradeError = "Grade of the salary should include";
       }
       var bonusError = false;
       if(p.Bonus == undefined)
       {
         bonusError = true;
         $scope.bonusError = "Please Add Bonus";
       }
       var statusError = false;
       if(p.Status == "")
       {
         statusError = true;
         $scope.statusError = "Salary Status should include";
       }
       if(!amountError && !salaryGradeError && !bonusError && !statusError){
         ajax.post("https://localhost:44368/api/Salary/Edit/"+id,p,
         function(resp){
             $location.path("/admin_salaryRead");
         },
         function(err){});
       }


     };
});
