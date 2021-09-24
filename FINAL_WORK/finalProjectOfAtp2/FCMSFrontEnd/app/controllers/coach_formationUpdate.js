app.controller("coach_formationUpdate",function($scope,$http,ajax, $routeParams,$location){

  var id = $routeParams.id;
  $scope.p = {};

  ajax.get("https://localhost:44368/api/Formation/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateFormation = function(p){
       //$scope.Name
       var nameError = false;
       if(p.Name == "")
       {
         nameError = true;
         $scope.nameError = "Formation Name field is required";
       }
       var typeError = false;
       if(p.Type == "")
       {
         typeError = true;
         $scope.typeError = "Formation Type filed is required";
       }
       if(!nameError && !typeError){
         ajax.post("https://localhost:44368/api/Formation/Edit/"+id,p,
         function(resp){
             $location.path("/coach_formationRead");
         },
         function(err){});
       }


     };
});
