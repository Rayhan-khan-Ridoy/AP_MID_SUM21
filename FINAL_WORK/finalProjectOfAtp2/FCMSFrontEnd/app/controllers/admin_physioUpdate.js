app.controller("admin_physioUpdate",function($scope,$http,ajax, $routeParams,$location){
  var id = $routeParams.id;
  $scope.p = {};


  ajax.get("https://localhost:44368/api/Physio/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdatePhysio = function(p){
       //$scope.Name
       var nameError = false;
       if(p.Name == "")
       {
         nameError = true;
         $scope.nameError = "Please Enter the name of Physio";
       }
       var userNameError = false;
       if(p.UserName == "")
       {
         userNameError = true;
         $scope.userNameError = "Please Enter the User name of Physio";
       }
       var degreeError = false;
       if(p.Degree == "")
       {
         degreeError = true;
         $scope.degreeError = "Please Enter Degree of the Physio";
       }
       var majorError = false;
       if(p.Major == "")
       {
         majorError = true;
         $scope.majorError = "Please Inlcude the Major of the Physio";
       }
       var salaryError = false;
       if(p.Salary_Id == "")
       {
         salaryError = true;
         $scope.salaryError = "Please Add Salary Grade of Physio";
       }
       if(!nameError && !userNameError && !degreeError && !majorError && !salaryError){
         ajax.post("https://localhost:44368/api/Physio/Edit/"+id,p,
         function(resp){
             $location.path("/admin_physioRead");
         },
         function(err){});
       }


     };
});
