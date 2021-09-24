app.controller("admin_physioCreate",function($scope,ajax,$location){
$scope.p = {};
    ajax.get("https://localhost:44368/api/Salary/Details",
    function(resp){
      $scope.salary = resp.data;


    },

    function(err){

    });

    $scope.AddPhysio = function(p){
       //$scope.Name
       var nameError = false;
       if(p.Name == undefined)
       {
         nameError = true;
         $scope.nameError = "Please Enter the name of Physio";
       }
       var userNameError = false;
       if(p.UserName == undefined)
       {
         userNameError = true;
         $scope.userNameError = "Please Enter the User name of Physio";
       }
       var passwordError = false;
       if(p.Password == undefined)
       {
         passwordError = true;
         $scope.passError = "Please Set a password which contains at least 8 digits";
       }
       var degreeError = false;
       if(p.Degree == undefined)
       {
         degreeError = true;
         $scope.degreeError = "Please Enter Degree of the Physio";
       }
       var majorError = false;
       if(p.Major == undefined)
       {
         majorError = true;
         $scope.majorError = "Please Inlcude the Major of the Physio";
       }
       var salaryError = false;
       if(p.Salary_Id == undefined)
       {
         salaryError = true;
         $scope.salaryError = "Please Add Salary Grade of Physio";
       }
       
       if(!nameError && !userNameError && !passwordError && !degreeError && !majorError && !salaryError)
       {
         ajax.post("https://localhost:44368/api/Physio/Add",p,
         function(resp){
             $location.path("/admin_physioRead");
         },
         function(err){});


       }
       };

});
