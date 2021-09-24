app.controller("admin_salaryCreate",function($scope,ajax,$location){
$scope.p = {};
    $scope.AddSalary = function(p){
       //$scope.Name
       var amountError = false;
       if(p.Amount == undefined)
       {
         amountError = true;
         $scope.amountError = "Please Add amount";
       }
       var salaryGradeError = false;
       if(p.Grade == undefined)
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
       if(p.Status == undefined)
       {
         statusError = true;
         $scope.statusError = "Salary Status should include";
       }
       
       if(!amountError && !salaryGradeError && !bonusError && !statusError)
       {
         ajax.post("https://localhost:44368/api/Salary/Add",p,
         function(resp){
             $location.path("/admin_salaryRead");
         },
         function(err){});


       }
       };


});
