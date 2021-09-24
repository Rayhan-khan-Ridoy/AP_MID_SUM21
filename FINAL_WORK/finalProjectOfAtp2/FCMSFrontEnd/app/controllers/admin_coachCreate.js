app.controller("admin_coachCreate",function($scope,ajax,$location){
  $scope.p = {};


    ajax.get("https://localhost:44368/api/Salary/Details",
    function(resp){
      $scope.salary = resp.data;

    },

    function(err){

    });

    $scope.AddCoach = function(p){
      var nameError = false;
      if(p.Name == undefined)
      {
        nameError = true;
        $scope.nameError = "Name field is required";
      }
      var userNameError = false;
      if(p.UserName == undefined)
      {
        userNameError = true;
        $scope.userNameError = "User Name field is required";
      }
      var passError = false;
      if(p.Password == undefined)
      {
        passError = true;
        $scope.passError = "Password Field is required";
      }
      var nationalityError = false;
      if(p.Nationality == undefined)
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
      if(p.Salary_Id == undefined)
      {
        salaryError = true;
        $scope.salaryError = "Salary field is required";
      }
      if(!nameError && !userNameError && !passError && !nationalityError
         && !ageError && !salaryError){
        ajax.post("https://localhost:44368/api/Coach/Add",p,
        function(resp){
            $location.path("/coach_f1");
        },
        function(err){});
      }


     };
});
