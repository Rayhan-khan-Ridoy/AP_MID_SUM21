app.controller("admin_coachUpdate",function($scope,$http,ajax, $routeParams,$location){
  var id = $routeParams.id;
  $scope.p = {};


  ajax.get("https://localhost:44368/api/Coach/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateCoach = function(p){
       //$scope.Name
       var nameError = false;
       if(p.Name == "")
       {
         nameError = true;
         $scope.nameError = "Name field is required";
       }
       var userNameError = false;
       if(p.UserName == "")
       {
         userNameError = true;
         $scope.userNameError = "User Name field is required";
       }
       var nationalityError = false;
       if(p.Nationality == "")
       {
         nationalityError = true;
         $scope.nationalityError = "Nationality field is required";
       }
       var ageError = false;
       if(p.Age == undefined)
       {
         ageError = true;
         $scope.ageError = "Age field is required";
       }
       var salaryError = false;
       if(p.Salary_Id == "")
       {
         salaryError = true;
         $scope.salaryError = "Salary field is required";
       }


       if(!nameError && !userNameError && !nationalityError && !ageError && !salaryError)
       {
         ajax.post("https://localhost:44368/api/CoachEdit/"+id,p,
         function(resp){
             $location.path("/coach_f1");
         },
         function(err){});
       }


     };
});
