app.controller("admin_playersCreate",function($scope,ajax,$location){
    $scope.p = {};
    ajax.get("https://localhost:44368/api/Salary/Details",
    function(resp){
      $scope.salary = resp.data;

    },

    function(err){

    });

    $scope.AddPlayer = function(p){

      var nameError = false;
      if(p.Name == undefined)
      {
        nameError = true;
        $scope.nError = "Name field is required";
      }
      var userNameError = false;
      if(p.UserName == undefined)
      {
        userNameError = true;
        $scope.unameError = "User Name field is required";
      }
      var passwordError = false;
      if(p.Password == undefined)
      {
        passwordError = true;
        $scope.pError = "Password field is required";
      }
      var nationalityError = false;
      if(p.Nationality == undefined)
      {
        nationalityError = true;
        $scope.ntError = "Nationality field is required";
      }
      var ageError = false;
      if(p.Age == undefined)
      {
        ageError = true;
        $scope.aError = "Age field is required";
      }
      var heightError = false;
      if(p.Height == undefined)
      {
        heightError = true;
        $scope.hError = "Height filed is required";
      }
      var weightError = false;
      if(p.Weight == undefined)
      {
        weightError = true;
        $scope.wError = "Weight filed is required";
      }
      var positionError = false;
      if(p.Position == undefined)
      {
        positionError = true;
        $scope.pError = "Please Select Position";
      }

      var joiningDateError = false;
      if(p.Joining_Date == undefined)
      {
        joiningDateError = true;
        $scope.jdError = "Select the Joining Date";
      }
      var contactYearError = false;
      if(p.Contract_Year == undefined)
      {
        contactYearError = true;
        $scope.cyError = "Select the Contact Year";
      }
      var performanceIdError = false;
      if(p.Performance_Id == undefined)
      {
        performanceIdError = true;
        $scope.piError = "Performance Id Field is required";
      }
      var salaryIdError = false;
      if(p.Salary_Id == undefined)
      {
        salaryIdError = true;
        $scope.siError = "Select Salary Grade";
      }
      var fitnessIdError = false;
      if(p.Fitness_Id == undefined)
      {
        fitnessIdError = true;
        $scope.fiError = "Fitness Id field is required";
      }

      if(!nameError && !userNameError && !passwordError && !ageError && !nationalityError
       && !heightError && !weightError && !positionError && !joiningDateError && !contactYearError
      && !performanceIdError && !salaryIdError  && !fitnessIdError){

        ajax.post("https://localhost:44368/api/Player/Add",p,
        function(resp){
            $location.path("/player_f2");
        },
        function(err){});

      }

     };
});
