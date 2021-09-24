app.controller("admin_playersUpdate",function($scope,$http,ajax, $routeParams,$location){
  var id = $routeParams.id;
   $scope.p = {};

  ajax.get("https://localhost:44368/api/Player/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

      $scope.UpdatePlayers = function(p){


        var nameError = false;
        if(p.Name == "")
        {
          nameError = true;
          $scope.nError = "Name field is required";
        }
        var userNameError = false;
        if(p.UserName == "")
        {
          userNameError = true;
          $scope.unError = "User Name field is required";
        }
        var passwordError = false;
        if(p.Password == "")
        {
          passwordError = true;
          $scope.pError = "Password field is required";
        }
        var nationalityError = false;
        if(p.Nationality == "")
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
        if(p.Position == "")
        {
          positionError = true;
          $scope.pError = "Please Select Position";
        }

        var joiningDateError = false;
        if(p.Joining_Date == "")
        {
          joiningDateError = true;
          $scope.jdError = "Select the Joining Date";
        }
        var contactYearError = false;
        if(p.Contract_Year == "")
        {
          contactYearError = true;
          $scope.cyError = "Select the Contact Year";
        }
        if(!nameError && !userNameError && !passwordError && !ageError && !nationalityError
         && !heightError && !weightError && !positionError && !joiningDateError && !contactYearError)
         {
          ajax.post("https://localhost:44368/api/PlayerEdit/"+id,p,
          function(resp){
              $location.path("/player_f2");
          },
          function(err){});
        }



     };
});
